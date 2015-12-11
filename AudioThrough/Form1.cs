using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using NAudio.Gui;
using NAudio.Wave;

namespace AudioThrough
{
    public partial class Form1 : Form
    {
        NotifyIcon appIcon;
        MenuItem startStopIcon;

        private WaveIn waveIn = null;
        private BufferedWaveProvider waveProvider = null;
        private WaveOut waveOut = null;


        public Form1()
        {
            InitializeComponent();
            appIcon = new NotifyIcon();
            appIcon.Icon = SystemIcons.Application;
            appIcon.Text = "AudioThrough";
            appIcon.DoubleClick += delegate { this.Show(); };
            appIcon.Visible = true;
            appIcon.ContextMenu = new ContextMenu();

            startStopIcon = new MenuItem("Start");
            startStopIcon.Click += StartStopIcon_Click;
            appIcon.ContextMenu.MenuItems.Add(startStopIcon);

            MenuItem exitIcon = new MenuItem("Exit");
            exitIcon.Click += delegate { this.Close(); };
            appIcon.ContextMenu.MenuItems.Add(exitIcon);

            InitDevices();
        }

        void InitDevices()
        {
            int waveInDevices = WaveIn.DeviceCount;
            for (int waveInDevice = 0; waveInDevice < waveInDevices; waveInDevice++)
            {
                WaveInCapabilities deviceInfo = WaveIn.GetCapabilities(waveInDevice);
                inDevices.Items.Add(deviceInfo.ProductName);
            }
            if (inDevices.Items.Count < 1)
            {
                MessageBox.Show("No input devices detected.");
                Application.Exit();
                this.Close();
            }
            inDevices.SelectedIndex = 0;

            int waveOutDevices = WaveOut.DeviceCount;
            for (int waveOutDevice = 0; waveOutDevice < waveInDevices; waveOutDevice++)
            {
                WaveOutCapabilities deviceInfo = WaveOut.GetCapabilities(waveOutDevice);
                outDevices.Items.Add(deviceInfo.ProductName);
            }
            if (inDevices.Items.Count < 1)
            {
                MessageBox.Show("No output devices detected.");
                Application.Exit();
                this.Close();
            }
            outDevices.SelectedIndex = 0;
        }

        void Start()
        {
            try
            {
                waveIn = new WaveIn(this.Handle);
                waveIn.BufferMilliseconds = 25;
                waveIn.RecordingStopped += waveIn_RecordingStopped;
                waveIn.DataAvailable += waveIn_DataAvailable;
                waveIn.DeviceNumber = inDevices.SelectedIndex;
                
                waveProvider = new BufferedWaveProvider(waveIn.WaveFormat);
                
                waveOut = new WaveOut();
                waveOut.DesiredLatency = 100;
                waveOut.Init(waveProvider);
                waveOut.PlaybackStopped += wavePlayer_PlaybackStopped;
                waveOut.Volume = (float)volumeControl.Value;
                waveOut.DeviceNumber = outDevices.SelectedIndex;

                waveIn.StartRecording();
                
                waveOut.Play();

                

                startStopIcon.Text = "Stop";
                listenBtn.Text = "Stop";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Failed to start listening");
            }
        }
        void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            // add received data to waveProvider buffer
            if (waveProvider != null)
                waveProvider.AddSamples(e.Buffer, 0, e.BytesRecorded);
            
        }
        void waveIn_RecordingStopped(object sender, StoppedEventArgs e)
        {
            // stop playback
            if (waveOut != null)
                waveOut.Stop();

            // dispose of wave input
            if (waveIn != null)
            {
                waveIn.Dispose();
                waveIn = null;
            }

            // drop wave provider
            waveProvider = null;
        }

        void wavePlayer_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            // stop recording
            if (waveIn != null)
                waveIn.StopRecording();

            // dispose of wave output
            if (waveOut != null)
            {
                waveOut.Dispose();
                waveOut = null;
            }
        }

        void Stop()
        {
            try
            {
                waveIn.StopRecording();
                InitDevices();

                startStopIcon.Text = "Start";
                listenBtn.Text = "Start";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Failed to stop listening");
            }
        }

        private void StartStopIcon_Click(object sender, EventArgs e)
        {
            if (startStopIcon.Text == "Start")
                Start();
            else
                Stop();
            
        }
        private void listenBtn_Click(object sender, EventArgs e)
        {
            if(listenBtn.Text == "Start")
                Start();
            else
                Stop();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
                Hide();
        }

        private void volumeControl_ValueChanged(object sender, EventArgs e)
        {
            waveOut.Volume = (float)volumeControl.Value;
        }
    }
}

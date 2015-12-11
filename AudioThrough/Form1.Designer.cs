namespace AudioThrough
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inDevices = new System.Windows.Forms.ComboBox();
            this.outDevices = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listenBtn = new System.Windows.Forms.Button();
            this.volumeControl = new System.Windows.Forms.NumericUpDown();
            this.volumeMeter1 = new NAudio.Gui.VolumeMeter();
            ((System.ComponentModel.ISupportInitialize)(this.volumeControl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Device:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output Device:";
            // 
            // inDevices
            // 
            this.inDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inDevices.FormattingEnabled = true;
            this.inDevices.Location = new System.Drawing.Point(133, 6);
            this.inDevices.Name = "inDevices";
            this.inDevices.Size = new System.Drawing.Size(192, 28);
            this.inDevices.TabIndex = 2;
            // 
            // outDevices
            // 
            this.outDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outDevices.FormattingEnabled = true;
            this.outDevices.Location = new System.Drawing.Point(133, 38);
            this.outDevices.Name = "outDevices";
            this.outDevices.Size = new System.Drawing.Size(192, 28);
            this.outDevices.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Volume:";
            // 
            // listenBtn
            // 
            this.listenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listenBtn.Location = new System.Drawing.Point(133, 103);
            this.listenBtn.Name = "listenBtn";
            this.listenBtn.Size = new System.Drawing.Size(87, 30);
            this.listenBtn.TabIndex = 6;
            this.listenBtn.Text = "Start";
            this.listenBtn.UseVisualStyleBackColor = true;
            this.listenBtn.Click += new System.EventHandler(this.listenBtn_Click);
            // 
            // volumeControl
            // 
            this.volumeControl.DecimalPlaces = 1;
            this.volumeControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeControl.Location = new System.Drawing.Point(133, 72);
            this.volumeControl.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.volumeControl.Name = "volumeControl";
            this.volumeControl.Size = new System.Drawing.Size(192, 26);
            this.volumeControl.TabIndex = 7;
            this.volumeControl.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.volumeControl.ValueChanged += new System.EventHandler(this.volumeControl_ValueChanged);
            // 
            // volumeMeter1
            // 
            this.volumeMeter1.Amplitude = 0F;
            this.volumeMeter1.Location = new System.Drawing.Point(226, 104);
            this.volumeMeter1.MaxDb = 18F;
            this.volumeMeter1.MinDb = -60F;
            this.volumeMeter1.Name = "volumeMeter1";
            this.volumeMeter1.Size = new System.Drawing.Size(99, 29);
            this.volumeMeter1.TabIndex = 8;
            this.volumeMeter1.Text = "volumeMeter1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 263);
            this.Controls.Add(this.volumeMeter1);
            this.Controls.Add(this.volumeControl);
            this.Controls.Add(this.listenBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outDevices);
            this.Controls.Add(this.inDevices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AudioThrough";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.volumeControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox inDevices;
        private System.Windows.Forms.ComboBox outDevices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button listenBtn;
        private System.Windows.Forms.NumericUpDown volumeControl;
        private NAudio.Gui.VolumeMeter volumeMeter1;
    }
}


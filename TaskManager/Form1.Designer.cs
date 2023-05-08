namespace IsletimSistemleriDonemProjesi
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
            this.components = new System.ComponentModel.Container();
            this.progressBarCPU = new System.Windows.Forms.ProgressBar();
            this.progressBarMemory = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOSVersion = new System.Windows.Forms.TextBox();
            this.txtDomainName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblMemory = new System.Windows.Forms.Label();
            this.lblCPUYuzde = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSIDTypeName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStatusName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSIDName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCaptionName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerParlaklık = new System.Windows.Forms.Timer(this.components);
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarCPU
            // 
            this.progressBarCPU.Location = new System.Drawing.Point(764, 239);
            this.progressBarCPU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarCPU.Name = "progressBarCPU";
            this.progressBarCPU.Size = new System.Drawing.Size(259, 34);
            this.progressBarCPU.TabIndex = 0;
            // 
            // progressBarMemory
            // 
            this.progressBarMemory.Location = new System.Drawing.Point(764, 299);
            this.progressBarMemory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarMemory.Maximum = 8024;
            this.progressBarMemory.Name = "progressBarMemory";
            this.progressBarMemory.Size = new System.Drawing.Size(259, 34);
            this.progressBarMemory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(712, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usable Memory:";
            // 
            // txtOSVersion
            // 
            this.txtOSVersion.Location = new System.Drawing.Point(194, 239);
            this.txtOSVersion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOSVersion.Name = "txtOSVersion";
            this.txtOSVersion.ReadOnly = true;
            this.txtOSVersion.Size = new System.Drawing.Size(357, 23);
            this.txtOSVersion.TabIndex = 5;
            // 
            // txtDomainName
            // 
            this.txtDomainName.Location = new System.Drawing.Point(194, 289);
            this.txtDomainName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDomainName.Name = "txtDomainName";
            this.txtDomainName.ReadOnly = true;
            this.txtDomainName.Size = new System.Drawing.Size(357, 23);
            this.txtDomainName.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.simpleButton3);
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Controls.Add(this.simpleButton2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.lblMemory);
            this.groupBox2.Controls.Add(this.lblCPUYuzde);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSIDTypeName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.progressBarMemory);
            this.groupBox2.Controls.Add(this.txtStatusName);
            this.groupBox2.Controls.Add(this.progressBarCPU);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSIDName);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.txtCaptionName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtOSVersion);
            this.groupBox2.Controls.Add(this.txtDomainName);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1517, 932);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bilgisayarın Özellikleri:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(761, 481);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Parlaklığınızı Ayarlayabilirsiniz!";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(764, 521);
            this.trackBar1.Maximum = 150;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(259, 56);
            this.trackBar1.TabIndex = 22;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.Location = new System.Drawing.Point(1050, 310);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(0, 17);
            this.lblMemory.TabIndex = 13;
            // 
            // lblCPUYuzde
            // 
            this.lblCPUYuzde.AutoSize = true;
            this.lblCPUYuzde.Location = new System.Drawing.Point(1048, 251);
            this.lblCPUYuzde.Name = "lblCPUYuzde";
            this.lblCPUYuzde.Size = new System.Drawing.Size(0, 17);
            this.lblCPUYuzde.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(101, 523);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "SID Tipi:";
            // 
            // txtSIDTypeName
            // 
            this.txtSIDTypeName.Location = new System.Drawing.Point(194, 519);
            this.txtSIDTypeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSIDTypeName.Name = "txtSIDTypeName";
            this.txtSIDTypeName.ReadOnly = true;
            this.txtSIDTypeName.Size = new System.Drawing.Size(357, 23);
            this.txtSIDTypeName.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 562);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Status:";
            // 
            // txtStatusName
            // 
            this.txtStatusName.Location = new System.Drawing.Point(194, 560);
            this.txtStatusName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStatusName.Name = "txtStatusName";
            this.txtStatusName.ReadOnly = true;
            this.txtStatusName.Size = new System.Drawing.Size(357, 23);
            this.txtStatusName.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "SID (Security Identifier):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Seviye:";
            // 
            // txtSIDName
            // 
            this.txtSIDName.Location = new System.Drawing.Point(194, 482);
            this.txtSIDName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSIDName.Name = "txtSIDName";
            this.txtSIDName.ReadOnly = true;
            this.txtSIDName.Size = new System.Drawing.Size(357, 23);
            this.txtSIDName.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(194, 436);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(357, 23);
            this.txtName.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hesap Erişimi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Caption İsminiz:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(194, 389);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(357, 23);
            this.txtDescription.TabIndex = 9;
            // 
            // txtCaptionName
            // 
            this.txtCaptionName.Location = new System.Drawing.Point(194, 336);
            this.txtCaptionName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCaptionName.Name = "txtCaptionName";
            this.txtCaptionName.ReadOnly = true;
            this.txtCaptionName.Size = new System.Drawing.Size(357, 23);
            this.txtCaptionName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "İşletim Sisteminiz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Domain İsminiz:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerParlaklık
            // 
            this.timerParlaklık.Enabled = true;
            this.timerParlaklık.Tick += new System.EventHandler(this.timerParlaklık_Tick);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = global::IsletimSistemleriDonemProjesi.Properties.Resources.moon;
            this.simpleButton3.Location = new System.Drawing.Point(1219, 21);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 64);
            this.simpleButton3.TabIndex = 30;
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::IsletimSistemleriDonemProjesi.Properties.Resources.day_and_night;
            this.simpleButton1.Location = new System.Drawing.Point(1110, 21);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(72, 64);
            this.simpleButton1.TabIndex = 29;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = global::IsletimSistemleriDonemProjesi.Properties.Resources.sun;
            this.simpleButton2.Location = new System.Drawing.Point(1003, 21);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(73, 64);
            this.simpleButton2.TabIndex = 28;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IsletimSistemleriDonemProjesi.Properties.Resources.logo_windows_13483;
            this.pictureBox1.Location = new System.Drawing.Point(66, 94);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 932);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontrol Merkezi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarCPU;
        private System.Windows.Forms.ProgressBar progressBarMemory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOSVersion;
        private System.Windows.Forms.TextBox txtDomainName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCaptionName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSIDName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStatusName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSIDTypeName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCPUYuzde;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Timer timerParlaklık;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}


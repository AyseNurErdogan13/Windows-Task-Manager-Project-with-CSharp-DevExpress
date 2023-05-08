namespace IsletimSistemleriDonemProjesi
{
    partial class DonanimOzellikleri
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
            this.cmbxOption = new System.Windows.Forms.ComboBox();
            this.lstDisplayHardware = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkHardware = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmbxOption
            // 
            this.cmbxOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxOption.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxOption.FormattingEnabled = true;
            this.cmbxOption.Items.AddRange(new object[] {
            "Win32_1394Controller",
            "Win32_1394ControllerDevice",
            "Win32_BaseBoard",
            "Win32_Battery",
            "Win32_BIOS",
            "Win32_Bus",
            "Win32_CDROMDrive",
            "Win32_CIMLogicalDeviceCIMDataFile",
            "Win32_DeviceBus",
            "Win32_DeviceMemoryAddress",
            "Win32_DeviceSettings",
            "Win32_DisplayConfiguration",
            "Win32_DisplayControllerConfiguration",
            "Win32_DMAChannel",
            "Win32_DriverVXD",
            "Win32_FloppyController",
            "Win32_FloppyDrive",
            "Win32_HeatPipe",
            "Win32_IDEController",
            "Win32_IDEControllerDevice",
            "Win32_InfraredDevice",
            "Win32_IRQResource",
            "Win32_Keyboard",
            "Win32_MotherboardDevice",
            "Win32_OnBoardDevice",
            "Win32_PCMCIAController",
            "Win32_PNPAllocatedResource",
            "Win32_PnPDevice",
            "Win32_PnPEntity",
            "Win32_PointingDevice",
            "Win32_PortableBattery",
            "Win32_PortConnector",
            "Win32_PortResource",
            "Win32_POTSModem",
            "Win32_POTSModemToSerialPort",
            "Win32_PowerManagementEvent",
            "Win32_Printer",
            "Win32_PrinterConfiguration",
            "Win32_PrinterController",
            "Win32_PrinterDriverDll",
            "Win32_PrinterSetting",
            "Win32_PrinterShare",
            "Win32_PrintJob",
            "Win32_Processor",
            "Win32_SCSIController",
            "Win32_SCSIControllerDevice",
            "Win32_SerialPort",
            "Win32_SerialPortConfiguration",
            "Win32_SerialPortSetting",
            "Win32_SMBIOSMemory",
            "Win32_SoundDevice",
            "Win32_TemperatureProbe",
            "Win32_USBController",
            "Win32_USBControllerDevice",
            "Win32_VideoConfiguration",
            "Win32_VideoController",
            "Win32_VideoSettings",
            "Win32_VoltageProbe"});
            this.cmbxOption.Location = new System.Drawing.Point(702, 13);
            this.cmbxOption.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxOption.Name = "cmbxOption";
            this.cmbxOption.Size = new System.Drawing.Size(257, 24);
            this.cmbxOption.Sorted = true;
            this.cmbxOption.TabIndex = 16;
            this.cmbxOption.SelectedIndexChanged += new System.EventHandler(this.cmbxOption_SelectedIndexChanged_1);
            // 
            // lstDisplayHardware
            // 
            this.lstDisplayHardware.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstDisplayHardware.HideSelection = false;
            this.lstDisplayHardware.Location = new System.Drawing.Point(13, 45);
            this.lstDisplayHardware.Margin = new System.Windows.Forms.Padding(4);
            this.lstDisplayHardware.Name = "lstDisplayHardware";
            this.lstDisplayHardware.Size = new System.Drawing.Size(946, 465);
            this.lstDisplayHardware.TabIndex = 17;
            this.lstDisplayHardware.UseCompatibleStateImageBehavior = false;
            this.lstDisplayHardware.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 72;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 503;
            // 
            // chkHardware
            // 
            this.chkHardware.AutoSize = true;
            this.chkHardware.Checked = true;
            this.chkHardware.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHardware.Location = new System.Drawing.Point(13, 16);
            this.chkHardware.Margin = new System.Windows.Forms.Padding(4);
            this.chkHardware.Name = "chkHardware";
            this.chkHardware.Size = new System.Drawing.Size(213, 21);
            this.chkHardware.TabIndex = 18;
            this.chkHardware.Text = "Dont Display null Value items";
            this.chkHardware.UseVisualStyleBackColor = true;
            // 
            // DonanimOzellikleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 519);
            this.Controls.Add(this.chkHardware);
            this.Controls.Add(this.lstDisplayHardware);
            this.Controls.Add(this.cmbxOption);
            this.Name = "DonanimOzellikleri";
            this.Text = "DonanimOzellikleri";
            this.Load += new System.EventHandler(this.DonanimOzellikleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbxOption;
        private System.Windows.Forms.ListView lstDisplayHardware;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.CheckBox chkHardware;
    }
}
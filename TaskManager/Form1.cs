using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace IsletimSistemleriDonemProjesi
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        PerformanceCounter perfCPUCounter = new PerformanceCounter("Processor Information", "% Processor Time","_Total");
        PerformanceCounter perfMemCounter = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter perfSystemCounter = new PerformanceCounter("System", "System Up Time");
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("gdi32.dll")]
        public static extern bool SetDeviceGammaRamp(IntPtr hDC, ref RAMP lpRamp);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct RAMP
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Red;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Green;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Blue;
        }

        public static void SetGamma(int gamma)
        {
            if (gamma <= 256 && gamma >= 1)
            {
                RAMP ramp = new RAMP();
                ramp.Red = new ushort[256];
                ramp.Green = new ushort[256];
                ramp.Blue = new ushort[256];
                for (int i = 1; i < 256; i++)
                {
                    int iArrayValue = i * (gamma + 128);

                    if (iArrayValue > 65535)
                        iArrayValue = 65535;
                    ramp.Red[i] = ramp.Blue[i] = ramp.Green[i] = (ushort)iArrayValue;
                }
                SetDeviceGammaRamp(GetDC(IntPtr.Zero), ref ramp);
            }
        }

        public static void ParlaklikAyarla(int parlaklikDegeri)
        {
            try
            {
                SetGamma(parlaklikDegeri);
            }
            catch
            {
               //Here only to catch errors where input is not a number (EXIT, for example, is a string)        
            }
           
        }


        public static string DomainName = "";
        
        public String Get_Windows_OS()
        {
            String result = String.Empty;
            ManagementScope scope = null;
            try
            {
                ConnectionOptions options = new ConnectionOptions();
                options.Impersonation = System.Management.ImpersonationLevel.Impersonate;

                //SQL Üzerinden ulaştık DESKTOP-LUK6BDU

                scope = new ManagementScope("\\\\"+DomainName+"\\root\\cimv2", options);

                scope.Connect();

                ObjectQuery query = new ObjectQuery("Select Caption FROM Win32_OperatingSystem");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

                ManagementObjectCollection queryCollection = searcher.Get();
                foreach (ManagementObject m in queryCollection)
                {
                    result = m["Caption"].ToString();
                }
            }
            catch (Exception)
            {
                result = "Unable to Retrieve OS Version";
            }
            return result;


        }
        static ulong GetTotalMemoryInBytes()
        {
            ulong deger = (ulong)new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory / 1024 / 1024;
            
            return deger;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Value = 130;
            progressBarMemory.Maximum = Convert.ToInt16(GetTotalMemoryInBytes());
            Font theFont = new Font("Times New Roman", 10F, FontStyle.Italic);

            foreach (Control theControl in (SpecialMethods.GetAllControls(this)))
            {
                theControl.Font = theFont;
            }
            timer1.Start();
            //Sırayı Bozma!
            //Domain Name Getiren
            DomainName = GetDomain();
            txtDomainName.Text = DomainName;

            //Caption Ekleme
            txtCaptionName.Text = GetCaption();

            //Windows Sürümü Getiren
            txtOSVersion.Text = Get_Windows_OS();

            //Description Ekleme
            txtDescription.Text = GetDescription();

            //Name Ekleme
            txtName.Text = GetName();

            //SID Ekleme
            //SID Nedir? bir kullanıcı veya bir grup kullanıcı gibi bir nesneyi 
                        //tanımlamak için kullanılan BENZERSİZ bir addır 
            txtSIDName.Text = GetSID();

            //SID Type Ekleme
            txtSIDTypeName.Text = GetSIDType();

            //Status Ekleme
            txtStatusName.Text = GetStatus();
            
        }
        public static string GetDomain()
        {
            ManagementObjectSearcher s = new ManagementObjectSearcher("\\root\\CIMV2", "SELECT * FROM Win32_UserAccount");
            foreach (ManagementObject  wmi in s.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Domain").ToString();
                }
                catch { }
            }
            return "User Domain Unknow";
        }
        public static string GetCaption()
        {
            ManagementObjectSearcher s = new ManagementObjectSearcher("\\root\\CIMV2", "SELECT * FROM Win32_UserAccount");
            foreach (ManagementObject wmi in s.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Caption").ToString();
                }
                catch { }
            }
            return "User Caption Unknow";
        }
        public static string GetDescription()
        {
            ManagementObjectSearcher s = new ManagementObjectSearcher("\\root\\CIMV2", "SELECT * FROM Win32_UserAccount");
            foreach (ManagementObject wmi in s.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Description").ToString();
                }
                catch { }
            }
            return "User Description Unknow";
        }
        public static string GetName()
        {
            ManagementObjectSearcher s = new ManagementObjectSearcher("\\root\\CIMV2", "SELECT * FROM Win32_UserAccount");
            foreach (ManagementObject wmi in s.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Name").ToString();
                }
                catch { }
            }
            return "User Name Unknow";
        }
        public static string GetSID()
        {
            ManagementObjectSearcher s = new ManagementObjectSearcher("\\root\\CIMV2", "SELECT * FROM Win32_UserAccount");
            foreach (ManagementObject wmi in s.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("SID").ToString();
                }
                catch { }
            }
            return "User SID Unknow";
        }
        public static string GetStatus()
        {
            ManagementObjectSearcher s = new ManagementObjectSearcher("\\root\\CIMV2", "SELECT * FROM Win32_UserAccount");
            foreach (ManagementObject wmi in s.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("Status").ToString();
                }
                catch { }
            }
            return "User SID Unknow";
        }
        public static string GetSIDType()
        {
            ManagementObjectSearcher s = new ManagementObjectSearcher("\\root\\CIMV2", "SELECT * FROM Win32_UserAccount");
            foreach (ManagementObject wmi in s.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("SIDType").ToString();
                }
                catch { }
            }
            return "User SIDType Unknow";
        }
        public static string GetInstallDate()
        {
            ManagementObjectSearcher s = new ManagementObjectSearcher("\\\\" + DomainName +"\\root\\CIMV2", "SELECT * FROM Win32_UserAccount");
            foreach (ManagementObject wmi in s.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("InstallDate").ToString();
                }
                catch { }
            }
            return "User InstallDate Unknow";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //CPU
            int sayi = (int)perfCPUCounter.NextValue();
            progressBarCPU.Value = sayi;
            lblCPUYuzde.Text = "%"+sayi.ToString();

            //Available Memory
            int sayi2= (int)perfMemCounter.NextValue();
            progressBarMemory.Value = sayi2;
            lblMemory.Text = sayi2.ToString()+"MB";
        }

        private void timerParlaklık_Tick(object sender, EventArgs e)
        {
            ParlaklikAyarla(trackBar1.Value);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           // int deger = trackBar1.Value;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 130;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 75;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 30;
        }
    }
}

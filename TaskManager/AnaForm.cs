using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsletimSistemleriDonemProjesi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }
        Form1 f1;
        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (f1 == null || f1.IsDisposed)
            {
                f1 = new Form1();
                f1.MdiParent = this;
                f1.Show();
            }
        }
        BataryaOzellikleri bataryaOzellikleri;
        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (bataryaOzellikleri == null || bataryaOzellikleri.IsDisposed)
            {
                bataryaOzellikleri = new BataryaOzellikleri();
                bataryaOzellikleri.MdiParent = this;
                bataryaOzellikleri.Show();
            }
        }

        GorevYoneticisi gorevYoneticisi;
        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (gorevYoneticisi == null || gorevYoneticisi.IsDisposed)
            {
                gorevYoneticisi = new GorevYoneticisi();
                gorevYoneticisi.MdiParent = this;
                gorevYoneticisi.Show();
            }
        }
        BIOSOzellikleri bIOSOzellikleri;
        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (bIOSOzellikleri == null || bIOSOzellikleri.IsDisposed)
            {
                bIOSOzellikleri = new BIOSOzellikleri();
                bIOSOzellikleri.MdiParent = this;
                bIOSOzellikleri.Show();
            }
        }
        AnakartOzellikleri anakartOzellikleri;
        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (anakartOzellikleri == null || anakartOzellikleri.IsDisposed)
            {
                anakartOzellikleri = new AnakartOzellikleri();
                anakartOzellikleri.MdiParent = this;
                anakartOzellikleri.Show();
            }
        }

        BUSVeriYolu bUSVeriYolu;
        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (bUSVeriYolu == null || bUSVeriYolu.IsDisposed)
            {
                bUSVeriYolu = new BUSVeriYolu();
                bUSVeriYolu.MdiParent = this;
                bUSVeriYolu.Show();
            }
        }
        //Win32_CIMLogicalDeviceCIMDataFile
        AygitlarinKullandigiSuruculer aygitlarinKullandigiSuruculer;

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (aygitlarinKullandigiSuruculer == null || aygitlarinKullandigiSuruculer.IsDisposed)
            {
                aygitlarinKullandigiSuruculer = new AygitlarinKullandigiSuruculer();
                aygitlarinKullandigiSuruculer.MdiParent = this;
                aygitlarinKullandigiSuruculer.Show();
            }
        }
        GPU0 gPU0;
        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (gPU0 == null || gPU0.IsDisposed)
            {
                gPU0 = new GPU0();
                gPU0.MdiParent = this;
                gPU0.Show();
            }
        }
        GPU1 gPU1;
        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (gPU1 == null || gPU1.IsDisposed)
            {
                gPU1 = new GPU1();
                gPU1.MdiParent = this;
                gPU1.Show();
            }
        }
        IDEOzellikleri ıDEOzellikleri;
        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (ıDEOzellikleri == null || ıDEOzellikleri.IsDisposed)
            {
                ıDEOzellikleri = new IDEOzellikleri();
                ıDEOzellikleri.MdiParent = this;
                ıDEOzellikleri.Show();
            }
        }
        IRQKesmeleri IRQkesmeleri;
        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (IRQkesmeleri == null || IRQkesmeleri.IsDisposed)
            {
                IRQkesmeleri = new IRQKesmeleri();
                IRQkesmeleri.MdiParent = this;
                IRQkesmeleri.Show();
            }
        }
        Keyboard keyboard;
        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (keyboard == null || keyboard.IsDisposed)
            {
                keyboard = new Keyboard();
                keyboard.MdiParent = this;
                keyboard.Show();
            }
        }
        AnakartKaynakları anakartKaynakları;
        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (anakartKaynakları == null || anakartKaynakları.IsDisposed)
            {
                anakartKaynakları = new AnakartKaynakları();
                anakartKaynakları.MdiParent = this;
                anakartKaynakları.Show();
            }
        }
        PortableBattery portableBattery;
        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (portableBattery == null || portableBattery.IsDisposed)
            {
                portableBattery = new PortableBattery();
                portableBattery.MdiParent = this;
                portableBattery.Show();
            }
        }
        PortBaglayicilari portBaglayicilari;
        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (portBaglayicilari == null || portBaglayicilari.IsDisposed)
            {
                portBaglayicilari = new PortBaglayicilari();
                portBaglayicilari.MdiParent = this;
                portBaglayicilari.Show();
            }
        }
        PortResource portResource;
        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (portResource == null || portResource.IsDisposed)
            {
                portResource = new PortResource();
                portResource.MdiParent = this;
                portResource.Show();
            }
        }
        Printer printer;
        private void navBarItem17_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (printer == null || printer.IsDisposed)
            {
                printer = new Printer();
                printer.MdiParent = this;
                printer.Show();
            }
        }
        CPUIslemci cPUIslemci;
        private void navBarItem18_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (cPUIslemci == null || cPUIslemci.IsDisposed)
            {
                cPUIslemci = new CPUIslemci();
                cPUIslemci.MdiParent = this;
                cPUIslemci.Show();
            }
        }
        SesAygiti sesAygiti;
        private void navBarItem19_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (sesAygiti == null || sesAygiti.IsDisposed)
            {
                sesAygiti = new SesAygiti();
                sesAygiti.MdiParent = this;
                sesAygiti.Show();
            }
        }

        //temp_probe
        SicaklikSensoru sicaklikSensoru;
        private void navBarItem20_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (sicaklikSensoru == null || sicaklikSensoru.IsDisposed)
            {
                sicaklikSensoru = new SicaklikSensoru();
                sicaklikSensoru.MdiParent = this;
                sicaklikSensoru.Show();
            }
        }
        
        USBDenetliyicisi uSBDenetliyicisi;
        private void navBarItem21_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (uSBDenetliyicisi == null || uSBDenetliyicisi.IsDisposed)
            {
                uSBDenetliyicisi = new USBDenetliyicisi();
                uSBDenetliyicisi.MdiParent = this;
                uSBDenetliyicisi.Show();
            }
        }
        VideoController videoController;
        private void navBarItem22_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (videoController == null || videoController.IsDisposed)
            {
                videoController = new VideoController();
                videoController.MdiParent = this;
                videoController.Show();
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;

            if (f1 == null || f1.IsDisposed)
            {
                f1 = new Form1();
                f1.MdiParent = this;
                f1.Show();
            }
        }
        

        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }
            if (e.KeyCode == Keys.F12)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                TopMost = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;



namespace IsletimSistemleriDonemProjesi
{
    public partial class BataryaOzellikleri : Form
    {
        public BataryaOzellikleri()
        {
            InitializeComponent();
        }
        System.Management.ObjectQuery query = new ObjectQuery("Select * FROM Win32_Battery");
       
        public void bataryaDeviceID()
        {
            PowerStatus pwr = SystemInformation.PowerStatus;
            
            String deviceId;

            //Şarj edilirken, şarj aletinin kendisini kullanarak burada bunu söylemiş oluyor
            deviceId = pwr.PowerLineStatus.ToString();
            if (deviceId.Equals("Online"))
            {
                pictureBox1.Image = Properties.Resources.doluyor;
                pictureBox1.Show();
                textBox3.Text = "Şarj Aleti Takılı";
                
            }
            else if(deviceId.Equals("Offline"))
            {
                pictureBox1.Image = Properties.Resources.dolmuyor2;
                pictureBox1.Show();
                textBox3.Text = "Şarj Edilmiyor!";
            }
            else
            {
                textBox3.Text = "Bu bilgiye ulaşılamıyor!";
            }


            //bunda da bilgisayarın kendi bataryasının doldurulup doldurulmadığının bilgisini veriyor!
            String strBatteryChargingStatus;
            strBatteryChargingStatus = pwr.BatteryChargeStatus.ToString();
            textBox1.Text = strBatteryChargingStatus;

            float strBatterylife;
            strBatterylife = (pwr.BatteryLifePercent)*100;
           
            textBox2.Text = ("%"+strBatterylife);



        }
        private void BataryaOzellikleri_Load(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            timer1.Start();
            Font theFont = new Font("Times New Roman", 10F, FontStyle.Italic);

            foreach (Control theControl in (SpecialMethods.GetAllControls(this)))
            {
                theControl.Font = theFont;
            }
            bataryaDeviceID();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Font theFont = new Font("Times New Roman", 10F, FontStyle.Italic);

            foreach (Control theControl in (SpecialMethods.GetAllControls(this)))
            {
                theControl.Font = theFont;
            }
            bataryaDeviceID();
        }
    }
}

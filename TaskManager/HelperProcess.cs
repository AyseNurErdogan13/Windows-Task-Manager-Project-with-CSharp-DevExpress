using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace IsletimSistemleriDonemProjesi
{
    class HelperProcess
    {
        Boolean ret = false;
        Process[] globalProcess;

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        /// <summary>
        /// Çalışan uygulamaların listesi.
        /// </summary>
        /// <returns></returns>
        public List<AppManagementModel> AppProcessList()
        {
            globalProcess = Process.GetProcesses();
            List<AppManagementModel> localProcessList = new List<AppManagementModel>();

            foreach (Process item in globalProcess)
            {
                if (!String.IsNullOrEmpty(item.MainWindowTitle)
                    || item.ProcessName == "Skype"
                    || item.ProcessName == "Dropbox")
                {
                    if (item.ProcessName != "AppManagement")
                    {
                        AppManagementModel model = new AppManagementModel();
                        model.PID = item.Id;
                        model.ProcessName = item.ProcessName;
                        model.MainWindowTitle = item.MainWindowTitle;
                        model.StartTime = item.StartTime;

                        localProcessList.Add(model);
                    }
                }
            }

            return localProcessList;
        }

        /// <summary>
        /// Xml dosyasını yükler.
        /// </summary>
        public void loadXml()
        {
            this.xmlWriter();
        }

        /// <summary>
        /// Çalışan uygulamaları xml dosyasına yazar.
        /// </summary>
        private void xmlWriter()
        {
            if (!File.Exists("AppManagement.xml"))
            {
                FileStream fileStream = File.Create("AppManagement.xml");
                fileStream.Close();
            }

            #region <AppManagement> etiketi oluşturma işlemi.
            //Dosyanın oluşturulacağı dizin,Kodlaması
            XmlTextWriter xmlCreate = new XmlTextWriter("AppManagement.xml", UTF8Encoding.UTF8);
            //Xml içine Element Oluşturma işlemine başlanıyor.
            xmlCreate.WriteStartDocument();
            //AppManagement Etiketi ekledik.
            xmlCreate.WriteStartElement("AppManagement");
            //Element Oluşturma işlemi bitti.
            xmlCreate.WriteEndDocument();
            //Dosya oluşturuldu ve bağlantı kapatıldı.
            xmlCreate.Close();
            #endregion

            #region Çalışan programlar xml'de ki <AppManagement> etiketleri arasına yazılıyor.
            //Çalışan programlar çekiliyor.
            List<AppManagementModel> appList = this.AppProcessList();

            foreach (AppManagementModel p in appList)
            {
                //AppManagement xml yükleniyor.
                XmlDocument doc = new XmlDocument();
                doc.Load("AppManagement.xml");

                //Element Ekledik.<App>
                XmlElement UserElement = doc.CreateElement("App");
                //Elementi bir attribute atadık. <App Name="p.ProcessName">
                UserElement.SetAttribute("Name", p.ProcessName);

                //<App Name=""> altında <Label> Adında alt element oluşturuldu.
                XmlElement labelElement = doc.CreateElement("Label");

                //Dropbox skype gibi programlar bazen arka planda çalıştığı için mainWindowTitle boş atanıyor.
                //Bundan dolayı label olarak processName veriyoruz.
                switch (p.ProcessName)
                {
                    case "Dropbox":
                        labelElement.InnerText = p.ProcessName;
                        UserElement.AppendChild(labelElement);
                        ret = true;
                        break;

                    case "Skype":
                        labelElement.InnerText = p.ProcessName;
                        UserElement.AppendChild(labelElement);
                        ret = true;
                        break;
                }

                //Ön planda çalışıyorsa, görünen adını atıyoruz.
                if (!ret)
                {
                    labelElement.InnerText = p.MainWindowTitle;
                    UserElement.AppendChild(labelElement);
                }

                //<App Name=""> ve labelin altına <StartTime> ekledik.
                XmlElement StartTimeElement = doc.CreateElement("StartTime");
                StartTimeElement.InnerText = p.StartTime.ToString();
                UserElement.AppendChild(StartTimeElement);

                //xml dosyamıza element ve kayıtları ekledik
                doc.DocumentElement.AppendChild(UserElement);
                //xml dosyamıza fiziksel olarak kayıtları yazıyoruz
                XmlTextWriter xmlTextWriter = new XmlTextWriter("AppManagement.xml", null);
                xmlTextWriter.Formatting = Formatting.Indented;
                //Kayıtlar eklendi
                doc.WriteContentTo(xmlTextWriter);
                //Dosya kapatıldı
                xmlTextWriter.Close();

                ret = false;
            }
            #endregion
        }

        /// <summary>
        /// Gönderilen xml verisini DataGridview'a yazar.
        /// </summary>
        /// <param name="_xmlFilePath"></param>
        /// <param name="_dataGridView"></param>
        public void listDatagridview(string _xmlFilePath, DataGridView _dataGridView)
        {
            DataSet ds = new DataSet();
            //xml dosyamızı okumak için bir reader oluşturuyoruz.
            XmlReader xmlReader;
            //Readerin içine pathini verdiğimiz dosyayı dolduruyoruz.
            xmlReader = XmlReader.Create(_xmlFilePath, new XmlReaderSettings());
            //içeriği Dataset e aktarıyoruz.
            ds.ReadXml(xmlReader);

            if (ds.Tables.Count != 0)
            {
                //gridviewin kaynağı olarak dataseti gösteriyoruz.
                _dataGridView.DataSource = ds.Tables[0];

                //Kolon başlıkları.
                _dataGridView.Columns[0].HeaderText = "Görünen Ad";
                _dataGridView.Columns[1].HeaderText = "Başlatılma zamanı";
                _dataGridView.Columns[2].HeaderText = "Program Adı";

                //Kolon sıralaması
                _dataGridView.Columns[0].DisplayIndex = 0;
                _dataGridView.Columns[1].DisplayIndex = 2;
                _dataGridView.Columns[2].DisplayIndex = 1;

                //Kolonların otomatik genişlik ayarı.
                _dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                _dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                _dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }

            xmlReader.Close();
        }

        /// <summary>
        /// </summary>
        /// <param name="_processName">Uygulama adı.</param>
        public void killProcess(string _processName)
        {
            if (!string.IsNullOrWhiteSpace(_processName))
            {
                try
                {
                    foreach (var item in globalProcess)
                    {
                        if (item.ProcessName == _processName)
                        {
                            item.Kill();
                        }
                    }
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }

        /// <summary>
        /// Çalışan tüm uygulamaları kapatır.
        /// </summary>
        public void killProcessAll()
        {
            List<AppManagementModel> localAppList = this.AppProcessList();

            //Tüm listede dönülür ve programlar kill edilir.
            foreach (AppManagementModel model in localAppList)
            {
                if (model.ProcessName != "AppManagement")
                {
                    this.killProcess(model.ProcessName);
                }
            }
        }
    }
}

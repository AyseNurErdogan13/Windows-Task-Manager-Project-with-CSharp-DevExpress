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
    public partial class GorevYoneticisi : Form
    {
        public GorevYoneticisi()
        {
            InitializeComponent();
        }
        HelperProcess helperProcess = new HelperProcess();
        public string selectedPrograms;
        private void GorevYoneticisi_Load(object sender, EventArgs e)
        {
            helperProcess.loadXml();
            helperProcess.listDatagridview("AppManagement.xml", dataGridViewProcessApp);
            timer1.Interval = 2000;
            timer1.Start();
        }

        void refreshGrid()
        {
            helperProcess.loadXml();
            helperProcess.listDatagridview("AppManagement.xml", dataGridViewProcessApp);
        }

        private void btnKill_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridViewProcessApp.SelectedRows)
            {
                selectedPrograms = item.Cells[2].Value.ToString();
                helperProcess.killProcess(selectedPrograms);
            }
            this.refreshGrid();
        }

        private void btnAllItemKill_Click_1(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();

            dg = MessageBox.Show("Açık tüm uygulamalar kapanacak, emin misiniz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                helperProcess.killProcessAll();
                MessageBox.Show("Tüm uygulamalar kapatıldı.", "Açıklama", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.refreshGrid();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.refreshGrid();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            this.refreshGrid();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

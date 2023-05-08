using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Instrumentation;

namespace IsletimSistemleriDonemProjesi
{
    public partial class DonanimOzellikleri : Form
    {

        public DonanimOzellikleri()
        {
            InitializeComponent();
            cmbxOption.SelectedItem = "Win32_Processor";
        }

        private void InsertInfo(string Key, ref ListView lst, bool DontInsertNull)
        {
            lst.Items.Clear();

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + Key);

            try
            {
                foreach (ManagementObject share in searcher.Get())
                {

                    ListViewGroup grp;
                    try
                    {
                        grp = lst.Groups.Add(share["Name"].ToString(), share["Name"].ToString());
                    }
                    catch
                    {
                        grp = lst.Groups.Add(share.ToString(), share.ToString());
                    }

                    if (share.Properties.Count <= 0)
                    {
                        MessageBox.Show("No Information Available", "No Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    foreach (PropertyData PC in share.Properties)
                    {

                        ListViewItem item = new ListViewItem(grp);
                        if (lst.Items.Count % 2 != 0)
                            item.BackColor = Color.White;
                        else
                            item.BackColor = Color.WhiteSmoke;

                        item.Text = PC.Name;

                        if (PC.Value != null && PC.Value.ToString() != "")
                        {
                            switch (PC.Value.GetType().ToString())
                            {
                                case "System.String[]":
                                    string[] str = (string[])PC.Value;

                                    string str2 = "";
                                    foreach (string st in str)
                                        str2 += st + " ";

                                    item.SubItems.Add(str2);

                                    break;
                                case "System.UInt16[]":
                                    ushort[] shortData = (ushort[])PC.Value;


                                    string tstr2 = "";
                                    foreach (ushort st in shortData)
                                        tstr2 += st.ToString() + " ";

                                    item.SubItems.Add(tstr2);

                                    break;

                                default:
                                    item.SubItems.Add(PC.Value.ToString());
                                    break;
                            }
                        }
                        else
                        {
                            if (!DontInsertNull)
                                item.SubItems.Add("No Information available");
                            else
                                continue;
                        }
                        lst.Items.Add(item);
                    }
                }
            }

            catch (Exception exp)
            {
                MessageBox.Show("Üzgünüz! Verilere erişemiyoruz. Lütfen sonra tekrar deneyiniz\n" + exp.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RemoveNullValue(ref ListView lst)
        {
            foreach (ListViewItem item in lst.Items)
                if (item.SubItems[1].Text == "No Information available")
                    item.Remove();
        }

        private void cmbxOption_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            InsertInfo(cmbxOption.SelectedItem.ToString(), ref lstDisplayHardware, chkHardware.Checked);
        }
        


        private void DonanimOzellikleri_Load(object sender, EventArgs e)
        {

        }
    }
}

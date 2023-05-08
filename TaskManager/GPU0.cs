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
    public partial class GPU0 : Form
    {
        public GPU0()
        {
            InitializeComponent();
        }
        private void InsertInfo(ref ListView lst, bool DontInsertNull)
        {
            lst.Items.Clear();
            
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from  Win32_DisplayControllerConfiguration");

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
                        MessageBox.Show("Üzgünüz! Listelenecek bir bilgi bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                item.SubItems.Add("Kullanılabilir Bir Bilgi Bulunamadı!");
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
        private void GPU0_Load(object sender, EventArgs e)
        {
            Font theFont = new Font("Times New Roman", 10F, FontStyle.Italic);

            foreach (Control theControl in (SpecialMethods.GetAllControls(this)))
            {
                theControl.Font = theFont;
            }
            InsertInfo(ref lstDisplayHardware, chkHardware.Checked);
        }
    }
}

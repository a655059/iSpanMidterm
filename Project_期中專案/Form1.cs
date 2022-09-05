using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_期中專案
{
    public partial class Form1 : Form
    {
        iSpanProjectEntities2 dbindex = new iSpanProjectEntities2();
        byte[] bytes;
        public string account;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            MemberAccount list = new MemberAccount() { };
 
            list.MemberAcc = txtAccount.Text;
            list.MemberPw = txtPassworld.Text;
            list.TWorNOT = ckbox_yes.Checked;
            list.RegionID = cmb_are.SelectedIndex+1;
            list.Phone = txt_phon.Text;
            list.Email = txt_mail.Text;
            list.BackUpEmail = txt_backMail.Text;
            list.Address = txtadd.Text;
            list.NickName = txt_nickName.Text;
            list.Name = txt_name.Text;
            list.Birthday = DTP_BIR.Value;
            list.Bio = txt_bio.Text;
            list.MemPic = bytes;

            this.dbindex.MemberAccounts.Add(list);
            this.dbindex.SaveChanges();
            MessageBox.Show("新增成功!");
        }

        private void btn_pic_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pic_box.Image = Image.FromFile(this.openFileDialog1.FileName);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                this.pic_box.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                bytes = ms.GetBuffer();//將圖片轉成byt儲存起來
            }
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbload();
        }
        private void cbload()
        {
            var q = from i in dbindex.CountryLists
                    orderby i.CountryID ascending
                    select i.CountryName;
            var q1 = from i in dbindex.RegionLists
                     where i.CountryID == 1
                     orderby i.RegionID ascending
                     select i.RegionName;

            cmbo_city.Text = q.FirstOrDefault();

            cmbo_city.Items.AddRange(q.ToArray());
            cmb_are.Items.AddRange(q1.ToArray());
            cmb_are.Text = cmb_are.Items[0].ToString();
            //cmbo_city.Text = cmbo_city.Items[0].ToString();
        }

        private void cmbo_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q = from i in dbindex.CountryLists
                    where i.CountryName == cmbo_city.Text
                    orderby i.CountryID
                    select i.CountryID;
            var q1 = from i in dbindex.RegionLists
                     where i.CountryID == q.FirstOrDefault()
                     orderby i.RegionID ascending
                     select i.RegionName;

            cmb_are.Items.Clear();
            cmb_are.Items.AddRange(q1.ToArray());
            cmb_are.Text = cmb_are.Items[0].ToString();
        }
    }
}

using prjProject.Entity;
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
        iSpanProjectEntities dbindex = new iSpanProjectEntities();
        byte[] bytes;
        public string account;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            MemberAccount list = new MemberAccount() { };

            var q = from i in dbindex.RegionLists.AsEnumerable()
                    where i.RegionName.Contains(cmb_are.Text)
                    //orderby i.RegionID ascending
                    select i;
            var q1 = q.ToList();
            var memData = from i in dbindex.MemberAccounts.AsEnumerable()
                          select i;
            var memDaList = memData.ToList();

            if (txtAccount.Text == "" || txtPassworld.Text == "" || txt_phon.Text == "" || txt_mail.Text == "" || txtadd.Text == "" || txt_name.Text == "")
            {
                MessageBox.Show("請輸入必填欄位:\n" + "使用者帳號\n" + "密碼\n" + "所在縣市地區\n" + "電話 電子信箱\n" +
                                "地址 姓名\n" + "生日");
                return;
            }
            foreach (var i in memDaList)
            {
            if (txtAccount.Text == i.MemberAcc) { MessageBox.Show("此帳號已註冊");return; }
            else if (txt_phon.Text == i.Phone) { MessageBox.Show("此電話號碼已註冊，請確認!");return; }
            else if (txt_mail.Text == i.Email) { MessageBox.Show("此電子信箱已註冊，請確認"); return; }
            else
            {
            list.MemberAcc = txtAccount.Text;
            list.MemberPw = txtPassworld.Text;
            list.TWorNOT = ckbox_yes.Checked;
            list.RegionID =Convert.ToInt32(q1[0].RegionID);//countryID==>cmb_are.text
            list.Phone = txt_phon.Text;
            list.Email = txt_mail.Text;
            list.BackUpEmail = txt_backMail.Text;
            list.Address = txtadd.Text;
            list.NickName = txt_nickName.Text;
            list.Name = txt_name.Text;
            list.Birthday = DTP_BIR.Value;
            list.Bio = txt_bio.Text;
            list.MemPic = bytes;
            list.MemStatusID = 1;
            }
            }
            this.dbindex.MemberAccounts.Add(list);
            this.dbindex.SaveChanges();
            MessageBox.Show("新增成功!");
            Close();
        }

        private void btn_pic_Click(object sender, EventArgs e)
        {
            try
            {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file";
            dialog.InitialDirectory = ".\\";
            dialog.Filter = "xls files (*.*)|*.jpg";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pic_box.Image = Image.FromFile(this.openFileDialog1.FileName);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                this.pic_box.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                bytes = ms.GetBuffer();//將圖片轉成byt儲存起來
            }
            }
            catch (Exception)
            {
                MessageBox.Show("請選擇其他圖片(ex:jpg檔)");
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

        private void txtPassworld_TextChanged(object sender, EventArgs e)
        {
            string txtpwd = txtPassworld.Text;
            if (txtpwd.Length <= 5) { account_mes.Text = "密碼強度低"; }
            else if (txtpwd.Length > 5 && txtpwd.Length < 8) { account_mes.Text = "密碼強度中等"; }
            else { account_mes.Text = "密碼強度高"; }
        }
    }
}

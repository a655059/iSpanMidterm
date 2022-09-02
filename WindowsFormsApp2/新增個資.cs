using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class 帳號管理 : Form
    {
        public 帳號管理()
        {
            InitializeComponent();
        }
        iSpanProjectEntities1 DBiSpan = new iSpanProjectEntities1(); //資料模組帶入
        private void 新增_Click(object sender, EventArgs e)
        {
            var 地區 = DBiSpan.RegionLists.Where(n=>n.RegionName==comRegionID.Text).
                            Select(n => n.RegionID).FirstOrDefault();

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] bytes = ms.GetBuffer();// 上三行為照片轉換

            //bool ispass = false;            
            //if (!String.IsNullOrWhiteSpace(txtMemberAcc.Text)) ispass = true;
            //if (!ispass) return;

            MemberAccount mem = new MemberAccount()// 建立資料帶入路徑
            {
                MemberAcc = txtMemberAcc.Text,
                MemberPw = txtMemberPw.Text,
                TWorNOT = checkBox1.Checked,
                RegionID = 地區,
                Phone = txthone.Text,
                Email = txtEmail.Text,
                BackUpEmail = txtackUPEmail.Text,
                Address = txtAddress.Text,
                NickName = txtNickName.Text,
                Name = txtName.Text,
                Birthday = dateTimePicker1.Value,
                Bio=txtBio.Text,
                MemPic=bytes
            };
            this.DBiSpan.MemberAccounts.Add(mem);// 新增資料到資料庫
            DBiSpan.SaveChanges();  // 確定帶入          
            MessageBox.Show("新增成功");
            
            listBox1.Items.Clear();
            var QQ = DBiSpan.MemberAccounts.Select(n => n.MemberAcc).ToList();
            foreach (var i in QQ)
            {
                listBox1.Items.Add(i);
            }

        }
        
        private void 開啟帶入人名和地區_Load(object sender, EventArgs e) 
        {
            
            //開啟時自動執行地區帶入
            var Q = DBiSpan.RegionLists.Select(n => n.RegionName).ToList();
            foreach (var i in Q)
            {
                comRegionID.Items.Add(i);
            }

            //自動帶入帳號名單至listbox
            var QQ = DBiSpan.MemberAccounts.Select(n => n.MemberAcc).ToList();
            foreach (var i in QQ)
            {
                listBox1.Items.Add(i);
            }
            //if (listBox1.Items.Count==0) return;
            //listBox1.SelectedIndex = 0;  //預設選取第一筆資料
            //txtMemberAcc.Enabled = false;
        }

        private void 選照片_Click(object sender, EventArgs e)  //選照片按鈕
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
        }

        List<int> list = new List<int>();

        private void 修改_Click(object sender, EventArgs e)
        {
            MemberAccount Q = 點到的人名();

            var 地區 = DBiSpan.RegionLists.Where(n => n.RegionName == comRegionID.Text).
                            Select(n => n.RegionID).FirstOrDefault();

            Q.MemberAcc = txtMemberAcc.Text;
            Q.MemberPw = txtMemberPw.Text;
            Q.TWorNOT = checkBox1.Checked;
            Q.RegionID =地區;
            Q.Phone = txthone.Text;
            Q.Email = txtEmail.Text;
            Q.BackUpEmail = txtackUPEmail.Text;
            Q.Address = txtAddress.Text;
            Q.NickName = txtNickName.Text;
            Q.Name = txtName.Text;
            Q.Birthday = dateTimePicker1.Value;
            Q.Bio = txtBio.Text;      

            this.DBiSpan.SaveChanges();
            MessageBox.Show("修改成功");
        }

        private void 刪除_Click(object sender, EventArgs e)
        {
            MemberAccount Q = 點到的人名();
            this.DBiSpan.MemberAccounts.Remove(Q);
            this.DBiSpan.SaveChanges();
            MessageBox.Show("刪除成功");
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            //把資料帶入空格的方法
            MemberAccount Q = 點到的人名();

            txtMemberAcc.Text = Q.MemberAcc;
            txtMemberPw.Text = Q.MemberPw;
            checkBox1.Checked = Q.TWorNOT;
            comRegionID.SelectedIndex = Q.RegionID - 1;
            txthone.Text = Q.Phone;
            txtEmail.Text = Q.Email;
            txtackUPEmail.Text = Q.BackUpEmail;
            txtAddress.Text = Q.Address;
            txtNickName.Text = Q.NickName;
            txtName.Text = Q.Name;
            dateTimePicker1.Value = Q.Birthday;
            txtBio.Text = Q.Bio;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(Q.MemPic);
            this.pictureBox1.Image = Image.FromStream(ms);
        }

        private MemberAccount 點到的人名()
        {
            string value = listBox1.SelectedItem.ToString();
            var Q = from O in DBiSpan.MemberAccounts
                    where O.MemberAcc == value
                    select O;
            return Q.FirstOrDefault();
        }
    }
}

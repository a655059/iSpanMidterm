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

namespace prjProject.Management
{
    public partial class 申訴管理 : Form
    {
        public 申訴管理()
        {
            InitializeComponent();
        }
        iSpanProjectEntities DBiSpan = new iSpanProjectEntities();
        申訴修改刪除 修刪 = new 申訴修改刪除();
        private void 申訴管理_Load(object sender, EventArgs e)
        {
            var type = DBiSpan.ArgumentTypes.Select(n => new { 
            n.ArgumentTypeID,
            n.ArgumentTypeName
            }).ToList();
            dataGridView1.DataSource = type;

            var reason = DBiSpan.Arguments.Select(n => new { 
            n.OrderID,
            n.ArgumentID,
            n.ChangeorReturn,
            n.Reason,
            n.ArgumentTypeID
            }).ToList();
            dataGridView2.DataSource = reason;

            var pic = DBiSpan.ArguePics.Select(n => new { 
            n.ArguePicID,
            n.ArguementID,
            n.ArguePic1
            }).ToList();
            dataGridView3.DataSource = pic;
        }

        private void 修改_Click(object sender, EventArgs e)
        {
            var selectID = dataGridView2.CurrentRow.Cells["ArgumentID"].Value;
            修刪.inag = Convert.ToInt32(selectID);
            修刪.ShowDialog();
        }
    }
}

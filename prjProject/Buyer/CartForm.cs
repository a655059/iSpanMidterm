using prjProject.Entity;
using prjProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjProject
{
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
        }
        iSpanProjectEntities dbContext = new iSpanProjectEntities();
        public bool IsBuyNow { get; set; }
        public int productDetailID { get; set; }
        public int productCount { get; set; }
        public string memberName
        {
            get { return lblWelcome.Text; }
            set { lblWelcome.Text = $"歡迎 {value}"; }
        }
        public string ProductNumInCart
        {
            get { return lblProductNumInCart.Text; }
            set { lblProductNumInCart.Text = value; }
        }
        public int memberID { get; set; }
        private void CartForm_Load(object sender, EventArgs e)
        {
            memberID = CFunctions.GetMemberInfoFromHomePage();
            CFunctions.ShowMemberInfoAtHeader(memberID, out string memberName, out int productNumInCart);
            lblWelcome.Text = $"歡迎 {memberName}" ;
            lblProductNumInCart.Text = productNumInCart.ToString();
            if (IsBuyNow)
            {
                var q = dbContext.ProductDetails.Where(i => i.ProductDetailID == productDetailID).Select(i => i).FirstOrDefault();
                MemoryStream ms = new MemoryStream(q.Pic);
                Image productPhoto = Image.FromStream(ms);
                string productName = q.Product.ProductName;
                string productStyle = q.Style;
                productName = $"{productName} - {productStyle}";
                decimal productPrice = q.UnitPrice;
                int productSumPrice = Convert.ToInt32(productPrice) * productCount;
                var q3 = dbContext.MemberAccounts.Where(i => i.MemberID == memberID).Select(i => i).FirstOrDefault();
                string buyerAddress = q3.Address;
                string buyerPhone = q3.Phone;
                int productID = q.ProductID;
                List<string> shipperName = dbContext.ShipperToProducts.Where(i => i.ProductID == productID).Select(i => i.Shipper.ShipperName).ToList();
                UCtrlShowItemsInCart uCtrl = CFunctions.AddOrderToUCtrl(0, productDetailID, productPhoto, productName, productPrice, productCount, productSumPrice, buyerAddress, buyerPhone, shipperName);
                flpProductInCart.Controls.Add(uCtrl);
            }
            else
            {
                List<UCtrlShowItemsInCart> list = CFunctions.AddOrderToUCtrlInCartForm(memberID);
                foreach (var i in list)
                {
                    flpProductInCart.Controls.Add(i);
                }
            }
            RegisterEventToFlpProductInCart(flpProductInCart);
            var q1 = dbContext.OfficialCoupons.Where(i => i.MemberID == memberID && i.ExpireN_A == false && i.CouponID != 2).Select(i => i.Coupon.CouponName);
            if (q1.ToList().Count > 0)
            {
                foreach (var p in q1)
                {
                    UCtrlForCoupon uCtrlForCoupon = new UCtrlForCoupon();
                    uCtrlForCoupon.CouponName = p;
                    uCtrlForCoupon.UseOrNot = "使用";
                    flpCouponCandidate.Controls.Add(uCtrlForCoupon);
                    foreach (Control control in uCtrlForCoupon.Controls)
                    {
                        if (control.GetType() == typeof(Button))
                        {
                            Button button = (Button)control;
                            button.Click += btnUse_Click;
                        }
                    }
                }
            }
        }
        private void RegisterEventToFlpProductInCart(FlowLayoutPanel flpProductInCart)
        {
            foreach (UCtrlShowItemsInCart uCtrl in flpProductInCart.Controls)
            {
                foreach (Control control in uCtrl.Controls)
                {
                    if (control.GetType() == typeof(Button))
                    {
                        Button button = (Button)control;
                        button.Click += btnDelete_Click;
                    }
                    else if (control.GetType() == typeof(NumericUpDown))
                    {
                        NumericUpDown numericUpDown = (NumericUpDown)control;
                        numericUpDown.ValueChanged += nudCount_ValueChanged;
                    }
                    else if (control.GetType() == typeof(CheckBox))
                    {
                        CheckBox checkBox = (CheckBox)control;
                        checkBox.CheckedChanged += CheckBox_CheckedChanged;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        private void btnUse_Click(object sender, EventArgs e)
        {
            Button btnUse = (Button)sender;
            UCtrlForCoupon uCtrl = (UCtrlForCoupon)btnUse.Parent;
            string couponName = uCtrl.CouponName;
            if (flpSelectedCoupon.Controls.Count == 0)
            {
                UCtrlForCoupon uCtrl1 = new UCtrlForCoupon();
                uCtrl1.CouponName = couponName;
                uCtrl1.UseOrNot = "這次不用";
                foreach (Control control in uCtrl1.Controls)
                {
                    if (control.GetType() == typeof(Button))
                    {
                        Button button = (Button)control;
                        button.Click += btnNotUse_Click;
                    }
                    else
                    {
                        continue;
                    }
                }
                flpSelectedCoupon.Controls.Add(uCtrl1);
                flpCouponCandidate.Controls.Remove(uCtrl);
            }
            else
            {
                string tempCouponName = couponName;
                foreach (UCtrlForCoupon uCtrlForCoupon in flpSelectedCoupon.Controls)
                {
                    uCtrl.CouponName = uCtrlForCoupon.CouponName;
                }
                foreach (UCtrlForCoupon uCtrlForCoupon in flpSelectedCoupon.Controls)
                {
                    uCtrlForCoupon.CouponName = tempCouponName;
                }
            }
            flpCouponCandidate.Visible = false;
            IsCouponCandidateOpened = false;
            
            
            float discount = CFunctions.GetDiscountPrice(flpSelectedCoupon, flpProductInCart);
            lblDiscount.Text = discount.ToString("C0");
            int totalPrice = CFunctions.GetTotalPrice(flpProductInCart, discount);
            lblTotalPrice.Text = totalPrice.ToString("C0");
        }

        private void btnNotUse_Click(object sender, EventArgs e)
        {
            Button btnUse = (Button)sender;
            UCtrlForCoupon uCtrl = (UCtrlForCoupon)btnUse.Parent;
            string couponName = uCtrl.CouponName;
            UCtrlForCoupon uCtrl1 = new UCtrlForCoupon();
            uCtrl1.CouponName = couponName;
            uCtrl1.UseOrNot = "使用";
            flpCouponCandidate.Controls.Add(uCtrl1);
            flpSelectedCoupon.Controls.Remove(uCtrl);
            foreach (Control control in uCtrl1.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button button = (Button)control;
                    button.Click += btnUse_Click;
                }
                else
                {
                    continue;
                }
            }
            float discount = CFunctions.GetDiscountPrice(flpSelectedCoupon, flpProductInCart);
            lblDiscount.Text = discount.ToString("C0");
            int totalPrice = CFunctions.GetTotalPrice(flpProductInCart, discount);
            lblTotalPrice.Text = totalPrice.ToString("C0");
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            float discount = CFunctions.GetDiscountPrice(flpSelectedCoupon, flpProductInCart);
            lblDiscount.Text = discount.ToString("C0");
            int totalPrice = CFunctions.GetTotalPrice(flpProductInCart, discount);
            lblTotalPrice.Text = totalPrice.ToString("C0");
            IscbChooseAllClicked = false;
            if (IscbItemsClicked)
            {
                CFunctions.CancelcbChooseAll(flpProductInCart, cbChooseAll);
            }
            IscbChooseAllClicked = true;
        }

        private void nudCount_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            UCtrlShowItemsInCart parent = (UCtrlShowItemsInCart)numericUpDown.Parent;
            int productPrice = int.Parse(parent.productPrice.Replace("NT$", "").Replace(",",""));
            parent.productSumPrice = (Convert.ToInt32(parent.productCount) * productPrice).ToString("C0");
            float discount = CFunctions.GetDiscountPrice(flpSelectedCoupon, flpProductInCart);
            lblDiscount.Text = discount.ToString("C0");
            int totalPrice = CFunctions.GetTotalPrice(flpProductInCart, discount);
            lblTotalPrice.Text = totalPrice.ToString("C0");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要刪除此商品嗎?", "是否要刪除?", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {

                if (IsBuyNow)
                {
                    Button button = (Button)sender;
                    flpProductInCart.Controls.Remove(button.Parent);
                }
                else
                {
                    Button button = (Button)sender;
                    int orderDetailID = (button.Parent as UCtrlShowItemsInCart).orderDetailID;
                    var q = dbContext.OrderDetails.Where(i => i.OrderDetailID == orderDetailID).Select(i => i).FirstOrDefault();
                    int quantity = q.Quantity;
                    int productDetailID = q.ProductDetailID;
                    CFunctions.UpgradeQuantity(productDetailID, quantity);
                    int orderID = q.OrderID;
                    dbContext.OrderDetails.Remove(q);
                    dbContext.SaveChanges();
                    var q1 = dbContext.OrderDetails.Where(i => i.OrderID == orderID).Select(i => i).ToList();
                    if (q1.Count < 1)
                    {
                        var q2 = dbContext.Orders.Where(i => i.OrderID == orderID).Select(i => i).FirstOrDefault();
                        dbContext.Orders.Remove(q2);
                        dbContext.SaveChanges();
                    }
                    flpProductInCart.Controls.Remove(button.Parent);
                    CFunctions.SendMemberInfoToEachForm(memberID);
                }
                float discount = CFunctions.GetDiscountPrice(flpSelectedCoupon, flpProductInCart);
                lblDiscount.Text = discount.ToString("C0");
                int totalPrice = CFunctions.GetTotalPrice(flpProductInCart, discount);
                lblTotalPrice.Text = totalPrice.ToString("C0");
            }
            else
            {
                return;
            }
        }

        private bool IscbChooseAllClicked = true;
        private bool IscbItemsClicked = true;
        private void cbChooseAll_CheckedChanged(object sender, EventArgs e)
        {
            IscbItemsClicked = false;
            if (IscbChooseAllClicked)
            {
                if (cbChooseAll.Checked)
                {
                    foreach (UCtrlShowItemsInCart uCtrl in flpProductInCart.Controls)
                    {
                        uCtrl.IsChecked = true;
                    }
                }
                else
                {
                    foreach (UCtrlShowItemsInCart uCtrl in flpProductInCart.Controls)
                    {
                        uCtrl.IsChecked = false;
                    }
                }
            }
            else
            {
                return;
            }
            IscbItemsClicked = true;

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            
            if (!CFunctions.IsProductInCartInfoAllChecked(flpProductInCart, IsBuyNow))
            {
                return;
            }
            if (IsBuyNow)
            {
                CFunctions.AddOrderAndOrderDetailToDataBase(flpProductInCart, flpSelectedCoupon, memberID);
            }
            else if (CFunctions.IsAllProductSelected(flpProductInCart))
            {
                int orderDetailID = ((UCtrlShowItemsInCart)flpProductInCart.Controls[0]).orderDetailID;
                string recieveAdr = ((UCtrlShowItemsInCart)flpProductInCart.Controls[0]).buyerAddress;
                int couponID = CFunctions.GetCouponID(flpSelectedCoupon);
                int orderID = dbContext.OrderDetails.Where(i => i.OrderDetailID == orderDetailID).Select(i => i.OrderID).FirstOrDefault();
                var order = dbContext.Orders.Where(i => i.OrderID == orderID).Select(i => i).FirstOrDefault();
                order.OrderDatetime = DateTime.Now;
                order.RecieveAdr = recieveAdr;
                order.FinishDate = DateTime.Now;
                order.CouponID = couponID;
                order.StatusID = 2;
                dbContext.SaveChanges();
                foreach (UCtrlShowItemsInCart uCtrl in flpProductInCart.Controls)
                {
                    string shipperName = uCtrl.shipperName.ToString();
                    int shipperID = dbContext.Shippers.Where(i => i.ShipperName == shipperName).Select(i => i.ShipperID).FirstOrDefault();
                    int quantity = uCtrl.productCount;
                    var orderDetail = dbContext.OrderDetails.Where(i => i.OrderDetailID == uCtrl.orderDetailID).Select(i => i).FirstOrDefault();
                    orderDetail.ShipperID = shipperID;
                    orderDetail.Quantity = quantity;
                    orderDetail.ShippingDate = DateTime.Now;
                    orderDetail.RecieveDate = DateTime.Now;
                    orderDetail.ShippingStatusID = 1;
                    dbContext.SaveChanges();
                    int oldQuantity = uCtrl.oldQty;
                    CFunctions.SubtractQtyFromProductDetailDB(uCtrl.productDetailID, oldQuantity, quantity);
                }
                CFunctions.RemoveMemberCouponFromDB(memberID, couponID);
            }
            else 
            {
                CFunctions.AddOrderAndOrderDetailToDataBase(flpProductInCart, flpSelectedCoupon, memberID);
                CFunctions.RemoveOrderDetailFromDB(flpProductInCart);
            }
            
            MessageBox.Show("你的訂單已成立");
            flpProductInCart.Controls.Clear();
            List<UCtrlShowItemsInCart> list = CFunctions.AddOrderToUCtrlInCartForm(memberID);
            foreach (var i in list)
            {
                flpProductInCart.Controls.Add(i);
            }
            RegisterEventToFlpProductInCart(flpProductInCart);
            CFunctions.SendMemberInfoToEachForm(memberID);
            lblDiscount.Text = "-NT$0";
            lblTotalPrice.Text = "NT$0";
            flpSelectedCoupon.Controls.Clear();
            int remainProductCount = Convert.ToInt32(lblProductNumInCart.Text);
            MessageBox.Show($"你的購物車中尚有 {remainProductCount} 件商品");
        }
        bool IsCouponCandidateOpened = false;
        private void btnChooseCoupon_Click(object sender, EventArgs e)
        {
            if (!IsCouponCandidateOpened)
            {
                flpCouponCandidate.Visible = true;
            }
            else
            {
                flpCouponCandidate.Visible = false;
            }
            IsCouponCandidateOpened = !IsCouponCandidateOpened;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

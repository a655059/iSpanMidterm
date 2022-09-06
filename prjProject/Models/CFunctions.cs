﻿using pgjMidtermProject;
using prjProject.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjProject.Models
{
    public class CFunctions
    {

        public static void ClickItemAndShow(Object sender, out int productID)
        {
            Control c = sender as Control;
            CtrlDisplayItem ctrlDisplayItem;
            if (c.Parent.GetType() == typeof(CtrlDisplayItem))
            {
                ctrlDisplayItem = c.Parent as CtrlDisplayItem;
            }
            else
            {
                ctrlDisplayItem = c as CtrlDisplayItem;
            }
            productID = ctrlDisplayItem.productID;
        }

        public static List<CtrlDisplayItem> GetProductsForShow(IQueryable<Product> q)
        {
            iSpanProjectEntities dbContext = new iSpanProjectEntities();
            List<CtrlDisplayItem> list = new List<CtrlDisplayItem>();
            
            foreach (var p in q)
            {
                var q1 = dbContext.ProductPics.Where(i => i.ProductID == p.ProductID).Select(i => i.picture).FirstOrDefault();
                var q2 = dbContext.ProductDetails.Where(i => i.ProductID == p.ProductID).OrderBy(i => i.UnitPrice).Select(i => i.UnitPrice).ToList();
                byte[] image = null;
                if (q1 != null)
                {
                    image = q1;
                }
                string productUnitPrice = "";
                if (q2.Count > 0)
                {
                    decimal maxPrice = q2[q2.Count - 1];
                    decimal minPrice = q2[0];
                    if (maxPrice == minPrice)
                    {
                        productUnitPrice = $"{minPrice.ToString("C0")}";
                    }
                    else
                    {
                        productUnitPrice = $"{minPrice.ToString("C0")} - {maxPrice.ToString("C0")}";
                    }
                }
                string productName = p.ProductName;
                string productDescription = p.Description;
                int productID = p.ProductID;
                CtrlDisplayItem ctrlDisplayItem = CFunctions.AddProductInfoToUserControl(productID, productName, productUnitPrice, productDescription, image);
                list.Add(ctrlDisplayItem);
            }
            return list;
        }

        public static CtrlDisplayItem AddProductInfoToUserControl(int productID, string productName, string productUnitPrice, string productDescription, byte[] image = null, int quantity = 1)
        {
            Image img = null;
            if (image != null)
            {
                MemoryStream ms = new MemoryStream(image);
                img = Image.FromStream(ms);
            }
            
            string qty = "";
            if (quantity == 0)
            {
                qty = "已售完";
            }
            CtrlDisplayItem ctrlDisplayItem = new CtrlDisplayItem
            {
                productID = productID,
                itemName = productName,
                itemPrice = productUnitPrice,
                itemDescription = productDescription,
                itemPhoto = img,
                SoldOut = qty,
            };
            return ctrlDisplayItem;
        }
        public static int GetMemberInfoFromHomePage()
        {
            int memberID = -1;
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(MainForm))
                {
                    MainForm f = (MainForm)form;
                    memberID = f.memberID;
                }
            }
            return memberID;
        }
        
        public static void SendMemberInfoToEachForm(int memberID)
        {
            iSpanProjectEntities dbContext = new iSpanProjectEntities();
            var q = dbContext.MemberAccounts.Where(i => i.MemberID == memberID).Select(i => i).FirstOrDefault();
            var productNumInCart = dbContext.OrderDetails.Where(i => i.Order.MemberID == memberID && i.Order.StatusID == 1).Select(i => i).ToList().Count;
            string memberRegion = q.RegionList.RegionName;
            string memberCountry = q.RegionList.CountryList.CountryName;
            int memberCountryID = Convert.ToInt32(q.RegionList.CountryID);
            var memberRegions = dbContext.RegionLists.Where(i => i.CountryID == memberCountryID).Select(i => i.RegionName).ToArray();
            var countryNames = dbContext.CountryLists.Select(i => i.CountryName).ToArray();
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(MainForm))
                {
                    MainForm f = (MainForm)form;
                    f.memberName = q.Name;
                    f.ProductNumInCart = productNumInCart.ToString();
                    f.memberID = memberID;
                }
                else if (form.GetType() == typeof(SelectedProductForm))
                {
                    SelectedProductForm f = (SelectedProductForm)form;
                    f.memberID = memberID;
                    f.memberName = q.Name;
                    f.ProductNumInCart = productNumInCart.ToString();
                    f.countries = countryNames;
                    f.memberCountryName = memberCountry;
                    f.regions = memberRegions;
                    f.memberRegionName = memberRegion;
                    CFunctions.SetHeart(f);
                    f.memberRegion = q.RegionList.RegionName;
                } 
                else if (form.GetType() == typeof(CartForm))
                {
                    CartForm f = (CartForm)form;
                    f.memberID = memberID;
                    f.memberName = q.Name;
                    f.ProductNumInCart = productNumInCart.ToString();
                }
                else if (form.GetType() == typeof(CommentForm))
                {
                    CommentForm f = (CommentForm)form;
                    f.memberID = memberID;
                    f.memberName = q.Name;
                    f.ProductNumInCart = productNumInCart.ToString();
                }
                else
                {
                    continue;
                }
            }
        }

        public static void SetHeart(SelectedProductForm form)
        {
            iSpanProjectEntities dbContext = new iSpanProjectEntities();
            var q4 = dbContext.Likes.Where(i => i.MemberID == form.memberID && i.ProductID == form.productID).Select(i => i).ToList();

            if (q4.Count == 1)
            {
                form.heart = Image.FromFile("../../Images/redHeart.png");
                form.IsHeartClick = true;
            }
            else
            {
                form.heart = Image.FromFile("../../Images/blackHeart4.png");
                form.IsHeartClick = false;
            }
        }

        public static void AddToCart(COrderInfo orderInfo)
        {
            iSpanProjectEntities dbContext = new iSpanProjectEntities();
            var q = dbContext.Orders.Where(i => i.MemberID == orderInfo.MemberID && i.StatusID == 1).Select(i => i).ToList();
            
            if (q.Count > 0)
            {
                int orderID = q[0].OrderID;
                var q1 = dbContext.OrderDetails.Where(i => i.ProductDetailID == orderInfo.ProductDetailID && i.OrderID == orderID).Select(i => i);

                if (q1.ToList().Count > 0)
                {
                    q1.FirstOrDefault().Quantity += orderInfo.Quantity;
                    dbContext.SaveChanges();
                }
                else
                {
                    OrderDetail orderDetail = new OrderDetail
                    {
                        OrderID = orderID,
                        ProductDetailID = orderInfo.ProductDetailID,
                        ShipperID = orderInfo.ShipperID,
                        Quantity = orderInfo.Quantity,
                        ShippingDate = orderInfo.ShippingDate,
                        RecieveDate = orderInfo.RecieveDate,
                        OutAdr = orderInfo.OutAdr,
                        ShippingStatusID = orderInfo.ShippingStatusID,
                    };
                    dbContext.OrderDetails.Add(orderDetail);
                    dbContext.SaveChanges();
                }
            }
            else
            {
                Order order = new Order
                {
                    MemberID = orderInfo.MemberID,
                    OrderDatetime = orderInfo.OrderDatetime,
                    RecieveAdr = orderInfo.RecieveAdr,
                    FinishDate = orderInfo.FinishDate,
                    CouponID = orderInfo.CouponID,
                    StatusID = 1
                };
                dbContext.Orders.Add(order);
                dbContext.SaveChanges();
                int newOrderID = dbContext.Orders.Where(i => i.MemberID == orderInfo.MemberID && i.StatusID == 1).Select(i => i.OrderID).FirstOrDefault();
                OrderDetail orderDetail = new OrderDetail
                {
                    OrderID = newOrderID,
                    ProductDetailID = orderInfo.ProductDetailID,
                    ShipperID = orderInfo.ShipperID,
                    Quantity = orderInfo.Quantity,
                    ShippingDate = orderInfo.ShippingDate,
                    RecieveDate = orderInfo.RecieveDate,
                    OutAdr = orderInfo.OutAdr,
                    ShippingStatusID = orderInfo.ShippingStatusID,
                };
                dbContext.OrderDetails.Add(orderDetail);
                dbContext.SaveChanges();
            }
        }
        public static int UpgradeQuantity(int productDetailID, int count = 0)
        {
            iSpanProjectEntities dbContext = new iSpanProjectEntities();
            var q = dbContext.ProductDetails.Where(i => i.ProductDetailID == productDetailID).Select(i => i).FirstOrDefault();
            q.Quantity += count;
            dbContext.SaveChanges();
            var q1= dbContext.ProductDetails.Where(i => i.ProductDetailID == productDetailID).Select(i => i).FirstOrDefault();
            int latestQuantity = q1.Quantity;
            return latestQuantity;
        }

        public static void ShowMemberInfoAtHeader(int memberID, out string memberName, out int productNumInCart)
        {
            iSpanProjectEntities dbContext = new iSpanProjectEntities();
            memberName = dbContext.MemberAccounts.Where(i => i.MemberID == memberID).Select(i => i.Name).FirstOrDefault();
            productNumInCart = dbContext.OrderDetails.Where(i => i.Order.MemberID == memberID && i.Order.StatusID == 1).Select(i => i).ToList().Count;
        }

        public static List<UCtrlShowItemsInCart> AddOrderToUCtrlInCartForm(int memberID)
        {
            iSpanProjectEntities dbContext = new iSpanProjectEntities();
            List<UCtrlShowItemsInCart> list = new List<UCtrlShowItemsInCart>();
            int orderID = dbContext.Orders.Where(i => i.MemberID == memberID && i.StatusID == 1).Select(i => i.OrderID).FirstOrDefault();
            var q = dbContext.OrderDetails.Where(i => i.OrderID == orderID).Select(i => i);
            var q1 = dbContext.MemberAccounts.Where(i => i.MemberID == memberID).Select(i => i).FirstOrDefault();
            string buyerAddress = q1.Address;
            string buyerPhone = q1.Phone;
            foreach (var p in q)
            {
                byte[] bytes = p.ProductDetail.Pic;
                MemoryStream ms = new MemoryStream(bytes);
                Image image = Image.FromStream(ms);
                string productName = p.ProductDetail.Product.ProductName;
                string productStyle = p.ProductDetail.Style;
                productName = $"{productName} - {productStyle}";
                decimal productPrice = p.ProductDetail.UnitPrice;
                int productCount = p.Quantity;
                int productSumPrice = Convert.ToInt32(productPrice) * productCount;
                int orderDetailID = p.OrderDetailID;
                int productID = p.ProductDetail.Product.ProductID;
                int productDetailID = p.ProductDetailID;
                int oldQty = productCount;
                List<string> shipperName = dbContext.ShipperToProducts.Where(i => i.ProductID == productID).Select(i => i.Shipper.ShipperName).ToList();


                UCtrlShowItemsInCart uCtrl = AddOrderToUCtrl(oldQty, productDetailID, image, productName, productPrice, productCount, productSumPrice, buyerAddress, buyerPhone, shipperName, orderDetailID);
                list.Add(uCtrl);
            }
            return list;
        }

       


        public static UCtrlShowItemsInCart AddOrderToUCtrl(int oldQty, int productDetailID, Image productPhoto, string productName, decimal productPrice, int productCount, int productSumPrice, string buyerAddress, string buyerPhone, object shipperName, int orderDetailID = 0)
        {
            UCtrlShowItemsInCart uCtrl = new UCtrlShowItemsInCart
            {
                oldQty = oldQty,
                orderDetailID = orderDetailID,
                productDetailID = productDetailID,
                productPhoto = productPhoto,
                productName = productName,
                productPrice = $"{productPrice.ToString("C0")}",
                productCount = productCount,
                productSumPrice = $"{productSumPrice.ToString("C0")}",
                buyerAddress = buyerAddress,
                buyerPhone = buyerPhone,
                shipperName = shipperName,
            };
            return uCtrl;
        }

        public static bool IsAllInfoChecked(int productDetailID, string productRegion, decimal nudCountValue, out int detailID, out string outAdr, out int qty)
        {
            detailID = 0;
            outAdr = "";
            qty = 0;
            if (productDetailID == 0 || productRegion == "")
            {
                MessageBox.Show("請選擇一個樣式");
                return false;
            }
            else
            {
                detailID = productDetailID;
                outAdr = productRegion;
            }
            if (nudCountValue == 0)
            {
                MessageBox.Show("請選擇訂購的數量");
                return false;
            }
            else
            {
                qty = Convert.ToInt32(nudCountValue);
            }
            return true;
        }

        public static void ResetStyleButton(FlowLayoutPanel flp, int productID)
        {
            iSpanProjectEntities dbContext = new iSpanProjectEntities();
            foreach (Control control in flp.Controls)
            {
                if (control.GetType() == typeof(Label))
                {
                    Label label = (Label)control;
                    string style = label.Text;
                    int productQuantity = dbContext.ProductDetails.Where(i => i.Style == style && i.ProductID == productID).Select(i => i.Quantity).FirstOrDefault();
                    if (productQuantity == 0)
                    {
                        label.ForeColor = Color.DarkGray;
                        label.BorderStyle = BorderStyle.Fixed3D;
                        label.BackColor = Color.Transparent;
                    }
                    else
                    {
                        label.BorderStyle = BorderStyle.FixedSingle;
                    }
                    
                }
                else
                {
                    continue;
                }
            }
        }
        public static int GetTotalPrice(FlowLayoutPanel flpProductInCart, float discount)
        {
            int totalPrice = 0;
            foreach (UCtrlShowItemsInCart uCtrl in flpProductInCart.Controls)
            {
                if (uCtrl.IsChecked)
                {
                    totalPrice += Convert.ToInt32(uCtrl.productSumPrice.Replace("NT$", "").Replace(",", ""));
                }
                else
                {
                    continue;
                }
            }
            totalPrice += Convert.ToInt32(discount);
            if (totalPrice <= 0)
            {
                totalPrice = 0;
            }
            return totalPrice;
        }

        public static float GetDiscountPrice(FlowLayoutPanel flpSelectedCoupon, FlowLayoutPanel flpProductInCart)
        {
            float oldTotalPrice = 0;
            
            foreach (UCtrlShowItemsInCart uCtrlShowItemsInCart in flpProductInCart.Controls)
            {
                if (uCtrlShowItemsInCart.IsChecked)
                {
                    oldTotalPrice += float.Parse(uCtrlShowItemsInCart.productSumPrice.Replace("NT$", "").Replace(",", ""));
                }
                else
                {
                    continue;
                }
            }
            float tempPrice = oldTotalPrice;
            iSpanProjectEntities dbContext = new iSpanProjectEntities();
            foreach (UCtrlForCoupon uCtrl in flpSelectedCoupon.Controls)
            {
                string couponName = uCtrl.CouponName;
                var q = dbContext.Coupons.Where(i => i.CouponName == couponName).Select(i => i.Discount).FirstOrDefault();
                tempPrice *= (1 - q);
            }
            float discount = tempPrice - oldTotalPrice;
            return discount;
        }
        public static void CancelcbChooseAll(FlowLayoutPanel flp, CheckBox checkBox)
        {
            foreach (UCtrlShowItemsInCart uCtrl in flp.Controls)
            {
                if (uCtrl.IsChecked == false)
                {
                    checkBox.Checked = false;
                    break;
                }
            }
        }

        public static bool IsProductInCartInfoAllChecked(FlowLayoutPanel flp, bool isBuyNow)
        {
            iSpanProjectEntities dbContext = new iSpanProjectEntities();
            if (flp.Controls.Count == 0)
            {
                MessageBox.Show("購物車裡沒有商品了");
                return false;
            }
            int selectedProductCount = CFunctions.SelectedProductCount(flp);
            if (selectedProductCount == 0)
            {
                MessageBox.Show("請至少選擇一個商品");
                return false;
            }

            foreach (UCtrlShowItemsInCart uCtrl in flp.Controls)
            {
                if (uCtrl.IsChecked)
                {
                    string productName = "";
                    string style = "";
                    int productQty = 0;
                    int orderDetailQty = 0;
                    int productDetailID = uCtrl.productDetailID;
                    if (isBuyNow)
                    {
                        var q = dbContext.ProductDetails.Where(i => i.ProductDetailID == productDetailID).Select(i => i).FirstOrDefault();
                        productName = q.Product.ProductName;
                        style = q.Style;
                        productQty = q.Quantity;
                        orderDetailQty = 0;
                    }
                    else
                    {
                        var q = dbContext.OrderDetails.Where(i => i.OrderDetailID == uCtrl.orderDetailID).Select(i => i).FirstOrDefault();
                        productName = q.ProductDetail.Product.ProductName;
                        style = q.ProductDetail.Style;
                        productQty = q.ProductDetail.Quantity;
                        orderDetailQty = q.Quantity;
                    }
                    
                    if (uCtrl.productCount > productQty + orderDetailQty)
                    {
                        MessageBox.Show($"{productName} - {style} 的庫存僅剩 {productQty + orderDetailQty} 件，請重新選擇商品數量");
                        return false;
                    }
                    else if (uCtrl.shipperName.ToString() == "")
                    {
                        MessageBox.Show("請選擇一個物流公司");
                        return false;
                    }
                    else if (uCtrl.buyerAddress == "")
                    {
                        MessageBox.Show("請填寫收貨地址");
                        return false;
                    }
                    else if (uCtrl.buyerPhone == "")
                    {
                        MessageBox.Show("請填寫連絡電話");
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return true;
        }
        public static bool IsAllProductSelected(FlowLayoutPanel flp)
        {
            bool isAllProductSelected = true;
            int selectedCount = SelectedProductCount(flp);
            if (selectedCount == flp.Controls.Count)
            {
                isAllProductSelected = true;
            }
            else
            {
                isAllProductSelected = false;
            }
            return isAllProductSelected;
        }
        public static int SelectedProductCount(FlowLayoutPanel flp)
        {
            int selectedCount = 0;
            foreach (UCtrlShowItemsInCart uCtrl in flp.Controls)
            {
                if (uCtrl.IsChecked)
                {
                    selectedCount += 1;
                }
                else
                {
                    continue;
                }
            }
            return selectedCount;
        }
        public static int GetCouponID(FlowLayoutPanel flp)
        {
            int couponID = 0;
            if (flp.Controls.Count == 0)
            {
                couponID = 7;
            }
            else
            {
                foreach (UCtrlForCoupon uCtrl in flp.Controls)
                {
                    iSpanProjectEntities dbContext = new iSpanProjectEntities();
                    couponID = dbContext.Coupons.Where(i => i.CouponName == uCtrl.CouponName).Select(i => i.CouponID).FirstOrDefault();
                }
            }
            return couponID;
        }
        public static void AddOrderAndOrderDetailToDataBase(FlowLayoutPanel flpProductInCart, FlowLayoutPanel flpSelectedCoupon, int memberID)
        {
            iSpanProjectEntities dbContext = new iSpanProjectEntities();
            int couponID = CFunctions.GetCouponID(flpSelectedCoupon);
            var address = (flpProductInCart.Controls[0] as UCtrlShowItemsInCart).buyerAddress ;
            Order order = new Order
            {
                MemberID = memberID,
                OrderDatetime = DateTime.Now,
                RecieveAdr = address,
                FinishDate = DateTime.Now,
                CouponID = couponID,
                StatusID = 2
            };
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
            var q = dbContext.Orders.Where(i => i.MemberID == memberID && i.StatusID == 2 && i.CouponID == couponID).OrderByDescending(i => i.OrderID).Select(i => i).FirstOrDefault();
            int orderID = q.OrderID;
            foreach (UCtrlShowItemsInCart uCtrl in flpProductInCart.Controls)
            {
                if (uCtrl.IsChecked)
                {
                    string shipperName = uCtrl.shipperName.ToString();
                    int quantity = uCtrl.productCount;
                    int shipperID = dbContext.Shippers.Where(i => i.ShipperName == shipperName).Select(i => i.ShipperID).FirstOrDefault();
                    int productDetailID = uCtrl.productDetailID;
                    int regionID = dbContext.ProductDetails.Where(i => i.ProductDetailID == productDetailID).Select(i => i.Product.RegionID).FirstOrDefault();
                    string outAdr = dbContext.RegionLists.Where(i => i.RegionID == regionID).Select(i => i.RegionName).FirstOrDefault();
                    OrderDetail orderDetail = new OrderDetail
                    {
                        OrderID = orderID,
                        ProductDetailID = productDetailID,
                        ShipperID = shipperID,
                        Quantity = quantity,
                        ShippingDate = DateTime.Now,
                        RecieveDate = DateTime.Now,
                        OutAdr = outAdr,
                        ShippingStatusID = 1,
                    };
                    dbContext.OrderDetails.Add(orderDetail);
                    dbContext.SaveChanges();
                    int oldQuantity = uCtrl.oldQty;
                    CFunctions.SubtractQtyFromProductDetailDB(productDetailID, oldQuantity, quantity);
                }
                else
                {
                    continue;
                }
            }
            CFunctions.RemoveMemberCouponFromDB(memberID, couponID);
        }

        public static void SubtractQtyFromProductDetailDB( int productDetailID, int oldQuantity, int newQuantity)
        {
            iSpanProjectEntities dbContext = new iSpanProjectEntities();
            var q = dbContext.ProductDetails.Where(i => i.ProductDetailID == productDetailID).Select(i => i).FirstOrDefault();
            q.Quantity = oldQuantity + q.Quantity - newQuantity;
            dbContext.SaveChanges();
        }
        public static void RemoveMemberCouponFromDB(int memberID, int couponID)
        {
            if (couponID == 7) return;
            iSpanProjectEntities dbContext = new iSpanProjectEntities();
            var q = dbContext.OfficialCoupons.Where(i => i.MemberID == memberID && i.CouponID == couponID).Select(i => i).FirstOrDefault();
            q.ExpireN_A = false;
            dbContext.SaveChanges();
        }

        public static void RemoveOrderDetailFromDB(FlowLayoutPanel flp)
        {
            iSpanProjectEntities dbContext = new iSpanProjectEntities();
            foreach (UCtrlShowItemsInCart uCtrl in flp.Controls)
            {
                if (uCtrl.IsChecked)
                {
                    int orderDetailID = uCtrl.orderDetailID;
                    var q = dbContext.OrderDetails.Where(i => i.OrderDetailID == orderDetailID).Select(i => i).FirstOrDefault();
                    dbContext.OrderDetails.Remove(q);
                    dbContext.SaveChanges();
                }
                else
                {
                    continue;
                }
            }
        }
        
        public static void ShowComments(int productID)
        {
            iSpanProjectEntities dbContext = new iSpanProjectEntities();
            var comments = dbContext.Comments.Where(i => i.ProductID == productID).OrderByDescending(i => i.CommentID).Select(i=>i);
            foreach (var c in comments)
            {

                UCtrlComment uCtrl = new UCtrlComment();
                //uCtrl.
            }
        }
        
    }
}

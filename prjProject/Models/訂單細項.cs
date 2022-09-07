using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjProject.Models
{
    public class 訂單細項
    {
        public int OrderID
        {
            get;
            set;
        }
        public int OrderDetailID
        {
            get;
            set;
        }

        public int ProductDetailID
        {
            get;
            set;
        }

        public int ShipperID
        {
            get;
            set;
        }

        public int Quantity
        {
            get;
            set;
        }

        public DateTime ShippingDate
        {
            get;
            set;
        }

        public DateTime ReceiveDate
        {
            get;
            set;
        }

        public string OutAdr
        {
            get;
            set;
        }

        public int ShippingStatusID
        {
            get;
            set;
        }
    }
}

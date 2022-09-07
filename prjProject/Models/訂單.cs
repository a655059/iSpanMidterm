using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjProject.Models
{
    public class 訂單
    {
        public int OrderID
        {
            get;
            set;
        }

        public int MemberID
        {
            get;
            set;
        }

        public DateTime OrderDatetime
        {
            get;
            set;
        }

        public string RecieveAdr
        {
            get;
            set;
        }

        public DateTime FinishDate
        {
            get;
            set;
        }

        public int CouponID
        {
            get;
            set;
        }

        public int StatusID
        {
            get;
            set;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjProject.Management
{
   public class 商品細項
    {
        public int ProductID { get; set; }
        public string Style { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public byte[] pic { get; set; }

    }
}

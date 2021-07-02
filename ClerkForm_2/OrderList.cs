using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClerkForm_2
{
    public class OrderList
    {
        public int orderId { get; set; }
        public int productCode { get; set; }
        public string product { get; set; }
        public int count { get; set; }
        public string orderTime { get; set; }

        public bool complete { get; set; }
        public OrderList() { }
    }
}

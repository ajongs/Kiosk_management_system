using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClerkForm_2
{
    public partial class OrderCompleteForm : Form
    {
        List<UserControl1> UcList = new List<UserControl1>();
        public OrderCompleteForm()
        {
            InitializeComponent();
        }
        public void makeList(List<OrderList> list)
        {
            int no = 0;
            int i = 0;
            foreach (var l in list)
            {
                UserControl1 userControl = new UserControl1();
                if (no != l.orderId && l.complete == true)
                {
                    no = l.orderId;
                    userControl.No = no.ToString();
                    int count = checkCount(list, no);
                    userControl.list = GroupingList(list, no);
                    if (count == 0)
                    {
                        userControl.Product = l.product;
                    }
                    else
                    {
                        userControl.Product = l.product + " 외 " + count + "건";
                    }
                    userControl.Time = l.orderTime;
                    UcList.Add(userControl);
                    panel1.Controls.Add(UcList[i]);
                    i++;
                }
            }
        }
        private int checkCount(List<OrderList> list, int n)
        {
            return list.FindAll(id => id.orderId == n).Count - 1;
        }
        private List<OrderList> GroupingList(List<OrderList> list, int n)
        {
            return list.FindAll(l => l.orderId == n);
        }
    }
}

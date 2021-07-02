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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public List<OrderList> list { set; get; }
        public string No
        {
            get
            {
                return this.idlbl.Text;
            }
            set
            {
                this.idlbl.Text = value;
            }
        }
        public string Product
        {
            get
            {
                return this.productlbl.Text;
            }
            set
            {
                this.productlbl.Text = value;
            }
        }
        public string Time
        {
            get
            {
                return this.timelbl.Text;
            }
            set
            {
                this.timelbl.Text = value;
            }
        }
        public bool check = false;
        private void idlbl_CheckedChanged(object sender, EventArgs e)
        {
            check = true;
        }

        private void idlbl_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                idlbl.Checked = false;
            }
            check = false;
        }
        public bool checkStatus()
        {
            return idlbl.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectAll();
        }
        private void selectAll()
        {
            string info = "";
            foreach (var l in list)
            {
                info += l.product + "  " + l.count + "개 " + "\n";
            }
            MessageBox.Show(info);
        }

        private void productlbl_Click(object sender, EventArgs e)
        {
            selectAll();
            button1.Focus();
        }

        private void timelbl_Click(object sender, EventArgs e)
        {
            selectAll();
            button1.Focus();
        }
    }
}

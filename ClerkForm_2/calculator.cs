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
    public partial class calculator : Form
    {
        double result=0;
        string op = "";
        public calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tb.Text += btn.Text;
            btnEqual.PerformClick();
        }

        private void op_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            result = Double.Parse(tb.Text);
            op = btn.Text;
            tb.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (op) 
            {
                case "+":
                    result += Double.Parse(tb.Text);
                    tb.Text = result.ToString();
                    break;
                case "-":
                    result -= Double.Parse(tb.Text);
                    tb.Text = result.ToString();
                    break;
                case "/":
                    result /= Double.Parse(tb.Text);
                    tb.Text = result.ToString();
                    break;
                case "*":
                    result *= Double.Parse(tb.Text);
                    tb.Text = result.ToString();
                    break;
            }

        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            result = 0;
            tb.Clear();
        }
    }
}

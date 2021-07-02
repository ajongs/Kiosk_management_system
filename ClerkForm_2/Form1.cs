using Guna.UI.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClerkForm_2
{
    
    public partial class Form1 : Form
    {
        private Form activeForm = null;
        private Manager manager;
        private List<Manager> managerList;
        public Form1(Manager manager, List<Manager> managerList)
        {
            InitializeComponent();
            this.manager = manager;
            this.managerList = managerList;
        }
        private void openContentForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(GunaAdvenceButton))
                {
                    GunaAdvenceButton button = (GunaAdvenceButton)previousBtn;
                    button.BaseColor = Color.FromArgb(255, 224, 192);
                }
            }
        }
        private void httpConnect()
        {
            OrderListForm form1 = new OrderListForm();
            form1.reMakeList = httpConnect;
            openContentForm(form1);
            String uri = "http://localhost:8080/orderList";
            //uri 사용시 문의하세요
            WebClient webClient = new WebClient();

            //GET 방식
            Stream stream = webClient.OpenRead(uri);
            string responseJson = new StreamReader(stream).ReadToEnd();
            //MessageBox.Show(responseJson);
            List<OrderList> orderList = JsonConvert.DeserializeObject<List<OrderList>>(responseJson);
            form1.makeList(orderList);
        }
        private void orderListBtn_Click(object sender, EventArgs e)
        {
            DisableButton();
            httpConnect();
            GunaAdvenceButton button = (GunaAdvenceButton)sender;
            button.BaseColor = Color.Snow;
            
        }

        private void orderCompleteBtn_Click(object sender, EventArgs e)
        {
            OrderCompleteForm form= new OrderCompleteForm();
            openContentForm(form);
            DisableButton();
            GunaAdvenceButton button = (GunaAdvenceButton)sender;
            button.BaseColor = Color.Snow;

            String uri = "http://localhost:8080/orderList";
            //uri 사용시 문의하세요
            WebClient webClient = new WebClient();

            //GET 방식
            Stream stream = webClient.OpenRead(uri);
            string responseJson = new StreamReader(stream).ReadToEnd();
            //MessageBox.Show(responseJson);

            List<OrderList> orderList = JsonConvert.DeserializeObject<List<OrderList>>(responseJson);

            form.makeList(orderList);
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            calculator cal = new calculator();
            cal.Show();
        }

        private void configBtn_Click(object sender, EventArgs e)
        {
            openContentForm(new ConfigForm(manager, managerList));
            DisableButton();
            GunaAdvenceButton button = (GunaAdvenceButton)sender;
            button.BaseColor = Color.Snow;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            managerId.Text = manager.id;
            orderListBtn.PerformClick();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);
                pictureBox2.Image = image;
            }
        }
    }
}

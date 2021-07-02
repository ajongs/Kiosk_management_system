using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClerkForm_2
{
    public partial class OrderListForm : Form
    {
        List<UserControl1> UcList = new List<UserControl1>();
        public OrderListForm()
        {
            InitializeComponent();
        }
        public delegate void orderButtonDelegate();

        public orderButtonDelegate reMakeList;

        public void makeList(List<OrderList> list)
        { 
            int no = 0;
            int i = 0;
            foreach(var l in list)
            {
                UserControl1 userControl = new UserControl1();
                if (no != l.orderId && l.complete == false)
                {
                    no = l.orderId;
                    userControl.No = no.ToString();
                    userControl.list = GroupingList(list, no);
                    int count = checkCount(list, no);
                    if (count == 0) {
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
            return list.FindAll(l => l.orderId == n).Count-1;
        }
        private List<OrderList> GroupingList(List<OrderList> list, int n)
        {
            return list.FindAll(l => l.orderId == n);
        }
        public List<int> findCheckedBox()
        {
            List<int> checkedUserControlList = new List<int>();
            foreach (var l in UcList)
            {
                if (l.checkStatus())
                {
                    checkedUserControlList.Add(int.Parse(l.No));
                }
            }
            return checkedUserControlList;
        }
        private void completeBtn_Click(object sender, EventArgs e)
        {
            //체크된 항목 알아오기
            List<int> checkedUserControlList = findCheckedBox();
            var requestJson = JsonConvert.SerializeObject(checkedUserControlList.ToArray(), Formatting.Indented);

            
            //var jsonStringName = new JavaScriptSerializer();
            String uri = "http://localhost:8080/orderComplete";
            //uri 사용시 문의하세요
            WebClient webClient = new WebClient();

            //POST 방식
            webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
            webClient.Encoding = UTF8Encoding.UTF8;
            string responseJson = webClient.UploadString(uri, requestJson);

            MessageBox.Show(responseJson);

            //부모 클래스의 GET 요청 재사용
            reMakeList();
        }
    }
}

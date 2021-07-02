using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClerkForm_2
{
    public partial class LoginForm : Form
    {
        List<Manager> managerList;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            bool login = false;
            Manager manager=null;
            foreach(var m in managerList)
            {
                if(m.id == idTBox.Text && m.password == int.Parse(PassTBox.Text))
                {
                    login = true;
                    manager = m;
                    break;
                }
            }
            if (login)
            {
                this.Hide();
                Form1 form1 = new Form1(manager, managerList);
                form1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("계정 혹은 비밀번호가 일치하지 않습니다.");
                idTBox.Clear();
                PassTBox.Clear();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //파일 입출력
            StreamReader rd = new StreamReader(File.OpenRead("manager.txt"));

            managerList = new List<Manager>();
            List<String> list = new List<string>();
            
            int i = 0;
            while (!rd.EndOfStream)
            {
                //파일자료 리스트로 읽기
                list.Add(rd.ReadLine());
                Manager manager = new Manager();
                //레코드 프로퍼티로 읽기
                manager.id = list[i].Split(',')[0];
                manager.password = int.Parse(list[i].Split(',')[1]);
                managerList.Add(manager);
                i++;
            }
            rd.Close();
        }
    }
}

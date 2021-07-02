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
    public partial class ConfigForm : Form
    {
        Manager manager;
        List<Manager> managerList;
        public ConfigForm(Manager manager, List<Manager> managerList)
        {
            InitializeComponent();
            this.manager = manager;
            this.managerList = managerList;
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(nowPw.Text) != manager.password)
            {
                clearPWBoxes();
                MessageBox.Show("현재 비밀번호가 일치하지 않습니다.");
            }
            else if(int.Parse(newPW.Text )!= int.Parse(checkPw.Text))
            {
                clearPWBoxes();
                MessageBox.Show("확인비밀번호가 새로운 비밀번호와 일치하지 않습니다.");
            }
            else
            {
                manager.password = int.Parse(newPW.Text);

                int index = managerList.FindIndex(m => m.id == manager.id);
                managerList[index].password = manager.password;

                StreamWriter sw = new StreamWriter("manager.txt",false);

                foreach(var m in managerList){
                    sw.WriteLine(m.id + ", " + m.password);
                }
                sw.Close();
                clearPWBoxes();
                MessageBox.Show("변경 되었습니다.");
            }
        }
        private void clearPWBoxes()
        {
            nowPw.Clear();
            newPW.Clear();
            checkPw.Clear();
        }
    }
}

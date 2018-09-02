using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurant
{
    public partial class 修改密码 : Form
    {
        public 修改密码()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;//无效
            string userName = ID.Text;
            string oldPass = OLDPASS.Text;
            string newPass = NEWPASS.Text;
            string newPass1 = NEWPASS1.Text;

            if(newPass!=newPass1)
            {
                MessageBox.Show("两次输入的密码不一致！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (userName == string.Empty || userName.Equals(" "))
            {
                MessageBox.Show("请输入用户名！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ID.Focus();
            }
            else if (oldPass == string.Empty || oldPass.Equals(" "))
            {
                MessageBox.Show("请输入旧密码！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OLDPASS.Focus();
            }
            else if (newPass == string.Empty || newPass.Equals(" "))
            {
                MessageBox.Show("请输入新密码！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NEWPASS.Focus();
            }
            else if (newPass1 == string.Empty || newPass1.Equals(" "))
            {
                MessageBox.Show("请重复输入新密码！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NEWPASS1.Focus();
            }
            else
            {
                string remark;
                if (rdoNomal.Checked == true)
                {
                    remark = "1";
                }
                else if (rdoAdm.Checked == true)
                {
                    remark = "2";
                }
                else
                {
                    MessageBox.Show("请选择用户类别！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string connString = "Data Source=DESKTOP-4E43AKN;Initial Catalog=restaurant;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                string sql = String.Format("update [user] set password='{0}' where username='{1}' and password ='{2}' and remark= {3}", newPass, userName, oldPass, remark);
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    int num = (int)comm.ExecuteScalar();
                    if (num == 1)
                    {
                        MessageBox.Show("修改密码成功", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new Login().Show();
                        this.Visible = false;
                    }
                    else
                    {
                        NEWPASS.Text = "";
                        NEWPASS1.Text = "";
                        MessageBox.Show("您输入的用户名或密码错误！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        ID.Clear();
                        OLDPASS.Clear();
                        ID.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数据库出错！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    conn.Close();
                }
            }
           // this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }
    }
}

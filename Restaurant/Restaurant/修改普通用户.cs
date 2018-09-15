using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class 修改普通用户 : Form
    {
        public 修改普通用户()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string passWord = txtPkey.Text;
            if (userName == string.Empty || userName.Equals(" "))
            {
                MessageBox.Show("请输入用户名！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
            }
            else if (passWord == string.Empty || passWord.Equals(" "))
            {
                MessageBox.Show("请输入新密码！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPkey.Focus();
            }
            else if(!passWord.Equals(txtkey2.Text))
            {
                MessageBox.Show("两次输入的密码不一致！", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connString = "Data Source=;Initial Catalog=restaurant;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                string sql = String.Format("update [User] set password='{0}' where username='{1}' and remark={2}", passWord,userName, "1");
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    int num = (int)comm.ExecuteNonQuery();
                    if (num == 1)
                    {
                        MessageBox.Show("修改密码成功！", "修改成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("没有用户名为" + userName + "的用户", "修改失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        }
    }
}

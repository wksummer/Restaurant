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
    public partial class Login : Form
    {
        public static string userName;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            userName = txtUser.Text;
            string passWord = txtPkey.Text;
            if (userName == string.Empty || userName.Equals(" "))
            {
                MessageBox.Show("请输入用户名！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
            }
            else if (passWord == string.Empty || passWord.Equals(" "))
            {
                MessageBox.Show("请输入密码！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPkey.Focus();
            }
            else
            {
                string remark;
                if (rdoNorm.Checked == true)
                {
                    remark = "1";
                }
                else if (rdoAdm.Checked == true)
                {
                    remark = "2";
                }
                else
                {
                    MessageBox.Show("请选择用户类别！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string connString = "Data Source=;Initial Catalog=restaurant;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                string sql = String.Format("select count(*) from [user] where username='{0}' and password ='{1}' and remark= {2}", userName, passWord,remark);
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    int num = (int)comm.ExecuteScalar();
                    if (num == 1)
                    {
                        MessageBox.Show("欢迎进入点餐系统！", "登录成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(remark.Equals("2"))
                        {
                            Administrator admin = new Administrator();
                            admin.Show();
                        }
                        else
                        {
                            Staff staff= new Staff();
                            staff.Show();
                        }

                        this.Visible = false;
                    }
                    else
                    {
                        txtPkey.Text = "";
                        MessageBox.Show("您输入的用户名或密码错误！", "登陆失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtUser.Clear();
                        txtPkey.Focus();
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

        private void btnChg_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            new 修改密码().Show();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Signup sign = new Signup();
            sign.Show();
        }
    }
}

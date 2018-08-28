using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Login : Form
    {
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
            string userName = txtUser.Text;
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

        }
    }
}

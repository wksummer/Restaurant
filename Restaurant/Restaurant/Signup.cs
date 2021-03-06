﻿using System;
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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string passWord = txtPkey.Text;
            if (userName == string.Empty || userName.Equals(" "))
            {
                MessageBox.Show("请输入用户名！", "注册失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
            }
            else if (passWord == string.Empty || passWord.Equals(" "))
            {
                MessageBox.Show("请输入密码！", "注册失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("请选择用户类别！", "注册失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string connString = "Data Source=;Initial Catalog=restaurant;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                string sql = String.Format("select count(*) from [user] where username='{0}'", userName,remark);
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sql, conn);
                    int num = (int)comm.ExecuteScalar();
                    if (num == 1)
                    {

                        MessageBox.Show("该用户名已被注册！", "注册失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtUser.Clear();
                        txtPkey.Clear();
                        txtUser.Focus();
                        
                    }
                    else
                    { 
                        String sql1 = String.Format("insert [User] values('{0}','{1}',{2})",userName,passWord,remark);
                        SqlCommand comm1 = new SqlCommand(sql1, conn);
                        num = (int)comm1.ExecuteNonQuery();
                        if (num == 1)
                        {
                            MessageBox.Show("恭喜,注册成功！", "注册成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("注册失败！", "注册失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
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

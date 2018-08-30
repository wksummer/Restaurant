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
            bool flag = false;//数据库操作是否成功
            //
            //数据库修改
            if(flag)
            {
                 //模态对话框
            }
            this.Close();
            new Login().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }
    }
}

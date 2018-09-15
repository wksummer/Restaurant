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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("您确定要注销登录吗？", "注销", mess, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
                System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
            }

        }

        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons mess = MessageBoxButtons.OKCancel;
            DialogResult dr = MessageBox.Show("确定退出吗？", "退出", mess, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void 增加普通用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNor an = new AddNor();
            an.Show();
        }

        private void 修改普通用户密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改普通用户 change = new 修改普通用户();
            change.Show();
        }

        private void 修改饭菜信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            饭菜信息管理 form = new 饭菜信息管理();
            form.Show();
        }

        private void 修改套餐信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            套餐管理 form = new 套餐管理();
            form.Show();
        }

        private void 统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 员工业绩排名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Performance per = new Performance();
            per.Show();
        }

        private void 按时间从查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            统计查询 form = new 统计查询();
            form.Show();
        }

        private void 热销套餐ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            热销套餐 form = new 热销套餐();
            form.Show();
        }
    }
}

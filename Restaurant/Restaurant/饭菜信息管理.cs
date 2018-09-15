using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurant
{
    public partial class 饭菜信息管理 : Form
    {
        String connString = "Data Source=.;Initial Catalog=restaurant;Integrated Security=True";
        SqlConnection conn;
        DataSet ds;
        SqlDataAdapter da;
        string category;
        string itemname;
        string  amount;
        string  itemprice;
        public 饭菜信息管理()
        {
            InitializeComponent();
        }
        private void GetDataGridView()
        {
            conn = new SqlConnection(connString);
            string sql = "select category as 单品类别,itemname as 单品名,itemprice as 单品价格, amount as 库存  from fooditem";
            da = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            GetDataGridView();
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            button2.Enabled = true;
            button3.Enabled = true;
            category= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            itemname = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            itemprice = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            amount = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = category;
            textBox1.Text = itemname;
            textBox2.Text=amount;
            textBox3.Text = itemprice;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("修改确认", "确定要修改吗？", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            { string olditemname = textBox1.Text;
              string sql = string.Format("update fooditem set  itemprice={0},amount={1} where itemname ='{2}'",textBox3.Text, textBox2.Text,textBox1.Text);
              
                try
                {
                    SqlCommand command = new SqlCommand(sql, conn);
                    conn.Open();
                    int num = command.ExecuteNonQuery();
                    //如果更新数据成功 重新绑定datagridview
                    if (num > 0 )
                    {
                        GetDataGridView();
                        MessageBox.Show("修改成功！", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "数据库操作失败！");
                }
                finally
                {
                    conn.Close();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            string category1 = Convert.ToString(comboBox1.Text);
            string itemname1 = Convert.ToString(textBox1.Text);
            int amount1 = Convert.ToInt32(textBox2.Text.Trim());
            double  itemprice1= Convert.ToDouble(textBox3.Text);
            if (itemname1 == "")
                MessageBox.Show("单品名称不能为空！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (category1 == "")
                MessageBox.Show("单品类型不能为空！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (itemprice1<0||itemprice1==0||itemprice1.ToString()=="")
                MessageBox.Show("单品价非法，请检查是否小于等于零或价格为空", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (amount1 < 0 || amount1 == 0 || amount1.ToString() == "")
                MessageBox.Show("单品数目不能为空！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (itemname1 != "" && category1 != ""&&amount1>0&&itemprice1>0)
            {
                DialogResult result = MessageBox.Show("确认要添加吗？", "确认信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        string MyInsert = string.Format(" insert fooditem  values('{0}','{1}',{2},{3})", itemname1, category1, itemprice1, amount1);                 
                        SqlCommand comm = new SqlCommand(MyInsert, conn);
                        conn.Open();
                        int n1 = comm.ExecuteNonQuery();                 
                        if (n1 > 0 )
                        {
                            GetDataGridView();
                            MessageBox.Show("添加成功！", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("该单品已存在，不能重复添加！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("删除确认", "确定删除？", MessageBoxButtons.OKCancel);
            string itemname1 = Convert.ToString(textBox1.Text.Trim());
            if (result == DialogResult.OK)
            {
                string sql2 = string.Format("delete from fooditem  where itemname='{0}'",itemname1);
                            
                try
                {
                    SqlCommand comm = new SqlCommand(sql2, conn);
                    conn.Open();                
                    int n = comm.ExecuteNonQuery();
                    if (n > 0)
                    {
                        MessageBox.Show("操作完成", "删除成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetDataGridView();

                    }
               }
                catch (Exception ex)
                {
                    MessageBox.Show("套餐中有该单品，不能删除！", "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

      

        

     
      

      

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
    public partial class 套餐管理 : Form
    {
        String connString = "Data Source=.;Initial Catalog=restaurant;Integrated Security=True";
        SqlConnection conn;
        DataSet ds;
        SqlDataAdapter da;
        string taocanname;
        string itemname1;
        string itemname2;
        string itemname3;
        string itemname4;
        double  taocanprice;
        public 套餐管理()
        {
            InitializeComponent();
            finelize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            taocanname = textBox1.Text.Trim();
            itemname1 = comboBox1.Text;
            itemname2 = comboBox2.Text;
            itemname4 = comboBox3.Text;
            itemname3 = comboBox4.Text;
            taocanprice = Convert.ToDouble(textBox2.Text);
            conn = new SqlConnection(connString);
            conn.Open();           
            if(textBox2.Text != "")
            {
                string sql6 = string.Format("insert  taocan values('{0}','{1}','{2}','{3}','{4}',{5})", taocanname, itemname1, itemname2, itemname3, itemname4, taocanprice);
                DialogResult result = MessageBox.Show("确认要添加吗？", "确认信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        SqlCommand comm = new SqlCommand(sql6, conn);
                        int n1 = comm.ExecuteNonQuery();
                        if (n1 > 0)
                        {
                            MessageBox.Show("添加成功！", "操作成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetDataGridView();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("套餐已存在，不能重复添加！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
          
            taocanname = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("确定删除？", "删除确定", MessageBoxButtons.OKCancel);
            string deleStr = string.Format("delete  from  taocan where taocanname='{0}'", taocanname);
            if (result == DialogResult.OK)
            {

                try
                {
                    conn.Open();
                  
                    SqlCommand comm = new SqlCommand(deleStr, conn);

                 
                    int n = comm.ExecuteNonQuery();

                    if ( n > 0)
                    {
                        MessageBox.Show("操作完成", "删除成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetDataGridView();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("删除失败", "该收支类别有收支项目信息，不能删除", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    GetDataGridView();
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void GetDataGridView()
        {
           
            conn = new SqlConnection(connString);
            string sql = "select  taocanname as 套餐名,  itemname1 as 荤菜 ,itemname2  as 素菜 ,itemname3  as 面食, itemname4  as 汤粥 ,taocanprice as 价格  from taocan";
            da = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count> 0)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                comboBox2.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBox3.Text=dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboBox4.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            conn.Open();
            DialogResult result = MessageBox.Show("确定要修改吗？", "修改提醒", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string oldtaocanname = textBox1.Text.Trim();
                string sql = string.Format("update taocan set  itemname1='{0}',itemname2='{1}',itemname3='{2}',itemname4='{3}',taocanprice={4} from taocan where taocanname='{5}'",comboBox1.Text,comboBox2.Text,comboBox3.Text,comboBox4.Text,textBox2.Text.Trim(), textBox1.Text.Trim());
                SqlCommand comm = new SqlCommand(sql, conn);
                int num = comm.ExecuteNonQuery();
                if (num > 0)
                {
                    GetDataGridView();
                    MessageBox.Show("修改成功！", "操作完成", MessageBoxButtons.OK);

                }
                conn.Close();
            }
            else
            {
                GetDataGridView();
                conn.Close();
            }
        }
        private  void finelize()
        {
            conn = new SqlConnection(connString);
            conn.Open();
            DataSet ds1 = new DataSet();
            string sql1 = string.Format("select itemname  from fooditem where category = '面食'");
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
            da1.Fill(ds1);
            comboBox3.DataSource = ds1.Tables[0];
            comboBox3.DisplayMember = "itemname";

            DataSet ds2 = new DataSet();
            string sql2 = string.Format("select itemname  from fooditem where category = '荤菜'");
            SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
            da2.Fill(ds2);
            comboBox1.DataSource = ds2.Tables[0];
            comboBox1.DisplayMember = "itemname";

            DataSet ds3 = new DataSet();
            string sql3 = string.Format("select itemname  from fooditem where category = '素菜'");
            SqlDataAdapter da3 = new SqlDataAdapter(sql3, conn);
            da3.Fill(ds3);
            comboBox2.DataSource = ds3.Tables[0];
            comboBox2.DisplayMember = "itemname";

            DataSet ds4 = new DataSet();
            string sql4 = string.Format("select itemname  from fooditem where category = '汤粥'");
            SqlDataAdapter da4 = new SqlDataAdapter(sql4, conn);
            da4.Fill(ds4);
            comboBox4.DataSource = ds4.Tables[0];
            comboBox4.DisplayMember = "itemname";
            conn.Close();

          
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            GetDataGridView();
            //Image.FromFile(Application.StartupPath + @"\picture\3.jpg");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zongjia = string.Format("select sum(itemprice)*0.9 as zongjia from fooditem  where itemname in ('{0}', '{1}', '{2}','{3}') ", comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text);
            SqlDataAdapter da5 = new SqlDataAdapter(zongjia, conn);
            DataSet ds5 = new DataSet();
            da5.Fill(ds5);
            textBox2.Text = Convert.ToString(ds5.Tables[0].Rows[0][0]);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zongjia = string.Format("select sum(itemprice)*0.9 as zongjia from fooditem  where itemname in ('{0}', '{1}', '{2}','{3}') ", comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text);
            SqlDataAdapter da5 = new SqlDataAdapter(zongjia, conn);
            DataSet ds5 = new DataSet();
            da5.Fill(ds5);
            textBox2.Text = Convert.ToString(ds5.Tables[0].Rows[0][0]);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zongjia = string.Format("select sum(itemprice)*0.9 as zongjia from fooditem  where itemname in ('{0}', '{1}', '{2}','{3}') ", comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text);

            SqlDataAdapter da5 = new SqlDataAdapter(zongjia, conn);
            DataSet ds5 = new DataSet();
            da5.Fill(ds5);
            textBox2.Text = Convert.ToString(ds5.Tables[0].Rows[0][0]);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zongjia = string.Format("select sum(itemprice)*0.9 as zongjia from fooditem  where itemname in ('{0}', '{1}', '{2}','{3}') ", comboBox1.Text, comboBox2.Text, comboBox3.Text, comboBox4.Text);
            SqlDataAdapter da5 = new SqlDataAdapter(zongjia, conn);
            DataSet ds5 = new DataSet();
            da5.Fill(ds5);
            textBox2.Text = Convert.ToString(ds5.Tables[0].Rows[0][0]);
        }
    }
}

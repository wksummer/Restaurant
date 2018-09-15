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
    public partial class 统计查询 : Form
    {
        String connString = "Data Source=.;Initial Catalog=restaurant;Integrated Security=True";
        SqlConnection conn; 
        DataSet ds;
        public 统计查询()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql1 = string.Format("select  fooditem.itemname as 单品名 ,zongshu 总数 from fooditem, (select sum(saleamount) as zongshu, itemname  from foodlist Where DateDiff(dd, tradedate, '{0}') = 0 group by itemname) as tongji where tongji.itemname = fooditem.itemname and fooditem.category = '面食'order by zongshu desc ", dateTimePicker1.Value);
                SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                textBox1.Text = Convert.ToString(ds1.Tables[0].Rows[0][0]);

                string sql2 = string.Format("select  fooditem.itemname as 单品名 ,zongshu 总数 from fooditem, (select sum(saleamount) as zongshu, itemname  from foodlist Where DateDiff(dd, tradedate, '{0}') = 0 group by itemname) as tongji where tongji.itemname = fooditem.itemname and fooditem.category = '荤菜' order by zongshu desc", dateTimePicker1.Value);
                SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                textBox4.Text = Convert.ToString(ds2.Tables[0].Rows[0][0]);

                string sql3 = string.Format("select  fooditem.itemname as 单品名 ,zongshu 总数 from fooditem, (select sum(saleamount) as zongshu, itemname  from foodlist Where DateDiff(dd, tradedate, '{0}') = 0 group by itemname) as tongji where tongji.itemname = fooditem.itemname and fooditem.category = '素菜' order by zongshu desc ", dateTimePicker1.Value);
                SqlDataAdapter da3 = new SqlDataAdapter(sql3, conn);
                DataSet ds3 = new DataSet();
                da3.Fill(ds3);
                textBox3.Text = Convert.ToString(ds3.Tables[0].Rows[0][0]);
                string sql4 = string.Format("select  fooditem.itemname as 单品名 ,zongshu 总数 from fooditem, (select sum(saleamount) as zongshu, itemname  from foodlist Where DateDiff(dd, tradedate, '{0}') = 0 group by itemname) as tongji where tongji.itemname = fooditem.itemname and fooditem.category = '汤粥' order by zongshu desc ", dateTimePicker1.Value);
                SqlDataAdapter da4 = new SqlDataAdapter(sql4, conn);
                DataSet ds4 = new DataSet();
                da4.Fill(ds4);
                textBox2.Text = Convert.ToString(ds4.Tables[0].Rows[0][0]);
               string sql = string.Format("select itemname as 单品名,sum(saleamount) as 总销售量 from foodlist where DateDiff(dd,tradedate,'{0}')=0 group by itemname", dateTimePicker1.Value);
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
             MessageBox.Show("销售信息不全", "无法统计", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            finally
            {
               conn.Close();
            }


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string sql = string.Format("select itemname as 单品名 ,saleamount as 销售数量,tradedate as 消费时间  from foodlist  where DateDiff(dd, tradedate, '{0}')=0 ", dateTimePicker1.Value);
            conn = new SqlConnection(connString);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connString);
                string sql1 = string.Format("select  fooditem.itemname as 单品名 ,zongshu 总数 from fooditem, (select sum(saleamount) as zongshu, itemname  from foodlist Where DateDiff(wk, tradedate, '{0}') = 0 group by itemname) as tongji where tongji.itemname = fooditem.itemname and fooditem.category = '面食'order by zongshu desc ", dateTimePicker1.Value);
                SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                textBox1.Text = Convert.ToString(ds1.Tables[0].Rows[0][0]);
                string sql2 = string.Format("select  fooditem.itemname as 单品名 ,zongshu 总数 from fooditem, (select sum(saleamount) as zongshu, itemname  from foodlist Where DateDiff(wk, tradedate, '{0}') = 0 group by itemname) as tongji where tongji.itemname = fooditem.itemname and fooditem.category = '荤菜' order by zongshu desc", dateTimePicker1.Value);
                SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                textBox4.Text = Convert.ToString(ds2.Tables[0].Rows[0][0]);
                string sql3 = string.Format("select  fooditem.itemname as 单品名 ,zongshu 总数 from fooditem, (select sum(saleamount) as zongshu, itemname  from foodlist Where DateDiff(wk, tradedate, '{0}') = 0 group by itemname) as tongji where tongji.itemname = fooditem.itemname and fooditem.category = '素菜'order by zongshu desc ", dateTimePicker1.Value);
                SqlDataAdapter da3 = new SqlDataAdapter(sql3, conn);
                DataSet ds3 = new DataSet();
                da3.Fill(ds3);
                textBox3.Text = Convert.ToString(ds3.Tables[0].Rows[0][0]);
                string sql4 = string.Format("select  fooditem.itemname as 单品名 ,zongshu 总数 from fooditem, (select sum(saleamount) as zongshu, itemname  from foodlist Where DateDiff(wk, tradedate, '{0}') = 0 group by itemname) as tongji where tongji.itemname = fooditem.itemname and fooditem.category = '汤粥'order by zongshu desc ", dateTimePicker1.Value);
                SqlDataAdapter da4 = new SqlDataAdapter(sql4, conn);
                DataSet ds4 = new DataSet();
                da4.Fill(ds4);
                textBox2.Text = Convert.ToString(ds4.Tables[0].Rows[0][0]);
                string sql = string.Format("select itemname as 单品名,sum(saleamount) as 总销售量 from foodlist where DateDiff(wk,tradedate,'{0}')=0 group by itemname", dateTimePicker1.Value);
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("销售信息不全", "无法统计", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connString);
                string sql1 = string.Format("select  fooditem.itemname as 单品名 ,zongshu 总数 from fooditem, (select sum(saleamount) as zongshu, itemname  from foodlist Where DateDiff(mm, tradedate, '{0}') = 0 group by itemname) as tongji where tongji.itemname = fooditem.itemname and fooditem.category = '面食'order by zongshu desc ", dateTimePicker1.Value);
                SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                textBox1.Text = Convert.ToString(ds1.Tables[0].Rows[0][0]);
                string sql2 = string.Format("select  fooditem.itemname as 单品名 ,zongshu 总数 from fooditem, (select sum(saleamount) as zongshu, itemname  from foodlist Where DateDiff(mm, tradedate, '{0}') = 0 group by itemname) as tongji where tongji.itemname = fooditem.itemname and fooditem.category = '荤菜' order by zongshu desc", dateTimePicker1.Value);
                SqlDataAdapter da2 = new SqlDataAdapter(sql2, conn);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                textBox4.Text = Convert.ToString(ds2.Tables[0].Rows[0][0]);
                string sql3 = string.Format("select  fooditem.itemname as 单品名 ,zongshu 总数 from fooditem, (select sum(saleamount) as zongshu, itemname  from foodlist Where DateDiff(mm, tradedate, '{0}') = 0 group by itemname) as tongji where tongji.itemname = fooditem.itemname and fooditem.category = '素菜'order by zongshu desc ", dateTimePicker1.Value);
                SqlDataAdapter da3 = new SqlDataAdapter(sql3, conn);
                DataSet ds3 = new DataSet();
                da3.Fill(ds3);
                textBox3.Text = Convert.ToString(ds3.Tables[0].Rows[0][0]);
                string sql4 = string.Format("select  fooditem.itemname as 单品名 ,zongshu 总数 from fooditem, (select sum(saleamount) as zongshu, itemname  from foodlist Where DateDiff(mm, tradedate, '{0}') = 0 group by itemname) as tongji where tongji.itemname = fooditem.itemname and fooditem.category = '汤粥'order by zongshu desc ", dateTimePicker1.Value);
                SqlDataAdapter da4 = new SqlDataAdapter(sql4, conn);
                DataSet ds4 = new DataSet();
                da4.Fill(ds4);
                textBox2.Text = Convert.ToString(ds4.Tables[0].Rows[0][0]);
                string sql = string.Format("select itemname as 单品名,sum(saleamount) as 总销售量 from foodlist where DateDiff(mm,tradedate,'{0}')=0 group by itemname", dateTimePicker1.Value);
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
              MessageBox.Show("销售信息不全", "无法统计", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }

        }

        private void 统计查询_Load(object sender, EventArgs e)
        {

        }
    }
}     

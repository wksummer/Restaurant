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
    public partial class 热销套餐 : Form
    {
        public 热销套餐()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connString = "Data Source=.;Initial Catalog=restaurant;Integrated Security=True";
            SqlConnection conn;
            conn = new SqlConnection(connString);
            DataSet ds;
            try
            {
                string sql = string.Format("select taocanname as 套餐名,sum(saleamount) as 金额 from taocanlist group by taocanname");
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                ds = new DataSet();
                da.Fill(ds);
                dgv.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "统计失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

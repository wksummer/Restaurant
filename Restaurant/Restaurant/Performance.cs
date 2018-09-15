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
    public partial class Performance : Form
    {
        public Performance()
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
                string sql = string.Format("select excel1.username as 员工,price1+price2 as 业绩 from (select username, sum(itemprice) as price1 from foodlist, fooditem group by username) as excel1,(select username, sum(taocanprice) as price2 from taocanlist, taocan group by username) as excel2 order by price1 + price2; ");
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

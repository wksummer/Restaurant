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
    public partial class MainForm : Form
    {
        String connString = "Data Source=;Initial Catalog=restaurant;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader dr;
        decimal sum = 0;


        class Food
        {
            public string Name;
            public decimal Price;
            public int Amount;
            public Food(string name,decimal price,int amount)
            {
                Name = name;
                Price = price;
                Amount = amount;
            }
            public override string ToString()
            {
                return Name;
            }
        }
        class Taocan
        {
            public string Name;
            public string Name1;
            public string Name2;
            public string Name3;
            public string Name4;
            public decimal Price;
            public int Amount;
            public Taocan( string name, string name1, string name2, string name3, string name4, decimal price, int amount)
            {
                Name = name;
                Name1 = name1;
                Name2 = name2;
                Name3 = name3;
                Name4 = name4;
                Price = price;
                Amount = amount;
            }
            public override string ToString()
            {
                return Name;
            }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            comm = new SqlCommand();
            comm.Connection = conn;
            cboCato.Items.Add("荤菜");
            cboCato.Items.Add("素菜");
            cboCato.Items.Add("面食");
            cboCato.Items.Add("汤粥");
            cboCato.Items.Add("套餐");
            cboCato.SelectedIndex = 0;
            this.FormClosing += new FormClosingEventHandler(this.MainForm_FormClosing);
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("订单将会被取消！\n你确定要关闭吗？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                int i;
                string sqlfood = "";
                for (i = 0; i < listOrder.Items.Count; i++)
                {
                    if (listOrder.Items[i] is Food)
                    {
                        Food f = listOrder.Items[i] as Food;
                        listOrder.Items.Remove(listOrder.SelectedItem);
                        sqlfood += string.Format("update fooditem set amount = amount + 1 where itemname = '{0}';", f.Name);
                    }
                    else
                    {
                        Taocan t = listOrder.Items[i] as Taocan;
                        listOrder.Items.Remove(listOrder.SelectedItem);
                        sqlfood += string.Format("update fooditem set amount = amount + 1 where " +
                                "itemname = '{0}' or itemname = '{1}' or itemname = '{2}' or itemname = '{3}';", t.Name1, t.Name2, t.Name3, t.Name4);
                    }
                    if (!sqlfood.Equals(""))
                    {
                        try
                        {
                            conn.Open();
                            comm.CommandText = sqlfood;
                            comm.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
                e.Cancel = false;  //点击OK   
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void cboCato_SelectedIndexChanged(object sender, EventArgs e)
        {
            listItem.Items.Clear();
            string sql1;
            if (cboCato.SelectedItem.ToString()!="套餐")
            {
                sql1 = String.Format("select * from fooditem where category='{0}';", cboCato.Text);
                try
                {
                    conn.Open();
                    comm.CommandText = sql1;
                    dr = comm.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            string name = dr["itemname"].ToString().Trim();
                            decimal price = (decimal)dr["itemprice"];
                            int amount = (int)dr["amount"];
                            listItem.Items.Add(new Food(name, price, amount));
                        }
                    }
                    else
                    {
                        MessageBox.Show("该菜种内无菜品信息，请先添加！", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    dr.Close();
                    conn.Close();
                }
            }
            else //套餐
            {
                sql1 = String.Format("select taocanname,itemname1,itemname2,itemname3,itemname4,taocanprice,min(amount) as amount " +
                    "from taocan, fooditem where itemname = itemname1 or itemname = itemname2 or itemname = itemname3 " +
                    "or itemname = itemname4 group by taocanname, itemname1, itemname2, itemname3, itemname4,taocanprice; ");
                try
                {
                    conn.Open();
                    comm.CommandText = sql1;
                    dr = comm.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            string name = dr["taocanname"].ToString().Trim();
                            string name1 = dr["itemname1"].ToString().Trim();
                            string name2 = dr["itemname2"].ToString().Trim();
                            string name3 = dr["itemname3"].ToString().Trim();
                            string name4 = dr["itemname4"].ToString().Trim();
                            decimal price = (decimal)dr["taocanprice"];
                            int amount = (int)dr["amount"];
                            listItem.Items.Add(new Taocan(name, name1, name2, name3, name4, price, amount));
                        }
                    }
                    else
                    {
                        MessageBox.Show("该菜种内无菜品信息，请先添加！", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    dr.Close();
                    conn.Close();
                }

            }
            listItem.SelectedIndex = 0;
        }

        private void listItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listItem.SelectedItem is Food)
            {
                Food f = listItem.SelectedItem as Food;
                string name = f.Name;
                txtDanjia.Text = f.Price.ToString();
                txtTaocan.Text = "";
                picture.Image = Image.FromFile(Environment.CurrentDirectory.ToString()+"\\"+name+".PNG");
            }
            else
            {
                Taocan t = listItem.SelectedItem as Taocan;
                txtDanjia.Text = t.Price.ToString();
                txtTaocan.Text = t.Name1 + "\n" + t.Name2 + "\n" + t.Name3 + "\n" + t.Name4;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sqlfood = "";
            
            if (listItem.SelectedItem is Food)
            {
                Food f = listItem.SelectedItem as Food;
                if (f.Amount > 0)
                {
                    listOrder.Items.Add(f);
                    f.Amount -= 1;
                    sqlfood += string.Format("update fooditem set amount = amount - 1 where itemname = '{0}';", f.Name);
                    sum += f.Price;
                    txtSum.Text = sum.ToString();
                }
                else
                {
                    MessageBox.Show("该菜品已售罄！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                Taocan t = listItem.SelectedItem as Taocan;
                if (t.Amount > 0)
                {
                    listOrder.Items.Add(t);
                    t.Amount -= 1;
                    sqlfood += string.Format("update fooditem set amount = amount - 1 where " +
                            "itemname = '{0}' or itemname = '{1}' or itemname = '{2}' or itemname = '{3}';", t.Name1, t.Name2, t.Name3, t.Name4);
                    sum += t.Price;
                    txtSum.Text = sum.ToString();
                }
                else
                {
                    MessageBox.Show("该菜品已售罄！", "添加失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if(!sqlfood.Equals(""))
            {
                try
                {
                    conn.Open();
                    comm.CommandText = sqlfood;
                    comm.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            string sqlfood = "";
            if(listOrder.SelectedIndex == -1)
            {
                MessageBox.Show("未选择可取消的菜品！", "取消失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (listOrder.SelectedItem is Food)
                {
                    Food f = listOrder.SelectedItem as Food;
                    listOrder.Items.Remove(listOrder.SelectedItem);
                    f.Amount += 1;
                    sqlfood += string.Format("update fooditem set amount = amount + 1 where itemname = '{0}';", f.Name);
                    sum -= f.Price;
                    txtSum.Text = sum.ToString();
                }
                else
                {
                    Taocan t = listItem.SelectedItem as Taocan;
                    listOrder.Items.Remove(listOrder.SelectedItem);
                    t.Amount += 1;
                    sqlfood += string.Format("update fooditem set amount = amount + 1 where " +
                            "itemname = '{0}' or itemname = '{1}' or itemname = '{2}' or itemname = '{3}';", t.Name1, t.Name2, t.Name3, t.Name4);
                    sum -= t.Price;
                    txtSum.Text = sum.ToString();
                }
                if (!sqlfood.Equals(""))
                {
                    try
                    {
                        conn.Open();
                        comm.CommandText = sqlfood;
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result=MessageBox.Show("请顾客确认菜单！\n总共是" + sum + "元，确认下单吗？", "确认菜单", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            string user = Login.userName;
            if(result==DialogResult.Cancel)
            {
                return;
            }
            else
            {
                string sqllist="";
                int i;
                for(i=0;i<listOrder.Items.Count;i++)
                {
                    if(listOrder.Items[i] is Food)
                    {
                        Food f = listOrder.Items[i] as Food;
                        
                        sqllist += string.Format("insert into foodlist values('{0}', GETDATE(), 1, '{1}'); ", f.Name, user);
                    }
                    else
                    {
                        Taocan t = listOrder.Items[i] as Taocan;
                        
                        sqllist += string.Format("insert into taocanlist values('{0}', GETDATE(), 1, '{1}'); ",t.Name,user);
                        sqllist += string.Format("insert into foodlist values('{0}', GETDATE(), 1, '{1}'); ",t.Name1,user);
                        sqllist += string.Format("insert into foodlist values('{0}', GETDATE(), 1, '{1}'); ", t.Name2, user);
                        sqllist += string.Format("insert into foodlist values('{0}', GETDATE(), 1, '{1}'); ", t.Name3, user);
                        sqllist += string.Format("insert into foodlist values('{0}', GETDATE(), 1, '{1}'); ", t.Name4, user);
                    }
                }
                try
                {
                    conn.Open();
                    comm.CommandText = sqllist;
                    comm.ExecuteNonQuery();
                    MessageBox.Show("已成功下单！\n顾客可回座等待上菜！","下单成功",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作数据库出错", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    listOrder.Items.Clear();
                    conn.Close();
                }
            }
        }
    }
}

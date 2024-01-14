using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MENU_MASTER_RESTAURENT
{
    public partial class Beverages : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CHO3R9O\SQLEXPRESS; Initial Catalog=Menumaster; Integrated Security=True");
        SqlCommand scmd;
        SqlDataReader read;


        public Beverages()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DashBoard01 DB = new DashBoard01();
            DB.Show();
            this.Close();
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            OrderAndMenu OAM = new OrderAndMenu();
            OAM.Show();
            this.Close();
        }

        
       

        private void button6_Click_1(object sender, EventArgs e)
        {
            PaymentBillAndCart PBAC = new PaymentBillAndCart();
            PBAC.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Food F = new Food();
            F.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ShortEats SE = new ShortEats();
            SE.Show();
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Dessert D = new Dessert();
            D.Show();
            this.Close();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            OrderAndMenu OAM = new OrderAndMenu();
            OAM.Show();
            this.Close();
        }

        //Database Part

        private void button19_Click(object sender, EventArgs e)
        {
            string dcode = textBox1.Text;
            string dname = textBox2.Text;
            int qty = int.Parse(textBox3.Text);
            decimal dprice = decimal.Parse(textBox4.Text);

            decimal tot = dprice * qty;

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Order_Menu03 values('" + dcode + "','" + dname + "','" + qty + "','" + dprice + "','" + tot + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            this.dataGridView1.Rows.Add(dcode, dname, qty, dprice, tot);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }


        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Order_Menu03";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }

        private void button20_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Order_Menu03 ";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("record deleted successully!");
            dataGridView1.Rows.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            PaymentBillAndCart PBAC = new PaymentBillAndCart();
            PBAC.Show();
            this.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[4].Value);
            }

            label16.Text = sum.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                scmd = new SqlCommand("select * from Order_Menu where PID='" + textBox1.Text + "'", con);
                con.Open();
                read = scmd.ExecuteReader();

                if (read.Read())
                {
                    string pname;
                    string qty;
                    string price;

                    pname = read["ProductName"].ToString();
                    qty = read["Qty"].ToString();
                    price = read["Price(Rs)"].ToString();

                    textBox2.Text = pname;
                    textBox3.Text = qty;
                    textBox4.Text = price;

                    con.Close();


                }
                else
                {
                    MessageBox.Show("No Data Found");
                }

            }
        }

    }
}

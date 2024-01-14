using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;

namespace MENU_MASTER_RESTAURENT
{
    public partial class PaymentBillAndCart : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CHO3R9O\SQLEXPRESS; Initial Catalog=Menumaster; Integrated Security=True");
        
        SqlDataReader read;


        public PaymentBillAndCart()
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

        private void button12_Click(object sender, EventArgs e)
        {
            OrderAndMenu OAM = new OrderAndMenu();
            OAM.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Food F = new Food();
            F.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShortEats SE = new ShortEats();
            SE.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dessert D = new Dessert();
            D.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Beverages B = new Beverages();
            B.Show();
            this.Close();
        }


        //Database part



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
            dataGridView2.DataSource = dt;
            con.Close();

        }


        private void button9_Click(object sender, EventArgs e)
        {
            disp_data();
        }


        private void button20_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Order_Menu03 where PID= '" + textBox1.Text + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("record deleted successully!");
        }


        private void button19_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int row = 0; row < dataGridView2.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dataGridView2.Rows[row].Cells[4].Value);
            }

            label2.Text = sum.ToString();
        }

     

        
        private void button11_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Order_Menu03 ";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("record deleted successully!");
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("date : {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total payable Amount : " + label2.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("date : {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total payable Amount : " + label2.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView2);
        }



    }
}


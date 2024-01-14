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
    public partial class KitchenBill : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CHO3R9O\SQLEXPRESS; Initial Catalog=Menumaster; Integrated Security=True");

        public KitchenBill()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT PID,ProductName,Qty FROM Order_Menu where OrderID='"+ textBox1.Text +"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }

        private void button22_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Kitchen Order Receipt";
            printer.SubTitle = string.Format("date : {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total payable Amount : " + label2.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            KitchenOrder PBAC = new KitchenOrder();
            PBAC.Show();
            this.Close();
        }

    }
}

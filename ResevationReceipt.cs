using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DGVPrinterHelper;
using System.Data.SqlClient;


namespace MENU_MASTER_RESTAURENT
{
    public partial class ResevationReceipt : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CHO3R9O\SQLEXPRESS; Initial Catalog=Menumaster; Integrated Security=True");


        public ResevationReceipt()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DashBoard01 DB = new DashBoard01();
            DB.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableReservation TR = new TableReservation();
            TR.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TableReservation TR = new TableReservation();
            TR.Show();
            this.Close();
        }


        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM TableReservation01";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();

        }


        private void button16_Click(object sender, EventArgs e)
        {
            disp_data();
        }


        private void button21_Click(object sender, EventArgs e)
        {
            int count = 0;

            if (dataGridView2.DataSource != null)
            {
                count = ((DataTable)dataGridView2.DataSource).Rows.Count;
            }
            else
            {
                count = dataGridView2.RowCount;
            }

            label16.Text = count.ToString();
        }




        private void button22_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Table Resevation Receipt";
            printer.SubTitle = string.Format("date : {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total payable Amount : " + label16.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView2);
        }

       


    }
}
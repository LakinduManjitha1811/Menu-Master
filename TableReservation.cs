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
    public partial class TableReservation : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CHO3R9O\SQLEXPRESS; Initial Catalog=Menumaster; Integrated Security=True");

        public TableReservation()
        {
            InitializeComponent();
        }



        internal static void showDialog()
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DashBoard01 Db = new DashBoard01();
            Db.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            ResevationReceipt RR = new ResevationReceipt();
            RR.Show();
            this.Close();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            DashBoard01 Db = new DashBoard01();
            Db.Show();
            this.Close();
            
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into TableReservation01 values('" + checkedListBox1.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            checkedListBox1.Text = "";
            comboBox1.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";

            
            
            disp_data();
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

        private void button15_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from TableReservation01 where [Table No]= '" + textBox1.Text + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("One of table detail deleted successully!");
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
            ResevationReceipt Db = new ResevationReceipt();
            Db.Show();
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
       

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MENU_MASTER_RESTAURENT;

namespace MENU_MASTER_RESTAURENT
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CHO3R9O\SQLEXPRESS;Initial Catalog=Menumaster;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into menutable values('" + comboBox1.Text + "', '" + textBox1.Text + "' ,'" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            disp_data();

            MessageBox.Show("record inserted successfully");
        }

        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select*from menutable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE from menutable where Name='" + comboBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();

            MessageBox.Show("record deleted successfully! ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select*from menutable where name='"+comboBox1.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            MenuManagement OAM = new MenuManagement();
            OAM.Show();
            this.Close();
        }

        

       
    }
}


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
using System.Windows;

namespace MENU_MASTER_RESTAURENT
{
    public partial class Registerform : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CHO3R9O\SQLEXPRESS;Initial Catalog=Menumaster;Integrated Security=True");
        static SqlCommand scmd;
        public Registerform()
        {
            InitializeComponent();
        }

        private void Regbtn_Click(object sender, EventArgs e)
        {
            if (!Authenticate())
            {
                MessageBox.Show("Do not keep any textbox blank!");
                return;

            }
            string query = "INSERT INTO Yusers1 VALUES(@USER,@PASS,@NAME,@EMAIL,@TELEPHONE)";
            con.Open();
            scmd = new SqlCommand(query,con);

            //adding parameters
            scmd.Parameters.Add("@USER", SqlDbType.VarChar);
            scmd.Parameters["@USER"].Value = userbox.Text;

            scmd.Parameters.Add("@PASS", SqlDbType.VarChar);
            scmd.Parameters["@PASS"].Value = passbox.Text;

            scmd.Parameters.Add("@NAME", SqlDbType.VarChar);
            scmd.Parameters["@NAME"].Value = nametBox.Text;

            scmd.Parameters.Add("@EMAIL", SqlDbType.VarChar);
            scmd.Parameters["@EMAIL"].Value = emailbox.Text;

            scmd.Parameters.Add("@TELEPHONE", SqlDbType.VarChar);
            scmd.Parameters["@TELEPHONE"].Value = telephoneBox2.Text;

            scmd.ExecuteNonQuery();
            con.Close();
        }
        bool Authenticate()
        {
            if (string.IsNullOrWhiteSpace(userbox.Text)||
                string.IsNullOrWhiteSpace(passbox.Text)||
                string.IsNullOrWhiteSpace(nametBox.Text)
                )
                return false;
           else return true;
        }

        private void passbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                this.Hide();
                Loginform reg = new Loginform();
                reg.ShowDialog();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

     
    
               
            }
            
            
    }


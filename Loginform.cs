using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows;
using MENU_MASTER_RESTAURENT;

namespace MENU_MASTER_RESTAURENT
{

    public partial class Loginform : Form
    {
        public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CHO3R9O\SQLEXPRESS; Initial Catalog=Menumaster; Integrated Security=True");
        static SqlCommand scmd;
        public Loginform()
        {
            InitializeComponent();
        }

        private void Regbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registerform reg = new Registerform();
            reg.ShowDialog();
        }

        private void Logbtn_Click(object sender, EventArgs e)
        {
            bool isUserok = false, ispassok = false;
            if (!Authenticate())
            {
                MessageBox.Show("Do not keep any textbox blank!");
                return;
            }



            string query = "SELECT*FROM Yusers1 WHERE username=@USER";
            con.Open();
            scmd = new SqlCommand(query, con);

            //adding parameters
            scmd.Parameters.Add("@USER", SqlDbType.VarChar);
            scmd.Parameters["@USER"].Value = userbox.Text;

            SqlDataReader sda = scmd.ExecuteReader();

            if (sda.HasRows)
            {
                isUserok = true;
            }
            con.Close();

            con.Open();
            query = "SELECT*FROM Yusers1 WHERE username=@USER AND passcode=@PASS";
            scmd = new SqlCommand(query, con);

            //adding parameters
            scmd.Parameters.Add("@USER", SqlDbType.VarChar);
            scmd.Parameters["@USER"].Value = userbox.Text;

            scmd.Parameters.Add("@PASS", SqlDbType.VarChar);
            scmd.Parameters["@PASS"].Value = passbox.Text;

            sda = scmd.ExecuteReader();

            if (sda.HasRows)
            {
                ispassok = true;
            }

            if (isUserok == false)
            {
                MessageBox.Show("user does not exist!");
            }
            else if (isUserok == true && ispassok == false)
            {
                MessageBox.Show("wrong password!");
            }
            else
            {
                this.Hide();
                DashBoard01 app = new DashBoard01();
                app.ShowDialog();
                Close();
            }
            con.Close();



        }
        bool Authenticate()
        {
            if (string.IsNullOrWhiteSpace(userbox.Text) ||
                string.IsNullOrWhiteSpace(passbox.Text) 
                )
                return false;
            else return true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MENU_MASTER_RESTAURENT;

namespace MENU_MASTER_RESTAURENT
{
    public partial class DashBoard01 : Form
    {
        public DashBoard01()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            MenuManagement MM = new MenuManagement();
            MM.Show();
            this.Close();
        }

        private void DashBoard01_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            TableReservation Tb = new TableReservation();
            Tb.Show();
            this.Close();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            OrderAndMenu OM = new OrderAndMenu();
            OM.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            KitchenOrder KO = new KitchenOrder();
            KO.Show();
            this.Close();
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            Loginform Lf = new Loginform();
            Lf.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            TableReservation Tb = new TableReservation();
            Tb.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            OrderAndMenu OM = new OrderAndMenu();
            OM.Show();
            this.Close();
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            KitchenOrder KO = new KitchenOrder();
            KO.Show();
            this.Close();
        
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            MenuManagement MM = new MenuManagement();
            MM.Show();
            this.Close();
        }

       
    }
}

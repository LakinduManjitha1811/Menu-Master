using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MENU_MASTER_RESTAURENT
{
    public partial class MenuManagement : Form
    {
        public MenuManagement()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DashBoard01 DB = new DashBoard01();
            DB.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DashBoard01 DB = new DashBoard01();
            DB.Show();
            this.Close();
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

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 KO = new Form3();
            KO.Show();
            this.Close();
        }


    }
}

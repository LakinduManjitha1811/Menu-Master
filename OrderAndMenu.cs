using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MENU_MASTER_RESTAURENT
{
    public partial class OrderAndMenu : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );

        public OrderAndMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button8.Region = Region.FromHrgn(CreateRoundRectRgn(-3, 10, 120, 134,127, 127));
            button9.Region = Region.FromHrgn(CreateRoundRectRgn(-3, 10, 120, 134, 127, 127));
            button10.Region = Region.FromHrgn(CreateRoundRectRgn(-3, 10, 120, 134, 127, 127));
            button11.Region = Region.FromHrgn(CreateRoundRectRgn(-3, 10, 120, 134, 127, 127));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Food F = new Food();
            F.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShortEats DB = new ShortEats();
            DB.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DashBoard01 DB = new DashBoard01();
            DB.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Food F = new Food();
            F.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DashBoard01 DB = new DashBoard01();
            DB.Show();
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

        private void button10_Click(object sender, EventArgs e)
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

        private void button11_Click(object sender, EventArgs e)
        {
            Beverages B = new Beverages();
            B.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PaymentBillAndCart PBAC = new PaymentBillAndCart();
            PBAC.Show();
            this.Close();
        }

       
    }
}

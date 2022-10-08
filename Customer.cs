using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaDesk
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile profile= new Profile();
            profile.Show();
            this.Hide();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            CustomerOrder c_order = new CustomerOrder();
            c_order.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Checkout  checkout = new Checkout();
            checkout.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login loginBack = new Login();
            loginBack.Show();
            this.Hide();
        }
    }
}

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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile adminprofile = new Profile();
            adminprofile.Show();
            this.Hide();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            EmpList emplist = new EmpList();
            emplist.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerList customerlist = new CustomerList();
            customerlist.Show();
            this.Hide();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderList orderlist = new OrderList();
            orderlist.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login= new Login();
            login.Show();
            this.Hide();
        }
    }
}

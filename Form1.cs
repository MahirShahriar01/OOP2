using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaDesk
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) == true)
            {
                txtUserName.Focus();
                ///errorProvider2.SetError(this.txtUserName, "invalid email");
                MessageBox.Show("invalid email");
            }
            else if (string.IsNullOrEmpty(txtPassword.Text) == true)
            {
                txtPassword.Focus();
               ///errorProvider2.SetError(this.txtPass, "invalid email");
                MessageBox.Show("field cannot  be empty");
            }
            else
            {


                SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmadesk"].ConnectionString);
                string query = "Select * from [tbl_users] where userName = '" + txtUserName.Text.Trim() + "' and " +
                    "password = '" + txtPassword.Text.Trim() + "'";
                // MessageBox.Show(query);
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {
                    //MessageBox.Show("Username or Password Correct");
                    LoginInfo.UserID = dtbl.Rows[0]["userID"].ToString();
                    switch (dtbl.Rows[0]["role_id"].ToString())
                    {
                        case "1":
                            // admin
                            Admin admin= new Admin();
                            admin.Show();
                            this.Hide();
                            break;
                        case "2":
                            // Employee
                            Employee employee = new Employee();
                            employee.Show();
                            this.Hide();
                            break;
                        case "3":
                            // Customer
                            Customer customer = new Customer();
                            customer.Show();
                            this.Hide();
                            break;
                    }
                    
                }

                else
                {
                    MessageBox.Show("Username or Password incorrect");
                }

            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}

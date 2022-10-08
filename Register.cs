using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaDesk
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmadesk"].ConnectionString))
            {
                connection.Open();
                string sql = "INSERT INTO tbl_users(first_name,last_name,email,phone,address,userName) VALUES(@param1,@param2,@param3,@param4,@param5,@param6)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = txtFirstName.Text;
                    cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = txtLastName.Text;
                    cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = txtEmail.Text;
                    cmd.Parameters.Add("@param4", SqlDbType.VarChar, 50).Value = txtUserName.Text;
                    cmd.Parameters.Add("@param5", SqlDbType.VarChar, 50).Value = txtPhone.Text;
                    cmd.Parameters.Add("@param6", SqlDbType.VarChar, 50).Value = txtAddress.Text;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    
                }
            }
            MessageBox.Show("Welcome");
            
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}

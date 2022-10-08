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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();

        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmadesk"].ConnectionString);
            string query = "Select * from [tbl_users] where userID = " + LoginInfo.UserID  ;
            // MessageBox.Show(query);
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            txtFirstName.Text = dtbl.Rows[0]["first_name"].ToString();
            txtLastName.Text = dtbl.Rows[0]["last_name"].ToString();
            txtPhone.Text = dtbl.Rows[0]["phone"].ToString();
            txtAddress.Text = dtbl.Rows[0]["address"].ToString();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login loginBack = new Login();
            loginBack.Show();
            this.Hide();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmadesk"].ConnectionString))
            {
                connection.Open();
                string sql = "UPDATE tbl_users set first_name=@param1,last_name=@param2,phone=@param3,address=@param4 where userID = " + LoginInfo.UserID;
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = txtFirstName.Text;
                    cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = txtLastName.Text;
                    //cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = txtEmail.Text;
                   // cmd.Parameters.Add("@param4", SqlDbType.VarChar, 50).Value = txtUserName.Text;
                    cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = txtPhone.Text;
                    cmd.Parameters.Add("@param4", SqlDbType.VarChar, 50).Value = txtAddress.Text;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Account Updated");

        }
    }
}

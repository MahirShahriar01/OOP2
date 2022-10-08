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
    public partial class CustomerList : Form
    {
        DataSet ds = new DataSet();
        

        public CustomerList()
        {
            InitializeComponent();
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'infodataDataSet1.tbl_users' table. You can move, or remove it, as needed.
            this.tbl_usersTableAdapter.Fill(this.infodataDataSet1.tbl_users);
            //this.tbl_usersTableAdapter.Fill(this.infodataDataSet.tbl_users);

            string sql = "SELECT first_name,last_name,email,phone,address FROM tbl_users where role_id=3";
            SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmadesk"].ConnectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, sqlcon);
            sqlcon.Open();
            dataadapter.Fill(ds, "Titles_table");
            sqlcon.Close();

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin adminBack = new Admin();
            adminBack.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

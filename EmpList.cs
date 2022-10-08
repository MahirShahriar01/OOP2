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
    public partial class EmpList : Form
    {
        DataSet ds = new DataSet();
        public EmpList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmpList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'infodataDataSet.tbl_users' table. You can move, or remove it, as needed.
            this.tbl_usersTableAdapter.Fill(this.infodataDataSet.tbl_users);
            
            string sql = "SELECT first_name,last_name,email,phone,address FROM tbl_users where role_id=2";
            SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmadesk"].ConnectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, sqlcon);
            sqlcon.Open();
            dataadapter.Fill(ds, "Titles_table");
            sqlcon.Close();

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_usersTableAdapter.FillBy(this.infodataDataSet.tbl_users);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin adminBack = new Admin();
            adminBack.Show();
            this.Hide();
        }
    }
}

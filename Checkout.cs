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
    public partial class Checkout : Form
    {
        DataSet ds = new DataSet();
        public Checkout()
        {
            InitializeComponent();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'infodataDataSet7.tbl_orders' table. You can move, or remove it, as needed.
            this.tbl_ordersTableAdapter1.Fill(this.infodataDataSet7.tbl_orders);
            // TODO: This line of code loads data into the 'infodataDataSet5.tbl_orders' table. You can move, or remove it, as needed.
            this.tbl_ordersTableAdapter.Fill(this.infodataDataSet5.tbl_orders);
            string sql = "SELECT ordered_by,order_desc,order_date,order_price,order_status FROM tbl_orders ";
            SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmadesk"].ConnectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, sqlcon);
            sqlcon.Open();
            dataadapter.Fill(ds, "Titles_table");
            sqlcon.Close();

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Customer customerBack = new Customer();
            customerBack.Show();
            this.Hide();
        }
    }
}

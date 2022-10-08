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
    public partial class OrderList : Form
    {
        DataSet ds = new DataSet();
        public OrderList()
        {
            InitializeComponent();
        }

        private void OrderList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'infodataDataSet4.tbl_orders' table. You can move, or remove it, as needed.
            this.tbl_ordersTableAdapter1.Fill(this.infodataDataSet4.tbl_orders);
            // TODO: This line of code loads data into the 'infodataDataSet3.tbl_orders' table. You can move, or remove it, as needed.
            
            string sql = "SELECT order_id,order_price,order_quantity FROM tbl_orders ";
            SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmadesk"].ConnectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, sqlcon);
            sqlcon.Open();
            dataadapter.Fill(ds, "Titles_table");
            sqlcon.Close();

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login loginBack = new Login();
           loginBack.Show();
            this.Hide();
        }
    }
}

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
    public partial class Inventory : Form
    {
        DataSet ds = new DataSet();
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'infodataDataSet2.tbl_products' table. You can move, or remove it, as needed.
            this.tbl_productsTableAdapter.Fill(this.infodataDataSet2.tbl_products);
            

            string sql = "SELECT product_name,product_quantity,product_price FROM tbl_products where product_quantity !=0";
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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addproduct = new AddProduct();
            addproduct.Show();
            this.Hide();
        }
    }
}

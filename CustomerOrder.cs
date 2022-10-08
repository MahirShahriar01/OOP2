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
    public partial class CustomerOrder : Form
    {
        DataSet ds = new DataSet();
        string order_description;
        decimal totalPrice;
        public CustomerOrder()
        {
            InitializeComponent();
        }

        private void CustomerOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'infodataDataSet6.tbl_products' table. You can move, or remove it, as needed.
            this.tbl_productsTableAdapter.Fill(this.infodataDataSet6.tbl_products);
            string sql = "SELECT product_name,product_quantity,product_price FROM tbl_products where product_quantity !=0";
            SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmadesk"].ConnectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, sqlcon);
            sqlcon.Open();
            dataadapter.Fill(ds, "Titles_table");
            sqlcon.Close();

            dataGridView1.DataSource = ds.Tables[0];

        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows[0];

            decimal price = Convert.ToDecimal(selectedRow.Cells[2].Value) * quantity.Value;
            string Description = Convert.ToString(selectedRow.Cells[1].Value) + " " + quantity.Value + " " + price;
            quantity.Value = 0;
            order_description += Description + "\n";
            totalPrice += price;
            MessageBox.Show(order_description);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Customer customerBack = new Customer();
            customerBack.Show();
            this.Hide();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmadesk"].ConnectionString))
            {
                connection.Open();
                string sql = "INSERT INTO tbl_orders(ordered_by,order_desc,order_date,order_price,order_status) VALUES(@param1,@param2,@param3,@param4,@param5)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = LoginInfo.UserID;
                    cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = order_description;
                    cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = DateTime.Now.ToString();
                    cmd.Parameters.Add("@param4", SqlDbType.VarChar, 50).Value = totalPrice;
                    cmd.Parameters.Add("@param5", SqlDbType.VarChar, 50).Value = "Pending";
                   // cmd.Parameters.Add("@param6", SqlDbType.VarChar, 50).Value = ;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                }
                MessageBox.Show("checkout successfully");
                Checkout checkout= new Checkout();
                checkout.Show();
                this.Hide();
            }
        }
    }
}

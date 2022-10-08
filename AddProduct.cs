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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["pharmadesk"].ConnectionString))
            {
                connection.Open();
                string sql = "INSERT INTO tbl_products(product_name,product_desc,product_quantity,product_price) VALUES(@param1,@param2,@param3,@param4)";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = txt_ProductName.Text;
                    cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = txt_ProductDesc.Text;
                    cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = txt_ProductQuantity.Text;
                    cmd.Parameters.Add("@param4", SqlDbType.VarChar, 50).Value = txt_ProductPrice.Text;
                    
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Product Created");
        }
    }
}

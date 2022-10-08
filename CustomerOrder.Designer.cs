
namespace PharmaDesk
{
    partial class CustomerOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblproductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infodataDataSet6 = new PharmaDesk.InfodataDataSet6();
            this.tbl_productsTableAdapter = new PharmaDesk.InfodataDataSet6TableAdapters.tbl_productsTableAdapter();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infodataDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.productquantityDataGridViewTextBoxColumn,
            this.productpriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblproductsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(62, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 211);
            this.dataGridView1.TabIndex = 0;
            // 
            // pidDataGridViewTextBoxColumn
            // 
            this.pidDataGridViewTextBoxColumn.DataPropertyName = "pid";
            this.pidDataGridViewTextBoxColumn.HeaderText = "pid";
            this.pidDataGridViewTextBoxColumn.Name = "pidDataGridViewTextBoxColumn";
            this.pidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "product_name";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            // 
            // productquantityDataGridViewTextBoxColumn
            // 
            this.productquantityDataGridViewTextBoxColumn.DataPropertyName = "product_quantity";
            this.productquantityDataGridViewTextBoxColumn.HeaderText = "product_quantity";
            this.productquantityDataGridViewTextBoxColumn.Name = "productquantityDataGridViewTextBoxColumn";
            // 
            // productpriceDataGridViewTextBoxColumn
            // 
            this.productpriceDataGridViewTextBoxColumn.DataPropertyName = "product_price";
            this.productpriceDataGridViewTextBoxColumn.HeaderText = "product_price";
            this.productpriceDataGridViewTextBoxColumn.Name = "productpriceDataGridViewTextBoxColumn";
            // 
            // tblproductsBindingSource
            // 
            this.tblproductsBindingSource.DataMember = "tbl_products";
            this.tblproductsBindingSource.DataSource = this.infodataDataSet6;
            // 
            // infodataDataSet6
            // 
            this.infodataDataSet6.DataSetName = "InfodataDataSet6";
            this.infodataDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_productsTableAdapter
            // 
            this.tbl_productsTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddtoCart.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoCart.Location = new System.Drawing.Point(258, 113);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(100, 23);
            this.btnAddtoCart.TabIndex = 1;
            this.btnAddtoCart.Text = "Add To Cart";
            this.btnAddtoCart.UseVisualStyleBackColor = true;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckout.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(429, 113);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(75, 23);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(429, 401);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "<-BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(62, 113);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(120, 20);
            this.quantity.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Order Informations";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Wide Latin", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(139, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 29);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "PhanrmaDesk";
            // 
            // CustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerOrder";
            this.Text = "CustomerOrder";
            this.Load += new System.EventHandler(this.CustomerOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblproductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infodataDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private InfodataDataSet6 infodataDataSet6;
        private System.Windows.Forms.BindingSource tblproductsBindingSource;
        private InfodataDataSet6TableAdapters.tbl_productsTableAdapter tbl_productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
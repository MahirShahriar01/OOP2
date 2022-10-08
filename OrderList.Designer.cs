
namespace PharmaDesk
{
    partial class OrderList
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
            this.tblordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.infodataDataSet4 = new PharmaDesk.InfodataDataSet4();
            this.tblordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infodataDataSet3 = new PharmaDesk.InfodataDataSet3();
            this.tbl_ordersTableAdapter = new PharmaDesk.InfodataDataSet3TableAdapters.tbl_ordersTableAdapter();
            this.tbl_ordersTableAdapter1 = new PharmaDesk.InfodataDataSet4TableAdapters.tbl_ordersTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infodataDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infodataDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderidDataGridViewTextBoxColumn,
            this.orderpriceDataGridViewTextBoxColumn,
            this.order_quantity});
            this.dataGridView1.DataSource = this.tblordersBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(63, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 155);
            this.dataGridView1.TabIndex = 0;
            // 
            // tblordersBindingSource1
            // 
            this.tblordersBindingSource1.DataMember = "tbl_orders";
            this.tblordersBindingSource1.DataSource = this.infodataDataSet4;
            // 
            // infodataDataSet4
            // 
            this.infodataDataSet4.DataSetName = "InfodataDataSet4";
            this.infodataDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblordersBindingSource
            // 
            this.tblordersBindingSource.DataMember = "tbl_orders";
            this.tblordersBindingSource.DataSource = this.infodataDataSet3;
            // 
            // infodataDataSet3
            // 
            this.infodataDataSet3.DataSetName = "InfodataDataSet3";
            this.infodataDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ordersTableAdapter
            // 
            this.tbl_ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_ordersTableAdapter1
            // 
            this.tbl_ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(324, 349);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 33);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Log Out";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Wide Latin", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(91, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 29);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "PhanrmaDesk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Order Informations";
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "order_id";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "order_id";
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            this.orderidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderpriceDataGridViewTextBoxColumn
            // 
            this.orderpriceDataGridViewTextBoxColumn.DataPropertyName = "order_price";
            this.orderpriceDataGridViewTextBoxColumn.HeaderText = "order_price";
            this.orderpriceDataGridViewTextBoxColumn.Name = "orderpriceDataGridViewTextBoxColumn";
            // 
            // order_quantity
            // 
            this.order_quantity.DataPropertyName = "order_quantity";
            this.order_quantity.HeaderText = "order_quantity";
            this.order_quantity.Name = "order_quantity";
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(489, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderList";
            this.Text = "OrderList";
            this.Load += new System.EventHandler(this.OrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infodataDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infodataDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private InfodataDataSet3 infodataDataSet3;
        private System.Windows.Forms.BindingSource tblordersBindingSource;
        private InfodataDataSet3TableAdapters.tbl_ordersTableAdapter tbl_ordersTableAdapter;
        private InfodataDataSet4 infodataDataSet4;
        private System.Windows.Forms.BindingSource tblordersBindingSource1;
        private InfodataDataSet4TableAdapters.tbl_ordersTableAdapter tbl_ordersTableAdapter1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_quantity;
        private System.Windows.Forms.Label label1;
    }
}
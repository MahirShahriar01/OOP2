
namespace PharmaDesk
{
    partial class Checkout
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
            this.tblordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infodataDataSet5 = new PharmaDesk.InfodataDataSet5();
            this.tbl_ordersTableAdapter = new PharmaDesk.InfodataDataSet5TableAdapters.tbl_ordersTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderedbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.infodataDataSet7 = new PharmaDesk.InfodataDataSet7();
            this.tbl_ordersTableAdapter1 = new PharmaDesk.InfodataDataSet7TableAdapters.tbl_ordersTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infodataDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infodataDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // tblordersBindingSource
            // 
            this.tblordersBindingSource.DataMember = "tbl_orders";
            this.tblordersBindingSource.DataSource = this.infodataDataSet5;
            // 
            // infodataDataSet5
            // 
            this.infodataDataSet5.DataSetName = "InfodataDataSet5";
            this.infodataDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ordersTableAdapter
            // 
            this.tbl_ordersTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(491, 350);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 27);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "<-BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderedbyDataGridViewTextBoxColumn,
            this.orderdescDataGridViewTextBoxColumn,
            this.orderdateDataGridViewTextBoxColumn,
            this.orderpriceDataGridViewTextBoxColumn,
            this.orderstatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblordersBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(23, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // orderedbyDataGridViewTextBoxColumn
            // 
            this.orderedbyDataGridViewTextBoxColumn.DataPropertyName = "ordered_by";
            this.orderedbyDataGridViewTextBoxColumn.HeaderText = "ordered_by";
            this.orderedbyDataGridViewTextBoxColumn.Name = "orderedbyDataGridViewTextBoxColumn";
            // 
            // orderdescDataGridViewTextBoxColumn
            // 
            this.orderdescDataGridViewTextBoxColumn.DataPropertyName = "order_desc";
            this.orderdescDataGridViewTextBoxColumn.HeaderText = "order_desc";
            this.orderdescDataGridViewTextBoxColumn.Name = "orderdescDataGridViewTextBoxColumn";
            // 
            // orderdateDataGridViewTextBoxColumn
            // 
            this.orderdateDataGridViewTextBoxColumn.DataPropertyName = "order_date";
            this.orderdateDataGridViewTextBoxColumn.HeaderText = "order_date";
            this.orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
            // 
            // orderpriceDataGridViewTextBoxColumn
            // 
            this.orderpriceDataGridViewTextBoxColumn.DataPropertyName = "order_price";
            this.orderpriceDataGridViewTextBoxColumn.HeaderText = "order_price";
            this.orderpriceDataGridViewTextBoxColumn.Name = "orderpriceDataGridViewTextBoxColumn";
            // 
            // orderstatusDataGridViewTextBoxColumn
            // 
            this.orderstatusDataGridViewTextBoxColumn.DataPropertyName = "order_status";
            this.orderstatusDataGridViewTextBoxColumn.HeaderText = "order_status";
            this.orderstatusDataGridViewTextBoxColumn.Name = "orderstatusDataGridViewTextBoxColumn";
            // 
            // tblordersBindingSource1
            // 
            this.tblordersBindingSource1.DataMember = "tbl_orders";
            this.tblordersBindingSource1.DataSource = this.infodataDataSet7;
            // 
            // infodataDataSet7
            // 
            this.infodataDataSet7.DataSetName = "InfodataDataSet7";
            this.infodataDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ordersTableAdapter1
            // 
            this.tbl_ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Wide Latin", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(143, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 29);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "PhanrmaDesk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Checkout Informations";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(595, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infodataDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infodataDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private InfodataDataSet5 infodataDataSet5;
        private System.Windows.Forms.BindingSource tblordersBindingSource;
        private InfodataDataSet5TableAdapters.tbl_ordersTableAdapter tbl_ordersTableAdapter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private InfodataDataSet7 infodataDataSet7;
        private System.Windows.Forms.BindingSource tblordersBindingSource1;
        private InfodataDataSet7TableAdapters.tbl_ordersTableAdapter tbl_ordersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderedbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
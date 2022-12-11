namespace WkSevenAssignmentFinalAttemptVoss
{
    partial class Form1
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
            this.dataGridViewListProducts = new System.Windows.Forms.DataGridView();
            this.storeNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weekSevenDatabaseVossDataSet = new WkSevenAssignmentFinalAttemptVoss.WeekSevenDatabaseVossDataSet();
            this.inventoryTableAdapter = new WkSevenAssignmentFinalAttemptVoss.WeekSevenDatabaseVossDataSetTableAdapters.InventoryTableAdapter();
            this.btnListProducts = new System.Windows.Forms.Button();
            this.inventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnOpenLookUpProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekSevenDatabaseVossDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListProducts
            // 
            this.dataGridViewListProducts.AllowUserToOrderColumns = true;
            this.dataGridViewListProducts.AutoGenerateColumns = false;
            this.dataGridViewListProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storeNumberDataGridViewTextBoxColumn,
            this.productCodeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridViewListProducts.DataSource = this.inventoryBindingSource;
            this.dataGridViewListProducts.Location = new System.Drawing.Point(56, 48);
            this.dataGridViewListProducts.Name = "dataGridViewListProducts";
            this.dataGridViewListProducts.Size = new System.Drawing.Size(448, 283);
            this.dataGridViewListProducts.TabIndex = 0;
            this.dataGridViewListProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // storeNumberDataGridViewTextBoxColumn
            // 
            this.storeNumberDataGridViewTextBoxColumn.DataPropertyName = "StoreNumber";
            this.storeNumberDataGridViewTextBoxColumn.HeaderText = "StoreNumber";
            this.storeNumberDataGridViewTextBoxColumn.Name = "storeNumberDataGridViewTextBoxColumn";
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "Inventory";
            this.inventoryBindingSource.DataSource = this.weekSevenDatabaseVossDataSet;
            // 
            // weekSevenDatabaseVossDataSet
            // 
            this.weekSevenDatabaseVossDataSet.DataSetName = "WeekSevenDatabaseVossDataSet";
            this.weekSevenDatabaseVossDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // btnListProducts
            // 
            this.btnListProducts.Location = new System.Drawing.Point(56, 13);
            this.btnListProducts.Name = "btnListProducts";
            this.btnListProducts.Size = new System.Drawing.Size(448, 23);
            this.btnListProducts.TabIndex = 1;
            this.btnListProducts.Text = "Click to List Products";
            this.btnListProducts.UseVisualStyleBackColor = true;
            this.btnListProducts.Click += new System.EventHandler(this.btnListProducts_Click);
            // 
            // inventoryBindingSource1
            // 
            this.inventoryBindingSource1.DataMember = "Inventory";
            this.inventoryBindingSource1.DataSource = this.weekSevenDatabaseVossDataSet;
            // 
            // btnOpenLookUpProduct
            // 
            this.btnOpenLookUpProduct.Location = new System.Drawing.Point(56, 361);
            this.btnOpenLookUpProduct.Name = "btnOpenLookUpProduct";
            this.btnOpenLookUpProduct.Size = new System.Drawing.Size(160, 23);
            this.btnOpenLookUpProduct.TabIndex = 2;
            this.btnOpenLookUpProduct.Text = "Click to Look Up Product";
            this.btnOpenLookUpProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpenLookUpProduct.UseVisualStyleBackColor = true;
            this.btnOpenLookUpProduct.Click += new System.EventHandler(this.btnOpenLookUpProduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 706);
            this.Controls.Add(this.btnOpenLookUpProduct);
            this.Controls.Add(this.btnListProducts);
            this.Controls.Add(this.dataGridViewListProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekSevenDatabaseVossDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListProducts;
        private WeekSevenDatabaseVossDataSet weekSevenDatabaseVossDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private WeekSevenDatabaseVossDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnListProducts;
        private System.Windows.Forms.BindingSource inventoryBindingSource1;
        private System.Windows.Forms.Button btnOpenLookUpProduct;
    }
}


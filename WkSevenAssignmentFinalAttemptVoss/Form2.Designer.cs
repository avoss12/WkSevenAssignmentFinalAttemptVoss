namespace WkSevenAssignmentFinalAttemptVoss
{
    partial class Form2
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
            this.txtBoxLookUpProduct = new System.Windows.Forms.TextBox();
            this.dataGridViewLookUpProduct = new System.Windows.Forms.DataGridView();
            this.lblLookUpProduct = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLookUpProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxLookUpProduct
            // 
            this.txtBoxLookUpProduct.Location = new System.Drawing.Point(123, 64);
            this.txtBoxLookUpProduct.Name = "txtBoxLookUpProduct";
            this.txtBoxLookUpProduct.Size = new System.Drawing.Size(227, 20);
            this.txtBoxLookUpProduct.TabIndex = 5;
            this.txtBoxLookUpProduct.TextChanged += new System.EventHandler(this.txtBoxLookUpProduct_TextChanged);
            // 
            // dataGridViewLookUpProduct
            // 
            this.dataGridViewLookUpProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLookUpProduct.Location = new System.Drawing.Point(12, 90);
            this.dataGridViewLookUpProduct.Name = "dataGridViewLookUpProduct";
            this.dataGridViewLookUpProduct.Size = new System.Drawing.Size(448, 175);
            this.dataGridViewLookUpProduct.TabIndex = 4;
            this.dataGridViewLookUpProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLookUpProduct_CellContentClick);
            // 
            // lblLookUpProduct
            // 
            this.lblLookUpProduct.AutoSize = true;
            this.lblLookUpProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLookUpProduct.Location = new System.Drawing.Point(135, 9);
            this.lblLookUpProduct.Name = "lblLookUpProduct";
            this.lblLookUpProduct.Size = new System.Drawing.Size(187, 25);
            this.lblLookUpProduct.TabIndex = 6;
            this.lblLookUpProduct.Text = "Look Up Product";
            this.lblLookUpProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Product Code";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLookUpProduct);
            this.Controls.Add(this.txtBoxLookUpProduct);
            this.Controls.Add(this.dataGridViewLookUpProduct);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLookUpProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxLookUpProduct;
        private System.Windows.Forms.DataGridView dataGridViewLookUpProduct;
        private System.Windows.Forms.Label lblLookUpProduct;
        private System.Windows.Forms.Label label1;
    }
}
namespace Experiment2
{
    partial class StockInventoryForm
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
            this.stockInventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.productCodeData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productStatusData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQtyData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stockInventoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stockInventoryDataGridView
            // 
            this.stockInventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockInventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productCodeData,
            this.productNameData,
            this.productStatusData,
            this.productQtyData});
            this.stockInventoryDataGridView.Location = new System.Drawing.Point(44, 28);
            this.stockInventoryDataGridView.Name = "stockInventoryDataGridView";
            this.stockInventoryDataGridView.Size = new System.Drawing.Size(663, 287);
            this.stockInventoryDataGridView.TabIndex = 0;
            // 
            // productCodeData
            // 
            this.productCodeData.HeaderText = "Product Code";
            this.productCodeData.Name = "productCodeData";
            this.productCodeData.ReadOnly = true;
            // 
            // productNameData
            // 
            this.productNameData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productNameData.HeaderText = "Product Name";
            this.productNameData.Name = "productNameData";
            this.productNameData.ReadOnly = true;
            // 
            // productStatusData
            // 
            this.productStatusData.HeaderText = "Status";
            this.productStatusData.Name = "productStatusData";
            this.productStatusData.ReadOnly = true;
            // 
            // productQtyData
            // 
            this.productQtyData.HeaderText = "Quantity";
            this.productQtyData.Name = "productQtyData";
            // 
            // StockInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stockInventoryDataGridView);
            this.Name = "StockInventoryForm";
            this.Text = "StockInventoryForm";
            this.Load += new System.EventHandler(this.StockInventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockInventoryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView stockInventoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeData;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameData;
        private System.Windows.Forms.DataGridViewTextBoxColumn productStatusData;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQtyData;
    }
}
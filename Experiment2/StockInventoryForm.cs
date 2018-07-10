using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Experiment2
{
    public partial class StockInventoryForm : Form
    {

        private Repository repository = new Repository();

        public StockInventoryForm()
        {
            InitializeComponent();
        }

        public void DisplayStockInventoryTable() {

            stockInventoryDataGridView.Rows.Clear();

            foreach (Stock item in repository.GetStockOnHand()) {

                int n = stockInventoryDataGridView.Rows.Add();
                stockInventoryDataGridView.Rows[n].Cells[0].Value = item.Product.ProductCode;
                stockInventoryDataGridView.Rows[n].Cells[1].Value = item.Product.ProductName;
                if (item.Product.ProductStatus == 0)
                {
                    stockInventoryDataGridView.Rows[n].Cells[2].Value = "Active";
                }
                else {
                    stockInventoryDataGridView.Rows[n].Cells[2].Value = "Not Active";
                }
                stockInventoryDataGridView.Rows[n].Cells[3].Value = item.Quantity;
            }
        }

        private void StockInventoryForm_Load(object sender, EventArgs e)
        {
            DisplayStockInventoryTable();
        }
    }
}

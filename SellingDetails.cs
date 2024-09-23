using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OnlineMarketManagmnetSystem.BuyProduct;

namespace OnlineMarketManagmnetSystem
{
    public partial class SellingDetails : Form
    {
        private BindingSource _bindingSource = new BindingSource();
        private List<SellingDetailItem> _sellingDetails;

        public SellingDetails(List<SellingDetailItem> sellingDetails)
        {
            InitializeComponent();
            _sellingDetails = sellingDetails;

            LoadSellingDetails();
        }

        private void LoadSellingDetails()
        {
            DataGridViewSellingDetails.Rows.Clear();  // Clear previous data
            DataGridViewSellingDetails.Columns.Clear();  // Clear previous columns

            // Add the required columns
            DataGridViewSellingDetails.Columns.Add("ProductId", "Product ID");
            DataGridViewSellingDetails.Columns.Add("ProductName", "Product Name");  // Add this new column
            DataGridViewSellingDetails.Columns.Add("Quantity", "Quantity");
            DataGridViewSellingDetails.Columns.Add("Price", "Price");

            // Add rows to the DataGridView
            foreach (var item in _sellingDetails)
            {
                DataGridViewSellingDetails.Rows.Add(item.ProductId, item.ProductName, item.Quantity, item.Price);  // Add product name
            }
        }

        private void DataGridViewSellingDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle any interactions with the DataGridView cells if needed
        }
        public SellingDetails()
        {
            InitializeComponent();
        }

        private void buttonBuyingRefresh_Click(object sender, EventArgs e)
        {
            // Clear the existing selling details list
            BuyProduct.SellingDetailsList.Clear();

            // Load updated selling details into the DataGridView
            LoadSellingDetails();
        }
        //private void LoadSellingDetails()
        //{
        //    _bindingSource.ResetBindings(false);  // This refreshes the data in the DataGridView
        //}

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSellBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminView adminView = new AdminView();
            adminView.Show();
        }

        //private void DataGridViewSellingDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}

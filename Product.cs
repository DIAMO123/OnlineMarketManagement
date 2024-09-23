using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Security.Cryptography;

namespace OnlineMarketManagmnetSystem
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DIAMOND\\SQLEXPRESS;Initial Catalog=ALU;Integrated Security=True;Encrypt=False");

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FillCategory()
        {
            string query = "SELECT [Categories Id], [Categories Name] FROM CategoriesTable";
            DataTable dt = new DataTable();

            try
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader sda = cmd.ExecuteReader();
                    dt.Load(sda);
                }


                comboboxProductCategories.DisplayMember = "Categories Name";
                comboboxProductCategories.ValueMember = "Categories Id";
                comboboxProductCategories.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private void FillSearchCategory()
        {
            string query = "SELECT [Categories Id], [Categories Name] FROM CategoriesTable";
            DataTable dt = new DataTable();

            try
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader sda = cmd.ExecuteReader();
                    dt.Load(sda);
                }


                comboboxSearchCategory.DisplayMember = "Categories Name";
                comboboxSearchCategory.ValueMember = "Categories Id";
                comboboxSearchCategory.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }





        private void populate()
        {
            string query = @"
    SELECT 
        p.[Product Id], 
        p.[Product Name], 
        p.[Product Quantity], 
        p.[Product Price], 
        c.[Categories Id],  
        c.[Categories Name] AS [Product Category]
    FROM 
        ProductTable p
    INNER JOIN 
        CategoriesTable c
    ON 
        p.[Product Category] = c.[Categories Id]";

            DataTable dt = new DataTable();

            try
            {
                // Ensure the connection is only opened if it's closed
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                {
                    sda.Fill(dt);
                }

                DataGridViewProduct.DataSource = dt;

                // Optionally hide the Category ID column
                DataGridViewProduct.Columns[4].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to populate data: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }




        private void buttonProductAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure a category is selected
                if (comboboxProductCategories.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a product category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                con.Open();
                string query = "INSERT INTO ProductTable ([Product Id], [Product Name], [Product Quantity], [Product Price], [Product Category]) VALUES (@ProductId, @ProductName, @ProductQuantity, @ProductPrice, @ProductCategory)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Adding parameters
                    cmd.Parameters.AddWithValue("@ProductId", txtProductId.Text);
                    cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@ProductQuantity", txtProductQuantity.Text);
                    cmd.Parameters.AddWithValue("@ProductPrice", txtProductPrice.Text);
                    cmd.Parameters.AddWithValue("@ProductCategory", comboboxProductCategories.SelectedValue); // Use the selected category ID

                    cmd.ExecuteNonQuery();
                }


                MessageBox.Show("Product Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh UI
                populate();
                txtProductId.Text = "";
                txtProductName.Text = "";
                txtProductQuantity.Text = "";
                txtProductPrice.Text = "";
                comboboxProductCategories.SelectedIndex = -1;  // Clear category selection
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }



        private void Product_Load(object sender, EventArgs e)
        {
            FillCategory();
            populate();
            FillSearchCategory();

            DataGridViewProduct.CellClick += DataGridViewProduct_CellClick;

        }

        private void buttonProductUpdate_Click(object sender, EventArgs e)
        {
            // Ensure that a product ID is selected
            if (string.IsNullOrEmpty(txtProductId.Text))
            {
                MessageBox.Show("Please select a product to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensure a category is selected
            if (comboboxProductCategories.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();

                // Update query
                string query = @"UPDATE ProductTable 
                         SET [Product Name] = @ProductName, 
                             [Product Quantity] = @ProductQuantity, 
                             [Product Price] = @ProductPrice, 
                             [Product Category] = @ProductCategory
                         WHERE [Product Id] = @ProductId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Adding parameters
                    cmd.Parameters.AddWithValue("@ProductId", txtProductId.Text);  // Product ID
                    cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);  // Product Name
                    cmd.Parameters.AddWithValue("@ProductQuantity", txtProductQuantity.Text);  // Product Quantity
                    cmd.Parameters.AddWithValue("@ProductPrice", txtProductPrice.Text);  // Product Price
                    cmd.Parameters.AddWithValue("@ProductCategory", comboboxProductCategories.SelectedValue);  // Product Category

                    // Execute the query
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Product Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView after the update
                populate();

                // Clear the form fields
                txtProductId.Text = "";
                txtProductName.Text = "";
                txtProductQuantity.Text = "";
                txtProductPrice.Text = "";
                comboboxProductCategories.SelectedIndex = -1;  // Clear category selection
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }



        private void DataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user clicked on a row, not on the header
            if (e.RowIndex >= 0)
            {
                // Get the currently selected row
                DataGridViewRow row = DataGridViewProduct.Rows[e.RowIndex];

                // Assign the values to the respective text boxes
                txtProductId.Text = row.Cells[0].Value.ToString();  // Product Id
                txtProductName.Text = row.Cells[1].Value.ToString();  // Product Name
                txtProductQuantity.Text = row.Cells[2].Value.ToString();  // Product Quantity
                txtProductPrice.Text = row.Cells[3].Value.ToString();  // Product Price
                comboboxProductCategories.SelectedValue = row.Cells[4].Value;  // Product Category (Category ID)
            }
        }

        private void buttonProductDelete_Click(object sender, EventArgs e)
        {
            // Ensure that a product ID is selected
            if (string.IsNullOrEmpty(txtProductId.Text))
            {
                MessageBox.Show("Please select a product to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm deletion from the user
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    con.Open();

                    // Delete query
                    string query = "DELETE FROM ProductTable WHERE [Product Id] = @ProductId";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add ProductId parameter
                        cmd.Parameters.AddWithValue("@ProductId", txtProductId.Text);

                        // Execute the delete command
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Product Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the DataGridView after deletion
                    populate();

                    // Clear the form fields
                    txtProductId.Text = "";
                    txtProductName.Text = "";
                    txtProductQuantity.Text = "";
                    txtProductPrice.Text = "";
                    comboboxProductCategories.SelectedIndex = -1;  // Clear category selection
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }

        private void comboboxSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonProductSearch_Click(object sender, EventArgs e)
        {

            // Ensure that a category is selected
            if (comboboxSearchCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected category ID
            int selectedCategoryId = (int)comboboxSearchCategory.SelectedValue;

            // Query to fetch products based on selected category
            string query = @"
    SELECT 
        p.[Product Id], 
        p.[Product Name], 
        p.[Product Quantity], 
        p.[Product Price], 
        c.[Categories Id], 
        c.[Categories Name] AS [Product Category]
    FROM 
        ProductTable p
    INNER JOIN 
        CategoriesTable c
    ON 
        p.[Product Category] = c.[Categories Id]
    WHERE 
        p.[Product Category] = @CategoryId";

            DataTable dt = new DataTable();

            try
            {

                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CategoryId", selectedCategoryId);  // Category ID parameter
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                }


                // Display the filtered products in the DataGridView
                DataGridViewProduct.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }


        }

        private void buttonProductCategories_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminView adminView = new AdminView();
            adminView.Show();
        }

        private void buttonProductLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void comboboxSearchCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

       
    }
}

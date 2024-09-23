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

namespace OnlineMarketManagmnetSystem
{
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DIAMOND\\SQLEXPRESS;Initial Catalog=ALU;Integrated Security=True;Encrypt=False");

        private void populate()
        {
            try
            {
                con.Open();
                string query = "select * from CategoriesTable";  // Define your query here
                SqlDataAdapter sda = new SqlDataAdapter(query, con);  // Pass the query and connection to the SqlDataAdapter
                var ds = new DataSet();  // DataSet to hold the retrieved data
                sda.Fill(ds);  // Fill the DataSet with data from the database
                DataGridViewCategories.DataSource = ds.Tables[0];  // Bind the DataSet's first table to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to populate data: " + ex.Message);  // Display an error message if something goes wrong
            }
            finally
            {
                con.Close();
            }
        }
        private void buttonCategoriesAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "insert into CategoriesTable values('" + txtCategoriesId.Text + "','" + txtCategoriesName.Text + "','" + txtCategoriesDescribtion.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                populate();
                txtCategoriesId.Text = "";
                txtCategoriesName.Text = "";
                txtCategoriesDescribtion.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            populate();
            this.DataGridViewCategories.CellClick += new DataGridViewCellEventHandler(this.DataGridViewCategories_CellContentClick);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataGridViewCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)  // Make sure the user has clicked on a valid row (not the header)
            {
                DataGridViewRow row = DataGridViewCategories.Rows[e.RowIndex];
                txtCategoriesId.Text = row.Cells[0].Value.ToString();
                txtCategoriesName.Text = row.Cells[1].Value.ToString();
                txtCategoriesDescribtion.Text = row.Cells[2].Value.ToString();
            }
        }

        private void buttonCategoriesUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCategoriesId.Text == "" || txtCategoriesName.Text == "" || txtCategoriesDescribtion.Text == "")
                {
                    MessageBox.Show("Missing Data!!!!!!", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    con.Open();
                    string query = "update CategoriesTable set [Categories Name]='" + txtCategoriesName.Text + "',[Categories Describtion]='" + txtCategoriesDescribtion.Text + "'where [Categories Id]=" + txtCategoriesId.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    populate();
                    txtCategoriesId.Text = "";
                    txtCategoriesName.Text = "";
                    txtCategoriesDescribtion.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCategoriesDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtCategoriesId.Text == "")
                {
                    MessageBox.Show("Select Category Id To Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    string query = "delete from CategoriesTable where [Categories Id] ='" + txtCategoriesId.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                    populate();
                    txtCategoriesId.Text = "";
                    txtCategoriesName.Text = "";
                    txtCategoriesDescribtion.Text = "";
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonCategoriesLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void buttonProductCategories_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product product = new Product();
            product.Show();

        }

        private void buttonSellingDetails_Click(object sender, EventArgs e)
        {
            SellingDetails sellingDetailsForm = new SellingDetails(BuyProduct.SellingDetailsList);
            sellingDetailsForm.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMarketManagmnetSystem
{
    public partial class AdminRegistration : Form
    {
        public AdminRegistration()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DIAMOND\\SQLEXPRESS;Initial Catalog=ALU;Integrated Security=True;Encrypt=False");
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void abuttonRegistration_Click(object sender, EventArgs e)
        {
            // Get input from the form fields
            string prevUsername = txtPreAdminName.Text; // Assume txtPreviousUsername is the name of your TextBox for previous username
            string prevPassword = txtPrePassword.Text; // TextBox for previous password
            string newUsername = txtNewAdminName.Text;       // TextBox for new username
            string newPassword = txtNewAdminPassword.Text;       // TextBox for new password

            // SQL query to check if the previous username and password match
            string query = "SELECT COUNT(*) FROM AdminTable WHERE Username = @prevUsername AND Password = @prevPassword";

            // Open a SQL connection
            using (SqlConnection con = new SqlConnection("Data Source=DIAMOND\\SQLEXPRESS;Initial Catalog=ALU;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@prevUsername", prevUsername);
                cmd.Parameters.AddWithValue("@prevPassword", prevPassword);

                con.Open();

                // Check if the previous details exist
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    // If previous username and password match, update with new values
                    string updateQuery = "UPDATE AdminTable SET Username = @newUsername, Password = @newPassword WHERE Username = @prevUsername AND Password = @prevPassword";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                    updateCmd.Parameters.AddWithValue("@newUsername", newUsername);
                    updateCmd.Parameters.AddWithValue("@newPassword", newPassword);
                    updateCmd.Parameters.AddWithValue("@prevUsername", prevUsername);
                    updateCmd.Parameters.AddWithValue("@prevPassword", prevPassword);

                    int rowsAffected = updateCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Username and Password updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // If previous username and password don't match, show an error message
                    MessageBox.Show("Wrong previous username or password. Please try again.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                con.Close();

                txtPreAdminName.Text = "";
                txtPrePassword.Text = "";
                txtNewAdminName.Text = "";
                txtNewAdminPassword.Text = "";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegistrationClear_Click(object sender, EventArgs e)
        {
            txtPreAdminName.Text = "";
            txtPrePassword.Text = "";
            txtNewAdminName.Text = "";
            txtNewAdminPassword.Text = "";
        }

        private void buttonLinkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}

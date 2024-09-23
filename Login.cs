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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OnlineMarketManagmnetSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DIAMOND\\SQLEXPRESS;Initial Catalog=ALU;Integrated Security=True;Encrypt=False");

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter username and password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if (comboboxLogin.SelectedIndex == 0)
                {
                    string query = "SELECT COUNT(*) FROM AdminTable WHERE [UserName]=@username AND Password=@password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    con.Open();
                    int count = (int)cmd.ExecuteScalar(); // FIXED: Use ExecuteScalar to get the count from the query
                    con.Close();

                    // Check if credentials match
                    if (count > 0)
                    {
                        MessageBox.Show("WELCOME TO YOUR PROFILE!");
                        txtUserName.Text = "";
                        txtPassword.Text = "";
                        this.Hide();
                        AdminView buyProduct = new AdminView();
                        buyProduct.Show();

                    }
                    else
                    {
                        MessageBox.Show("ERROR: USERNAME OR PASSWORD INCORRECT", "Error");
                    }

                }
                else if (comboboxLogin.SelectedIndex == 1)
                {
                    string query = "SELECT COUNT(*) FROM CustomerTable WHERE [Customer Name]=@username AND Password=@password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    con.Open();
                    int count = (int)cmd.ExecuteScalar(); // FIXED: Use ExecuteScalar to get the count from the query
                    con.Close();

                    // Check if credentials match
                    if (count > 0)
                    {
                        MessageBox.Show("WELCOME TO YOUR PROFILE!");
                        txtUserName.Text = "";
                        txtPassword.Text = "";
                        this.Hide();
                        BuyProduct buyProduct = new BuyProduct();
                        buyProduct.Show();

                    }
                    else
                    {
                        MessageBox.Show("ERROR: USERNAME OR PASSWORD INCORRECT", "Error");
                    }

                }
                else
                {
                    MessageBox.Show("Select Your Roll Frist", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonLinkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboboxLogin.SelectedIndex = -1;
            txtUserName.Text = "";
            txtPassword.Text = "";

        }

        private void AssignAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminRegistration registration = new AdminRegistration();
            registration.Show();
        }
    }
}

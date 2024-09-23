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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DIAMOND\\SQLEXPRESS;Initial Catalog=ALU;Integrated Security=True;Encrypt=False");
        private void comboboxLogin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {

            if (txtCustomerName.Text != "" && txtRegistrationPassword.Text != "" && txtCustomerAge.Text != "" && comboboxRegistrationGender.Text != "" && txtCustomerAddress.Text != "" && txtCustomerPhone.Text != "")
            {
                SqlCommand cmd = new SqlCommand(@"INSERT INTO CustomerTable
                ([Customer Name]
                ,[Password]
                ,[Age]
                ,[Gender]
                ,[Address]
                ,[Mobile])
           
                 VALUES
                 ('" + txtCustomerName.Text + "','" + txtRegistrationPassword.Text + "','" + txtCustomerAge.Text + "','" + comboboxRegistrationGender.Text + "','" + txtCustomerAddress.Text + "','" + txtCustomerPhone.Text + "') ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Register Successful", "Successful", MessageBoxButtons.OK);

                txtCustomerName.Text = "";
                txtRegistrationPassword.Text = "";
                txtCustomerAge.Text = "";
                comboboxRegistrationGender.Text = "";
                txtCustomerAddress.Text = "";
                txtCustomerPhone.Text = "";
            }
                

            
            else
            {
                MessageBox.Show("Missing Data", "Error", MessageBoxButtons.OK);
            }




        }

        private void buttonRegistrationClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
            txtRegistrationPassword.Text = "";
            txtCustomerAge.Text = "";
            comboboxRegistrationGender.Text = "";
            txtCustomerAddress.Text = "";
            txtCustomerPhone.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLinkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();  
            login.Show();
        }
    }
}

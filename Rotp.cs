using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMarketManagmnetSystem
{
    public partial class Rotp : Form
    {
        public Rotp()
        {
            InitializeComponent();
        }

        private void rbuttonBkashOtpBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rocket rocket = new Rocket();
            rocket.Show();
        }

        private void rbuttonBkashotpCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbuttonBkashotpConfirm_Click(object sender, EventArgs e)
        {

            if (r.Text == "")
            {
                MessageBox.Show("Otp Missing", "Error", MessageBoxButtons.OK);
            }
            else
            {
                this.Hide();
                Rocketend rocketend = new Rocketend();
                rocketend.Show();
            }


            
        }
    }
}

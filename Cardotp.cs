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
    public partial class Cardotp : Form
    {
        public Cardotp()
        {
            InitializeComponent();
        }

        private void cbuttonBkashOtpBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Card c = new Card();
            c.Show();
        }

        private void cbuttonBkashotpCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbuttonBkashotpConfirm_Click(object sender, EventArgs e)
        {
            if (c.Text == "")
            {
                MessageBox.Show("Otp Missing", "Error", MessageBoxButtons.OK);
            }
            else
            {
                this.Hide();
                CardEnd bkashEnd = new CardEnd();
                bkashEnd.Show();
            }



           
        }
    }
}

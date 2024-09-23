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
    public partial class Card : Form
    {
        public Card()
        {
            InitializeComponent();
        }

        private void cbuttonBkashBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Buy1 buy1 = new Buy1();
            buy1.Show();

        }

        private void cbuttonBkashEnter_Click(object sender, EventArgs e)
        {
            if (cphone.Text == "")
            {
                MessageBox.Show("Number Missing", "Error", MessageBoxButtons.OK);
            }
            else
            {
                this.Hide();
                Cardotp cardotp = new Cardotp();
                cardotp.Show();
            }


            
        }

        private void cbuttonBkashCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

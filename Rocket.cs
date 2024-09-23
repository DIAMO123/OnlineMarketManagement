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
    public partial class Rocket : Form
    {
        public Rocket()
        {
            InitializeComponent();
        }

        private void rbuttonBkashBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Buy1 buy1 = new Buy1();
            buy1.Show();
        }

        private void rbuttoBkashCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbuttonBkashEnter_Click(object sender, EventArgs e)
        {
            if (rphone.Text == "")
            {
                MessageBox.Show("Number Missing", "Error", MessageBoxButtons.OK);
            }
            else
            {
                this.Hide();
                Rotp rotp = new Rotp();
                rotp.Show();
            }


            
        }
    }
}

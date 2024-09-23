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
    public partial class Bkash : Form
    {
        public Bkash()
        {
            InitializeComponent();
        }

        private void buttonBkashBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Buy1 buy1 = new Buy1();
            buy1.Show();
        }

        private void buttonBkashCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBkashEnter_Click(object sender, EventArgs e)
        {
            if (bkphone.Text== "")
            {
                MessageBox.Show("Number Missing","Error",MessageBoxButtons.OK);
            }
            else
            {
                this.Hide();
                Botp botp = new Botp();
                botp.Show();
            }
            
            
            
        }
    }
}

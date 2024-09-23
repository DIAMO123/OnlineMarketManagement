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
    public partial class BkashEnd : Form
    {
        int progressValue = 0;
        public BkashEnd()
        {
            InitializeComponent();
            this.Load += new EventHandler(BkashEnd_Load);
        }

        private void BkashEnd_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Increment the progress value
            progressValue += 1; // Increments the progress by 2 each tick (100ms * 50 = 5000ms = 5 seconds)

            // Set the progress bar value
            progressBar1.Value = progressValue;

            // Stop the timer when progress reaches 100%
            if (progressValue >= 100)
            {
                timer1.Stop();
                MessageBox.Show("Payment Successfully Done!!!!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void buttonBkashendotpConfirm_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyProduct buyProduct = new BuyProduct();
            buyProduct.Show();
        }

        private void bkashendlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();   
        }
    }
}

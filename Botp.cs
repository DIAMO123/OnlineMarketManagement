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
    public partial class Botp : Form
    {
        public Botp()
        {
            InitializeComponent();
        }

        private void buttonBkashOtpBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bkash bkash = new Bkash();
            bkash.Show();
        }

        private void buttonBkashotpCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBkashotpConfirm_Click(object sender, EventArgs e)
        {
            if (bk.Text == "")
            {
                MessageBox.Show(" Otp Missing", "Error", MessageBoxButtons.OK);
            }
            else
            {
                this.Hide();
                BkashEnd bkashEnd = new BkashEnd();
                bkashEnd.Show();
            }


           
        }

        private void Botp_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Notp : Form
    {
        public Notp()
        {
            InitializeComponent();
        }

        private void nbuttonBkashOtpBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nagad nagad = new Nagad();
            nagad.Show();
        }

        private void nbuttonBkashotpCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nbuttonBkashotpConfirm_Click(object sender, EventArgs e)
        {
            if (n.Text == "")
            {
                MessageBox.Show("Otp Missing", "Error", MessageBoxButtons.OK);
            }
            else
            {
                this.Hide();
                nagadend Nagadend = new nagadend();
                Nagadend.Show();
            }



            
        }
    }
}

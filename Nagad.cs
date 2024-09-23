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
    public partial class Nagad : Form
    {
        public Nagad()
        {
            InitializeComponent();
        }

        private void nbuttonBkashBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Buy1 buy1 = new Buy1();
            buy1.Show();
        }

        private void nbuttonBkashCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nbuttonBkashEnter_Click(object sender, EventArgs e)
        {
            if (nphone.Text == "")
            {
                MessageBox.Show("Number Missing", "Error", MessageBoxButtons.OK);
            }
            else
            {
                this.Hide();
                Notp notp = new Notp();
                notp.Show();
            }



           
        }
    }
}

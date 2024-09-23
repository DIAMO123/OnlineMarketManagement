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
    public partial class Buy1 : Form
    {
        public Buy1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rocket rocket = new Rocket();
            rocket.Show();
        }

        private void Bkash_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bkash bkash = new Bkash();
            bkash.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Nagad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nagad nagad = new Nagad();
            nagad.Show();
        }

        private void VisaCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Card card = new Card();
            card.Show();
        }

        private void Buy1Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyProduct buyProduct = new BuyProduct();
            buyProduct.Show();
        }
    }
}

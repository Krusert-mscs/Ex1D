using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtRateCanada_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountCanada.Text = "0.00";
            txtAmountEurope.Text = "0.00";
            txtAmountJapan.Text = "0.00";
            txtAmountUnitedKingdom = "0.00";
            txtCAtoUS.Text = "";
        }

        private void txtAmountCanada_TextChanged(object sender, EventArgs e)
        {
            txtCAtoUS.Text = (
                Convert.ToDecimal(txtRateCanada.Text) * Convert.ToDecimal(txtAmountCanada.Text)
            ).ToString("0.00");
            txtAmountEurope.Focus();
        }

        private void txtAmountEurope_TextChanged(object sender, EventArgs e)
        {
            txtEUtoUS.Text = (
                Convert.ToDecimal(txtRateEurope.Text) * Convert.ToDecimal(txtAmountEurope.Text)
            ).ToString("0.00");
            txtAmountJapan.Focus();
        }

        private void txtAmountJapan_TextChanged(object sender, EventArgs e)
        {
            txtJAtoUS.Text = (
                Convert.ToDecimal(txtRateJapan.Text) * Convert.ToDecimal(txtAmountJapan.Text)
            ).ToString("0.00");
            txtAmountUnitedKingdom.Focus();
        }

        private void txtAmountUnitedKingdom_TextChanged(object sender, EventArgs e)
        {
            txtUKtoUS.Text = (
                Convert.ToDecimal(txtRateUnitedKingdom.Text) * Convert.ToDecimal(txtAmountUnitedKingdom.Text)
            ).ToString("0.00");
        }

        private void txtCAtoUS_TextChanged(object sender, EventArgs e)
        {
            //txtUSSubtotal = (
                
           // ).ToString("0.00");
        }

    }
}

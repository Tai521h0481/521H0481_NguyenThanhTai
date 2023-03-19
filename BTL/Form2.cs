using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public bool Success { get; set; }
        private void btnCF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNum.Text) || string.IsNullOrEmpty(txtPIN.Text))
            {
                MessageBox.Show("Please complete all information");
            }
            else
            {
                DialogResult result = MessageBox.Show("Cost for each trip is 20$?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("The transaction is successful, your account has been deducted $20. Thank you!");
                    // input to database
                    Success = true;
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("Transaction cancelled.");
                }
            }
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPIN_TextChanged(object sender, EventArgs e)
        {
            txtPIN.Text = new string(txtPIN.Text.Where(char.IsDigit).ToArray());
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            txtNum.Text = new string(txtNum.Text.Where(char.IsDigit).ToArray());
        }
    }
}

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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
            QRCoder.QRCodeData qrCodeData = qrGenerator.CreateQrCode("Your QR code data goes here", QRCoder.QRCodeGenerator.ECCLevel.Q);
            QRCoder.QRCode qrCode = new QRCoder.QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(5);

            // Show QR code image in a PictureBox control
            pictureBox1.Image = qrCodeImage;
        }
        public bool Success { get; set; }
        private void btnCF_Click(object sender, EventArgs e)
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

        private void btnCC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

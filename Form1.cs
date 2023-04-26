using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
namespace gerador_qr_code
{
    public partial class Form1 : Form
    {
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        string text_to_generate_qr_code = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label_message_to_user_Click(object sender, EventArgs e)
        {
            
        }

        private void button_gerar_qr_code_Click(object sender, EventArgs e)
        {
            text_to_generate_qr_code = textBox_user_input.Text;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text_to_generate_qr_code, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            Bitmap resizedImage = new Bitmap(qrCodeImage, new Size(200, 200)); //Redimenciona o tamanho do QrCode
            pictureBox_for_qr_code.Image = resizedImage;
            textBox_user_input.Text = "";

        }
    }
}

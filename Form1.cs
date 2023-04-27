using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace gerador_qr_code
{
    public partial class QrCodeGeneratorByText : Form
    {

        string text_to_generate_qr_code = "";
        Bitmap resizedImage;
        public QrCodeGeneratorByText()
        {
            InitializeComponent();
            Bitmap png = new Bitmap(global::gerador_qr_code.Properties.Resources.qrcode);
            Icon icone = Icon.FromHandle(png.GetHicon());
            this.Icon = icone;
        }
        private void button_gerar_qr_code_Click(object sender, EventArgs e)
        {
            
            text_to_generate_qr_code = textBox_user_input.Text;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text_to_generate_qr_code, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            resizedImage = new Bitmap(qrCodeImage, new Size(200, 200)); //Redimenciona o tamanho do QrCode
            pictureBox_for_qr_code.Visible = true;
            pictureBox_for_qr_code.Image = resizedImage;
            textBox_user_input.Text = "";
            button_save_qr_code.Visible = true;
        }

        private void button_save_qrcode_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PNG Image|*.png|JPEG Image|*.jpg|BMP Image|*.bmp";
            saveFileDialog1.Title = "Save QR Code Image";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        resizedImage.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case 2:
                        resizedImage.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 3:
                        resizedImage.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                }
                fs.Close();
            }
        }
            private void botao_visitar_git_Click(object sender, EventArgs e)
            {
                string url = "https://github.com/VBSX/gerador_qr_code_csharp";
                Process.Start(url);
            }
    }

    
}


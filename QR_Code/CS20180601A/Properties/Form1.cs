using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VB = Microsoft.VisualBasic;
using ZXing;
using ZXing.QrCode;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using BarcodeLib.Barcode;

namespace CS20180601A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int start, counter;
        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //counter = 10;
                ColorDialog A = new ColorDialog();
                if (A.ShowDialog() == DialogResult.OK)
                    counter = int.Parse(VB.Interaction.InputBox("輸入計時秒數","CS20180515A"));
                start = 1;
                timer1.Enabled = true;
                this.Text = DateTime.Now.ToString();
            }
            catch(Exception X)
            {
                MessageBox.Show(X.ToString(), "錯誤訊息", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }            
        }       

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ZXing.BarcodeWriter BW = new BarcodeWriter
                {
                    
                    Format = ZXing.BarcodeFormat.QR_CODE,
                    Options = new ZXing.QrCode.QrCodeEncodingOptions
                    {
                        Height = vScrollBar1.Value,
                        Width = vScrollBar1.Value,

                        CharacterSet = "UTF-8",
                        ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.H
                    }
                };
                pictureBox1.Image = BW.Write(textBox1.Text);
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString(), "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Width = vScrollBar1.Value;
            pictureBox1.Height = vScrollBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SFD = new SaveFileDialog();
                ColorDialog CD = new ColorDialog();
                BarcodeLib.Barcode.QRCode ColorQRCode = new QRCode();
                ColorQRCode.ModuleSize = 10;
                ColorQRCode.LeftMargin = 10;
                ColorQRCode.RightMargin = 10;
                ColorQRCode.TopMargin = 10;
                ColorQRCode.BottomMargin = 10;
                ColorQRCode.Encoding = QRCodeEncoding.Auto;
                ColorQRCode.ECL = QRCodeErrorCorrectionLevel.H;
                ColorQRCode.Data = textBox1.Text;
                //ColorQRCode.BackgroundColor = Color.Brown;
                //ColorQRCode.ModuleColor = Color.DeepSkyBlue;
                if (CD.ShowDialog() == DialogResult.OK)
                {
                    ColorQRCode.BackgroundColor = CD.Color;
                }
                else return;

                if (CD.ShowDialog() == DialogResult.OK)
                {
                    ColorQRCode.ModuleColor = CD.Color;
                }
                else return;

                SFD.Filter = "PNG|*.png|Other|*.*";
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    ColorQRCode.drawBarcode(SFD.FileName);
                    pictureBox1.ImageLocation = SFD.FileName;
                    System.Diagnostics.Process.Start(SFD.FileName);
                }
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString(), "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string bg, fg;
                string ps=VB.Interaction.InputBox("請輸入Pixel Size","QR-Code畫素");                
                ColorDialog CD = new ColorDialog();
                if (CD.ShowDialog() == DialogResult.OK)
                {
                    bg = CD.Color.R.ToString() + "-" + CD.Color.G.ToString() + "-" + CD.Color.B.ToString();
                }
                else return;
                if (CD.ShowDialog() == DialogResult.OK)
                {
                    fg = CD.Color.R.ToString() + "-" + CD.Color.G.ToString() + "-" + CD.Color.B.ToString();
                }
                else return;
                string URL = "http://api.qrserver.com/v1/create-qr-code/?data=" + textBox1.Text + "&size" + ps + "x" + ps + "&bgcolor=" + bg + "&color=" + fg+"&ecc=H";//&size可以省略成只打&就好                
                pictureBox1.Load(URL);
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString(), "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OFD = new OpenFileDialog();
                OFD.Title = "Load a Logo File";
                SaveFileDialog SFD = new SaveFileDialog();
                SFD.Title = "Save QR code with Logo to a File";
                ColorDialog CD = new ColorDialog();

                MessagingToolkit.QRCode.Codec.QRCodeEncoder QRCEncoder = new QRCodeEncoder();
                QRCEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
                QRCEncoder.QRCodeScale = 20;
                MessageBox.Show("請輸入背景顏色");
                if (CD.ShowDialog() == DialogResult.OK)
                {
                    QRCEncoder.QRCodeBackgroundColor = CD.Color;
                }
                else return;
                MessageBox.Show("請輸入前景顏色");
                if (CD.ShowDialog() == DialogResult.OK)
                {
                    QRCEncoder.QRCodeForegroundColor = CD.Color;
                }
                else return;
                Bitmap BM = QRCEncoder.Encode(textBox1.Text,Encoding.UTF8);

                System.Drawing.Image Logo;
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    Logo = Image.FromFile(OFD.FileName);
                }
                else return;

                System.Drawing.Graphics G = Graphics.FromImage(BM);

                //int left = (BM.Width / 2) - (Logo.Width / 2);
                //int top = (BM.Height / 2) - (Logo.Height / 2);
                //G.DrawImage(Logo, new Point(left, top));
                G.DrawImage(Logo, new Point(BM.Width - Logo.Width, BM.Height - Logo.Height));

                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    BM.Save(SFD.FileName, System.Drawing.Imaging.ImageFormat.Png);                    
                    pictureBox1.ImageLocation= SFD.FileName;
                    System.Diagnostics.Process.Start(SFD.FileName);
                }
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString(), "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 FM2 = new Form2();
            FM2.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                start++;
                textBox1.Text = DateTime.Now.ToString();
                if (start > counter) timer1.Enabled = false;
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString(), "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

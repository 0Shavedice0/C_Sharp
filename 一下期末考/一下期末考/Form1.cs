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

namespace 一下期末考
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random RN = new Random();
        private void 產生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                checked
                {
                    int input = int.Parse(VB.Interaction.InputBox("請輸入產生ProgressBar數目", "106-2Q7A"));
                    for (int i = 1; input >= i; i++)
                    {
                        ProgressBar PB = new ProgressBar();
                        this.WindowState = FormWindowState.Maximized;
                        PB.Value = RN.Next(0, 101);
                        PB.Top = RN.Next(200, 801);
                        PB.Left = RN.Next(20, 701);
                        PB.Click += new EventHandler(PBClick);
                        PB.MouseLeave += new EventHandler(Mouse);
                        this.Controls.Add(PB);
                    }
                    this.Text = "Number of Controls" + this.Controls.Count;
                }
            }
            catch(Exception X)
            {
                MessageBox.Show(X.ToString(),"錯誤訊息",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }            
        }
        private void 產生ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                checked
                {
                    PictureBox PP = new PictureBox();
                    int sidelength = RN.Next(50, 401);
                    PP.Name = "PP";
                    PP.Width = sidelength;
                    PP.Height = sidelength;
                    PP.Left = RN.Next(20, 1001);
                    PP.Top = RN.Next(200, 801);
                    PP.BackColor = Color.Pink;
                    this.Text = "Number of Controls:" + this.Controls.Count;
                    this.Controls.Add(PP);
                    PP.Click += new EventHandler(PPClick);
                }
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString(), "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void PBClick(object sender,EventArgs e)
        {
            try
            {
                checked
                {
                    if (((ProgressBar)sender).Value >= 10) ((ProgressBar)sender).Value = ((ProgressBar)sender).Value - 10;
                    else if (((ProgressBar)sender).Value < 10) ((ProgressBar)sender).Value = ((ProgressBar)sender).Value - ((ProgressBar)sender).Value;
                    this.Text = ((ProgressBar)sender).Value.ToString();
                }
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString(), "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void PPClick(object sender, EventArgs e)
        {
            try
            {
                checked
                {
                    string input = VB.Interaction.InputBox("請輸入中文或網址", "106-2Q7A");
                    ZXing.BarcodeWriter BW = new BarcodeWriter
                    {
                        Format = ZXing.BarcodeFormat.QR_CODE,
                        Options = new ZXing.QrCode.QrCodeEncodingOptions
                        {
                            Width = ((PictureBox)sender).Width,
                            Height = ((PictureBox)sender).Height,
                            CharacterSet = "UTF-8",
                            ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.H
                        }
                    };
                    ((PictureBox)sender).Image = BW.Write(input);
                }
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString(), "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private  void Mouse(object sender, EventArgs e)
        {
            try
            {
                checked
                {
                    ((ProgressBar)sender).Value = 100;
                }
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString(), "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
        private void 移除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                checked
                {
                    while (this.Controls.Count / 2 >= 1)
                    {
                        foreach (Control PB in this.Controls)
                        {
                            if (PB.GetType() == typeof(ProgressBar)) this.Controls.Remove(PB);
                        }
                    }
                    this.Text = "Number of Controls:" + this.Controls.Count;
                }
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString(), "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void 移除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                checked
                {
                    while (this.Controls.Count / 2 >= 1)
                    {
                        foreach (Control PP in this.Controls)
                        {
                            if (PP.GetType() == typeof(PictureBox)) this.Controls.Remove(PP);
                        }
                    }
                    this.Text = "Number of Controls:" + this.Controls.Count;
                }
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString(), "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}

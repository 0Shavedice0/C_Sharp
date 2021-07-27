using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS20180601A
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            Doodle(e.X, e.Y, "Circle");
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            Doodle(e.X, e.Y, "Rectangle");
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            
            Doodle(e.X, e.Y, "Line");
        }
        private void Doodle(int X,int Y,string Type)
        {
            System.Drawing.Graphics G = this.CreateGraphics();
            switch (Type)
            {
                case "Line":
                    G.DrawLine(System.Drawing.Pens.Blue, 0, 0, X, Y);
                    break;
                case "Rectangle":
                    G.DrawRectangle(System.Drawing.Pens.Black, 0, 0, X, Y);
                    break;
                case "Circle":
                    G.DrawEllipse(System.Drawing.Pens.AliceBlue, 0, 0, X, Y);
                    break;
            }
        }
    }
}

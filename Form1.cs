using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Draw_Android
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush b1 = new SolidBrush(Color.LightGreen);
            SolidBrush b2 = new SolidBrush(Color.White);
            Rectangle r = new Rectangle(50, 50, 250, 300);
            Rectangle r2 = new Rectangle(100, 100, 20, 20);
            Rectangle r3 = new Rectangle(230, 100, 20, 20);
            Rectangle r4 = new Rectangle(50, 470, 50, 50);
            Rectangle r5 = new Rectangle(250, 470, 50, 50);
            Rectangle r6 = new Rectangle(10, 220, 30, 30);
            Rectangle r7 = new Rectangle(10, 350, 30, 30);
            Rectangle r8 = new Rectangle(310, 220, 30, 30);
            Rectangle r9 = new Rectangle(310, 350, 30, 30);
            Rectangle r1 = new Rectangle(100, 600, 30, 30);
            Rectangle r0 = new Rectangle(215, 600, 30, 30);

            Pen p = new Pen(Color.LightGreen);
            p.Width = 5;

            g.FillPie(b1, r, 180, 180);
            g.FillPie(b2, r2, 360, 360);
            g.FillPie(b2, r3, 360, 360);
            g.DrawLine(p, 80, 40, 180, 150);
            g.DrawLine(p, 280, 40, 180, 150);

            g.FillRectangle(b1, 50, 220, 250, 280);
            g.FillRectangle(b1, 70, 470, 210, 50);
            g.FillRectangle(b1, 10, 230, 30, 140);
            g.FillRectangle(b1, 310, 230, 30, 140);
            g.FillRectangle(b1, 100, 510, 30, 110);
            g.FillRectangle(b1, 215, 510, 30, 110);

            g.FillPie(b1, r4, 90, 90);
            g.FillPie(b1, r5, 360, 90);
            g.FillPie(b1, r6, 180, 180);
            g.FillPie(b1, r7, 360, 180);
            g.FillPie(b1, r8, 180, 180);
            g.FillPie(b1, r9, 360, 180);
            g.FillPie(b1, r1, 360, 180);
            g.FillPie(b1, r0, 360, 180);
            Font t = new Font("Saysettha OT", 50);
            g.DrawString("Android", t, Brushes.LightGreen, 380, 100);
            Font n = new Font("Saysettha OT", 20);
            g.DrawString("Mr Jafong Vue 3cs2", n, Brushes.Red, 380, 500);

        }
    }
}

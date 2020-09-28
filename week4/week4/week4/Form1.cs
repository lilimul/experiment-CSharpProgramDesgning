using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week4
{
    public partial class tree : Form
    {
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        Pen pen = Pens.Black;
        void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(
                pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }
        void drawTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        public tree()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            graphics = this.panel1.CreateGraphics();
            // this.CreateGraphics();
            int n = Convert.ToInt32(this.n.Text);
            int leng = Convert.ToInt32(this.leng.Text);
            per1 = Convert.ToDouble(this.per1t.Text);
            per2 = Convert.ToDouble(this.per2t.Text);
            th1 = Convert.ToDouble(this.th1t.Text);
            th2 = Convert.ToDouble(this.th2t.Text);
            Console.WriteLine($"th2 th1");
            drawTree(n, 200, 310, leng, -Math.PI / 2);
        }

        private void btnCclor_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Color cl = this.colorDialog1.Color;
                pen = new Pen(cl);
            }
        }
    }
}

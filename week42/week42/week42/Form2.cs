using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week3;

namespace week42
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            double price = Convert.ToDouble(textBox3.Text);
            goodsFactory.addGoods(name,price);
            Console.WriteLine("Add new good");
        }
    }
}

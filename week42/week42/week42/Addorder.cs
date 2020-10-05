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
using week42;
namespace week42
{
    public partial class Addorder : Form
    {
        public List<OrderDetail> newOrderDetailList;
        public Order newOrder;
        public string odgid
        {
            get;set;
        }
        public string odgcount
        {
            get;set;
        }
        public string oddiscount
        {
            get;
            set;
        }
        public Addorder()
        {
            InitializeComponent();
            newOrderDetailList = new List<OrderDetail>();
            newOrder = new Order();
            gidtxt.DataBindings.Add("Text", this, odgid);
            gcount.DataBindings.Add("Text", this, odgcount);
            gdiscount.DataBindings.Add("Text", this, oddiscount);
        }
       public void addDetail(int gid,int gcount,double discount)
        {
            Console.WriteLine("sdgweg");
            OrderDetail newDetail = new OrderDetail();
            newDetail.goodsCount = gcount;
            newDetail.goodsId = gid;
            newDetail.goodsDiscount = discount;
            newOrderDetailList.Add(newDetail);
            this.oDetailsbindingSource.DataSource = newOrderDetailList;
            Console.WriteLine(newOrderDetailList.Count);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cusText_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  int goodid = Convert.ToInt32(odgid);
            int goodcount = Convert.ToInt32(odgcount);
            double gooddiscount = Convert.ToDouble(oddiscount);*/
            addDetail(4, 5, 6);
            this.oDetailsbindingSource.ResetBindings(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Add new order");
            newOrder.details = newOrderDetailList;
            newOrder.customId = Convert.ToInt32(this.cusText.Text);
            Form1.addOrder(newOrder);
            this.Close();
        }
    }
}

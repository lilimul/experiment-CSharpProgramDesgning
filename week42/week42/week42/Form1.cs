using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week3;

namespace week42
{
    public partial class Form1 : Form
    {
         static OrderService oServe = new OrderService();
        public Form1()
        {
            InitializeComponent();       //工厂增加商品
            goodsFactory.addGoods("goodsa", 1);
            goodsFactory.addGoods("goodsb", 2);
            goodsFactory.addGoods("goodsc", 3);

            //增加订单
            int orderId = oServe.addorder("order1", 1);
            oServe.orderAddDetail(orderId, 0, 3, 0.5);
            oServe.orderAddDetail(orderId, 2, 3, 0.5);
            orderId = oServe.addorder("order2", 2);
            oServe.orderAddDetail(orderId, 0, 3, 0.5);
            oServe.orderAddDetail(orderId, 2, 3, 0.5);
            oServe.orderList[0].listDeatil();
            //Console.WriteLine(oServe.orderList[0].orderTotal);
            Console.WriteLine(oServe.orderList[0].ifHaveGood(2));
            //oServe.orderList.Sort();
            //oServe.queryByOid(2,true);
            //  oServe.queryByCusid(1);
            oServe.queryByGoodId(2);
            Console.WriteLine("Hello World!");

            this.goodsBindingSource.DataSource = goodsFactory.goodsList;
            this.orderQueryBindingSource.DataSource = oServe.queryList;
            this.AllOrderbindingSource.DataSource = oServe.orderList;
            this.orderDetailbindingSource.DataSource = oServe.orderDetailList;
        }

        private void XMLinBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择想要导入的XML文件";
            if (ofd.ShowDialog() == DialogResult.OK)
            { 
                oServe.XMLtoOrder(ofd.FileName);
            }
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public static void addOrder(Order neworder)
        {
            oServe.orderList.Add(neworder);
            return;
        }
        private void QueryBtnId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.queryBoxid.Text);
            int queryindex = oServe.queryByOid(id, true);
            if (queryindex <= 0)
                return;
           this.orderQueryBindingSource.DataSource= oServe.orderList[queryindex];
        }

        private void QueryBtnGid_Click(object sender, EventArgs e)
        {
            int gid = Convert.ToInt32(this.QueryBoxGid.Text);
            oServe.queryByGoodId(gid);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("sssss");
            int index = e.RowIndex;
            oServe.orderDetailList = oServe.orderList[index].orderDetails;
        }

        private void OrderBtnAdd_Click(object sender, EventArgs e)
        {
            Addorder addOrderForm = new Addorder();
            addOrderForm.FormClosed += new System.Windows.Forms.FormClosedEventHandler((s, evnt) =>
            {
                Console.WriteLine("Added");
                this.AllOrderbindingSource.ResetBindings(true);
            });
                
            new Addorder().ShowDialog();
        }

        private void AddOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.AllOrderbindingSource.ResetBindings(true);
        }

        private void OrderDetailList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

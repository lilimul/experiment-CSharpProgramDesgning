using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;  
using System.Xml.Serialization;
using System.Runtime.InteropServices.WindowsRuntime;

namespace week3
{//订单号、商品名称、客户、订单金额
    [Serializable]
   public class Order:IComparable//订单类
    {
        public int OrderId
        {
            get;set;
        }
        public List<OrderDetail> details;
        public List<OrderDetail> orderDetails {
            get { return details; }
        }//订单详情
        public int customId
        {
            get;set;
        }
        public override bool Equals(object obj)//用客户id判断订单是否相等
        {
            Order order  = obj as Order;
            return customId==order.customId;
        }
        public int CompareTo(Object obj2){//让这个元素list可以按照订单id排序
            Order order = obj2 as Order;
            if(order == null)
            throw new Exception("Compare with null order");
            return this.OrderId.CompareTo(order.OrderId);
        }
        // override object.GetHashCode
        public override int GetHashCode()//用于字典排序
        {
            return this.OrderId;
        }
        public bool addDetail(int gid, int count, double discount = 1)//给订单增加商品行
        {
            if (gid > goodsFactory.count)
            {
                Console.WriteLine("Goods not exit with num {0}!", gid);
                return false;
            }
            OrderDetail newDetail = new OrderDetail {};
            newDetail.goodsId = gid;
            newDetail.goodsDiscount = discount;
            newDetail.goodsCount = count;
            if (orderDetails.Contains(newDetail))
            {
                return false;
            }
           /* foreach (OrderDetail od in orderDetails){
                if(od.Equals(newDetail)){
                    return false;
                }
            }*/
            orderDetails.Add(newDetail);
            return true;
            
        }
        public double orderTotal//计算订单总共价格的属性
        {
            get
            {
                double total = 0;
                foreach(OrderDetail order in orderDetails)
                {
                    if(order.goodsId> goodsFactory.count - 1)
                    {
                        continue;
                    }
                    good ordergood = goodsFactory.goodsList[order.goodsId];

                    total += order.goodsCount * ordergood.price * order.goodsDiscount;
                }
                return total;
            }
        }
        public bool ifHaveGood(int gid)//判断订单是否含有某个id的商品
        {
            foreach (OrderDetail order in orderDetails)
            {
                if (order.goodsId == gid)
                {
                    return true;
                }
            }
            return false;
        }
        public Order()//构造函数
        {
            details = new List<OrderDetail>();
        }
        public override string ToString()//字符串化
        {
            return String.Format("Order id:{0},Custom Id:{1},Order count:{2}", OrderId, customId, orderDetails.Count);
        }
        public void listDeatil()//展示订单下属所有的信息
        {
            Console.WriteLine("Here is the detail of order No.{0}", OrderId);
            int index = 1;
            foreach(OrderDetail od in orderDetails)
            {
                String odId = String.Format("Detail No.{0}", index);
                Console.WriteLine(odId+od.ToString());
                index++;
            }
        }
 
    }

    public class OrderDetail//订单的详情，包括商品id和数量
    {
        public int OrderDetailId
        {
            get;set;
        }
        public int goodsId {
            get;set;
        }
        public int goodsCount
        {
            get;set;
        }
        public double goodsDiscount
        {
            get;set;
        }
        public Order Order
        {
            set;get;
        }
     /*   public OrderDetail(int gid,int count,double discount=1)
        {
            goodsId = gid;
            goodsCount = count;
            goodsDiscount = discount;
        }*/
        public override string ToString()
        {
            string orderDetailString = String.Format("goodId:{0},count:{1},discount:{2}", goodsId, goodsCount, goodsDiscount);
            return orderDetailString;
        }
        public void modify(int gid,int count,double discount){//修改订单详情
            goodsId = gid;
            goodsCount = count;
            goodsDiscount = discount;
        }
        public override bool Equals(object obj)//用商品id和数量判断订单内容是否重复
        {
            OrderDetail  od = obj as OrderDetail;
          return od.goodsId==goodsId&&od.goodsCount==goodsCount;
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            return this.goodsId;
        }
    }
    class goodsFactory//记录商品id
    {
        public static List<good> goodsList = new List<good>();
        public static void addGoods(string name, double price)//给工厂增加商品种类
        {
            good newGood = new good(name, price);
            goodsList.Add(newGood);
        }
        public static int count
        {
            get
            {
                return goodsList.Count;
            }
        }
    }
    public class good//商品
    {
        public int goodId//商品主键
        {
            get;set;
        }
        public string name
        {
            get;set;
        }
        public double price
        {
            get;set;
        }
   public  good(string name,double price)
    {
        this.name = name;
        this.price = price;
    }
           public override string ToString()
        {
            return String.Format("Good name:{0},Goode price:{1}",name,price);
        }
    }
    class OrderService//订单服务类
    {
        public List<Order> orderList;
        public List<Order> queryList;

        private int oid;
        public List<OrderDetail> orderDetailList
        {
            get; set;
        }
        public OrderService()//初始化
        {
            orderList = new List<Order>();
            queryList=new List<Order>();
            orderDetailList = new List<OrderDetail>();
            oid =0;
        }
        public void orderToXML(){//把订单转化为xml

            Console.WriteLine("start [pserilaize");
            XmlSerializer xmlseri =  new XmlSerializer(typeof(List<Order>));
            using(FileStream fs = new FileStream("order.xml",FileMode.Create)){
                xmlseri.Serialize(fs, orderList);
            }
            Console.WriteLine(File.ReadAllText("order.xml"));
        }
        public bool XMLtoOrder(String path)//读取xml
        {
            try
            {
                XmlSerializer xmlseri = new XmlSerializer(typeof(List<Order>));
                using (FileStream fs= new FileStream(path, FileMode.Open))
                {
                    orderList = (List<Order>)xmlseri.Deserialize(fs);
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Error occured when trying to read XML File...");
                Console.WriteLine(ex.ToString());
                return false;
            }
            Console.WriteLine("XML read!");
            return true;
        }
        public List<Order> Query(Func<Order, bool> condition)
        {
            var query = orderList.Where(o => condition(o));
            return query.ToList();
        }
        public bool ifHaveOrder(int oid)//检查能否用oid获得订单
        {

            if(queryByOid(oid,false)<0){
                return false;
            }
            return true;
        }
        public void customSort()//个性化排序
        {

        }
        public int addorder(string oName,int cusId)//增加订单
        {
            int oId = oid+1;
            try {
                Order newOrder = new Order { OrderId = oId, customId = cusId};
                foreach(Order o in orderList){
                    if(o.Equals(newOrder)){
                        throw new Exception("Order have existed");
                    }
                }
                orderList.Add(newOrder);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
            Console.WriteLine("New Order");
            oid++;
            return oId;
        }
        public bool deleOrder(int oid)//删除订单
        {
            try { 
                int oinex = queryByOid(oid,false);
            if (oinex<0)
            {
                    throw new Exception("Don't have such order");
                }
            orderList.RemoveAt(oinex);
            Console.WriteLine("Deleted order No.{0}", oid);
            }
            catch
            {
                Console.WriteLine("Dele order error");
                return false;
            }
            return true;
        }
        public bool modifyOrder(int oid,int odid,int gid, int count,double discount = 1)//修改订单
        {
            try { 
                int oinex = queryByOid(oid,false);
            if (oinex<0)
            {
                    throw new Exception("Don't have such order");
                }
                Order order = orderList[oid - 1];

                if (odid > order.orderDetails.Count || odid < 0)
                {
                    throw new Exception("Don't have such order detail");
                }
                if (gid > goodsFactory.count || gid < 0)
                {
                    throw new Exception("Don't have such goods");
                }
                order.orderDetails[oinex].modify(gid,count,discount);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Modify order error");
                return false;
            }
            Console.WriteLine("Order No.{0}'s detail No.{1} have been modyfied.",oid,odid);
            return true;
        }
            public int queryByOid(int oid,bool show){//用订单id查询
            //return orderList.FirstOrDefault(o => o.orderId == oid).orderId;
                if (oid<=0){
                    Console.WriteLine("Not avali oid");
                    return -1;
                }
                for(int i=0;i<orderList.Count;i++){
                    if(orderList[i].OrderId==oid){
                        if(show){
                Console.WriteLine("Query order is showen below:");
                Console.WriteLine(orderList[oid-1].ToString());
                }
                        return i;
                    }
                }
                 Console.WriteLine("Not find order");
                return -2;
            }
            public bool queryByGoodId(int gid){//使用商品id查询订单
                 if (gid > goodsFactory.count || gid < 0)
                {
                   Console.WriteLine("Ivali good id");
                   return false;
                }
var orders = from Order o in orderList where o.ifHaveGood(gid) == true orderby o.orderTotal select o;
            Console.WriteLine("Queryby id order is showen below:");
            foreach(Order o in orders)
            {
                Console.WriteLine(o.ToString());
            }
            return true;
            }
            public bool queryByCusid(int cusid){//使用客户id查询订单
            var orders = from Order o in orderList where o.customId==cusid orderby o.orderTotal select o;
            Console.WriteLine("Query order is showen below:");
            foreach(Order o in orderList){
                Console.WriteLine(o.ToString());
            }
            return true;
            }
                public bool orderAddDetail(int oid,int gid,int count,double discount=1)//订单增加条目
        {
            if (oid > orderList.Count)
            {
                Console.WriteLine("Don't exist order with oid {0}!", oid);
                return false;
            }
            if (gid > goodsFactory.count)
            {
                Console.WriteLine("Don't exist goods with gid {0}!", gid);
                return false;
            }
            return orderList[oid - 1].addDetail(gid, count, discount);
        }
        /*public bool findOrderById(int oid)
        {
            if (oid > orderList.Count||oid<0)
            {
                Console.WriteLine("Don't have this oid");
                return false;
            }

        }*/
    }
  /*  class Program
    {
        
        static void Main(string[] args)
        {
            OrderService oServe = new OrderService();
            //工厂增加商品
            goodsFactory.addGoods("goodsa", 1);
            goodsFactory.addGoods("goodsb", 2);
            goodsFactory.addGoods("goodsc", 3);
            //增加订单
            int orderId  = oServe.addorder("order1",1);
            oServe.orderAddDetail(orderId, 0, 3, 0.5);
            oServe.orderAddDetail(orderId, 2, 3, 0.5);
            oServe.orderList[0].listDeatil();
           //Console.WriteLine(oServe.orderList[0].orderTotal);
            Console.WriteLine(oServe.orderList[0].ifHaveGood(2));
            //oServe.orderList.Sort();
            //oServe.queryByOid(2,true);
          //  oServe.queryByCusid(1);
            oServe.queryByGoodId(2);
            oServe.orderToXML();
            oServe.XMLtoOrder();
            Console.WriteLine("Hello World!");
        }
    }*/
}

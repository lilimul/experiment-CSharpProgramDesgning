using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;

namespace WebApplication1
{
    public class goods
    {
        public string name
        {
            set;get;
        }
        public double price
        {
            set;get;
        }
    }
    public class goodsApi
    {
        public List<goods> goodsList;
        public void addOrder(string name,double price)
        {
            goods newGood = new goods();
            newGood.name = name;
            newGood.price = price;
            goodsList.Add(newGood);
            return;
        }
    }
}

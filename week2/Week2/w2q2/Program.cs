using System;
using System.Collections.Specialized;
using System.Xml.Schema;

namespace w2q2
{

    class node<T>
    {
        public node<T> next;
        public T data;
        public node(T value)
        {
            next = null;
            data = value;
        }
        public bool nextData(ref node<T> nextData)
        {
            if (next != null)
            {
                nextData = next;
                return true;
            }
            else
            {
                nextData = null;
                return false;
            }
        }
    }
    class chain<T>
    {
        private node<T> head;
        private node<T> tail;
        private int length;
        public int Length
        {
            get { return length; }
        }
        public chain() {
            head = tail = null;
            length = 0;
        }
        public node<T> Head
        {
            get { return head; }
        }
        public void addNode(T value)
        {
            node<T> newNode = new node<T>(value);
            if (tail == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
            length++;
            Console.WriteLine("new Node: {0}", newNode.data);
        }
        public void forEach(Action<T> action)
        {
            for (node<T> iter = head; iter != null; iter = iter.next)
            {
                action(iter.data);
            }
        }
        public void showAndjudge(ref int max, ref int min,ref int sum)
        {
            node<T> intNode = Head;
            max = min = (int)(object)Head.data;
            
            while (intNode != null)
            {
                Console.WriteLine(intNode.data);
                if ((int)(object)max < (int)(object)intNode.data)
                {
                    max = (int)(object)intNode.data;
                }
                if ((int)(object)min > (int)(object)intNode.data)
                {
                    min = (int)(object)intNode.data;
                }
                sum += (int)(object)intNode.data;
                intNode = intNode.next;
            }
        }

}
    class Program
    {
        static void Main(string[] args)
        {
            chain<int> intChain = new chain<int>();
            intChain.addNode(1);
            intChain.addNode(2);
            int max, min, sum;
            max =  sum = 0;
            min = 9999999;
            //intChain.showAndjudge(ref max,ref min,ref sum);
            intChain.forEach((data) =>
            {
                if (data > max)
                {
                    max = data;
                }
                if (data < min)
                {
                    min = data;
                }
                sum += data;
                Console.WriteLine($"{data} ");
            });
            Console.WriteLine("Max:{0},Min: {1},Sum: {2}",max,min,sum);
        }
    }
}

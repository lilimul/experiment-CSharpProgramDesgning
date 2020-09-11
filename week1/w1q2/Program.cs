using System;
using System.Collections;

namespace w1q2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            int num = 0;
            Console.WriteLine("Please input the items of array,press enter after each input.");
            while (int.TryParse(Console.ReadLine(), out num))
            {
                list.Add(num);
            }
            if (list.Count == 0)
            {
                Console.WriteLine("Empty array.");
                return;
            }
            Console.WriteLine("Array loaded.");
            //display array and sum it up
            int sum=0;
            Console.Write("The array is:");
            foreach (int listNum in list){
                Console.Write("{0} ",listNum);
                sum+=listNum;
            }
            list.Sort();
            //Show max item
            Console.WriteLine("The max item is: {0}", list[list.Count - 1]);
            //Show min item
            Console.WriteLine("The min item is:{0}", list[0]);
            //Show sum
            Console.WriteLine("The sum is:{0}",sum);
            //Show Average
            Console.WriteLine("The average is:{0}",sum/list.Count);
        }
    }
}

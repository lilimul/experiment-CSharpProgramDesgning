using System;
using System.Collections;

namespace w1q3
{
    class Program
    {
        private static void sieve(int[] list,int factor){
            
        }
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList(); 
            //initialize
            for(int i=2;i<100;i++){
                al.Add(i);
            }
            int prime=0;
            Console.Write("Here are the list of prime numbers: ");
            while(al.Count!=0){
                prime=(int)al[0];
                Console.Write("{0} ",prime);
                for(int i=0;i<al.Count;i++){
                    if((int)al[i]%prime==0){
                        al.RemoveAt(i);
                    }
                }
            }

        }
    }
}

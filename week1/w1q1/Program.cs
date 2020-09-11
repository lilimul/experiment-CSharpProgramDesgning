using System;

namespace w1q1
{
    class Program
    {
        public static bool isPrime(int num){
            //Determine if the num is prime
            double squart = Math.Sqrt(num);
            for(int i=2;i<=squart;i++){
                if(num%i==0)
                return false;
            }
            return true;
        } 
        public static void showPrimeDivisor(int num){
            for(int i=2;i<=num;i++){
                while(num%i==0){
                    num/=i;
                    if(isPrime(i))
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            showPrimeDivisor(5);
        }
    }
}

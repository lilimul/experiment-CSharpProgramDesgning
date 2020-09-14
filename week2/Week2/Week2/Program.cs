using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Dynamic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;

namespace w2q1

{
    interface  geometry
    {
        public bool Legal
        {
            get;
        }
        public double Area
        {
            get;
        }
    };
    class rectangle : geometry
    {
        protected double[] sides = new double[2];
        public double[] Sides
        {
            set
            {
                sides = value;
            }
            get
            {
                return sides;
            }
        }
        public bool Legal
        {
            get
            {
                return sides[0] > 0 && sides[1] > 0;
            }
        }
        public double Area
        {
            get
            {
                return sides[0] * sides[1];
            }
        }
        public rectangle(double side1,double side2)
        {
            double[] sides = { side1, side2 };
            this.sides = sides;
        }
    }
    class square: geometry
    {
        protected double side;
        public double Side
        {
            set
            {
                side = value;
            }
            get
            {
                return side;
            }
        }
        public bool Legal
        {
            get
            {
                return side > 0;
            }
        }
        public double Area
        {
            get
            {
                return side * side;
            }
        }
        public square(double side)
        {
            this.side = side;
        }
    }
    class tri : geometry
    {
        protected double[] sides = new double[3];
        public double[] Sides
        {
            get
            {
                return sides;
            }
            set
            {
                sides = value;
            }
        }
        public bool Legal
        {
            get
            {
                double a = sides[0];
                double b = sides[1];
                double c = sides[2];
                foreach (double side in sides)
                {
                    if (side <= 0)
                        return false;
                }
                if ((a + b > c) && (a + c > b) && (b + c > a) && (Math.Abs(a - b) < c) && (Math.Abs(c - b) < a) && (Math.Abs(c - a) < b))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public double Area
        {
            get
            {
                double a = sides[0];
                double b = sides[1];
                double c = sides[2];
                double p = 0.5 * (a + b + c);
                return Math.Sqrt((p*(p-a)*(p-b)*(p-c)));
            }
        }
        public tri(double a,double b,double c)
        {
            double[] sides = { a, b, c };
            this.sides = sides;
        }
    }
    class geometryFactory
    {
        Random random;
        public geometryFactory()
        {
            Console.WriteLine("Shape Factory constructed!");
            random = new Random();
        }
        public geometry createGeometry()
        {
            random = new Random();
            int randNum = random.Next(0, 3);
            switch (randNum)
            {
                case 0:
                    //new triangle
                    int a = random.Next(1, 10);
                    int b = random.Next(1, 10);
                    int c = random.Next(1, 10);
                    tri newTri = new tri(a,b,c);
                    Console.WriteLine("New triangle with sides:{0},{1},{2}", a, b, c);
                    return newTri;
                case 1:
                    //new square
                    int side = random.Next(10);
                    square newsquare = new square(side);
                    Console.WriteLine("New square with side:{0}", side);
                    return newsquare;
                case 2:
                    //new rectangle
                    int side1 = random.Next(10);
                    int side2 = random.Next(10);
                    rectangle newrectan = new rectangle(side1, side2);
                    Console.WriteLine("New rectangle with side:{0},{1}", side1,side2);
                    return newrectan;
                default:
                    //new square
                    return new square(1);
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            geometryFactory geofac = new geometryFactory();
            double areaSum = 0;
            for(int i = 0; i < 20; i++)
            {
                geometry newGeo= geofac.createGeometry();
                if (newGeo.Legal)
                {
                    Console.WriteLine("size{0}", newGeo.Area);
                    areaSum += newGeo.Area;
                }
            }
            Console.WriteLine("Finish!{0}", Math.Round(areaSum,2));
        }
    }
}

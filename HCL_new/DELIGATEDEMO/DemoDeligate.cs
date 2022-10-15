using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.DELIGATEDEMO
{
    public delegate int Mydell(int a);
    public delegate void Mydeli();
    public delegate int myDel(int a, string m);
   
    class DemoDeligate
    {
       public static int Square(int a)
        {
            Console.WriteLine("In Square method");
            return a * a;
        }

        public static int Cube(int a, string b)
        {
            Console.WriteLine("In Cube");
            return a * a * a;
        }
        public static void Greet()
        {
            Console.WriteLine("Good Morning");
        }
    }
    class Del
    {
        static void Main(string[] args)
        {
            DemoDeligate d = new DemoDeligate();
           Mydeli m = DemoDeligate.Greet;
           // Mydeli m = d.Greet;
            m();

            Mydell md = DemoDeligate.Square;
            int ans = md(14);
            
            myDel m1 = DemoDeligate.Cube;
            int c = m1(3, "shree");
        }
    }
}

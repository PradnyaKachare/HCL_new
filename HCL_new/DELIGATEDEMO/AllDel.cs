using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace HCL_new.DELIGATEDEMO
{
    //declare the delegate
    //target set
    //invoke
    //int a=10;
    //int *ptr;
    //ptr=&a;
    public delegate int mydel1(int c);
    public delegate void mydel2();
    public delegate int mydel3(int a, string m);

    class AllDel
    {
        public static int square(int a)
        {
            Console.WriteLine("in square method");
            return a * a;
        }

        public static int cube(int a, string b)
        {
            Console.WriteLine("in cube");
            return a * a * a;
        }

        public static void greet()
        {
            Console.WriteLine("Good Morning");
        }
        static void Main(string[] args)
        {
            Func<int, string, int> d1 = cube;
            d1(11, "om");

        }
    }
   /* class DDD
    {
        static void Main(string[] args)

        {
            //  Class13.cube(2, "dsf");
            Class13 ob = new Class13();

            mydel1 d1 = Class13.square;
            int ans = d1(12);
            mydel3 d2 = Class13.cube;
            int c = d2(3, "om");

            Console.WriteLine(ans);

        }
    }*/

    class DemoDel
    {
        static bool isEven(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Func<int, bool> d = isEven;
            bool b = d(13);

            Predicate<int> p = isEven;
            bool x = p(12);
        }
    }

   
    }

    public delegate int del6(int a, int b);
    class Demo3
    {
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static void Add(int a, int b)
        {
            Console.WriteLine("Addition " + (a + b));

        }

        static int square(int c)
        {
            return c * c;
        }
    static void Main(string[] args)
    {

    
            //lambda

            del6 e = (a, b) =>
            {
                Console.WriteLine("in lambda");
                return a * b;
            };
            int result = e(4, 5);
            Console.WriteLine(result);


           /* mydel5 f = (a, b) => Console.WriteLine("Additiomn:" + (a + b));
            f(3, 4);

            mydel1 sq = (a) => a * a;
            int r2 = sq(6);
            Console.WriteLine(r2);*/


        }
    }

    class T
    {
        static void m1(float a, int b)
        {
            Console.WriteLine("SQuare:" + (a * b));
        }

        static void Main(string[] args)
        {
            //void Action(16 input) --generics
            Action<float, int> a = (a, b) => Console.WriteLine(a + b);
        }
    }
    //Built 3 delgates
    //Func---store reference of function has return type and may 0 to 16 parameter
    //Action===>tore reference of function has void return type and may 0 to 16 parameter
    //Predicate===>reference whose return is bool and whicj 0 to 16 parameters


    //void add(int a,int b) void
    // int multiply(int a,int b)
    // bool isLeapyear(int yy)

    class ASD
    {
        static void greet()
        {
            Console.WriteLine("Happy morning");
        }

        //callback function
        static void m2(int a, Action act)
        {
            Console.WriteLine("Sq:" + a * a);
            act();
        }
        static void m2(List<int> lst, Predicate<int> p)
        {

        }

        static bool iseven(int b)
        {
            Console.WriteLine("in iseven function call :" + b);
            if (b % 2 == 0)
                return true;
            else
                return false;

        }
        static void print(int d)
        {
            Console.WriteLine(d);
        }
        static void Main(string[] args)
        {


            List<int> al = new List<int>() { 12, 56, 77, 88, 99, 90, 101 };
            al.ForEach(print);

            List<int> newlist = al.FindAll(iseven);
        }
    }

    




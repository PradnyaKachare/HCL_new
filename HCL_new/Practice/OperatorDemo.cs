using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.Practice
{
    internal class OperatorDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int sum = n1 + n2;
            Console.WriteLine($"Addition is {sum}");
        }

    }
    class Postfix
    {
        static void Main(string[] args)
        {
            int a = 10, b, c;
            b = a++; // postfix  b= 10  a=11
            c = ++a; // prefix   a=12  c=12

            int n1 = 10, n2, n3;
            n2 = n1--;  // n2=10   // n1=9
            n3 = --n1;  //  n1=8  n3=8

            Console.WriteLine($"value of a {a} value of b {b} value of c{c}");

            Console.WriteLine($"value of n1 {n1} value of n2 {n2} value of n3  {n3}");


            int x = 10;

            //Console.WriteLine($"{ a++}  {a++}  {++a} ");

            Console.WriteLine($"{x++}  {--x} {--x} {x++} {++x} ");

            int p = 5, q = 2, z;

            z = p * q + (p++ + --q) - q;
            //  5* 2 +(5 + 1)-1;
            //5*2+6-1
            //10+6-1
            //16-1
            //15
            Console.WriteLine(z);

        }
        class Ternary
        {
            static void Main(string[] args)
            {
                int a = 10, b = 15;
                //expression ? a(true) : b (false)
                int c = (a > b) ? a : b;
                Console.WriteLine(c);
            }


            class Greater
            {
                static void Main(string[] args)
                {
                    int age = 16;

                    if (age >= 18)
                    {
                        Console.WriteLine("Person can vote");
                    }
                    else
                    {
                        Console.WriteLine("Person can not vote");
                    }
                }


            }
        }
    }
       
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.Practice
{
    internal class Logic
    {
        static void Main(string[] args)
        {
            // find the number is even or odd number using if ... else
            // find the year is leap year
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 4 == 0)
            {
                Console.WriteLine("Leap year");
            }
            else
            {
                Console.WriteLine("not leap year");
            }
        }

        class Positive
        {
            static void Main(string[] args)
            {
                int num = -10;
                if (num > 0)  // first condition -> true
                {
                    Console.WriteLine("number is +ve");
                }
                else if (num < 0) // true
                {
                    Console.WriteLine("number is -ve");
                }
                else
                {
                    Console.WriteLine("number is zero");
                }
            }

            class Greater
            {
                static void Main(string[] args)
                {
                    // find out greatest from 3
                    int n1 = 20, n2 = 78, n3 = 145;

                    if (n1 > n2)
                    {
                        if (n1 > n3)
                        {
                            Console.WriteLine($"{n1} is greast number");
                        }
                        else
                        {
                            Console.WriteLine($"{n3} is greast numer");
                        }
                    }
                    else
                    {
                        if (n2 > n3)
                        {
                            Console.WriteLine($"{n2} is greast numer");
                        }
                        else
                        {
                            Console.WriteLine($"{n3} is greast numer");
                        }
                    }

                    //if(n1>n2 && n1 > n3)
                    //{
                    //    Console.WriteLine($"{n1} is greast numer");
                    //}
                    //if(n2>n1 && n2 > n3)
                    //{
                    //    Console.WriteLine($"{n2} is greast numer");
                    //}
                    //if(n3>n1 && n3 > n2)
                    //{
                    //    Console.WriteLine($"{n3} is greast numer");
                    //}
                }


            }
        }
    }
}

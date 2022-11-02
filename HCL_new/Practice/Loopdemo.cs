using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.Practice
{
    internal class Loopdemo
    {
        static void Main(string[] args)
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        // 1. print numbers from 1- 50
        // 2. print even numbers from 1-20
        // 3. print odd numbers from 100-50 in reverse order
        //4. accept a number from user & print the arithmetic table
        //5. print numbers from 1- 100 which are divisible by 5

        // 6. accept the number from user & find the factorial
        // 7. print the fibonacci series-> number of digits in o/p 7

    }
    class Whiledemo
    {
        static void Main(string[] args)
        {
            int n, n1 = 0, n2 = 1, n3;
            int i = 2;
            Console.WriteLine("Enter a upper limit");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{n1}  {n2}");
            while (i < n)
            {
                n3 = n1 + n2;
                Console.Write($" {n3}");
                n1 = n2;
                n2 = n3;

                i++;
            }


        }
    }

    class DoWhiledemo
    {
        static void Main(string[] args)
        {
            int n, n1 = 0, n2 = 1, n3;
            int i = 2;
            Console.WriteLine("Enter a upper limit");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{n1}  {n2}");
            do
            {
                n3 = n1 + n2;
                Console.Write($" {n3}");
                n1 = n2;
                n2 = n3;

                i++;
            } while (i < n);


        }
    }
    class Nestingfordemo
    {
        static void Main(string[] args)
        {
            // for loop

            for (int i = 1; i <= 4; i++) // row
            {
                for (int j = 1; j <= 5; j++) // column
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
    }


    

    
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new
{
    class cucuDemo
    {
        // A hash table that implements the Cuckoo Hashing algorithm for
        // resolving keys-collisions.


        int coo(int s)
        {
            if (s == 1)
            {
                s = 0;
            }
            if (s == 2)
            {
                s = 1;
            }

            return s;
        }
        static void Main(string[] args)
        {
            cucuDemo ck = new cucuDemo();
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 0;
           
            if (n == 1)
            {
                Console.WriteLine("0");
            }
            else if (n == 2)
            {
                Console.WriteLine("1");
            }
            else if (n > 2)
            {
                c = 1 * ck.coo(n - 1) + 2 * ck.coo(n - 2) + 3 * 1;

                Console.WriteLine(c);
            }
        }
    }
}



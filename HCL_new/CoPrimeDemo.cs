using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new
{
    class CoPrimeDemo
    {
        //find only 1 is common factor.
        static public int CoPrime(int n)
        {
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                int fact = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (n % j == 0 && i % j == 0)
                    {
                        fact++;
                    }

                }
                if (fact == 1)
                    c++;

            }
            return c;
        }
        public static void Main(string[] args)
        {
            int result = CoPrime(9);
            Console.WriteLine(result);
        }
    }
}

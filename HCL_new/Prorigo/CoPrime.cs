using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL_new.Prorigo
{
    class CoPrime
    {
        //find the number of coPrime of given number
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int gcd = 0;
            int c = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0 && n % j == 0)
                    {
                        gcd = j;
                    }
                }

                if (gcd == 1)
                {
                    c++;
                }

            }
            Console.WriteLine("Number of CoPrime number" + c);

        }

    }
}

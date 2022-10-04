using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL_new.Prorigo
{
    class Cucko
    {
        public int Cucu_seq(int input1)
        {
            int c = 0;
            // int cu1 = 0;
            // int cu2 = 1;

            if (input1 == 1)
            {
                Console.WriteLine("0");
            }
            else if (input1 == 2)
            {
                Console.WriteLine("1");
            }
            else if (input1 > 2)
            {
                c = 1 * Cuckoo(input1 - 1) + 2 * Cuckoo(input1 - 2) + 3 * 1;

                // Console.WriteLine(c);
            }
            return c;
        }
        int Cuckoo(int s)
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
            Cucko ck = new Cucko();
            int n = Convert.ToInt32(Console.ReadLine());

        }
    }

}

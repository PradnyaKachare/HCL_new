using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL.String
{
    internal class Arithmatic_progression
    {
        static void Main(string[] args)
        {
            Progration(3, 7, 8);
        }
        public static void Progration(int t2, int t3, int n)
        {
            int diff = t3 - t2;
            int t4 = t3;

            for(int i = 4; i < n; i++)
            {
                t4=t4 + diff;
            }
            Console.WriteLine(t4);
        }
       
    }


}

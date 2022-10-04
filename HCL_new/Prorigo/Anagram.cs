using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL_new.Prorigo
{
    class Anagram
    {
        public static string mutation(string s1, string s2)
        {
            char[] a1 = s1.ToLower().ToCharArray();
            char[] a2 = s2.ToLower().ToCharArray();
            Array.Sort(a1);
            Array.Sort(a2);

            string res1 = new string(a1);

            string res2 = new string(a2);
            string str = "";

            if (res2.Length > res1.Length)
            {
                str = res2.Substring(0, res1.Length);
            }
            else if (res1.Length > res2.Length)
            {
                str = res1.Substring(0, res2.Length);
            }
            else if (res1.Length == res2.Length & res1 == res2)
            {
                str = res1;
            }
            if (res1 == str)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            mutation(s1, s2);
        }
    }
}








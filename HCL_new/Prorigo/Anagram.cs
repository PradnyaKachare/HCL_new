using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL_new.Prorigo
{
    class Anagram
    {
            static void Main(string[] args)
            {
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();

                if (s1.Length == s2.Length)
                {
                    char[] a1 = s1.ToCharArray();
                    foreach (char ch in a1)
                    {
                        //Deepa
                        int idx = s2.IndexOf('z');
                        if (idx != -1)
                        {
                            s2 = s2.Substring(0, idx) + s2.Substring(idx + 1);

                        }
                    }
                    if (s2.Length == 0)
                        Console.WriteLine("Anagram");
                    else
                        Console.WriteLine("Not");
                }
                else
                    Console.WriteLine("Not anagaram");
            }
        }
}

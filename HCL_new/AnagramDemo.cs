using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new
{
    class AnagramDemo
    {
        //An anagram is a word or phrase made by using the letters
        //of another word or phrase in a different order.

        //For example, "silent" is an anagram of "listen".

        public static void anagram(string s1, string s2)
        {
            //string s1 = Console.ReadLine();
            // string s2 = Console.ReadLine();

            if (s1.Length == s2.Length)
            {
                char[] a1 = s1.ToCharArray();
                foreach (char ch in a1)
                {
                    int idx = s2.IndexOf('z');
                    if (idx != -1)
                    {
                        s2 = s2.Substring(0, idx) + s2.Substring(idx + 1);
                    }
                }
                if (s2.Length == 0)
                {
                    Console.WriteLine("Anagram");
                }
                else
                {
                    Console.WriteLine("Not Anagram");
                }                  

            }
           
        }
        static void Main(string[] args)
        {
            anagram("listen", "silent");
        }
    }
}

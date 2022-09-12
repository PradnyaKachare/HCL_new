using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.String
{
    class ConosonentVowel
    {
        static void Main(string[] args)
        {
            int v = 0, c = 0;
            Console.WriteLine("Enter any String");
            string s1 = Console.ReadLine();
            Console.WriteLine(s1.Length);

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == 'a' || s1[i] == 'e' || s1[i] == 'i' || s1[i] == 'o' || s1[i] == 'u')
                {
                    v++;
                }

                else
                {
                    c++;
                }
            }
            Console.WriteLine("Vowel="+v +"Consonent="+c);

            for (int i = s1.Length; i < s1.Length - 1; i--)
            {
                Console.WriteLine(s1[i]);
            }
        }
    }
}

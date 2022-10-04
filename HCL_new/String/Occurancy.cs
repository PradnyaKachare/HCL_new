using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.String
{
    class Occurancy
    {
        static int CountOccurrences(string str, string word)
        {            // split the string by spaces
            string[] a = str.Split(' ');
            // search for pattern in string
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                // if match found increase count
                if (word.Equals(a[i]))
                    count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string word = Console.ReadLine();
            /*string str = "India is my country and India is the best ";
            string word = "India"; */
            Console.Write(CountOccurrences(str, word));
        }
    }
}

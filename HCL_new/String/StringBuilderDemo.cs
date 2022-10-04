using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.String
{
    //String Builder sort Method to sort data.
    class StringBuilderDemo : IComparer<StringBuilder>
    {
        public int Compare(StringBuilder sb1, StringBuilder sb2)
        {
            string s1 = sb1.ToString();
            string s2 = sb2.ToString();

            return s1.CompareTo(s2);

        }
    }
    class MySortStringBuilder
    {
        static void Main(string[] args)
        {

            List<StringBuilder> lst = new List<StringBuilder>();

            lst.Add(new StringBuilder("Pradyna"));

            lst.Add(new StringBuilder("Komal"));

            lst.Add(new StringBuilder("Rituja"));

            lst.Add(new StringBuilder("Priyashree"));

            lst.Sort(new StringBuilderDemo());

            foreach (StringBuilder ob in lst)
            {

                Console.WriteLine(ob);
            }
        }
    }
}




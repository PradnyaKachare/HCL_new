using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.CollectionDemo
{
    class SortListDemo
    {
        static void Main(string[] args)
        {
            //underlying tis arry growable
            List<string> lst = new List<string>();

            lst.Add("Amey");
            lst.Add("Om");
            lst.Add("Priya");
            lst.Add("Riya");
            lst.Add("Pratik");
            //      lst.Insert(1, "Pranav");

            //sorting
            lst.Sort();
            foreach (string s in lst)
            {
                Console.WriteLine(s + "  ");
            }
        }
    }
}

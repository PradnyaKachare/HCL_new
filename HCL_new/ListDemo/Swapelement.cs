using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.CollectionDemo
{
    // 3.	WAP of swap two elements in an List
    class Swapelement
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>();

            lst.Add("Amey");
            lst.Add("Om");
            lst.Add("Priya");
            lst.Add("Riya");
            lst.Add("Pratik");

            //swaping 1position to another position

            string t = lst[0];
            lst[0] = lst[1];
            lst[1] = t;


            Console.WriteLine("Swaping list");
            foreach (string s in lst)

                Console.WriteLine(s);

        }
    }
}

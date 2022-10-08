using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.CollectionDemo
{

    //8.	WAP to print list in reverse order.
    class ReverseElement
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>();

            lst.Add("Amey");
            lst.Add("Om");
            lst.Add("Priya");
            lst.Add("Riya");
            lst.Add("Pratik");

          //  Console.WriteLine(lst[0]);  //index wise print element

            for (int i = 0; i < lst.Count; i++)
            {
                Console.Write(lst[i] + "   ");
            }
            Console.WriteLine();


            Console.WriteLine("Reverse Element");

            for (int i = lst.Count - 1; i >= 0; i--)
            {
                Console.Write(lst[i] + "   ");
            }

        }
    }
}

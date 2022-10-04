using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.CollectionDemo
{
    class DeleteElement
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>();

            lst.Add("Amey");
            lst.Add("Om");
            lst.Add("Priya");
            lst.Add("Riya");
            lst.Add("Pratik");


            Console.WriteLine("List of Given");

            foreach (string s in lst)
            {
                Console.Write(s + " , ");
            }
            Console.WriteLine();

            Console.WriteLine("\n List of Deleted element");

            //lst.Clear();                  //clear

            // lst.RemoveRange(1, 3);        //removerange

            // lst.RemoveAt(1);

            lst.Remove("Riya");

            for (int i = 0; i < lst.Count; i++)
            {
                Console.Write(lst[i] + "  , ");
            }


        }
    }
}

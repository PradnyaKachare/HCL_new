using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.CollectionDemo
{
    class LinkedLisDemo
    {
        static void Main(string[] args)
        {
            LinkedList<int> l = new LinkedList<int>();
            l.AddLast(100);
            l.AddLast(200);
            l.AddLast(300);
            l.AddFirst(2000);
            foreach (int list in l)
            {
                Console.WriteLine(list);
            }
        }
    }
}

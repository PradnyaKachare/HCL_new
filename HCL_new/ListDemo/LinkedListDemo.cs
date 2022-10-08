using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HCL_new.String
{
    class LinkedListDemo
    {
        static void Main(string[] args)
        {
            LinkedList<int> lst = new LinkedList<int>();

            lst.AddFirst(90);
            lst.AddLast(89);
            lst.AddLast(82);
            lst.AddLast(32);
            lst.AddLast(52);

            LinkedListNode<int> node = lst.Find(89);

            if (node != null)

                lst.AddBefore(node, 100);

            lst.Remove(32);

            foreach (int data in lst)

                Console.WriteLine(data);

            //Console.WriteLine(lst. ElementAt(4));

            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst.ElementAt(i));
            }
        }
    }
}

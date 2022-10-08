using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.StackDemo
{
    class DemoQueqe
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();

            q.Enqueue(10);              //insert
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            q.Enqueue(50);

             int d = q.Dequeue();    //delete
             Console.WriteLine(d);

           // Obtain the topmost element of my_queue
            /*int p = q.Peek();
            Console.WriteLine(p);*/

            foreach (int element in q)
            {
                Console.WriteLine(element);
            }
        }
    }
}

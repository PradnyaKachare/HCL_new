using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HCL_new
{
    class QueqeDemo
    {
        static public void Main()
        {
            //15.WAP to create a Queue to add 5 objects and also remove 
                //first two and iterate over it.         

            Queue my_queue = new Queue();

            // Adding elements in Queue  Using Enqueue() method
            my_queue.Enqueue("GFG");
            my_queue.Enqueue(1);
            my_queue.Enqueue(100);
            my_queue.Enqueue(null);
            my_queue.Enqueue(2.4);
            my_queue.Enqueue("Geeks123");

            Console.WriteLine("Total elements present in my_queue: {0}", my_queue.Count);
            my_queue.Dequeue();
            my_queue.Dequeue();
            // After Dequeue method
            Console.WriteLine("Total elements present in my_queue: {0}", my_queue.Count);


            // Remove all the elements from the queue
            //my_queue.Clear();

            // After Clear method
           // Console.WriteLine("Total elements present in my_queue: {0}", my_queue.Count);


            // Accessing the elements of my_queue Queue Using foreach loop
            foreach (var ele in my_queue)
            {
                Console.WriteLine(ele);
            }

            // present in the Queue or not
            if (my_queue.Contains("Geeks123") == true)
            {
                Console.WriteLine("Element available...!!");
            }
            else
            {
                Console.WriteLine("Element not available...!!");
            }
        }
    }
}

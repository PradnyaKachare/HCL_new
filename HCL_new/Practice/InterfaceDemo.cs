using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.Practice
{
    interface Imovable
    {
        //int x=12;                   //Interface Not Allowed non static member

        static int y = 90;

        public void Move();
        /*static void show();
        public int Add();*/

    }
    class Bus : Imovable
    {
        public void Move()
        {
            Console.WriteLine("Bus Is Moving" + Imovable.y);   //Variable access by using interface name
        }
        /*static void show()
        {
            Console.WriteLine("Show method");
        }
        public int Add()
        {
            return 2 + 3;
        }*/
    }


    class InterfaceDemo
    {
        static void Main(string[] args)
        {
            /*Bus b = new Bus();
            b.Move();
*/
            Imovable i = new Bus();
            i.Move();

            //Console.WriteLine( i.Add());
            //Imovable.Show();
        }
    }
}

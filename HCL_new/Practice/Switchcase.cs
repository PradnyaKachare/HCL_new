using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.Practice
{
    internal class Switchcase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. for Eng");
            Console.WriteLine("2. for Hindi");
            Console.WriteLine("3. for Marathi");
            Console.WriteLine("select your option");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("You have selected Eng lang");
                    break;
                case 2:
                    Console.WriteLine("You have selected Hindi lang");
                    break;
                case 3:
                    Console.WriteLine("You have selected Marathi lang");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}

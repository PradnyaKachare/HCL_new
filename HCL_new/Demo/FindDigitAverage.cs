using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.Demo
{
    class FindDigitAverage
    {
        public static void Main()
        {
            int i, n, sum = 0;
            double avg;

            Console.Write("Read 10 numbers and calculate sum and average:\n");
            // Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            // Console.Write("Input the 10 numbers : \n");
            for (i = 1; i <= 5; i++)
            {
                Console.Write("Number-{0} :", i);

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            avg = sum / i;


            Console.Write("The sum of 10 no is : {0}\nThe Average is : {1}\n", sum, avg);
        }
    }

}

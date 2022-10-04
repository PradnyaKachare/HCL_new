using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new
{
    class LarestArrayDemo
    {
        //find lage sub Array.
        static public void SubArry(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int j;
            int max = 0;
            int zero, ones = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                zero = 0;
                ones = 0;
                for (j = i; j < arr.Length; j++)
                {
                    if (arr[j] == 0)
                        zero++;
                    else
                        ones++;

                    if (zero == ones)
                    {
                        max = max > (j - i + 1) ? max : j - i + 1;
                    }
                }
            }
            Console.WriteLine(max);
        }


        static void Main(string[] args)
        {
            /* int size = int.Parse(Console.ReadLine());
             int[] arr = new int[size];*/
            int[] arr = { 1, 1, 0, 1, 0, 0, 1, 0, 1, 0 };

        }
    }
}

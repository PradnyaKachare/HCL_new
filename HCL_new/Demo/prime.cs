using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.Demo
{
    class Prime
    {
        // C# program to find sum of// primes in given array.
        // Function to find count of prime
        static void Main(string[] args)
        {
            //int[] nums = new int[5];
            //int[] nums1 = new int[5];
            int[] nums = { 7, 5, 85, 9, 11, 23, 18 };
            //Console.WriteLine("Original array elements:");
            // Console.WriteLine($"{string.Join(", ", nums)}");
            Console.WriteLine("Sum of all prime numbers in the said array: " + Test(nums));
            // int[] nums1 = { 200, 300, 250, 151, 162 };
            //Console.WriteLine("\nOriginal array elements:");
            //Console.WriteLine($"{string.Join(", ", nums1)}");
            //Console.WriteLine("Sum of all prime numbers in the said array: " + test(nums1));
        }
        public static int Test(int[] arr)
        {
            int result = 0;
            foreach (int number in arr)
            {
                if (IsPrime(number, number / 2))
                {
                    result = result + number;
                }
            }
            return result;
        }
        static bool IsPrime(int n1, int i)
        {
            if (i == 1)
            {
                return true;
            }
            else
            {
                if (n1 % i == 0)
                    return false;
                else
                    return IsPrime(n1, i - 1);
                //calling the function IsPrime itself recursively
            }
        }
    }
}



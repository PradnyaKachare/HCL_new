using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCL.Prorigo
{
    class Subarray
    {
            static void Main(string[] args)
            {
                //Accept Size
                int size = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[size];
                //Accept data
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());

                }

                int j;
                int max = 0;
                int zero, ones;

                //Find Largest subarray length have equal zero and one 

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
        }

    }


using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.String
{
    class RemoveDuplicate
    {
        /*  public void Display(string a)
          {
              for(int i=0;i<a.Length;i++)
              {
                  for (int k = 0; k >= 0; k--)
                  {
                      bool flag = true;
                      if (a[k] == a[i])
                      {
                          flag = false;
                          break;
                      }
                  }   
                  if(flag==)
                  {
                      Console.WriteLine(a[i]);
                  }


              }
          }*/
      
       /* static void Main(string[] args)
        {
            string nm = Console.ReadLine();
           // string nm = "Shaurya";
            string s2 = "";
            //bool b = true;
           // Console.WriteLine(!b);
            foreach (char ch in nm)
            {
                if (!s2.Contains(ch))
                {
                    s2 = s2 + ch;
                }

            }
            Console.WriteLine(s2);
        }*/

        public void Display(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                bool flag = true;
                for (int k = i; k >= 0; k++)
                {
                    if (a[k] == a[i])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }
}



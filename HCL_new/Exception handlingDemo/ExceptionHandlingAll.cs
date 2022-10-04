using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.Exception_handlingDemo
{
    /* class ExceptionHandlingAll
     {
         static string s;
         static int k;
         int x;
         static void Main(string[] args)
         {
             Console.WriteLine("Enter 2 number");
             try                         //code which might throw Error
             {
                 Console.WriteLine(s);
                 int a = int.Parse(Console.ReadLine());
                 int b = int.Parse(Console.ReadLine());
                 Console.WriteLine(a + b); 
                 try
                 {
                     Console.WriteLine("Division"+a/b);
                 }
                 catch (DivideByZeroException e)     //handler block
                 {
                     Console.WriteLine(e.Message);
                 }
                 Console.WriteLine("Try Ends");
             }
             catch(FormatException e)
             {
                 Console.WriteLine("Please Enter a Valid Number"+ e.Message);
             }
             catch(OverflowException e)
             {
                 Console.WriteLine("Number Too Big"+ e.Message);
             }

             catch(SystemException e)
             {
                 Console.WriteLine(e.Message);
             }
             finally     //it execute always irrespective of exception
             {
                 Console.WriteLine("");
             }
             for(int i=1;i<=20;i=i+2)
             {
                 Console.WriteLine(i);
             }
             SystemException ee = new NullReferenceException();
         }
     }*/
}

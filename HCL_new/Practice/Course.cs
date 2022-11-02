using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.Practice
{
    internal class Course
    {
      //  Student class with roll no, name, per  -> use properties to initialize values & retrieve it
        
        private int id;
            private string name;
            private double fees;

            // use property to assign & retrieve value from the data member
            public int Id
            {
                get { return id; }
                set { id = value; } // value is a built in keyword which assign value
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public double Fees
            {
                get { return fees; }
                set { fees = value; }
            }
        

        static void Main(string[] args)
        {
            // property initializer syntax
            Course c1 = new Course();
            c1.Id = 1;   // set accessor get called & assign the value
            c1.Name = "C#";
            c1.Fees = 20000;

            Console.WriteLine($"Id {c1.Id} {c1.Name} {c1.Fees}");

            // object initializer syntax
            Course c2 = new Course { Id = 2, Name = "Java", Fees = 20000 };

            Console.WriteLine($"Id {c2.Id} {c2.Name} {c2.Fees}");

        }

    }
}

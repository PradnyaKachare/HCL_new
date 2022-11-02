using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace HCL_new.Practice
{
    internal class Manager : Employe
    {
       
            private double ta;
              int bs;
/*
            public Manager() : base() // call constructor
            {
                ta = 0.0;
            }*/
            public Manager(string name, double bs, double pt, double ta) : base(name, bs, pt) // call constructor of base class
            {
                this.ta = ta;
            }

           /* public override void CalculateSalary()
            {
               int hra = bs * 0.40;
               int da = bs * 0.20;
               int pf = bs * 0.12;
              int total = bs + hra + da + ta;
               int netpaid = total - (pf + pt);
            }*/
           /* public override string ToString()
            {
                return $"Manager Id {id} Manager name {name} , total salary {total} & Net paid {netpaid}";
            }*/
                     

        static void Main(string[] args)
        {
            //Manager m1 = new Manager("managar1", 45000, 250, 5000);
            //m1.CalculateSalary();
            //Console.WriteLine(m1);

            Employe e1 = new Manager("managar2", 43000, 250, 5000);
            // association of method with object does at run time
            e1.CalculateSalary(); // runtime polymorphism
            Console.WriteLine(e1);

            Employe e2 = new Employe("emp1", 34000, 200);
            e2.CalculateSalary();
            Console.WriteLine(e2);
        }

    }
}

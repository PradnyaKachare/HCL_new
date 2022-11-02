using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.Practice
{

    public class Employe
    {
        private int id;
        private static int count = 0;
        private string name;
        private double bs, hra, da, pt, pf, total, netpaid;
        public Employe(string name, double bs, double pt)
        {
            count++;
            id = count;
            this.name = name;
            this.bs = bs;
            this.pt = pt;
        }
        public static int DisplayCount() // static
        {
            return count;
        }
        public void CalculateSalary() // instance / object method
        {
            hra = bs * 0.40;
            da = bs * 0.20;
            pf = bs * 0.12;
            total = bs + hra + da;
            netpaid = total - (pf + pt);
        }
        public string Print()
        {
            return $"EMployee Id {id} Employee name {name} , total salary {total} & Net paid {netpaid}";
        }


        static void Main(string[] args)
        {

            Employee emp1 = new Employee("test1", 27000, 200);
            emp1.CalculateSalary();
            Console.WriteLine(emp1.Print());

            Employee emp2 = new Employee("test2", 27500, 200);
            emp2.CalculateSalary();
            Console.WriteLine(emp2.Print());

            Employee emp3 = new Employee("test2", 24500, 200);
            emp3.CalculateSalary();
            Console.WriteLine(emp3.Print());

            Console.WriteLine(Employee.DisplayCount());// class method
        }
    }

        internal class StaticDemo
        {
            static void Main(string[] args)
            {

            }
        }


}

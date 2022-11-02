using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.Practice
{
    internal class DateDemo
    {
        int day, year;
        string month;

        // create a method to assign values to the data member
        public void AssignValue()
        {
            day = 13;
            month = "Sept";
            year = 2022;
        }
        // method to display values
        public string DisplayValue()
        {
            return $"Date is :{day} / {month} / {year}";
        }



        static void Main(string[] args)
        {
            // create object of Date class
            DateDemo date = new DateDemo();
            date.AssignValue();  // call to the method
            //string data = date.DisplayValue();
            //Console.WriteLine(data);
            // OR
            Console.WriteLine(date.DisplayValue());
        }
    }

    public class Date
    {
        private int day, year;
        private string month;

        public Date()
        {
            day = 1;
            month = "Jan";
            year = 2022;
        }
        public Date(int day, string month, int year) // parameter / arguments
        {
            this.day = day;  // this refers to data member
            this.month = month;
            this.year = year;
        }
        public string DisplayValue()
        {
            return $"Date is :{day} / {month} / {year}";
        }
    

    static void Main(string[] args)
    {
        Date d1 = new Date(); // constructor which does not have para
        Console.WriteLine(d1.DisplayValue());
        Date d2 = new Date(14, "Sept", 2022);
        Console.WriteLine(d2.DisplayValue());
    }
}
    public class DateDe
    {
        private int day, year;
        private string month;
        public DateDe(int day, string month, int year = 2022) // year is now default parameter
        {
            this.day = day;  // this refers to data member
            this.month = month;
            this.year = year;
        }
        public string DisplayValue()
        {
            return $"Date is :{day} / {month} / {year}";
        }

        static void Main(string[] args)
        {
            DateDe d1 = new DateDe(14, "Sept");
            // year paramter is the optional paramter
            Date d2 = new Date(1, "jan", 2023);
            Console.WriteLine(d1.DisplayValue());
            Console.WriteLine(d2.DisplayValue());
        }
    }

    public class Employee
    {
        private int id;
        private static int count = 0;
        private string name;
        private double bs, hra, da, pt, pf, total, netpaid;
        public Employee(string name, double bs, double pt)
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


}

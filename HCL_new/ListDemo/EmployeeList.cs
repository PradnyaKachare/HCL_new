using System;
using System.Collections.Generic;
using System.Text;

namespace HCL_new.ListDemo
{
    
    //20.	Create  a SortedList<Emp,string>  where key is emp object and value
    //is deptname he works in.Sort According to employee salary and if
    //two employees have same salary than according to name

    class EmployeeList
    {
        int eno, sal;
        string name;
        Department d;

        public EmployeeList()
        {
        }      

        public EmployeeList(int eno, int sal, string name, Department d)
        {
            this.Eno = eno;
            this.Sal = sal;
            this.Name = name;
            this.D = d;
        }

        public int Eno { get => eno; set => eno = value; }
        public int Sal { get => sal; set => sal = value; }
        public string Name { get => name; set => name = value; }
        internal Department D { get => d; set => d = value; }
        public override string ToString()
        {
            // return $"Empnumber: { eno} Name: {sal} Percentage:{name} Depatment: {d}" ;
            return "Empnumber:" + eno+ "Salary" +  sal+ "Name" + name+ "Depatment"+ d;
        }
    }

    internal class Department
    {
        int id;
        string d_nm;

        public Department()
        {
        }

        public Department(int id, string d_nm)
        {
            this.Id = id;
            this.D_nm = d_nm;
        }

        public int Id { get => id; set => id = value; }
        public string D_nm { get => d_nm; set => d_nm = value; }
    }
    class Sortsal
    {
        static void Main(string[] args)
        {
            LinkedList<EmployeeList> l = new LinkedList<EmployeeList>();
            l.AddFirst(new EmployeeList(1,56000,"Reva",new Department(1,"IT")));
            l.AddFirst(new EmployeeList(2, 65000, "Reva", new Department(2, "Sales")));
            l.AddFirst(new EmployeeList(1, 66000, "Reva", new Department(1, "IT")));
            l.AddFirst(new EmployeeList(2, 96000, "Reva", new Department(1, "Sales")));
            l.AddFirst(new EmployeeList(3, 86000, "Reva", new Department(1, "Developing")));

           // int Eno = 2;
            string d_nm = "";


            foreach (EmployeeList list in l)
            {
                if (list.Eno == 2)
                {
                    d_nm = list.D.D_nm;
                }
            }
            EmployeeList[] earr = new EmployeeList[l.Count];
            l.CopyTo(earr, 0);
            for(int i=0;i<l.Count;i++)
            {
                if(earr[i].D.D_nm == d_nm)
                {
                    l.Remove(earr[i]);
                }
            }
            foreach (EmployeeList list in l)
            {
                Console.WriteLine(list);
            }
        }
    }
}

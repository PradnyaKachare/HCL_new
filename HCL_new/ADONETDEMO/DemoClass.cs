using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace HCL_new.ADONETDEMO
{
    class DemoClass
    {
        //Connected Architecture using join
        static void Main(string[] args)
        {
            string str = "Server=HP\\SQLEXPRESS;Database= Hr;Integrated Security=True";
            SqlConnection c = new SqlConnection(str);
            c.Open();
            SqlCommand cmd = new SqlCommand("Select first_name,salary,department_name from employees e inner join departments d on d.department_id =e.employee_id", c);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Name:" + reader[0] + "Salary:" + reader[1] + "Department" + reader[2]);
            }
            c.Close();
        }
    }
}


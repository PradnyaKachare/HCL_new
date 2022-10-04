using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace HCL_new.ADONETDEMO
{
    class ConnectedDemo
    {
        //Connected Architecture 
        static void Main(string[] args)
        {
            string str = "Server=HP\\SQLEXPRESS;Database= Hr;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from employees", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Name:" + reader["First_Name"] + "Salary:" + reader["Salary"]);
            }
            con.Close();
        }
    }
}

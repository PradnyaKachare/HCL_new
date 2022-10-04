using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace HCL_new.ADONETDEMO
{
    class DisconnectDemoAll
    {
        static SqlConnection con = DBconnect.GetConnection();

        static SqlDataAdapter sda;

        static DataTable dt;

        static DisconnectDemoAll()
        {
            sda = new SqlDataAdapter("select * from book", con);

            //apply all constarints of table to DataTable
            sda.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            dt = new DataTable();
            sda.Fill(dt);
            SqlCommandBuilder sb = new SqlCommandBuilder(sda);

        }
        static void AddBook(int id, string bkname, string anm)
        {
            DataRow dr = dt.NewRow();

            dr[0] = id;
            dr[1] = bkname;
            dr[2] = anm;
            dt.Rows.Add(dr);
            // Console.WriteLine("Record Added successfully");
        }

        static void delete(int id)
        {
            DataRow dr = dt.Rows.Find(id);

            if (dr != null)
            {
                dr.Delete();
                Console.WriteLine("Record deleted successfully");
            }
            else
            {
                Console.WriteLine("Invalid Bookid");
            }
        }


        static void Update(int id)
        {

            DataRow dr = dt.Rows.Find(id);
            if (dr != null)
            {
                dr[1] = "Gita";
                dr[2] = "XYZ";
                Console.WriteLine("Record Updated successfully");
            }
            else
            {
                Console.WriteLine("Invalid Bookid");
            }

        }


        static void Main(string[] args)
        {
            //print data from datatable

            foreach (DataRow row in dt.Rows)

                Console.WriteLine(row[0] + " " + row[1] + " " + row[2]);

            // you are creating new row and adding that row to Datatable object
            AddBook(198, "Spring", "Kathy");
            // delete(107);
            // Update (200);

            sda.Update(dt);     //Update Chnges into Database table
        }


    }
}

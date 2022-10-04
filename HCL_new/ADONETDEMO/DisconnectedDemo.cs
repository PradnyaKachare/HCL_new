using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace HCL_new.ADONETDEMO
{
    class DisconnectedDemo
    {
        //Disconnected Architecture
        static void Main(string[] args)
        {
            SqlConnection con = DBconnect.GetConnection();
            SqlDataAdapter sda = new SqlDataAdapter("select * from book", con);
            sda.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            DataTable dt = new DataTable(); sda.Fill(dt);
            SqlCommandBuilder sb = new SqlCommandBuilder(sda);

            foreach (DataRow row in dt.Rows)

                Console.WriteLine(row[0] + " " + row[1] + " " + row[2]);

            DataRow dr = dt.NewRow();
            dr[1] = "Rhymes";
            dr[2] = "deepa";
            dt.Rows.Add(dr);

            foreach (DataRow row in dt.Rows)

                Console.WriteLine(row[0] + " " + row[1] + " " + row[2]);

            DataRow dr2 = dt.NewRow();
            dr2[0] = 120;
            dr2[1] = "python";
            dr2[2] = "ram";
            dt.Rows.Add(dr);

            foreach (DataRow row in dt.Rows)
                Console.WriteLine(row[0] + " " + row[1] + " " + row[2]);

            sda.Update(dt);
        }

    }
}

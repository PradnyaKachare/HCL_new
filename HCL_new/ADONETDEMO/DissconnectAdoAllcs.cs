using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace HCL_new.ADONETDEMO
{
    class DissconnectAdoAllcs
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBconnect.GetConnection();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from book", con);
            DataTable dt = new DataTable();
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            sda.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            sda.Fill(dt);

            do
            {
                Console.WriteLine("1-View all books");
                Console.WriteLine("2-Add new Book");
                Console.WriteLine("3-Delete Book");
                Console.WriteLine("4- Update Book");
                Console.WriteLine("enter choice");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("***Count" + dt.Rows.Count);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("************VIEW ALL BOOKS***************");
                        Console.WriteLine("View Count===" + dt.Rows.Count);
                        foreach (DataRow row in dt.Rows)
                            Console.WriteLine(row[0] + " " + row[1] + " " + row[2]);
                        break;
                    case 2:
                        Console.WriteLine("************Add new book***********");
                        Console.WriteLine("Enter bookid");
                        int bid = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter bookname");
                        string bookname = Console.ReadLine();
                        Console.WriteLine("enter authorname");
                        string aname = Console.ReadLine();
                        Console.WriteLine("Enter price");
                        int price = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter noOfCopies");
                        int n = int.Parse(Console.ReadLine());
                        DataRow dr = dt.NewRow();
                        dr[0] = bid;
                        dr[1] = bookname;
                        dr[2] = aname;
                        dr[3] = price;
                        dr[4] = n;
                        dt.Rows.Add(dr);
                        Console.WriteLine("Record added successfully");
                        break;
                    case 3:
                        Console.WriteLine("Enter bookid to delete");
                        int id = int.Parse(Console.ReadLine());
                        dr = dt.Rows.Find(id);
                        if (dr != null)
                        {
                            dt.Rows.Remove(dr);

                            //dr.AcceptChanges();
                            Console.WriteLine("Record deleted successfully");
                            Console.WriteLine("Count===" + dt.Rows.Count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid bookid");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter bookid to delete");
                        bid = int.Parse(Console.ReadLine());
                        dr = dt.Rows.Find(bid);
                        if (dr != null)
                        {
                            Console.WriteLine("enter  new bookname");
                            dr[1] = Console.ReadLine();
                            Console.WriteLine("enter  new author name");
                            dr[2] = Console.ReadLine();
                            Console.WriteLine("Record updated successfully");

                        }
                        else
                        {
                            Console.WriteLine("Invalid bookid");
                        }
                        break;

                }
                Console.WriteLine("Do you want to continue");
                string ch = Console.ReadLine().ToLower();

                if (ch == "no")
                    break;
            } while (true);
            sda.Update(dt);
        }
    }
}

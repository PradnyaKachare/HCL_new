using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace HCL_new.ADONETDEMO
{
    class ADODemo
    {
        //Insert ,Update,Delete,View
    }
    class DBconnect
    {
        const string connectionString = "Server=HP\\SQLEXPRESS;Database= Library;Integrated Security=True";
        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                return con;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return null;
        }
    }
    class DemoInsert
    {
        static void Main(string[] args)
        {
            SqlConnection c = DBconnect.GetConnection();
            c.Open();
            while (true)
            {
                SqlCommand cmd = new SqlCommand("insert into Book values (@id,@bknm,@anm,@price,@no)", c);
                Console.WriteLine("Enter bookid:");
                int bid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter bookname :");
                string bname = Console.ReadLine();
                Console.WriteLine("Enter authorname:");
                string aname = Console.ReadLine();
                Console.WriteLine("Enter Price:");
                int pr = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter NoOfcopies:");
                int n = int.Parse(Console.ReadLine());

                cmd.Parameters.AddWithValue("@id", bid);
                cmd.Parameters.AddWithValue("@bknm", bname);
                cmd.Parameters.AddWithValue("@anm", aname);
                cmd.Parameters.AddWithValue("@price", pr);
                cmd.Parameters.AddWithValue("@no", n);

                int count = cmd.ExecuteNonQuery();
                Console.WriteLine(count);

                if (count > 0)
                {
                    Console.WriteLine("Record Inserted Successfully");
                }
                Console.WriteLine("Do you want to Continue yes/ no");
                string choice = Console.ReadLine();

                if (choice == "no")
                    break;
            }

        }
    }

    class DemoMenu
    {
        static void ViewAllBooks()
        {
            SqlConnection c = null;
            try
            {
                c = DBconnect.GetConnection();
                c.Open();
                SqlCommand cmd = new SqlCommand("select * from book", c);
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("***************View All Books*******************");
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                c.Close();
            }
        }
        static void AddBook()
        {
            SqlConnection c = null;
            try
            {
                Console.WriteLine("********************Add New Book**********************");
                c = DBconnect.GetConnection();
                c.Open();
                SqlCommand cmd = new SqlCommand("insert into book values(@i,@bknm,@anm,@price,@no)", c);
                Console.WriteLine("Enter bookid");
                int bid = int.Parse(Console.ReadLine());
                Console.WriteLine("enter bookname");
                string bookname = Console.ReadLine();
                Console.WriteLine("enter authorname");
                string aname = Console.ReadLine();
                Console.WriteLine("Enter price");
                int pr = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter noOfCopies");
                int n = int.Parse(Console.ReadLine());

                cmd.Parameters.AddWithValue("@i", bid);
                cmd.Parameters.AddWithValue("@bknm", bookname);
                cmd.Parameters.AddWithValue("@anm", aname);
                cmd.Parameters.AddWithValue("@price", pr);
                cmd.Parameters.AddWithValue("@no", n);
                int count = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                c.Close();
            }
        }

        static void deleteBook()
        {
            Console.WriteLine("Enter bookid u want to delete");
            int bid = int.Parse(Console.ReadLine());
            SqlConnection c = null;
            try
            {
                Console.WriteLine("********************Add New Book**********************");
                c = DBconnect.GetConnection();
                c.Open();
                SqlCommand cmd = new SqlCommand("delete from book where bookid=@id", c);
                cmd.Parameters.AddWithValue("@id", bid);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                    Console.WriteLine("Deleted successfully: " + count);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                c.Close();
            }
        }
        static void updateBook()
        {
            SqlConnection c = null;

            try
            {
                Console.WriteLine("********************Edit Book**********************");
                c = DBconnect.GetConnection();
                c.Open();
                SqlCommand cmd = new SqlCommand("update book set bookname=@bknm,authorname=@anm,price=@price where Bookid=@i", c);
                Console.WriteLine("Enter bookid you want update");
                int bid = int.Parse(Console.ReadLine());
                Console.WriteLine("enter new bookname");
                string bookname = Console.ReadLine();
                Console.WriteLine("enter new authorname");
                string aname = Console.ReadLine();
                Console.WriteLine("Enter new price");
                int pr = int.Parse(Console.ReadLine());


                cmd.Parameters.AddWithValue("@i", bid);
                cmd.Parameters.AddWithValue("@bknm", bookname);
                cmd.Parameters.AddWithValue("@anm", aname);
                cmd.Parameters.AddWithValue("@price", pr);

                int count = cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                c.Close();
            }
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("************************");
                Console.WriteLine("1---View all books");
                Console.WriteLine("2---Add book");
                Console.WriteLine("3---Delete a Book");
                Console.WriteLine("4---Update a book");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ViewAllBooks();
                        break;
                    case 2:
                        AddBook();
                        break;
                    case 3:
                        deleteBook();
                        break;
                    case 4:
                        updateBook();
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                Console.WriteLine("Do you want continue  yes /no");
                string ch = Console.ReadLine();

                if (ch == "no")
                    break;
            }
            while (true);
        }
    }
}


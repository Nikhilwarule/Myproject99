using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Myproject99
{
    internal class DBConnect1
    {
        public static SqlConnection getConnection()
        {
            string str = "NIKHIL\\SQLEXPRESS01;Database=TQ;Integrated Security=True";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(str);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return con;


        }
    }
    class DEMOInsert1 //insert 
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBConnect1.getConnection();
            con.Open();
            Console.WriteLine("enter id,name,fees,dur");
            int CID = int.Parse(Console.ReadLine());
            string CNAME = Console.ReadLine();
            int FEES = int.Parse(Console.ReadLine());
            int DURATION = int.Parse(Console.ReadLine());
            SqlCommand cd = new SqlCommand("insert into COURSE values(@id,@name,@fees,@dur)", con);
            cd.Parameters.AddWithValue("@id", CID);
            cd.Parameters.AddWithValue("@name", CNAME);
            cd.Parameters.AddWithValue("@fees", FEES);
            cd.Parameters.AddWithValue("@dur", DURATION);
            int i = cd.ExecuteNonQuery();
            if (i > 0)
                Console.WriteLine("record inserted");


        }

    }
    class demoupdate1//update
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBConnect1.getConnection();
            con.Open();
            Console.WriteLine("enter id,name,fees");
            int CID = int.Parse(Console.ReadLine());
            string CNAME = Console.ReadLine();
            int FEES = int.Parse(Console.ReadLine());
            SqlCommand cd = new SqlCommand("update COURSE set CNAME=@name,FEES=@fees where CID=@id", con);
            cd.Parameters.AddWithValue("@id", CID);
            cd.Parameters.AddWithValue("@name", CNAME);
            cd.Parameters.AddWithValue("@fees", FEES);
            int i = cd.ExecuteNonQuery();
            if (i > 0)
            {
                Console.WriteLine("record updated successfully");
            }
            else
                Console.WriteLine("failed to update");

        }
    }
    class demodelete1//delete
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBConnect1.getConnection();
            con.Open();
            Console.WriteLine("enter id");
            int CID = int.Parse(Console.ReadLine());
            SqlCommand cd = new SqlCommand("delete from COURSE where Cid=@id", con);
            cd.Parameters.AddWithValue("@id", CID);
            int i = cd.ExecuteNonQuery();
            if (i > 0)
            {
                Console.WriteLine("record deleted successfully");
            }
            else
                Console.WriteLine("failed to delete");
        }
    }
    class demoselect1
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBConnect1.getConnection();
            con.Open();
            SqlCommand cd = new SqlCommand("select CID,CNAME from COURSE", con);
            SqlDataReader dr = cd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("id=" + dr[0] + "name=" + dr[1]);
            }
        }
    }
}


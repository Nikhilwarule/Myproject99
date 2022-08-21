using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Myproject99
{
    static class DBConnect
    {
        public static SqlConnection getConnection()
        {
            string str = "server =NIKHIL\\SQLEXPRESS01;Database=HR;Integrated Security=True";
            SqlConnection con = null;
           
            try
            {
                con = new SqlConnection(str);
                con.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return con;
        }
    }
    class DemoInsert
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBConnect.getConnection();
            Console.WriteLine("enter id ,nm , percent");
            int rollno = int.Parse(Console.ReadLine());
            string nm = Console.ReadLine();
            int marks = int.Parse(Console.ReadLine());
            SqlCommand cmd = new SqlCommand("insert into student values (@id,@nm,@mk)", con);
            cmd.Parameters.AddWithValue("@id", rollno);
            cmd.Parameters.AddWithValue("@nm", nm);
            cmd.Parameters.AddWithValue("@mk", marks);
            int i = cmd.ExecuteNonQuery();
            if (i>0)
                Console.WriteLine("record inserted");
        }
        static void Main1(string[] args)
        {
            SqlConnection con = DBConnect.getConnection();
            SqlCommand cmd = new SqlCommand("insert into student values(1,'Nikhil,18)", con);
            int i = cmd.ExecuteNonQuery();
            
            if (i>0)
                Console.WriteLine("Record inserted");
        }
    } 
    class DemoSelect
    {
        static void Main(string[] args)
        {
            string str = "server=NIKHIL\\SQLEXPRESS01;Database=HR;Integrated Security=True";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(str);
                con.Open();
                SqlCommand sqlcommand = new SqlCommand("select first_name,salary from employees", con);
                SqlDataReader dr=sqlcommand.ExecuteReader();
                 
                while(dr.Read())
                {
                    Console.WriteLine("Name="+dr["first_name"]+"Salary="+dr[1]);
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (con != null)
                    con.Close();

            }

        }
    }
}

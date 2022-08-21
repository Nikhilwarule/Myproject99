using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Myproject99
{
    class DisConnected
    {
        static SqlDataAdapter sda = null;
        static DataSet ds = null;
        public static DataSet getAllStudents()
        {
            SqlConnection con = null;

            con = DBConnect.Connect();

            sda = new SqlDataAdapter("select * from student", con);
            
            sda.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            ds = new DataSet();
            sda.Fill(ds);


            return ds;
        }

        static public void AddStudent()
        {
            Console.WriteLine("Enter id,nm,marks");
            int id = int.Parse(Console.ReadLine());
            string nm = Console.ReadLine();
            int mks = int.Parse(Console.ReadLine());

            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = id;
            dr[1] = nm;
            dr[2] = mks;
            ds.Tables[0].Rows.Add(dr);

            /*DataRow dr2 = ds.Tables[0].NewRow();
            dr2[0] = 11;
            dr2[1] = "nik";
            dr2[2] = 90;*/
            //ds.Tables[0].Rows.Add(dr2);

            //int result=sda.Update(ds);
            //Console.WriteLine(result>0?"Record inserted ":"Not");


        }

        public static void showAllStudent()
        {
            getAllStudents();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]);
            }

        }

        static public void UpdateStudent()
        {
            Console.WriteLine("Enter id to update");
            int id = int.Parse(Console.ReadLine());


            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            DataRow dr = ds.Tables[0].Rows.Find(id);
            Console.WriteLine("Finddddddd     " + dr[0] + " " + dr[1] + " " + dr[2]);
            Console.WriteLine("Enter new name");
            dr[1] = Console.ReadLine();
            dr[2] = 77;


            //ds.Tables[0].Rows.
            //sda.Update(ds);

        }


        public static void deletestudent()
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            Console.WriteLine("Enter id to delete");
            int id = int.Parse(Console.ReadLine());
            DataRow dr = ds.Tables[0].Rows.Find(id);
            if (dr != null)
                dr.Delete();


            //int r=sda.Update(ds);
            //Console.WriteLine(r>0?"Deleted Records "+r:"Not deleted");


        }

        static void Main(string[] args)
        {
            getAllStudents();
            AddStudent();
          
            
           UpdateStudent();
            deletestudent();
            sda.Update(ds);
            showAllStudent();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DATABASEEMPLOY
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"integrated security=true; data source=DESKTOP-RB3HGFJ\SQLEXPRESS;initial catalog=Traning");
            SqlDataAdapter ad = new SqlDataAdapter("Select * from EMPLOY",con);
            DataSet ds = new DataSet();
            ad.Fill(ds, "EMPLOY");
            foreach (DataRow dr in ds.Tables["EMPLOY"].Rows)
            {
                Console.Write(dr["ENO"]+"\t");
                Console.Write(dr["ENAME"] + "\t");
                Console.Write(dr["DESIG"] + "\t");
                Console.Write(dr["DESIG"] + "\t");
                Console.Write(dr["BASICS"] + "\t");
                Console.WriteLine();
               
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Clase10
{
    class Program
    {
        static void Main(string[] args)
        {
            String connString = @"Server = INSTRUCTOR-403\SQLEXPRESS; Database = Libros; Trusted_Connection = True;";
            SqlConnection conn = new SqlConnection(connString);
            String SQlCmd = "select * " +
                    "from editorial inner join libros " +
                    "on editorial.editorial_id = libros.Editorial_ID " +
                    " " +
                    "select * from libros " +
                    "select * from editorial" +
                    " ";

            conn.Open();
            var comando = conn.CreateCommand();
            comando.CommandText = SQlCmd;

            SqlDataReader lector = comando.ExecuteReader();

            lector.Read();
            lector.Close();

            System.Data.IDataAdapter da = new System.Data.SqlClient.SqlDataAdapter(SQlCmd, conn);

            DataSet ds = new DataSet("Libros");

            da.Fill(ds);

            ds.Tables[0].TableName = "eljoin";
            ds.Tables[1].TableName = "libros";
            ds.Tables[2].TableName = "editorial";

            foreach (DataTable dt in ds.Tables) {
                Console.WriteLine(dt.TableName);
                foreach (DataColumn col in dt.Columns) {
                    Console.Write("  ");
                    Console.WriteLine(col.ColumnName);
                    Console.Write("  ");
                    Console.WriteLine(col.GetType());
                }
            }

            ds.WriteXml(@"C:\clase10\dumpLibros.xml");
            ds.WriteXmlSchema(@"C:\clase10\dumpSchema.xml");
            
            conn.Close();

            Console.WriteLine("...");

            Console.ReadKey();
        }
    }
}

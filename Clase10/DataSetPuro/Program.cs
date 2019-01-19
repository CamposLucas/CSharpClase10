using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataSetPuro
{
    class Program
    {
        static void escribirDataset() {
            DataSet ds = new DataSet("Configuracion");
            ds.Tables.Add("ConexionBase");
            ds.Tables[0].Columns.Add("Server");
            ds.Tables[0].Columns.Add("Usuario");
            ds.Tables[0].Columns.Add("Password");

            ds.Tables[0].Rows.Add(new Object[] { @"INSTRUCTOR-403\SQLEXPRESS", "sa", "admin" });

            ds.WriteXml(@"C:\clase10\dumpMemoria.xml");
        }
        static void leerDataSet() {
            DataSet ds = new DataSet("Configuracion");
            ds.ReadXml(@"C:\clase10\dumpMemoria.xml");

            foreach (DataTable dt in ds.Tables) {
                foreach (DataColumn col in dt.Columns) {
                    Console.WriteLine(col.ColumnName);
                    Console.WriteLine(dt.Rows[0][col.ColumnName].ToString());
                }
            }            
        }
        static void Main(string[] args)
        {
            // escribirDataset();
            leerDataSet();
            Console.ReadKey();
        }
    }
}

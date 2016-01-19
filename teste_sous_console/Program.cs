using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace teste_sous_console
{
    class Program
    {
        static void Main(string[] args)
        {

            using (SqlConnection co = DataLayer.ConnexionDB.getConnection() )
            {
                Console.WriteLine(co.State);
                Console.Read();
            }
               
        }
    }
}

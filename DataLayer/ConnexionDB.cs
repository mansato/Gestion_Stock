using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DataLayer
{
    public class ConnexionDB
    {
        public static string connstr
        {
            get
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["stock"].ConnectionString);
                sb.ConnectTimeout = (conntime > 0) ? conntime : sb.ConnectTimeout;
                sb.ApplicationName = (appname != null) ? appname : sb.ApplicationName;

                return sb.ToString();

            }

        }

        public static int conntime { get; set; }
        public static string appname { get; set; }

        public static SqlConnection getConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connstr);
                conn.Open();
                return conn;
            }
            catch (Exception ex){ throw new Exception(ex.Message); }
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Contatos1._1.DAO
{
    public class ConnectionFactory
    {
        public static MySqlConnection GetConnection()
        {
            string conector = ConfigurationManager.ConnectionStrings["Contatos"].ConnectionString;

            return new MySqlConnection(conector);
        }        
    }
}

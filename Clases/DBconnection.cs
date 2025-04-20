using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lista_jugadores.Clases
{
    internal class DBconnection
    {
        // new MySql connection
        MySqlConnection connection = new MySqlConnection();

        // connection string credentials
        static string server = "localhost";
        static string port = "3306";
        static string db = "lista_jugadores";
        static string user = "root";
        static string password = "root";

        // connection string
        string connectionString = "server="+server+";"+"port="+port+";"+"user id="+user+";"+"password="+password+";"+"database="+db+";";

        // set MySql connection function
        public MySqlConnection setConnection()
        {
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
            } catch (Exception ex)
            {
                MessageBox.Show("no connected", ex.ToString());
            }
            return connection;
        }

        // drop MySql connection fuction
        public void dropConnection()
        {
            connection.Close();
        }
    }
}

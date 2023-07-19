using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace My_Journal
{
    internal class DB

    {
            MySqlConnection connection = new MySqlConnection("server = localhost; port = 3306; username = root; password = root;");
                
            String createDatabaseCommand = string.Format("CREATE SCHEMA IF NOT EXISTS myjournal; " +
            "USE myjournal;" +
            "CREATE TABLE IF NOT EXISTS `record` (`id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, `record` varchar(100) NOT NULL,  `date` date NOT NULL, PRIMARY KEY (id)) ;" +
            "CREATE TABLE IF NOT EXISTS `user` (`id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, `name` varchar(50) NOT NULL, `program` varchar(60) NOT NULL, `email` varchar(50) NOT NULL,`password` varchar(15) NOT NULL , PRIMARY KEY (id));");

        public void openConnection() {
            //if (connection.State == System.Data.ConnectionState.Closed)
            //    connection.Open();

            //MySqlCommand myCommand = new MySqlCommand(createDatabaseCommand, connection);
            //myCommand.ExecuteNonQuery();
            
          }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
            MySqlCommand myCommand = new MySqlCommand(createDatabaseCommand, connection);
            myCommand.ExecuteNonQuery();
            return (MySqlConnection)connection;
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApreServi
{
    class BD
    {
        static MySqlConnection connection;

        public static MySqlConnection GetConnection(){
            if(connection == null)
            {
                string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
                connection = new MySqlConnection(MyConString);
            }
            return connection;
       }

    }
}

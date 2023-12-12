using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace _479314_Ega_Rizky_Setiawan_ResponsiJuniorProject
{
    public class dbConnection
    {
        private static string conn = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsi";
        private NpgsqlConnection connection = new NpgsqlConnection(conn);

        public NpgsqlConnection GetConnection()
        {
            return this.connection;
        }
        public void OpenConnection()
        {
            connection.Open();
        }
        public void CloseConnection()
        {
            connection.Close();
        }
    }
}

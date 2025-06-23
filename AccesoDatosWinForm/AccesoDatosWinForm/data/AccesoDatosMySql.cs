using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using MySql.Data.MySqlClient;

namespace AccesoDatosWinForm.data
{
    internal class AccesoDatosMySql
    {
        MySqlConnection _connection ;
        MySqlCommand _command;
        MySqlDataReader _reader;

        public int ejecutarSentencia(string sentenciaSQL) {

            if (_connection == null)
            {
                throw new InvalidOperationException("La conexión no está inicializada.");
            }
            _command = new MySqlCommand(sentenciaSQL, _connection);
            return _command.ExecuteNonQuery();
        }

        public MySqlDataReader ejecutarQuery(string consulta) { 
            _command = new MySqlCommand(consulta, _connection);
            return _command.ExecuteReader();
        }

        public AccesoDatosMySql(string host, string db, 
            string user, string password, int port) {

            string connectionString = 
                $"Server={host};Database={db};User ID={user};" +
                $"Password={password};" +
                $"Port={port};";

            _connection = new MySqlConnection(connectionString);

            MySqlConnectionStringBuilder builderConnString =
                new MySqlConnectionStringBuilder();

            builderConnString.Server = host;
            builderConnString.Database = db;
            builderConnString.UserID = user;
            builderConnString.Password = password;
            builderConnString.Port = (uint)port;

            var otraCAdena = 
                builderConnString.ConnectionString;

        }
    }
}

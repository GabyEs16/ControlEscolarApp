﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ConexionBd
{
    public class Conexion
    {
        MySqlConnection _conn;
        public Conexion(string server, string user, string password, string database, uint port)
        {
            MySqlConnectionStringBuilder cadena = new MySqlConnectionStringBuilder();
            cadena.Server = server;
            cadena.UserID = user;
            cadena.Password = password;
            cadena.Database = database;
            cadena.Port = port;


            _conn = new MySqlConnection(cadena.ToString());
        }
        public void EjecutarConsulta(string cadena)
        {
            _conn.Open();
            MySqlCommand cnn = new MySqlCommand(cadena, _conn);
            cnn.ExecuteNonQuery();
            _conn.Close();
        }
        public DataSet ObtenerDatos(string cadena, string tabla)
        {
            var ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(cadena, _conn);
            da.Fill(ds, tabla);

            return ds;
        }
    }
}

using System;
using System.Collections.Generic;
using ConexionBd;
using System.Data;
using Entidades.ControlEscolarApp;


namespace AccesoDatos.ContolEscolarApp
{
    public class EscuelasAccesoaDatos
    {
        Conexion _conexion;

     public EscuelasAccesoaDatos()
        {
            _conexion = new Conexion("localhost", "root", "", "escolar", 3306);

        }
        public void Eliminar(int IdEscuela)
        {
            string cadena = string.Format("Delete from escuela where idescuela = {0} ", IdEscuela);
            _conexion.EjecutarConsulta(cadena);
        }

        public void Guardar(Escuela escuelas)
        {
            if (escuelas.Idescuela == 0)
            {


                string consulta = string.Format("insert into escuela values('{0}', '{1}', '{2}', '{3}')",
                    escuelas.Idescuela,
                    escuelas.Nombre,
                    escuelas.Director,
                    escuelas.Logo);

                _conexion.EjecutarConsulta(consulta);
            }
            else
            {
                string consulta = string.Format("Update escuela set nombre ='{0}',director= '{1}',logo = '{2}' where idescuela = {3}", escuelas.Nombre, escuelas.Director, escuelas.Logo, escuelas.Idescuela);

                _conexion.EjecutarConsulta(consulta);
            }
        }
        public Escuela GetEscuela()
        {
            var ds = new DataSet();
            string consulta = "Select * from escuela";
            ds = _conexion.ObtenerDatos(consulta, "escuela");
            var dt = new DataTable();
            dt = ds.Tables[0];
            var escuela = new Escuela();

            foreach (DataRow row in dt.Rows)
            {
                    escuela.Idescuela = Convert.ToInt32(row["idescuela"]);
                    escuela.Nombre = row["nombre"].ToString();
                    escuela.Director = row["director"].ToString();
                    escuela.Logo = row["Logo"].ToString();

            }
            return escuela;
        }
        /*public List<Escuela> ObtenerLista(string filtro)
        {
            var list = new List<Escuela>();
            string consulta = string.Format("Select * from escuela where nombre like '%{0}%'", filtro);
            var ds = _conexion.ObtenerDatos(consulta, "escuela");
            var dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var escuelas = new Escuela
                {


                    IdEscuela = Convert.ToInt32(row["idescuela"]),
                    Nombre = row["nombre"].ToString(),
                    Director = row["director"].ToString(),
                    Logo = row["logo"].ToString()


                };
                list.Add(escuelas);
            }
            return list;
        }*/

    }
}

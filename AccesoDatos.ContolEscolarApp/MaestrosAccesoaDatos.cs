using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolarApp;
using ConexionBd;
using System.Data;
using System.Windows.Forms;

namespace AccesoDatos.ContolEscolarApp
{
    public class MaestrosAccesoaDatos
    {
        Conexion _conexion;
        public MaestrosAccesoaDatos()
        {
            _conexion = new Conexion("localhost", "root", "", "escolar", 3306);
        }
        public void Eliminar(string NumeroControl)
        {
            string cadena = string.Format("Delete from maestros where NumeroControl = {0} ", NumeroControl);
            _conexion.EjecutarConsulta(cadena);
        }

        public void Guardar(Maestros maestros)
        {

            if (maestros.NumeroControl != " ")
            {
                string cadena = string.Format("insert into maestros values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", maestros.NumeroControl, maestros.Nombre, maestros.ApellidoP, maestros.ApellidoM, maestros.Fecha_Nan, maestros.Estado, maestros.Ciudad, maestros.Sexo, maestros.Email, maestros.Tarjeta);
                MessageBox.Show(cadena);
                _conexion.EjecutarConsulta(cadena);
            }
            else
            {
                string cadena = string.Format("Update maestros set  Nombre='{0}', ApellidoP='{1}',ApellidoM='{2}',Fecha_Nan='{3}',Estado='{4}',Ciudad='{5}', Sexo='{6}',Email='{7}',Tarjeta='{8}' where NumeroControl = '{4}'", maestros.Nombre, maestros.ApellidoP, maestros.ApellidoM, maestros.Fecha_Nan, maestros.Estado, maestros.Ciudad, maestros.Sexo, maestros.Email, maestros.Tarjeta, maestros.NumeroControl);
            }

        }
        public List<Maestros> ObtenerLista(string filtro)
        {
            var list = new List<Maestros>();
            string consulta = string.Format("Select * from maestros where Nombre like '%{0}%'", filtro);
            var ds = _conexion.ObtenerDatos(consulta, "maestros");
            var dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var maestros = new Maestros
                {
                    NumeroControl = row["NumeroControl"].ToString(),
                    Nombre = row["Nombre"].ToString(),
                    ApellidoP = row["ApellidoP"].ToString(),
                    ApellidoM = row["ApellidoM"].ToString(),
                    Fecha_Nan = row["Fecha_Nan"].ToString(),
                    Estado = row["Estado"].ToString(),
                    Ciudad = row["Ciudad"].ToString(),
                    Sexo = row["Sexo"].ToString(),
                    Email = row["Email"].ToString(),
                    Tarjeta = row["Tarjeta"].ToString()
                };
                list.Add(maestros);
            }
            return list;
        }
    }
}

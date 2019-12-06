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
    public class AlumnosAccesoDatos
    {
        Conexion _conexion;
        public AlumnosAccesoDatos()
        {
            _conexion = new Conexion("localhost", "root", "", "escolar", 3306);
        }
        public void Eliminar(string NumeroControl)
        {
            string cadena = string.Format("Delete from alumno where NumeroControl = {0} ", NumeroControl);
            _conexion.EjecutarConsulta(cadena);
        }
        
            public void Guardar(Alumno alumnos )
        {
            
            if (alumnos.NumeroControl != " ")
            {
                string cadena = string.Format("insert into alumno values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')",alumnos.NumeroControl, alumnos.Nombre, alumnos.ApellidoP, alumnos.ApellidoM,  alumnos.Sexo, alumnos.FechaNacimiento, alumnos.E_mail, alumnos.TelefonoContacto,alumnos.Estado,alumnos.Municipio,alumnos.Domicilio);
                MessageBox.Show(cadena);
                _conexion.EjecutarConsulta(cadena);
            }
            else
            {
                string cadena = string.Format("Update alumno set  Nombre='{0}', ApellidoP='{1}',ApellidoM='{2}',Sexo='{3}',FechaNacimiento='{4}',E_mail='{5}',TelefonoContacto='{6}',Estado='{7}',Municipio='{8}',Domicilio='{9}' where NumeroControl = '{4}'", alumnos.Nombre, alumnos.ApellidoP, alumnos.ApellidoM, alumnos.Sexo, alumnos.FechaNacimiento, alumnos.E_mail, alumnos.TelefonoContacto, alumnos.Estado, alumnos.Municipio, alumnos.Domicilio, alumnos.NumeroControl);
                _conexion.EjecutarConsulta(cadena);
            }
            
        }
        public List<Alumno> ObtenerLista(string filtro)
        {
            var list = new List<Alumno>();
            string consulta = string.Format("Select * from alumno where Nombre like '%{0}%'", filtro);
            var ds = _conexion.ObtenerDatos(consulta, "alumno");
            var dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                var alumnos = new Alumno
                {
                    NumeroControl = row["NumeroControl"].ToString(),
                    Nombre = row["Nombre"].ToString(),
                    ApellidoP = row["ApellidoP"].ToString(),
                    ApellidoM = row["ApellidoM"].ToString(),
                    Sexo = row["Sexo"].ToString(),
                    FechaNacimiento = row["FechaNacimiento"].ToString(),
                    E_mail = row["E_mail"].ToString(),
                    TelefonoContacto = row["TelefonoContacto"].ToString(),
                    Estado = row["Estado"].ToString(),
                    Municipio = row["Municipio"].ToString(),
                    Domicilio = row["Domicilio"].ToString()
                };
                list.Add(alumnos);
            }
            return list;
        }
    }
}

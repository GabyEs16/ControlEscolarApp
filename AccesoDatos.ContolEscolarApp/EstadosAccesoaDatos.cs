using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolarApp;
using ConexionBd;
using System.Data;

namespace AccesoDatos.ContolEscolarApp
{
    public class EstadosAccesoaDatos
    {
        Conexion _conexion;

        public EstadosAccesoaDatos()
        {
            _conexion = new Conexion("localhost", "root", "", "escolar", 3306);
        }

        public List<Estados> ObtenerEstado(string filtro)
        {
            var list = new List<Estados>();
            string consulta = string.Format("select * from estados where estado like '%{0}%'", filtro);
            var ds = _conexion.ObtenerDatos(consulta, "estados");
            var dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                var estados = new Estados
                {
                    Codigo = dr["Codigo"].ToString(),
                    Estado = dr["Estado"].ToString()
                };
                list.Add(estados);
            }
            return list;
        }
    }
}

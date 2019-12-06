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
    public class MunicipiosAccesoaDatos
    {
        Conexion _conexion;
        public MunicipiosAccesoaDatos()
        {
            _conexion = new Conexion("localhost", "root", "", "escolar", 3306);
        }
        public List<Municipios> ObtenerMunicipio(string filtro)
        {
            var lista = new List<Municipios>();
            string consulta = string.Format("select * from municipios where codigoEstado like '%{0}%'", filtro);
            var ds = _conexion.ObtenerDatos(consulta,"municipios");
                var dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    var municipios = new Municipios
                    { Id = Convert.ToInt32(row["id"]),
                        Municipio = row["municipio"].ToString(),
                        CodigoEstado = row["codigoEstado"].ToString()
                    };
                    lista.Add(municipios);
                }
         
            return lista;
        }
    }
}

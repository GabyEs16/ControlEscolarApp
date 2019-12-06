using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.ContolEscolarApp;
using Entidades.ControlEscolarApp;

namespace LogicaNegocio.ControlEscolarApp
{
    public class MunicipiosManejador
    {
        private MunicipiosAccesoaDatos _municipiosAccesoaDatos;
        public MunicipiosManejador()
        {
            _municipiosAccesoaDatos = new MunicipiosAccesoaDatos();
        }
        public IList<Municipios> ObtenerMunicipio(string filtro)
        {

            var list = new List<Municipios>();
            list = _municipiosAccesoaDatos.ObtenerMunicipio(filtro);
            return list;

        }
    }
}

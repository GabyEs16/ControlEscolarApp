using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolarApp;
using AccesoDatos.ContolEscolarApp;
using System.Text.RegularExpressions;

namespace LogicaNegocio.ControlEscolarApp
{
    public class EstadoManejador
    {
        private EstadosAccesoaDatos _EstadoManejador;

        public EstadoManejador()
        {
            _EstadoManejador = new EstadosAccesoaDatos();
        }
        public List<Estados> ObtenerEstado(string filtro)
        {

            var list = new List<Estados>();
            list = _EstadoManejador.ObtenerEstado(filtro);
            return list;
        }
    }
}

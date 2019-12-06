using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolarApp
{
    public class Municipios
    {
        private int _id;
        private string _municipio;
        private string _codigoEstado;

    
        public string Municipio { get => _municipio; set => _municipio = value; }
        public string CodigoEstado { get => _codigoEstado; set => _codigoEstado = value; }
        public int Id { get => _id; set => _id = value; }
    }
}

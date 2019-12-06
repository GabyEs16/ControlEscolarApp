using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolarApp
{
    public class Estados
    {
        private string _codigo;
        private string _estado;

        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Estado { get => _estado; set => _estado = value; }
    }
}

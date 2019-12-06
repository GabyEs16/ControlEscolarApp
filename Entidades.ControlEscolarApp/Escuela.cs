using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolarApp
{
    public class Escuela
    {
        private int _idescuela;
        private string _nombre;
        private string _director;
        private string _logo;

        public int Idescuela { get => _idescuela; set => _idescuela = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Director { get => _director; set => _director = value; }
        public string Logo { get => _logo; set => _logo = value; }
    }
}

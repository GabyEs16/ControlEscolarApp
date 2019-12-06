using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolarApp
{
    public class Maestros
    {
        private string _NumeroControl;
        private string _Nombre;
        private string _ApellidoP;
        private string _ApellidoM;
        private string _Fecha_Nan;
        private string _Estado;
        private string _Ciudad;
        private string _Sexo;
        private string _Email;
        private string _Tarjeta;
        private string _Licenciatura;
        private string _Maestria;
        private string _Doctorado;

        public string NumeroControl { get => _NumeroControl; set => _NumeroControl = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string ApellidoP { get => _ApellidoP; set => _ApellidoP = value; }
        public string ApellidoM { get => _ApellidoM; set => _ApellidoM = value; }
        public string Fecha_Nan { get => _Fecha_Nan; set => _Fecha_Nan = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public string Sexo { get => _Sexo; set => _Sexo = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Tarjeta { get => _Tarjeta; set => _Tarjeta = value; }
        public string Licenciatura { get => _Licenciatura; set => _Licenciatura = value; }
        public string Maestria { get => _Maestria; set => _Maestria = value; }
        public string Doctorado { get => _Doctorado; set => _Doctorado = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolarApp
{
    public class Alumno
    {
        private string _NumeroControl;
        private string _Nombre;
        private string _ApellidoP;
        private string _ApellidoM;
        private string _Sexo;
        private string _FechaNacimiento;
        private string _E_mail;
        private string  _TelefonoContacto;
        private string _Estado;
        private string _Municipio;
        private string _Domicilio;

        public string NumeroControl { get => _NumeroControl; set => _NumeroControl = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string ApellidoP { get => _ApellidoP; set => _ApellidoP = value; }
        public string ApellidoM { get => _ApellidoM; set => _ApellidoM = value; }
        public string Sexo { get => _Sexo; set => _Sexo = value; }
        public string FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public string E_mail { get => _E_mail; set => _E_mail = value; }
        public string TelefonoContacto { get => _TelefonoContacto; set => _TelefonoContacto = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string Municipio { get => _Municipio; set => _Municipio = value; }
        public string Domicilio { get => _Domicilio; set => _Domicilio = value; }
       
    }
}

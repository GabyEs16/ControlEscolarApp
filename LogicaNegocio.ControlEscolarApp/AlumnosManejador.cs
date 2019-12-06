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
     public class AlumnosManejador
    {
        private AlumnosAccesoDatos _alumnosAccesoDatos;         
        public AlumnosManejador()
        {
            _alumnosAccesoDatos = new AlumnosAccesoDatos();
        }

        public void Eliminar(string NumeroControl)
        {
            _alumnosAccesoDatos.Eliminar(NumeroControl);
        }

        public void Guardar(Alumno alumno)
        {
            _alumnosAccesoDatos.Guardar(alumno);
        }

        private bool NombreValido(string Nombre)
        {
            var regex = new Regex(@"^[A-Za-z]+( [A-Za-z]+)*$");
            var match = regex.Match(Nombre);

            if (match.Success)
            {
                return true;
            }
            return false;
        }

        private bool ApellidoPValido(string ApellidoP)
        {
            var regex = new Regex(@"^[A-Za-z]+( [A-Za-z]+)*$");
            var match = regex.Match(ApellidoP);

            if (match.Success)
            {
                return true;
            }
            return false;
        }
        private bool ApellidoMValido(string ApellidoM)
        {
            var regex = new Regex(@"^[A-Za-z]+( [A-Za-z]+)*$");
            var match = regex.Match(ApellidoM);

            if (match.Success)
            {
                return true;
            }
            return false;
        }
        //-----------------------------------------------------------------------------------------------
        private bool DomicilioValido(string Domicilio)
        {
            var regex = new Regex(@"^[A-Za-z]+( [A-Za-z]+)*$");
            var match = regex.Match(Domicilio);

            if (match.Success)
            {
                return true;
            }
            return false;
        }

        private bool E_mailValido(string E_mail)
        {
            var regex = new Regex(@"/[\w -\.] +@([\w -] +\.) +[\w -]{ 2,4}/");
            var match = regex.Match(E_mail);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
        private bool TelefonoValido(string telefono)
        {
            var regex = new Regex(@"[0-9]{1,9}(\.[0-9]{0,2})?$");
            var match = regex.Match(telefono);
            if (match.Success)
            {
                return true;
            }
            return false;
        }

        //-----------------------------------------------------------------------------------------------

        public List<Alumno> ObtenerLista(string filtro)
        {
            var list = new List<Alumno>();
            list = _alumnosAccesoDatos.ObtenerLista(filtro);
            return list;
        }
        public Tuple<bool, string> EsUsuarioValido(Alumno alumno)
        {
            string mensaje = "";
            bool valido = true;

            if (alumno.Nombre.Length == 0)
            {
                mensaje = "El nombre del Alumno es necesario";
                valido = false;
            }
            else if (!NombreValido(alumno.Nombre))
            {
                mensaje = "Escribe un fomato valido para el nombre";
                valido = false;
            }
            else if (alumno.Nombre.Length > 100)
            {
                mensaje = "La longitud para nombre de alumno es máximo 100 carazteres";
                valido = false;
            }
            return Tuple.Create(valido, mensaje);
        }

        public Tuple<bool, string> EsApellidoPValido(Alumno alumno)
        {
            string mensaje = "";
            bool valido = true;

            if (alumno.ApellidoP.Length == 0)
            {
                mensaje = "El Apellido Paterno del Alumno es necesario";
                valido = false;
            }
            else if (!ApellidoPValido(alumno.ApellidoP))
            {
                mensaje = "Escribe un fomato valido para el Apellido Paterno";
                valido = false;
            }
            else if (alumno.ApellidoP.Length > 100)
            {
                mensaje = "La longitud para Apellido Paterno de alumno es máximo 100 caracteres";
                valido = false;
            }
            return Tuple.Create(valido, mensaje);
        }

        public Tuple<bool, string> EsApellidoMValido(Alumno alumno)
        {
            string mensaje = "";
            bool valido = true;

            if (alumno.ApellidoM.Length == 0)
            {
                mensaje = "El Apellido Materno del Alumno es necesario";
                valido = false;
            }
            else if (!ApellidoMValido(alumno.ApellidoM))
            {
                mensaje = "Escribe un fomato valido para el Apellido Materno";
                valido = false;
            }
            else if (alumno.ApellidoM.Length > 100)
            {
                mensaje = "La longitud para Apellido Materno de alumno es máximo 100 caracteres";
                valido = false;
            }
            return Tuple.Create(valido, mensaje);
        }
        //-----------------------------------------------------------------------------------------
        public Tuple<bool, string> EsDomicilioValido(Alumno alumno)
        {
            string mensaje = "";
            bool valido = true;

            if (alumno.Domicilio.Length == 0)
            {
                mensaje = "El Domicilio del Alumno es necesario";
                valido = false;
            }
            else if (!DomicilioValido(alumno.Domicilio))
            {
                mensaje = "Escribe un fomato valido para el Domicilio";
                valido = false;
            }
            else if (alumno.Domicilio.Length > 250)
            {
                mensaje = "La longitud para nombre de alumno es máximo 250 caracteres";
                valido = false;
            }
            return Tuple.Create(valido, mensaje);
        }

        public Tuple<bool, string> EsE_mailValido(Alumno alumno)
        {
            string mensaje = "";
            bool valido = true;

            if (alumno.E_mail.Length == 0)
            {
                mensaje = "El E_mail del Alumno es necesario";
                valido = false;
            }
            else if (!E_mailValido(alumno.E_mail))
            {
                mensaje = "Escribe un fomato valido para el E_mail";
                valido = false;
            }
            else if (alumno.E_mail.Length > 100)
            {
                mensaje = "La longitud para E_mail de alumno es máximo 250 caracteres";
                valido = false;
            }
            return Tuple.Create(valido, mensaje);
        }


        //-----------------------------------------------------------------------------------------

        public Tuple<bool, string> EsTelefonoValido(Alumno alumno)
        {
            string mensaje = "";
            bool valido = true;

            if (alumno.TelefonoContacto.Length >= 15)
            {
                mensaje = "El telefono no puede ser mayor a 10 digitos";
                valido = false;
            }
            return Tuple.Create(valido,mensaje);
        }
    }
}

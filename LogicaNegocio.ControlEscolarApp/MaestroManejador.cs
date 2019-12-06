using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolarApp;
using AccesoDatos.ContolEscolarApp;
using System.Text.RegularExpressions;
using System.IO;

namespace LogicaNegocio.ControlEscolarApp
{
    public class MaestroManejador
    {
        private MaestrosAccesoaDatos _MaestrosAccesoDatos;
        public MaestroManejador()
        {
            _MaestrosAccesoDatos = new MaestrosAccesoaDatos();
        }
        public void SubirDocumento(string NombreArchivo, string Ruta, int IdMaestro)
        {
            if (NombreArchivo != null)
            {
                if (NombreArchivo != "")
                {
                    var archivoDoc = new FileInfo(NombreArchivo);
                    if (Directory.Exists(Ruta + IdMaestro.ToString()))
                    {

                    }
                }
            }
        }

        public void Eliminar(string NumeroControl)
        {
            _MaestrosAccesoDatos.Eliminar(NumeroControl);
        }

        public void Guardar(Maestros maestros)
        {
            _MaestrosAccesoDatos.Guardar(maestros);
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

        private bool EmailValido(string E_mail)
        {
            var regex = new Regex(@"/[\w -\.] +@([\w -] +\.) +[\w -]{ 2,4}/");
            var match = regex.Match(E_mail);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
        private bool TarjetaValida(int Tarjeta)
        {
            var regex = new Regex(@"[0-9]{1,9}(\.[0-9]{0,2})?$");
            var match = regex.Match(Tarjeta.ToString());
            if (match.Success)
            {
                return true;
            }
            return false;
        }

        //-----------------------------------------------------------------------------------------------

        public List<Maestros> ObtenerLista(string filtro)
        {
            var list = new List<Maestros>();
            list = _MaestrosAccesoDatos.ObtenerLista(filtro);
            return list;
        }
        public Tuple<bool, string> EsUsuarioValido(Maestros maestros)
        {
            string mensaje = "";
            bool valido = true;

            if (maestros.Nombre.Length == 0)
            {
                mensaje = "El nombre del Maestro es necesario";
                valido = false;
            }
            else if (!NombreValido(maestros.Nombre))
            {
                mensaje = "Escribe un fomato valido para el nombre";
                valido = false;
            }
            else if (maestros.Nombre.Length > 100)
            {
                mensaje = "La longitud para nombre no debe exceder 100 caracteres";
                valido = false;
            }
            return Tuple.Create(valido, mensaje);
        }

        public Tuple<bool, string> EsApellidoPValido(Maestros maestros)
        {
            string mensaje = "";
            bool valido = true;

            if (maestros.ApellidoP.Length == 0)
            {
                mensaje = "El Apellido Paterno del Maestro es necesario";
                valido = false;
            }
            else if (!ApellidoPValido(maestros.ApellidoP))
            {
                mensaje = "Escribe un fomato valido para el Apellido Paterno";
                valido = false;
            }
            else if (maestros.ApellidoP.Length > 100)
            {
                mensaje = "La longitud para Apellido Paterno es máximo 100 caracteres";
                valido = false;
            }
            return Tuple.Create(valido, mensaje);
        }

        public Tuple<bool, string> EsApellidoMValido(Maestros maestros)
        {
            string mensaje = "";
            bool valido = true;

            if (maestros.ApellidoM.Length == 0)
            {
                mensaje = "El Apellido Materno del Alumno es necesario";
                valido = false;
            }
            else if (!ApellidoMValido(maestros.ApellidoM))
            {
                mensaje = "Escribe un fomato valido para el Apellido Materno";
                valido = false;
            }
            else if (maestros.ApellidoM.Length > 100)
            {
                mensaje = "La longitud para Apellido Materno de maestros es máximo 100 caracteres";
                valido = false;
            }
            return Tuple.Create(valido, mensaje);
        }
        //-----------------------------------------------------------------------------------------
      
        public Tuple<bool, string> EsEmailValido(Maestros maestros)
        {
            string mensaje = "";
            bool valido = true;

            if (maestros.Email.Length == 0)
            {
                mensaje = "El Email es necesario";
                valido = false;
            }
            else if (!EmailValido(maestros.Email))
            {
                mensaje = "Escribe un fomato valido para el Email";
                valido = false;
            }
            else if (maestros.Email.Length > 100)
            {
                mensaje = "La longitud para Email de maestros es máximo 250 caracteres";
                valido = false;
            }
            return Tuple.Create(valido, mensaje);
        }


        //-----------------------------------------------------------------------------------------

        public Tuple<bool, string> EsTarjetaValida(Maestros maestros)
        {
            string mensaje = "";
            bool valido = true;

            if (maestros.Tarjeta.Length >= 15)
            {
                mensaje = "El numero de tarjeta no puede ser mayor a 15 digitos";
                valido = false;
            }
            return Tuple.Create(valido, mensaje);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ControlEscolarApp;
using AccesoDatos.ContolEscolarApp;
using Extensions.ControlEscolar;
using System.Text.RegularExpressions;
using System.IO;

namespace LogicaNegocio.ControlEscolarApp
{
    public class EscuelasManejador
    {
        private EscuelasAccesoaDatos _EscuelaAccesoaDatos = new EscuelasAccesoaDatos();
        private RutasManager _rutasManager;
        public EscuelasManejador()
        {
            _EscuelaAccesoaDatos = new EscuelasAccesoaDatos();
        }

       /* public void Eliminar(RutasManager rutasManager)
        {
            _rutasManager = rutasManager;
        }*/
        public void Eliminar(int IdEscuela)
        {
             _EscuelaAccesoaDatos.Eliminar(IdEscuela);
        }
        public void Guardar(Escuela escuelas)
        {
            _EscuelaAccesoaDatos.Guardar(escuelas);
        }

        public Escuela GetEscuela()
        {
            return _EscuelaAccesoaDatos.GetEscuela();
        }
        public bool CargarLogo(string fileName)
        {
            var archivoNombre = new FileInfo(fileName);
            if (archivoNombre.Length >500000)
            {
                return false;
            }

            return true;
        }
        public void LimpiarDocumento(int escuelaId, string tipoDocumento)
        {
            string rutaRepositorio = "";
            string extension = "";
            switch (tipoDocumento)
            {
                case "png":
                    rutaRepositorio = _rutasManager.RutaRepositoriosLogos;
                    extension = "*.png";
                    break;
                case "jpg":
                    rutaRepositorio = _rutasManager.RutaRepositoriosLogos;
                    extension = "*.jpg";
                    break;

            }
            string ruta = Path.Combine(rutaRepositorio, escuelaId.ToString());
            if (Directory.Exists(ruta))
            {
                var obtenerArchivos = Directory.GetFiles(ruta, extension);
                FileInfo archivoAnterior;
                if (obtenerArchivos.Length != 0)
                {
                    archivoAnterior = new FileInfo(obtenerArchivos[0]);

                    if (archivoAnterior.Exists)
                    {
                        archivoAnterior.Delete();
                    }
                }
            }
        }

        public void GuardarLogo(string fiileName, int escuelaId)
        {
            if (!string.IsNullOrEmpty(fiileName))
            {
                var archivoDocument = new FileInfo(fiileName);
                string ruta = Path.Combine(_rutasManager.RutaRepositoriosLogos, escuelaId.ToString());
                if (Directory.Exists(ruta))
                {
                    var obtenerArchivos = Directory.GetFiles(ruta);
                    FileInfo ArchivoAnterior;
                    if (obtenerArchivos.Length != 0)
                    {
                        ArchivoAnterior = new FileInfo(obtenerArchivos[0]);
                        if (ArchivoAnterior.Exists)
                        {
                            ArchivoAnterior.Delete();
                            archivoDocument.CopyTo(Path.Combine(ruta, archivoDocument.Name));
                        }
                    }
                    else
                    {
                        archivoDocument.CopyTo(Path.Combine(ruta, archivoDocument.Name));
                    }
                }
                else
                {
                    _rutasManager.crearRepositorioLogosEscuelas(escuelaId);
                    archivoDocument.CopyTo(Path.Combine(ruta, archivoDocument.Name));
                }
            }
        }
        public string GetNombreLogo(string fileName)
        {
            var archivoNombre = new FileInfo(fileName);
            return archivoNombre.Name;
        }
        private bool NombreValido(string nombre)
        {
            var regex = new Regex(@"^[A-Za-z]+( [A-Za-z]+)*$");
            var match = regex.Match(nombre);

            if (match.Success)
            {
                return true;
            }
            return false;
        }

        /*private bool TelefonoValido(string telefono)
        {
            var regex = new Regex(@"[0-9]{1,9}(\.[0-9]{0,2})?$");
            var match = regex.Match(telefono);
            if (match.Success)
            {
                return true;
            }
            return false;
        }

        public List<Escuela> ObtenerLista(string filtro)
        {
            var list = new List<Escuela>();
            list = _EscuelaAccesoaDatos.ObtenerLista(filtro);
            return list;
        }

        public Tuple<bool, string> EsEscuelaValido(Escuela escuela)
        {
            string mensaje = "";
            bool valido = true;

            if (escuela.Nombre.Length == 0)
            {
                mensaje = "El nombre de la escuela es necesario";
                valido = false;
            }
            else if (!NombreValido(escuela.Nombre))
            {
                mensaje = "Escribe un fomato valido para el nombre";
                valido = false;
            }
            else if (escuela.Nombre.Length > 15)
            {
                mensaje = "La longitud para nombre de escuela es máximo 15 caracteres";
                valido = false;
            }
            return Tuple.Create(valido, mensaje);
        }

        public Tuple<bool, string> EsTelefonoValido(Escuela escuela)
        {
            string mensaje = "";
            bool valido = true;

            if (Convert.ToString(escuela.Telefono).Length >= 15)
            {
                mensaje = "El telefono no puede ser mayor a 15 digitos";
                valido = false;
            }
            return Tuple.Create(valido, mensaje);
        }*/
    }
}

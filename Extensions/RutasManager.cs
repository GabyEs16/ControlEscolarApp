using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades.ControlEscolarApp;


namespace Extensions
{
    public class RutasManager
    {
        private string _appPath;
        private const string LOGOS = "Logos";

        public RutasManager(string appPath)
        {
            //Pasa el constructor de appPath privada a la global para trabajar 
            _appPath = appPath;
        }
        public string RutaRepositoriosLogos
        {
            //Para evitar combinaciones toma la ruta completa
            get { return Path.Combine(_appPath, LOGOS); }
        }
        public void crearRepositorioLogos()
        {
            //Si la ruta existe no se crea
            if (Directory.Exists(RutaRepositoriosLogos))
            {
                //Si no existe se crea Directorio. // Variable = Ruta C://
                Directory.CreateDirectory(RutaRepositoriosLogos);
            }
        }
        public void crearRepositorioLogosEscuelas(int escuelaId)
        {
            //sirve para verificar la existencia de las rutas
            crearRepositorioLogos();
            string ruta = Path.Combine(RutaRepositoriosLogos, escuelaId.ToString());
            if (Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
        }
        public string RutaLogoEscuela(Escuela escuela)
        {
            return Path.Combine(RutaRepositoriosLogos, escuela.Idescuela.ToString(), escuela.Logo);
        }
    }
    
}

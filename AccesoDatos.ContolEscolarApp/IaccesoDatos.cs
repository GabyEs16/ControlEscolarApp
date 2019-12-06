using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.ContolEscolarApp
{
    interface IaccesoDatos
    {
        void Guardar();
        void Eliminar();
        List<object> ObtenerLista();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ControlEscolarApp
{
    class NoControl
    {
            public string Generate(string año, int longitud, string extension)
            {
                string Short = "";
                string cadena = "";
                Random r = new Random();

                for (int i = 0; i < año.Length; i++)
                {
                    if (i > 1)
                    {
                        Short += año[i];
                    }
                }

                for (int i = 0; i < longitud; i++)
                {

                    int numero = r.Next(1, 36);
                    switch (numero)
                    {
                        case 1:
                            cadena += "L";
                            break;
                        case 2:
                            cadena += "D";
                            break;
                        case 3:
                            cadena += "2";
                            break;
                        case 4:
                            cadena += "0";
                            break;
                        case 5:
                            cadena += "0";
                            break;
                        case 6:
                            cadena += "9";
                            break;
                        default:
                            break;
                    }
                }

                return extension + Short + cadena;
            }
     }
}

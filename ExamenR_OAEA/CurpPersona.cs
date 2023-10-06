using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenR_OAEA
{
    internal class CurpPersona
    {
        //* public string  ObtenerSexo(string curp)
        //{

          /*  char SexoChar = curp[10];
            return (SexoChar == "H" || SexoChar == "h" )?"Nombre" : "Mujer";

        }*/
        



        public string ObtenerFechaNacimiento(string curp)
        {

            string dia = curp.Substring(8,2);
            string mes = curp.Substring(6,2);
            string año = curp.Substring(4,2);
            return dia + "/" + mes + "/19" + año; 

        }


      


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_2.Entidades
{
    public class Funciones
    {

        public bool ValidarVacio(string valor)
        {
              
            if (valor.Equals(" "))
            {
                return false;
                
            }
            else
            {
                return true;
            }
        }
    }
}

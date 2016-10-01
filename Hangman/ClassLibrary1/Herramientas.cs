using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.BusinessLogic
{
    public class Herramientas
    {

        private bool UnaLetraEsContenidaEnUnaPalabra(string unaLetra, string unaPalabra)
        {

            bool elResultado;

            elResultado = unaPalabra.ToLower().Contains(unaLetra.ToString().ToLower());

            return elResultado;

        }


    }
}

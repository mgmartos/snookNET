using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snookNET.Entities
{
    [Serializable]
    internal class Jugador
    {
        string NombreJugador { get; set; }  
        public Jugador()
        {
            NombreJugador = "";
        }
    }
}

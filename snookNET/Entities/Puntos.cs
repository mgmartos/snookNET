using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snookNET.Entities
{
    [Serializable]
    internal class Puntos
    {
        public  int Roja = 1;
        public  int Amarilla = 2;
        public  int Verde = 3;
        public  int Marron = 4;
        public  int Azul = 5;
        public  int Rosa = 6;
        public  int Negra = 7;

        public  int PuntosPlayer1 { get; set; }
        public  int PuntosPlayer2 { get; set; }
        public  int FramesPlayer1 { get; set; }
        public  int FramesPlayer2 { get; set; }
        public  int PuntosRestantes { get; set; }
        public  int Diferencia { get; set; }
        public int PlayerActivo { get; set; }
        public int RojasEmbocadas { get; set; }
        public int ColoresEmbocadas { get; set; }
        public char BolaAnterior { get; set; }
        public string ColorBola { get; set; }


        public Puntos()
        {
            PuntosPlayer1 =
            PuntosPlayer2 =
            FramesPlayer1 =
            FramesPlayer2 =

            Diferencia = 0;
            PuntosRestantes = 147;
            PlayerActivo = 1;
            RojasEmbocadas = 0;
            ColoresEmbocadas = 0;
            BolaAnterior = 'C';
        }

        public void CambiaPlayer()
        {
           PlayerActivo =  PlayerActivo == 1 ?  2 :  1;
        }
    }
}

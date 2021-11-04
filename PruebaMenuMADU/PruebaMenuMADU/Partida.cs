using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMenuMADU
{
    public class Partida
    {
        public int Puntuacion { get; set; }

        public String Dificultad { get; set; }

        public DateTime Fecha { get; set; }

        public Jugador Jugador { get; set; }

        public Partida()
        {

        }

        public Partida(int Puntuacion, String Dificultad, DateTime Fecha, Jugador Jugador)
        {
            this.Puntuacion = Puntuacion;
            this.Dificultad = Dificultad;
            this.Fecha = Fecha;
            this.Jugador = Jugador;
        }


    }
}

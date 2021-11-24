using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMenuMADU
{
    public class Partida
    {
        public int puntuacion { get; set; }

        public String dificultad { get; set; }

        public DateTime fecha { get; set; }

        public Jugador jugador { get; set; }

        public Partida()
        {

        }

        public Partida(int Puntuacion, String Dificultad, DateTime Fecha, Jugador Jugador)
        {
            this.puntuacion = Puntuacion;
            this.dificultad = Dificultad;
            this.fecha = Fecha;
            this.jugador = Jugador;
        }


    }
}

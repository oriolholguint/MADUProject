using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMenuMADU
{
    public class Personaje
    {
        public String Nombre { get; set; }

        public String Imagen { get; set; }

        public int PosicionRanking { get; set; }

        public Personaje()
        {

        }

        public Personaje(String Nombre, String Imagen, int PosicionRanking)
        {
            this.Nombre = Nombre;
            this.Imagen = Imagen;
            this.PosicionRanking = PosicionRanking;
        }
    }
}

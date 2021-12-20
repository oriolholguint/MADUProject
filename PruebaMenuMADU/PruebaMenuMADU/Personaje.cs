using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMenuMADU
{
    public class Personaje
    {
        public String nombre { get; set; }

        public String imagen { get; set; }

        public int posicionRanking { get; set; }

        public Personaje()
        {

        }

        public Personaje(String Nombre, String Imagen, int PosicionRanking)
        {
            this.nombre = Nombre;
            this.imagen = Imagen;
            this.posicionRanking = PosicionRanking;
        }
    }
}

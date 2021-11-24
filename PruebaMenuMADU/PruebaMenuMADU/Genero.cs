using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMenuMADU
{
    public class Genero
    {
        public String nombre { get; set; }
        
        public String musicaFondo { get; set; }

        public String imagenFondo { get; set; }

        public String imagenMenu { get; set; }

        public List<Personaje> personajes { get; set; }

        public Partida [] partidas { get; set; }

        public List<Pregunta> preguntas { get; set; }

     

        public Genero()
        {

        }

        public Genero(String Nombre, String MusicaFondo, String ImagenFondo, String ImagenMenu,
                      List<Personaje>  Personajes, Partida[] Partidas, List <Pregunta> Preguntas)
        {
            this.nombre = Nombre;
            this.musicaFondo = MusicaFondo;
            this.imagenFondo = ImagenFondo;
            this.imagenMenu = ImagenMenu;
            this.personajes = Personajes;
            this.partidas = Partidas;
            this.preguntas = Preguntas;
        }
    }
}

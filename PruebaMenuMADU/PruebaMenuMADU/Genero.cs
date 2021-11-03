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
        public String Nombre { get; set; }
        public String MusicaFondo { get; set; }
        public String ImagenFondo { get; set; }
        public String ImagenMenu { get; set; }
        public BindingList<Pregunta> Preguntas { get; set; }

        public Genero()
        {

        }


        public Genero(String Nombre, String MusicaFondo, String AudioFondo, String ImagenMenu, BindingList<Pregunta> Preguntas)
        {

            this.Nombre = Nombre;
            this.MusicaFondo = MusicaFondo;
            this.ImagenFondo = AudioFondo;
            this.ImagenMenu = ImagenMenu;
            this.Preguntas = Preguntas;
        }


    }




}

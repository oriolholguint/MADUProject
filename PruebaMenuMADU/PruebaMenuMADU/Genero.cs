﻿using System;
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

        public Personaje [] Personajes { get; set; }

        public Partida [] Partidas { get; set; }

        public Pregunta [] Preguntas { get; set; }

        public Genero()
        {

        }

        public Genero(String Nombre, String MusicaFondo, String ImagenFondo, String ImagenMenu,
                      Personaje[] Personajes, Partida[] Partidas, Pregunta[] Preguntas)
        {
            this.Nombre = Nombre;
            this.MusicaFondo = MusicaFondo;
            this.ImagenFondo = ImagenFondo;
            this.ImagenMenu = ImagenMenu;
            this.Personajes = Personajes;
            this.Partidas = Partidas;
            this.Preguntas = Preguntas;
        }
    }
}

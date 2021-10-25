﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PruebaMenuMADU
{
    public class Pregunta
    {
        public int id { get; set; }

        public String NombrePregunta { get; set; }

        public String Genero { get; set; }

        public String Tipo { get; set; }

        public String Url { get; set; }

        public Boolean MayorDeEdad { get; set; }

        public Respuesta[] respuestas { get; set; }


        public Pregunta()
        {

        }

        public Pregunta(int id, String NombrePregunta, String Genero, String Tipo, String UrlImgAudio, Boolean MayorDeEdad, Respuesta[] respuestas)
        {
            this.id = id;
            this.NombrePregunta = NombrePregunta;
            this.Genero = Genero;
            this.Tipo = Tipo;
            this.Url = UrlImgAudio;
            this.MayorDeEdad = MayorDeEdad;
            this.respuestas = respuestas;
            
        }

        public override string ToString()
        {
            return "id: " + this.id + ", Nombre Pregunta: " + this.NombrePregunta + ", Genero: " + this.Genero + ", Tipo: " + this.Tipo + ", Url: " + this.Url + ", Mayor de Edad: " + this.MayorDeEdad;
        }


    }
}

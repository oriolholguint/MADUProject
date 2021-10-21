using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMenuMADU
{
    class Pregunta
    {
        public int id { get; set; }

        public String NombrePregunta { get; set; }

        public String Genero { get; set; }

        public String Tipo { get; set; }

        public String UrlImgAudio { get; set; }

        public Boolean MayorDeEdad { get; set; }

        public BindingList<Respuesta> ListaRespuestas { get; set; }


        public Pregunta()
        {

        }

        public Pregunta(int id, String NombrePregunta, String Genero, String Tipo, String UrlImgAudio, Boolean MayorDeEdad)
        {
            this.id = id;
            this.NombrePregunta = NombrePregunta;
            this.Genero = Genero;
            this.Tipo = Tipo;
            this.UrlImgAudio = UrlImgAudio;
            this.MayorDeEdad = MayorDeEdad;
        }


    }
}

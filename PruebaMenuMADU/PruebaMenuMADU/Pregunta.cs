using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PruebaMenuMADU
{
    public class Pregunta
    {
       
        public String NombrePregunta { get; set; }

        public String Genero { get; set; }
                
        public String Imagen { get; set; }
        public String Sonido { get; set; }

        public Boolean MayorDeEdad { get; set; }

        public Respuesta[] respuestas { get; set; }


        public Pregunta()
        {

        }

        public Pregunta(String NombrePregunta, String Genero,String Imagen, String Sonido, Boolean MayorDeEdad, Respuesta[] respuestas)
        {
            
            this.NombrePregunta = NombrePregunta;
            this.Genero = Genero;
            this.Imagen = Imagen;
            this.Sonido = Sonido;
            this.MayorDeEdad = MayorDeEdad;
            this.respuestas = respuestas;
            
        }



        //public override string ToString()
        //{
        //    return "id: " + this.id + ", Nombre Pregunta: " + this.NombrePregunta + ", Genero: " + this.Genero + ", Tipo: " + this.Tipo + ", Url: " + this.Url + ", Mayor de Edad: " + this.MayorDeEdad;
        //}


    }
}

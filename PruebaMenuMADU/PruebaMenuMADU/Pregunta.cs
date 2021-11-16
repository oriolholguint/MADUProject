using Newtonsoft.Json;
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
        public String PreguntaDescripcion { get; set; }

        [JsonIgnore]
        public String Genero { get; set; }

        public String Imagen { get; set; }

        public String Sonido { get; set; }

        public Boolean EsMayorEdad { get; set; }

        public Respuesta[] Respuestas { get; set; }

        public Pregunta()
        {

        }

        public Pregunta(String PreguntaDescripcion, String Genero,String Imagen, String Sonido, Boolean MayorDeEdad, Respuesta[] Respuestas)
        {

            this.PreguntaDescripcion = PreguntaDescripcion;
            this.Imagen = Imagen;
            this.Sonido = Sonido;
            this.Genero = Genero;
            this.EsMayorEdad = EsMayorEdad;
            this.Respuestas = Respuestas;

        }
        public Pregunta(String PreguntaDescripcion, String Imagen, String Sonido, Boolean MayorDeEdad, Respuesta[] Respuestas)
        {

            this.PreguntaDescripcion = PreguntaDescripcion;
            this.Imagen = Imagen;
            this.Sonido = Sonido;
            this.EsMayorEdad = EsMayorEdad;
            this.Respuestas = Respuestas;

        }

        public override string ToString()
        {
            return "Pregunta Descripcion: " + PreguntaDescripcion +
                   "Imagen: " + Imagen +
                   "Sonido: " + Sonido +
                   "EsMayorEdad: " + EsMayorEdad +
                   "Respuestas: " + Respuestas;
        }
    }
}

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
        public String preguntaDescripcion { get; set; }

        [JsonIgnore]
        public String genero { get; set; }

        public String imagen { get; set; }

        public String sonido { get; set; }

        public Boolean esMayor { get; set; }

        public Respuesta[] respuestas { get; set; }

        public Pregunta()
        {

        }

        public Pregunta(String PreguntaDescripcion, String Genero,String Imagen, String Sonido, Boolean MayorDeEdad, Respuesta[] Respuestas)
        {

            this.preguntaDescripcion = PreguntaDescripcion;
            this.imagen = Imagen;
            this.sonido = Sonido;
            this.genero = Genero;
            this.esMayor = esMayor;
            this.respuestas = Respuestas;

        }
        public Pregunta(String PreguntaDescripcion, String Imagen, String Sonido, Boolean MayorDeEdad, Respuesta[] Respuestas)
        {

            this.preguntaDescripcion = PreguntaDescripcion;
            this.imagen = Imagen;
            this.sonido = Sonido;
            this.esMayor = esMayor;
            this.respuestas = Respuestas;

        }

        public override string ToString()
        {
            return "Pregunta Descripcion: " + preguntaDescripcion +
                   "Imagen: " + imagen +
                   "Sonido: " + sonido +
                   "EsMayorEdad: " + esMayor +
                   "Respuestas: " + respuestas;
        }
    }
}

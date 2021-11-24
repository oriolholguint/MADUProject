using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMenuMADU
{

     public class Respuesta
    {
        public String respuestaDescripcion { get; set; }

        public Boolean esCorrecta { get; set; }

        public Respuesta()
        {

        }

        public Respuesta(String RespuestaDescripcion,Boolean EsCorrecta)
        {
            this.respuestaDescripcion = RespuestaDescripcion;
            this.esCorrecta = EsCorrecta;
        }

        public override string ToString()
        {
            return "Nombre Respuesta: " + this.respuestaDescripcion + ", Correcta: " + this.esCorrecta;
        }
    }
}

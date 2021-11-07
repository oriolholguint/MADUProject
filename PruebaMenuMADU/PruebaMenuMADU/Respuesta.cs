using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMenuMADU
{

     public class Respuesta
    {
        public String RespuestaDescripcion { get; set; }

        public Boolean EsCorrecta { get; set; }

        public Respuesta()
        { 
        
        }

        public Respuesta(String RespuestaDescripcion,Boolean EsCorrecta)
        {
            this.RespuestaDescripcion = RespuestaDescripcion;
            this.EsCorrecta = EsCorrecta;
        }

        public override string ToString()
        {
            return "Respuesta Descripcion: " + this.RespuestaDescripcion + 
                   ", EsCorrecta: " + this.EsCorrecta;
        }
    }
}

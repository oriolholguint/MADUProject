using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMenuMADU
{
     public class Respuesta
    {
       
        public String NombreRespuesta { get; set; }
        public Boolean Correcta { get; set; }


        public Respuesta()
        { 
        
        }


        public Respuesta(String NombreRespuesta,Boolean Correcta)
        {
            
            this.NombreRespuesta = NombreRespuesta;
            this.Correcta = Correcta;
        }


        public override string ToString()
        {
            return "Nombre Respuesta: " + this.NombreRespuesta + ", Correcta: " + this.Correcta;
        }


    }
}

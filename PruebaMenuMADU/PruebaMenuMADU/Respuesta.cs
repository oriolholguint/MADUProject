using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMenuMADU
{
    class Respuesta
    {
        public int id { get; set; }
        public String NombreRespuesta { get; set; }
        public Boolean Correcta { get; set; }


        public Respuesta()
        { 
        
        }


        public Respuesta(int id,String NombreRespuesta,Boolean Correcta)
        {
            this.id = id;
            this.NombreRespuesta = NombreRespuesta;
            this.Correcta = Correcta;
        }


        public override string ToString()
        {
            return "id: " + this.id + ", Nombre Respuesta: " + this.NombreRespuesta + ", Correcta: " + this.Correcta;
        }


    }
}

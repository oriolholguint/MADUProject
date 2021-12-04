using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMenuMADU
{
    public class Administrador
    {
        public String nombre { get; set; }
        public String password { get; set; }
        public String fraseRecuperacion { get; set; }

        public Administrador(String nombre, String password, String fraseRecuperacion)
        {
            this.nombre = nombre;
            this.password = password;
            this.fraseRecuperacion = fraseRecuperacion;
        }
    }
}

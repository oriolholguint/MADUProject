using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaMenuMADU
{
    public class Jugador
    {
        public String Nombre{ get; set; }

        public String Contrasenna { get; set; }
        
        public int Edad { get; set; }

        public String Avatar { get; set; }

        public String Email { get; set; }

        public Jugador()
        {

        }

        public Jugador (String Nombre, String Contrasenna, int Edad, String Avatar, String Email)
        {
            this.Nombre = Nombre;
            this.Contrasenna = Contrasenna;
            this.Edad = Edad;
            this.Avatar = Avatar;
            this.Email = Email;
        }

    }
}

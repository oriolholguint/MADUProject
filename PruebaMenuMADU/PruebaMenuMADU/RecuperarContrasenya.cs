using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaMenuMADU
{
    public partial class RecuperarContrasenya : Form
    {
        private static char USER_SEPARATOR = ':';
        private String userToChange;

        public RecuperarContrasenya()
        {
            InitializeComponent();
        }

        private void btnConfirmarUsuario_Click(object sender, EventArgs e)
        {
            if (ComprobarCamposInfoUser()) //Compruebo que los campos estan rellenados y no estan vacios o son nulos
            {
                //Compruebo que el usuario existe y la frase de recuperar password es correcta
                if (ComprobarUsuario(txtUsuario.Text, txtFraseRecuperacion.Text)) 
                {
                    lblError.Visible = false; //En el caso que el mensaje de error este activo lo desactivo

                    //Oculto los controles del username y frase de recuperacion
                    lblUsuario.Visible = false;
                    lblFraseRecuperacion.Visible = false;
                    txtUsuario.Visible = false;
                    txtFraseRecuperacion.Visible = false;
                    btnConfirmarUsuario.Visible = false;

                    //Muestro los controles de password y repetir password
                    lblPassword.Visible = true;
                    lblRepeatPassword.Visible = true;
                    txtPassword.Visible = true;
                    txtRepeatPassword.Visible = true;
                    btnConfirmarPassword.Visible = true;

                    lblSaludarUsuario.Visible = true;
                    lblSaludarUsuario.Text = "Hola, " + txtUsuario.Text + "!";
                    userToChange = txtUsuario.Text;
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Los datos introducidos no son correctos";
                }
            }
        }

        private void btnConfirmarPassword_Click(object sender, EventArgs e)
        {
            //Compruebo que los campos password y repeat password sean correctos
            if(ComprobarCamposPassword())
            {
                EliminarUsuario(userToChange);
                AgregarUsuario(userToChange);
                MessageBox.Show("Se ha cambiado el password correctamente", "Cambiar password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void EliminarUsuario(String userToRemove)
        {
            List<String> InfoUsuarios = new List<String>();

            try
            {
                StreamReader sr = new StreamReader("..\\..\\etc\\passwd.txt");

                String linea;

                while ((linea = sr.ReadLine()) != null)
                {
                    String[] info = linea.Split(':');
                    if (!info[0].Equals(userToRemove))
                    {
                        InfoUsuarios.Add(linea);
                    }
                }

                sr.Close();

                StreamWriter sw = new StreamWriter("..\\..\\etc\\passwd.txt");

                //Guardo usuarios anteriores
                foreach (String userLine in InfoUsuarios)
                {
                    sw.Write(userLine + "\n");
                }

                sw.Close();                
            }
            catch (FileNotFoundException ex)
            {

            }
        }

        private void AgregarUsuario(String userToAdd)
        {
            try
            {
                StreamWriter sw = new StreamWriter("..\\..\\etc\\passwd.txt", true);

                String encryptPassword = Encriptar(txtPassword.Text);
                String encryptPhrase = Encriptar(txtFraseRecuperacion.Text);
                sw.Write(userToAdd + USER_SEPARATOR + encryptPassword + USER_SEPARATOR + encryptPhrase + "\n");

                sw.Close();
            }
            catch (FileNotFoundException ex)
            {

            }
        }

        private Boolean ComprobarCamposInfoUser()
        {
            Boolean CamposRellenados = true;

            if(String.IsNullOrEmpty(txtUsuario.Text))
            {
                errorProvider.SetError(txtUsuario, "El campo no puede estar vacio");
                CamposRellenados = false;
            }

            if(String.IsNullOrEmpty(txtFraseRecuperacion.Text))
            {
                errorProvider.SetError(txtFraseRecuperacion, "El campo no puede estar vacio");
                CamposRellenados = false;
            }

            return CamposRellenados;
        }

        private Boolean ComprobarCamposPassword()
        {
            Boolean CamposCorrectos = true;

            if(String.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "El campo no puede estar vacio");
                CamposCorrectos = false;
            }

            if(String.IsNullOrEmpty(txtRepeatPassword.Text))
            {
                errorProvider.SetError(txtRepeatPassword, "El campo no puede estar vacio");
                CamposCorrectos = false;
            }

            if(!txtRepeatPassword.Text.Equals(txtPassword.Text))
            {
                errorProvider.SetError(txtRepeatPassword, "El password no coincide");
                CamposCorrectos = false;
            }

            return CamposCorrectos;
        }

        private Boolean ComprobarUsuario(String usuario, String fraseRecuperacion)
        {
            Boolean usuarioExiste = false;

            try
            {
                StreamReader sr = new StreamReader("..\\..\\etc\\passwd.txt");

                String linea;

                while ((linea = sr.ReadLine()) != null && !usuarioExiste)
                {
                    String[] info = linea.Split(':');
                    if (info[0].Equals(usuario) && ComprobarFraseRecuperacion(fraseRecuperacion, info[2]))
                    {
                        usuarioExiste = true;
                    }
                }

                sr.Close();
            }
            catch (FileNotFoundException ex)
            {

            }

            return usuarioExiste;
        }

        private Boolean ComprobarFraseRecuperacion(String text, String fraseRecuperacion)
        {
            return BCrypt.Net.BCrypt.Verify(text, fraseRecuperacion);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private String Encriptar(String text)
        {
            String hashedPassword = BCrypt.Net.BCrypt.HashPassword(text);

            return hashedPassword;
        }
    }
}

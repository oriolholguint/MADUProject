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
    public partial class Registro : Form
    {
        private static char USER_SEPARATOR = ':';

        public Registro()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            LimpiarErrores();

            if(ComprobarCampos())
            {
                String encryptPassword = Encriptar(txtPassword.Text);
                String encryptPhrase = Encriptar(txtFraseRecuperacion.Text);

                try 
                {
                    StreamWriter sw = new StreamWriter("..\\..\\etc\\passwd.txt", true);

                    sw.WriteLine(txtNombreUsuario.Text + USER_SEPARATOR + encryptPassword + USER_SEPARATOR + encryptPhrase + "\n");
                    MessageBox.Show("Usuario registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    sw.Close();
                }
                catch(FileNotFoundException ex)
                {

                }

                LimpiarCampos();
            }

        }

        private Boolean ComprobarCampos()
        {
            Boolean registroCorrecto = true;

            if(String.IsNullOrEmpty(txtNombreUsuario.Text) || txtNombreUsuario.Text.Contains(":"))
            {
                errorProviderRegistro.SetError(txtNombreUsuario, "El nombre de usuario no puede estar vacio o es incorrecto");
                registroCorrecto = false;
            }
            else if(!ComprobarUsuario(txtNombreUsuario.Text))
            {
                errorProviderRegistro.SetError(txtNombreUsuario, "El usuario ya existe");
                registroCorrecto = false;

            }

            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                errorProviderRegistro.SetError(txtPassword, "El campo password no puede estar vacio");
                registroCorrecto = false;
            }

            if(String.IsNullOrEmpty(txtRepeatPassword.Text))
            {
                errorProviderRegistro.SetError(txtRepeatPassword, "El campo repeat password no puede estar vacio");
                registroCorrecto = false;
            }
            else if(!txtRepeatPassword.Text.Equals(txtPassword.Text))
            {
                errorProviderRegistro.SetError(txtRepeatPassword, "El password no coincide");
                registroCorrecto = false;
            }

            if(String.IsNullOrEmpty(txtFraseRecuperacion.Text))
            {
                errorProviderRegistro.SetError(txtFraseRecuperacion, "El campo frase recuperacion no puede estar vacio");
                registroCorrecto = false;
            }

            return registroCorrecto;
        }

        public void LimpiarErrores()
        {
            errorProviderRegistro.Clear();
        }

        public void LimpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtPassword.Text = "";
            txtRepeatPassword.Text = "";
            txtFraseRecuperacion.Text = "";
        }

        private String Encriptar(String text)
        {
            Byte[] passwordEncriptada = System.Text.Encoding.Unicode.GetBytes(text);
            String result = Convert.ToBase64String(passwordEncriptada);
            return result;
        }

        private Boolean ComprobarUsuario(String usuario)
        {
            Boolean usuarioCorrecto = true;

            try
            {
                StreamReader sr = new StreamReader("..\\..\\etc\\passwd.txt", true);

                String linea;

                while( (linea = sr.ReadLine()) != null )
                {
                    String[] userInfo = linea.Split(USER_SEPARATOR);

                    if(userInfo[0].Equals(usuario))
                    {
                        usuarioCorrecto = false;
                    }
                }

                sr.Close();
            }
            catch(FileNotFoundException ex)
            {

            }

            return usuarioCorrecto;
        }
    }
}

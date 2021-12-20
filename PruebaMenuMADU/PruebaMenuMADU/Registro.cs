using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaMenuMADU
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            LimpiarErrores();

            if (ComprobarCampos())
            {
                UserFileManager.AgregarUsuario(txtNombreUsuario.Text, txtPassword.Text, txtFraseRecuperacion.Text);

                LimpiarCampos();
            }

        }

        private Boolean ComprobarCampos()
        {
            Boolean registroCorrecto = true;

            if (String.IsNullOrEmpty(txtNombreUsuario.Text) || txtNombreUsuario.Text.Contains(":"))
            {
                errorProviderRegistro.SetError(txtNombreUsuario, "El nombre de usuario no puede estar vacio o es incorrecto");
                registroCorrecto = false;
            }
            else if (UserFileManager.ComprobarUsuarioExiste(txtNombreUsuario.Text))
            {
                errorProviderRegistro.SetError(txtNombreUsuario, "El usuario ya existe");
                registroCorrecto = false;

            }

            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                errorProviderRegistro.SetError(txtPassword, "El campo password no puede estar vacio");
                registroCorrecto = false;
            }

            if (String.IsNullOrEmpty(txtRepeatPassword.Text))
            {
                errorProviderRegistro.SetError(txtRepeatPassword, "El campo repeat password no puede estar vacio");
                registroCorrecto = false;
            }
            else if (!txtRepeatPassword.Text.Equals(txtPassword.Text))
            {
                errorProviderRegistro.SetError(txtRepeatPassword, "El password no coincide");
                registroCorrecto = false;
            }

            if (String.IsNullOrEmpty(txtFraseRecuperacion.Text))
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


    }
}

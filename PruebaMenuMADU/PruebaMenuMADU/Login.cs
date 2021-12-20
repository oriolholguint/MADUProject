using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PruebaMenuMADU
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        /*
         Los usuarios se guardan en un fichero llamado passwd que se encuentra en la carpeta etc
         Formato de los usuarios --> username:password encriptada
         */

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(UserFileManager.ComprobarLogin(txtUser.Text, txtPassword.Text))
            {
                txtUser.Text = "";
                txtPassword.Text = "";

                MainForm mainForm = new MainForm(this);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                lblError.Visible = true;
            }
        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {
            RecuperarContrasenya a = new RecuperarContrasenya();
            a.ShowDialog();
        }

        

        
    }
}

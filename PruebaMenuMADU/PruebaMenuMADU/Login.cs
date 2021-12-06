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
    public partial class Login : Form
    {

        private static String KEY = "jwey89e09ewhfo24";

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
            if(ComprobarUsuario(txtUser.Text, txtPassword.Text))
            {
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

        private Boolean ComprobarUsuario(String usuario, String password)
        {
            Boolean loginCorrecto = false;
            String passwordEncriptada = Encriptar(txtPassword.Text, KEY);
            
            try
            {
                StreamReader sr = new StreamReader("..\\..\\etc\\passwd.txt");

                String linea;

                while ((linea = sr.ReadLine()) != null && !loginCorrecto)
                {
                    String [] info = linea.Split(':');
                    if(info[0].Equals(usuario) && info[1].Equals(passwordEncriptada))
                    {
                        loginCorrecto = true;
                        txtUser.Text = "";
                        txtPassword.Text = "";
                    }
                }

                sr.Close();
            }
            catch(FileNotFoundException ex)
            {
             
            }

            return loginCorrecto;
        }

        private String Encriptar(String text, String key)
        {
            byte[] keyArray;
            byte[] encriptar = Encoding.UTF8.GetBytes(text);

            keyArray = Encoding.UTF8.GetBytes(key);

            var tdes = new TripleDESCryptoServiceProvider();

            tdes.Key = keyArray; 
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] result = cTransform.TransformFinalBlock(encriptar, 0, encriptar.Length);
            tdes.Clear();

            return Convert.ToBase64String(result, 0, result.Length);
        }
    }
}

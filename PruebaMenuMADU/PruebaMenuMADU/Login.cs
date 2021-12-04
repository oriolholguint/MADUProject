using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void button1_Click(object sender, EventArgs e)
        {
            String user = "admin";
            String pass = "admin";
            String userTextBox = textBoxUser.Text;
            String passTextBox = textBoxUser.Text;
            if (userTextBox.Equals(user))
            {
                if (passTextBox.Equals(pass))
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    labelError.Visible = true;
                }
            }
            else
            {
                labelError.Visible = true;
            }
        }

        private void labelRegistro_Click_1(object sender, EventArgs e)
        {
            RecuperarContrasenya a = new RecuperarContrasenya();
            a.ShowDialog();
        }
    }
}

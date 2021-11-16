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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


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
                    Menu mainForm = new Menu();
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

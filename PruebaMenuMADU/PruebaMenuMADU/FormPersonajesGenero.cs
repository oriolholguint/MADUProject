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
    public partial class FormPersonajesGenero : Form
    {
        public FormPersonajesGenero()
        {
            InitializeComponent();
        }

        private void btnCargarImagen1_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                pbImagenPRank1.ImageLocation = getImage.FileName;
            }
        }

        private void btnCargarImagen2_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                pbImagenPRank2.ImageLocation = getImage.FileName;
            }
        }

        private void btnCargarImagen3_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                pbImagenPRank3.ImageLocation = getImage.FileName;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }
    }
}

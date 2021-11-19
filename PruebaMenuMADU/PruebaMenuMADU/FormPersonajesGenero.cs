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
        public FormPersonajesGenero(List<Genero>Espanyol, List<Genero> Ingles)
        {
            this.GeneroEspanyol = Espanyol;
            this.GeneroIngles = Ingles;
            InitializeComponent();
            foreach (Genero item in GeneroEspanyol)
            {
                comboBox1.Items.Add(item.Nombre);

            }
        }

        public List<Genero> GeneroEspanyol { get; set; }
        //generoespañol[2].persionajes =
        public List<Genero> GeneroIngles { get; set; }

        List<Personaje> personatges = new List<Personaje>();

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
            
            String nomRank1, nomRank2, nomRank3,rutaImgR1, rutaImgR2, rutaImgR3;
            int posGenero;

            posGenero = comboBox1.SelectedIndex;

            nomRank1 = textBoxRank1.Text;
            rutaImgR1 = pbImagenPRank1.ImageLocation;
            Personaje perRank1 = new Personaje();
            perRank1.Nombre = nomRank1;
            perRank1.Imagen = rutaImgR1;
            perRank1.PosicionRanking = 1;

            nomRank2 = textBoxRank2.Text;
            rutaImgR2 = pbImagenPRank2.ImageLocation;
            Personaje perRank2 = new Personaje();
            perRank2.Nombre = nomRank2;
            perRank2.Imagen = rutaImgR2;
            perRank2.PosicionRanking = 2;

            nomRank3 = textBoxRank3.Text;
            rutaImgR3 = pbImagenPRank3.ImageLocation;
            Personaje perRank3 = new Personaje();
            perRank3.Nombre = nomRank3;
            perRank3.Imagen = rutaImgR3;
            perRank3.PosicionRanking = 3;

            if (!String.IsNullOrEmpty(nomRank1) || !String.IsNullOrWhiteSpace(nomRank1))
            {
                if (!String.IsNullOrEmpty(nomRank2) || !String.IsNullOrWhiteSpace(nomRank2))
                {
                    if (!String.IsNullOrEmpty(nomRank3) || !String.IsNullOrWhiteSpace(nomRank3))
                    {
                        personatges.Add(perRank1);
                        personatges.Add(perRank2);
                        personatges.Add(perRank3);

                        GeneroEspanyol[posGenero].Personajes = personatges;
                        GeneroIngles[posGenero].Personajes = personatges;

                        this.Close();
                    } 
                    else 
                    {
                        MessageBox.Show("Error al Crear Personaje");
                    }
                } 
                else 
                {
                    MessageBox.Show("Error al Crear Personaje");
                }
            } else 
            {
                MessageBox.Show("Error al Crear Personaje");
            } 



        }
    }
}

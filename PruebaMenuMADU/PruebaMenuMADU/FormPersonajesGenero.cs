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
    public partial class FormPersonajesGenero : Form
    {
        public FormPersonajesGenero(List<Genero>Espanyol, List<Genero> Ingles)
        {
            this.GeneroEspanyol = Espanyol;
            this.GeneroIngles = Ingles;
            InitializeComponent();
            foreach (Genero item in GeneroEspanyol)
            {
                comboBox1.Items.Add(item.nombre);

            }
        }

        public List<Genero> GeneroEspanyol { get; set; }

        public List<Genero> GeneroIngles { get; set; }

        List<Personaje> personatges = new List<Personaje>();
        private void btnCargarImagen1_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen(*.jpg)(*.jpeg)(*.png)(*.gif)|*.jpg; *jpeg; *.png; *.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                pbImagenPRank1.ImageLocation = getImage.FileName;
            }
        }


        private void btnCargarImagen2_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen(*.jpg)(*.jpeg)(*.png)(*.gif) | *.jpg; *jpeg; *.png; *.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                pbImagenPRank2.ImageLocation = getImage.FileName;
            }
        }

        private void btnCargarImagen3_Click(object sender, EventArgs e)
        { 
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen(*.jpg)(*.jpeg)(*.png)(*.gif)|*.jpg; *jpeg; *.png; *.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                pbImagenPRank3.ImageLocation = getImage.FileName;
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int posGenero = comboBox1.SelectedIndex;
            if (posGenero == -1)
            {
                MessageBox.Show("Sel·lecciona un género");
                return;
            }
            Personaje perRank1 = new Personaje();
            perRank1.nombre = textBoxRank1.Text;
            perRank1.imagen = Path.GetFileName(pbImagenPRank1.ImageLocation);
            perRank1.posicionRanking = 1;

            Personaje perRank2 = new Personaje();
            perRank2.nombre = textBoxRank2.Text;
            perRank2.imagen = Path.GetFileName(pbImagenPRank2.ImageLocation);
            perRank2.posicionRanking = 2;

            Personaje perRank3 = new Personaje();
            perRank3.nombre = textBoxRank3.Text;
            perRank3.imagen = Path.GetFileName(pbImagenPRank3.ImageLocation);
            perRank3.posicionRanking = 3;

            if (!String.IsNullOrEmpty(textBoxRank1.Text) && !String.IsNullOrWhiteSpace(textBoxRank1.Text) && pbImagenPRank1.Image != null)
            {
                if (!String.IsNullOrEmpty(textBoxRank2.Text) && !String.IsNullOrWhiteSpace(textBoxRank2.Text) && pbImagenPRank2.Image != null)
                {
                    if (!String.IsNullOrEmpty(textBoxRank3.Text) && !String.IsNullOrWhiteSpace(textBoxRank3.Text) && pbImagenPRank3.Image != null)
                    {
                        personatges.Add(perRank1);
                        personatges.Add(perRank2);
                        personatges.Add(perRank3);

                        GeneroEspanyol[posGenero].personajes = personatges;
                        GeneroIngles[posGenero].personajes = personatges;

                        ResourceManager.addImageToResources(pbImagenPRank1.ImageLocation);
                        ResourceManager.addImageToResources(pbImagenPRank2.ImageLocation);
                        ResourceManager.addImageToResources(pbImagenPRank3.ImageLocation);
                        MessageBox.Show("personajes modificados correctamente", "Gestión de personajes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    } 
                    else 
                    {
                        MessageBox.Show("Error al Crear Personaje del Rank 3");
                    }
                } 
                else 
                {
                    MessageBox.Show("Error al Crear Personaje del Rank 2");
                }
            } else 
            {
                MessageBox.Show("Error al Crear Personaje del Rank 1");
            } 
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<Personaje> Personajes = GeneroEspanyol[comboBox1.SelectedIndex].personajes;
            TextBox[] nom = { textBoxRank1, textBoxRank2, textBoxRank3 };
            PictureBox[] img = { pbImagenPRank1, pbImagenPRank2, pbImagenPRank3 };
            int cont = 0;
            if (!Personajes.Any()) cleanElements();
            foreach (Personaje personaje in Personajes)
            {
                nom[cont].Text = personaje.nombre;
                img[cont].Image = Image.FromFile(ResourceManager.IMAGES_PATH + personaje.imagen);
                img[cont].ImageLocation = ResourceManager.IMAGES_PATH + personaje.imagen;
                cont++;
            }
        }
        private void cleanElements()
        {
            TextBox[] nom = { textBoxRank1, textBoxRank2, textBoxRank3 };
            PictureBox[] img = { pbImagenPRank1, pbImagenPRank2, pbImagenPRank3 };
            int cont = 0;
            
            foreach (TextBox it in nom)
            {
                nom[cont].Text = "";
                img[cont].Image = null;
                img[cont].ImageLocation = null;
                cont++;
            }
        }
    }
}

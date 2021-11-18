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
    public partial class CrearGenero : Form
    {
        Genero createdEng { get; set; }
        List<Genero> listaEsp { get; set; }
        List<Genero> listaEng { get; set; }
        Genero createdEsp { get; set; }

        Boolean edit = false;


        public Boolean manualCancel = false;

        public CrearGenero(Genero Esp, Genero Eng)
        {
            InitializeComponent();
            this.edit = true;
            modifyGenre(Esp, Eng);
            editMode();
        }
        public CrearGenero(List<Genero> listaEsp, List<Genero> listaEng)
        {
            InitializeComponent();
            this.listaEsp = listaEsp;
            this.listaEng = listaEng;
        }
        public void editMode()
        {
            lblNewName.Text = "Nombre del genero:";
            lblNewNameEng.Text = "Name of the genre: ";
        }
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagePick = new OpenFileDialog();

            if (imagePick.ShowDialog() == DialogResult.OK)
            {
                String[] imageTypeAccepted = new String[] { "png", "jpg", "jpeg", "gif" };
                foreach (String type in imageTypeAccepted)
                {

                    if (imagePick.FileName.Split('.').Last().Equals(type))
                    {
                        break;
                    }else if (type.Equals(imageTypeAccepted.Last()))
                    {
                        MessageBox.Show("Tipo de archivo no admitido", "Error al añadir archivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                txtUrlOculta.Text = imagePick.FileName;
                Bitmap image = new Bitmap(imagePick.FileName);
                pbImagenGenero.Dock = DockStyle.Fill;
                pbImagenGenero.Image = (Image)image;
            }

        }
        private void modifyGenre(Genero genEsp,Genero genEng)
        {
            txtGenreName.Text = genEng.Nombre;
            txtNombreGenero.Text = genEsp.Nombre;
            txtUrlBackground.Text = genEsp.ImagenFondo;
            txtUrlMusic.Text = genEsp.MusicaFondo;
            txtUrlOculta.Text = genEsp.ImagenMenu;
            pbBg.Image = Image.FromFile(genEsp.ImagenFondo);
            pbImagenGenero.Image = Image.FromFile(genEsp.ImagenMenu);
            wmpMusic.URL = genEsp.MusicaFondo;

        }

        private void txtUrlOculta_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void BntCargarFondo_Click(object sender, EventArgs e)
        {
            OpenFileDialog bgPick = new OpenFileDialog();
            if (bgPick.ShowDialog() == DialogResult.OK)
            {
                String[] imageTypeAccepted = new String[] { "png", "jpg", "jpeg", "gif" };
                foreach (String type in imageTypeAccepted)
                {

                    if (bgPick.FileName.Split('.').Last().Equals(type))
                    {
                        break;
                    }
                    else if (type.Equals(imageTypeAccepted.Last()))
                    {
                        MessageBox.Show("Tipo de archivo no admitido", "Error al añadir archivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                txtUrlBackground.Text = bgPick.FileName;
                Bitmap image = new Bitmap(bgPick.FileName);
                pbBg.Dock = DockStyle.Fill;
                pbBg.Image = (Image)image;
            }
        }

        private void btnCargarMusica_Click(object sender, EventArgs e)
        {
            OpenFileDialog musicFile = new OpenFileDialog();
            if (musicFile.ShowDialog() == DialogResult.OK)
            {
                String[] videoTypeAccepted = new String[] {"mp3", "wav", "wma"};
                foreach (String type in videoTypeAccepted)
                {

                    if (musicFile.FileName.Split('.').Last().Equals(type))
                    {
                        break;
                    }
                    else if (type.Equals(videoTypeAccepted.Last()))
                    {
                        MessageBox.Show("Tipo de archivo no admitido", "Error al añadir archivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                txtUrlMusic.Text = musicFile.FileName;
                wmpMusic.URL = txtUrlMusic.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List <Personaje> personajesRap = new List<Personaje>();
            Partida[] partidasRap = new Partida[10];
            List<Pregunta> preguntasRap = new List<Pregunta>();
            String[] nonNullableStrings = { txtNombreGenero.Text, txtGenreName.Text, txtUrlBackground.Text, txtUrlMusic.Text, txtUrlOculta.Text };
            int paths = 0;
            foreach(String element in nonNullableStrings)
            {
                if (String.IsNullOrEmpty(element)){

                    MessageBox.Show("Llena todos los campos del genero y vuelve a intentarlo", "Error al crear el Genero", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (System.IO.File.Exists(element))
                {

                    paths++;
                }

            }
            if(paths<3)
            {

                MessageBox.Show("Corrige las rutas de los archivos", "Error al crear el Genero", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Genero spanish = new Genero(txtNombreGenero.Text, txtUrlMusic.Text, txtUrlBackground.Text, txtUrlOculta.Text, personajesRap, partidasRap, preguntasRap);
            Genero english = new Genero(txtGenreName.Text, txtUrlMusic.Text, txtUrlBackground.Text, txtUrlOculta.Text, personajesRap, partidasRap, preguntasRap);
            Boolean controlDeNombre = true;
            foreach (Genero gen in this.listaEsp)
            {
                if (gen.Nombre.Equals(spanish.Nombre))
                {
                    MessageBox.Show("Nombre para el nuevo genero incorrecto", "Error de Nombre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    controlDeNombre = false;
                    break;
                }
            }
            foreach (Genero gen in this.listaEng)
            {
                if (gen.Nombre.Equals(english.Nombre))
                {
                    MessageBox.Show("Nombre para el nuevo genero(version ingles) incorrecto/a", "Error de Nombre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    controlDeNombre = false;
                    break;
                }
            }

            if (controlDeNombre) {
                this.createdEng = english;
                this.createdEsp = spanish;
                this.Close();
                    return;
            }
            spanish = null;
            english = null;
            this.Close();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        internal Genero getCreatedGenre(String lang){return (lang.Contains("es") ? this.createdEsp : this.createdEng);}

        private void butCancel_Click(object sender, EventArgs e)
        {
            manualCancel = true;
            this.Close();
        }

        private void CrearGenero_Load(object sender, EventArgs e)
        {

        }

        private void txtGenreName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreGenero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

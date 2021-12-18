using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PruebaMenuMADU
{
    public partial class CrearGenero : Form
    {
        List<Genero> listaEsp;
        List<Genero> listaEng;
        Genero createdEng;
        Genero createdEsp;

        Genero generoSeleccionadoEsp;
        Genero generoSeleccionadoEng;

        Boolean editBool = false;

        public Boolean deleteGenre { get; set; }

        public Boolean manualCancel = false;

        public CrearGenero(List<Genero> listaEsp, List<Genero> listaEng, Genero Esp, Genero Eng)
        {
            //Modo editar genero
            InitializeComponent();
            this.deleteGenre = false;
            this.editBool = true;
            this.listaEsp = listaEsp;
            this.listaEng = listaEng;
            generoSeleccionadoEsp = Esp;
            generoSeleccionadoEng = Eng;
            modifyGenre(Esp, Eng);
            editMode();
        }
        public CrearGenero(List<Genero> listaEsp, List<Genero> listaEng)
        {
            //Modo crear nuevo genero
            InitializeComponent();
            this.deleteGenre = false;
            this.listaEsp = listaEsp;
            this.listaEng = listaEng;
            btnDeleteGenre.Visible = false; //Oculto boton eliminar genero cuando se va a crear uno
        }

        public void editMode()
        {
            lblNewName.Text = "Nombre del genero:";
            btnCreateEdit.Text = "Editar Genero";
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagePick = new OpenFileDialog();
            imagePick.Filter = "Archivos de Imagen(*.jpg)(*.jpeg)(*.png)(*.gif)|*.jpg; *jpeg; *.png; *.png";

            if (imagePick.ShowDialog() == DialogResult.OK)
            {
                String[] imageTypeAccepted = new String[] { "png", "jpg", "jpeg", "gif" };
                foreach (String type in imageTypeAccepted)
                {

                    if (imagePick.FileName.Split('.').Last().Equals(type))
                    {
                        break;
                    } else if (type.Equals(imageTypeAccepted.Last()))
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
        private void modifyGenre(Genero genEsp, Genero genEng)
        {
            txtNombreGenero.Text = genEsp.nombre;
            txtUrlBackground.Text = genEsp.imagenFondo;
            txtUrlMusic.Text = genEsp.musicaFondo;
            txtUrlOculta.Text = genEsp.imagenMenu;

            pbBg.Image = Image.FromFile(ResourceManager.IMAGES_PATH + genEsp.imagenFondo);
            pbImagenGenero.Image = Image.FromFile(ResourceManager.IMAGES_PATH + genEsp.imagenMenu); //Concateno el path donde se encuentran las imagenes
            wmpMusic.URL = genEsp.musicaFondo;
        }

        private void BntCargarFondo_Click(object sender, EventArgs e)
        {
            OpenFileDialog bgPick = new OpenFileDialog();
            bgPick.Filter = "Archivos de Imagen(*.jpg)(*.jpeg)(*.png)(*.gif)|*.jpg; *jpeg; *.png; *.png";

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
            musicFile.Filter = "Archivos de Audio (*.mp3)(*.wav)(*.wma)|*.mp3; *.wav; *.wma";

            if (musicFile.ShowDialog() == DialogResult.OK)
            {
                String[] videoTypeAccepted = new String[] { "mp3", "wav", "wma" };
                foreach (String type in videoTypeAccepted)
                {
                    Console.WriteLine(musicFile.FileName.Split('.').Last());
                    if (musicFile.FileName.Split('.').Last().Contains(type))
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
            if (ComprobarCampos()) //Compruebo que todos los campos esten rellenados
            {
                
                if (editBool) //Si estoy en modo de edicion
                {
                    EliminarGeneros(generoSeleccionadoEsp.nombre, generoSeleccionadoEng.nombre); //Elimino los generos antiguos
                    EditarGeneros(); //Edito los generos
                    this.listaEsp.Add(generoSeleccionadoEsp); //Añado a la lista el nuevo genero en espannol
                    this.listaEng.Add(generoSeleccionadoEng); //Añado a la lista el nuevo genero en ingles

                    if (pbImagenGenero.Image != null)
                    {
                        ((IDisposable)pbImagenGenero.Image).Dispose();
                    }

                    if(pbBg.Image != null)
                    {
                        ((IDisposable)pbBg.Image).Dispose();
                    }

                    this.Close();
                    wmpMusic.URL = null;
                    MessageBox.Show("Genero editado correctamente", "Editar Genero", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!ComprobarGeneroExiste(txtNombreGenero.Text))//Compruebo que el genero no existe
                    {
                        CrearGeneros(); //Creo los generos
                        
                        if (pbImagenGenero.Image != null)
                        {
                            ((IDisposable)pbImagenGenero.Image).Dispose();
                        }

                        if (pbBg.Image != null)
                        {
                            ((IDisposable)pbBg.Image).Dispose();
                        }

                        this.Close();
                        wmpMusic.URL = null;
                        MessageBox.Show("Genero creado correctamente", "crear Genero", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El genero ya existe", "Error Crear Genero", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Llena todos los campos del genero y vuelve a intentarlo", "Error al crear el Genero", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        public void CrearGeneros()
        {
            //Obtengo los nombres de las imagenes y sonido con su extension
            String imagenMenu = txtUrlOculta.Text.Split('\\').Last();
            String imagenFondo = txtUrlBackground.Text.Split('\\').Last();
            String sonido = txtUrlMusic.Text.Split('\\').Last();

            //Creo los generos
            Genero spanish = new Genero(txtNombreGenero.Text, sonido, imagenFondo, imagenMenu, new List<Personaje>(), new List<Pregunta>());
            Genero english = new Genero(txtNombreGenero.Text, sonido, imagenFondo, imagenMenu, new List<Personaje>(), new List<Pregunta>());

            this.createdEng = english;
            this.createdEsp = spanish;

            ResourceManager.addImageToResources(txtUrlOculta.Text);
            ResourceManager.addImageToResources(txtUrlBackground.Text);
            ResourceManager.addSoundToResources(txtUrlMusic.Text);
        }

        public void EditarGeneros()
        {
            //Obtengo los nombres de las imagenes y sonido con su extension
            String imagenMenu = txtUrlOculta.Text.Split('\\').Last();
            String imagenFondo = txtUrlBackground.Text.Split('\\').Last();
            String musicaFondo = txtUrlMusic.Text.Split('\\').Last();

            if(!generoSeleccionadoEsp.imagenMenu.Equals(imagenMenu))
            {
                generoSeleccionadoEsp.imagenMenu = imagenMenu;
                generoSeleccionadoEng.imagenMenu = imagenMenu;
                ResourceManager.addImageToResources(txtUrlOculta.Text);
            }

            if (!generoSeleccionadoEsp.imagenFondo.Equals(imagenFondo))
            {
                generoSeleccionadoEsp.imagenFondo = imagenFondo;
                generoSeleccionadoEng.imagenFondo = imagenFondo;
                ResourceManager.addImageToResources(txtUrlBackground.Text);
            }

            if (!generoSeleccionadoEsp.musicaFondo.Equals(musicaFondo))
            {
                generoSeleccionadoEsp.musicaFondo = musicaFondo;
                generoSeleccionadoEng.musicaFondo = musicaFondo;
                ResourceManager.addSoundToResources(txtUrlMusic.Text);
            }

            if(!generoSeleccionadoEsp.nombre.Equals(txtNombreGenero))
            {
                generoSeleccionadoEsp.nombre = txtNombreGenero.Text;
            }
        }

        public void EliminarGeneros(String nombreGeneroEsp, String nombreGeneroEng)
        {
            Boolean generoEliminado = false;
            int counter = 0;

            while (counter < listaEsp.Count && !generoEliminado)
            {
                if (listaEsp[counter].nombre.Equals(nombreGeneroEsp))
                {
                    listaEsp.RemoveAt(counter);
                    listaEng.RemoveAt(counter);

                    generoEliminado = true;
                }
                else
                {
                    counter++;
                }
            }
        }

        public Boolean ComprobarGeneroExiste(String nombreGenero)
        {
            Boolean generoExiste = false;

            for (int i = 0; i < listaEsp.Count; i++)
            {
                if (listaEsp[i].nombre.Equals(nombreGenero))
                {
                    generoExiste = true;
                }
            }

            return generoExiste;
        }

        public Boolean ComprobarCampos()
        {
            Boolean camposRellenados = true;

            if (String.IsNullOrEmpty(txtNombreGenero.Text) || String.IsNullOrEmpty(txtUrlBackground.Text) 
                 || String.IsNullOrEmpty(txtUrlMusic.Text) || String.IsNullOrEmpty(txtUrlOculta.Text))
            {
                camposRellenados = false;
            }

            return camposRellenados;
        }

        internal Genero getCreatedGenre(String lang) { return (lang.Contains("es") ? this.createdEsp : this.createdEng); }

        internal List<Genero> getListGenre(String lang) { return (lang.Contains("es") ? this.listaEsp : this.listaEng); }

        public List<Genero> ObtenerListaGeneros(String lang)
        {
            List<Genero> listaGeneros = null;

            if(lang.Equals("esp"))
            {
                listaGeneros = listaEsp;
            }
            else if (lang.Equals("eng"))
            {
                listaGeneros = listaEng;
            }

            return listaGeneros;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            manualCancel = true;
            this.Close();
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas eliminar el genero " + generoSeleccionadoEsp.nombre + "?",
                "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                EliminarGeneros(generoSeleccionadoEsp.nombre, generoSeleccionadoEng.nombre);
                this.deleteGenre = true;
                this.Close();
            }
        }

        private void CrearGenero_FormClosing(object sender, FormClosingEventArgs e)
        {
            wmpMusic.URL = null;
        }
    }
}
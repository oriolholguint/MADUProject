﻿using System;
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
    public partial class CrearPreguntasForm : Form
    {
        BindingList<Pregunta> preguntas = new BindingList<Pregunta>();
        BindingList<Respuesta> respuestas = new BindingList<Respuesta>();


        public CrearPreguntasForm()
        {
            InitializeComponent();
        }

        private void CrearPreguntasForm_Load(object sender, EventArgs e)
        {

        }

        private void vaciarCampos() {

            txtNombrePreg.Text = "";
            cbxGeneroPreg.SelectedItem = null;
            cbxTipoPreg.SelectedItem = null;
            cbxEdad.SelectedItem = null;
        
        }

        private void btnAñadirPregunta_Click(object sender, EventArgs e)
        {
            Pregunta pregunta = new Pregunta();
            

            pregunta.id = preguntas.Count() + 1;
            pregunta.NombrePregunta = txtNombrePreg.Text;
            pregunta.Genero = (String)cbxGeneroPreg.SelectedItem;
            pregunta.Tipo = (String)cbxTipoPreg.SelectedItem;
            pregunta.UrlImgAudio = "urlprueba";

            if (cbxEdad.SelectedItem.Equals("Mayor de edad"))
            {
                pregunta.MayorDeEdad = true;
            }
            else
            {
                pregunta.MayorDeEdad = false;
            }

            preguntas.Add(pregunta);

            Button btnSeleccionarPregunta = new Button();
            btnSeleccionarPregunta.Name = "btnSeleccionarPregunta";
            btnSeleccionarPregunta.Text = "Pregunta " + pregunta.id;
            
            btnSeleccionarPregunta.Size = new Size(130,122);

            btnSeleccionarPregunta.Location = new Point(3, flpListaPreguntas.Controls.Count * 20);
            flpListaPreguntas.Controls.Add(btnSeleccionarPregunta);
            btnSeleccionarPregunta.Click += (sender2, e2) => btnSeleccionarPregunta_Click(sender2, e2, pregunta);
            vaciarCampos();

        }
       

        private void btnSeleccionarPregunta_Click(object sender, EventArgs e, Pregunta preg)
        {
            

            txtNombrePreg.Text = preg.NombrePregunta;
            cbxGeneroPreg.SelectedItem = preg.Genero;
            cbxTipoPreg.SelectedItem = preg.Tipo;

            if (preg.MayorDeEdad)
            {
                cbxEdad.SelectedIndex = 1;
            }
            else
            {
                cbxEdad.SelectedIndex = 0;
            }
            


        }

        private void cbxGeneroPreg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                pbImagenPregunta.ImageLocation = getImage.FileName;
                txtUrlOculta.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);


            }
            else
            {
                MessageBox.Show("No se selecciono ninguna imagen", "Sin seleccion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            //SaveFileDialog guardarImagen = new SaveFileDialog();
            //guardarImagen.InitialDirectory = "";


        }

        private void cbxTipoPreg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoPreg.SelectedIndex == 0)
            {
                tlp2Respuestas.Visible = true;
            }
            else
            {
                tlp2Respuestas.Visible = false;
            }
        }
    }
}

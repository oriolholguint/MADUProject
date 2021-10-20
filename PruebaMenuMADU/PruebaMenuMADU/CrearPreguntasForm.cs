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
    public partial class CrearPreguntasForm : Form
    {
        BindingList<Pregunta> preguntas = new BindingList<Pregunta>();


        public CrearPreguntasForm()
        {
            InitializeComponent();
        }

        private void CrearPreguntasForm_Load(object sender, EventArgs e)
        {

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
            btnSeleccionarPregunta.Text = "Pregunta " + pregunta.id;
            btnSeleccionarPregunta.Size = new Size(130,122);

            btnSeleccionarPregunta.Location = new Point(3, flpListaPreguntas.Controls.Count * 20);
            flpListaPreguntas.Controls.Add(btnSeleccionarPregunta);

        }
    }
}

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
    public partial class ModificarPregunta : Form
    {
        Pregunta Pregunta;
        BindingList<Pregunta> Preguntas;

        public ModificarPregunta()
        {
            InitializeComponent();
        }

        public void setPregunta(BindingList<Pregunta> Preguntas, Pregunta Pregunta)
        {
            this.Preguntas = Preguntas;
            this.Pregunta = Pregunta;
            RellenarTextBoxes();
        }

        private void RellenarTextBoxes()
        {
            textBoxPregunta.Text = Pregunta.PreguntaDescripcion;
            if(Pregunta.EsMayorEdad)
            {
                checkBoxMayorEdad.Checked = true;
            }
            else
            {
                checkBoxMayorEdad.Checked = false;
            }
            textBoxImagen.Text = Pregunta.Imagen;
            textBoxSonido.Text = Pregunta.Sonido;
        }

       
    }
}

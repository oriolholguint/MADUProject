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
        Pregunta Pregunta = new Pregunta();

        public ModificarPregunta()
        {
            InitializeComponent();
        }

        public void SetPregunta(Pregunta Pregunta)
        {
            this.Pregunta = Pregunta;
            RellenarTextBoxes();
        }

        private void RellenarTextBoxes()
        {
            textBoxId.Text = Pregunta.id.ToString();
            textBoxPregunta.Text = Pregunta.NombrePregunta;
            comboBoxGenero.Text = Pregunta.Genero;
            comboBoxTipo.Text = Pregunta.Tipo;
            if(Pregunta.MayorDeEdad)
            {
                checkBoxMayorEdad.Checked = true;
            }
            else
            {
                checkBoxMayorEdad.Checked = false;
            }
            textBoxImagen.Text = Pregunta.UrlImgAudio;
            textBoxSonido.Text = Pregunta.UrlImgAudio;

        }
    }
}

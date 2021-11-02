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
    public partial class DataGridViewPreguntas : Form
    {
        BindingList<Pregunta> Preguntas;
        Genero GeneroSeleccionado;

        ModificarPregunta ModificarPregunta;

        public DataGridViewPreguntas()
        {
            InitializeComponent();
        }

        public DataGridViewPreguntas(Genero GeneroSeleccionado, ModificarPregunta ModificarPregunta)
        {
            InitializeComponent();
            this.GeneroSeleccionado = GeneroSeleccionado;

            List<Pregunta> PreguntasList = new List<Pregunta>(GeneroSeleccionado.Preguntas);
            Preguntas = new BindingList<Pregunta>(PreguntasList);

            this.ModificarPregunta = ModificarPregunta;

            RecargarDataGridView();
        }

        private void RecargarDataGridView()
        {
            dataGridViewTablaPreguntas.DataSource = Preguntas;            
            dataGridViewTablaPreguntas.Update();
            dataGridViewTablaPreguntas.Refresh();
        }

        private void dataGridViewTablaPreguntas_SelectionChanged(object sender, EventArgs e)
        {
            CargarPreguntaSeleccionada();
        }

        private void CargarPreguntaSeleccionada()
        {
            if (Preguntas.Count != 0)
            {
                ModificarPregunta.setPregunta(Preguntas, (Pregunta)dataGridViewTablaPreguntas.CurrentRow.DataBoundItem);
            }
        }

        /*private void dataGridViewTablaPreguntas_SelectionChanged(object sender, EventArgs e)
        {
            ModificarPregunta = new ModificarPregunta(Preguntas, (Pregunta)dataGridViewTablaPreguntas.CurrentRow.DataBoundItem);
        }*/
    }
}

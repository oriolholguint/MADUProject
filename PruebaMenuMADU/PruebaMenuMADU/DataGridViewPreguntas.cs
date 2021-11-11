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
        Genero GeneroSeleccionadoEsp;
        Genero GeneroSeleccionadoEng;

        BindingList<Pregunta> PreguntasEsp;
        BindingList<Pregunta> PreguntasEng;
        
        ModificarPregunta ModificarPregunta;

        public DataGridViewPreguntas()
        {
            InitializeComponent();
        }

        public DataGridViewPreguntas(Genero GeneroSeleccionadoEsp, Genero GeneroSeleccionadoEng, ModificarPregunta ModificarPregunta)
        {
            InitializeComponent();
            
            this.GeneroSeleccionadoEsp = GeneroSeleccionadoEsp;
            this.GeneroSeleccionadoEng = GeneroSeleccionadoEng;

            List<Pregunta> PreguntasListEsp = new List<Pregunta>(GeneroSeleccionadoEsp.Preguntas);
            PreguntasEsp = new BindingList<Pregunta>(PreguntasListEsp);

            List<Pregunta> PreguntasListEng = new List<Pregunta>(GeneroSeleccionadoEng.Preguntas);
            PreguntasEng = new BindingList<Pregunta>(PreguntasListEng);

            this.ModificarPregunta = ModificarPregunta;

            RecargarDataGridView();
        }

        private void RecargarDataGridView()
        {
            dataGridViewTablaPreguntas.DataSource = PreguntasEsp;            
            dataGridViewTablaPreguntas.Update();
            dataGridViewTablaPreguntas.Refresh();
        }

        private void dataGridViewTablaPreguntas_SelectionChanged(object sender, EventArgs e)
        {
            CargarPreguntaSeleccionada();
        }

        private void CargarPreguntaSeleccionada()
        {
            if (PreguntasEsp.Count != 0)
            {
                Pregunta PreguntaSeleccionadaEsp;
                Pregunta PreguntaSeleccionadaEng;

                //Obtengo el objeto de la pregunta seleccionada.
                PreguntaSeleccionadaEsp = (Pregunta) dataGridViewTablaPreguntas.CurrentRow.DataBoundItem;
                int IndicePregunta = PreguntasEsp.IndexOf(PreguntaSeleccionadaEsp);
                //Obtengo la pregunta seleccionada en ingles ya que tengo el indice de la fila seleccionada.
                PreguntaSeleccionadaEng = PreguntasEng[IndicePregunta];

                ModificarPregunta.setPregunta(GeneroSeleccionadoEsp, GeneroSeleccionadoEng, PreguntaSeleccionadaEsp, PreguntaSeleccionadaEng);
            }
        }

        
    }
}

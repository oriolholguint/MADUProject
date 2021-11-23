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

            this.ModificarPregunta = ModificarPregunta;

            RecargarDataGridView();
        }

        public void SetGeneros(Genero GeneroSeleccionadoEsp, Genero GeneroSeleccionadoEng)
        {
            this.GeneroSeleccionadoEsp = GeneroSeleccionadoEsp;
            this.GeneroSeleccionadoEng = GeneroSeleccionadoEng;
        }

        public void RecargarDataGridView()
        {
            //dataGridViewTablaPreguntas.DataSource = null; Si activo esta linea tengo que crear metodo que diseñe la data grid view
            dataGridViewTablaPreguntas.DataSource = new BindingList<Pregunta>(GeneroSeleccionadoEsp.Preguntas);
            dataGridViewTablaPreguntas.Update();
            dataGridViewTablaPreguntas.Refresh();
            //Elimino la columna genero ya que no es necesario para el datagridview
            dataGridViewTablaPreguntas.Columns["Genero"].Visible = false;
        }


        public void CargarPreguntaSeleccionada()
        {
            if (GeneroSeleccionadoEsp.Preguntas.Count != 0 && dataGridViewTablaPreguntas.Rows.Count > 0 )
            {
                int IndicePregunta = 0;

                Pregunta PreguntaSeleccionadaEsp;
                Pregunta PreguntaSeleccionadaEng;

                //Obtengo el objeto de la pregunta seleccionada.
                PreguntaSeleccionadaEsp = (Pregunta) dataGridViewTablaPreguntas.CurrentRow.DataBoundItem;
                IndicePregunta = GeneroSeleccionadoEsp.Preguntas.IndexOf(PreguntaSeleccionadaEsp);
                //Obtengo la pregunta seleccionada en ingles ya que tengo el indice de la fila seleccionada.
                PreguntaSeleccionadaEng = GeneroSeleccionadoEng.Preguntas[IndicePregunta];

                ModificarPregunta.setPregunta(GeneroSeleccionadoEsp, GeneroSeleccionadoEng, PreguntaSeleccionadaEsp, PreguntaSeleccionadaEng);
            }
        }

        private void dataGridViewTablaPreguntas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarPreguntaSeleccionada();
            ModificarPregunta.ActivarBotonesOpciones(); //Activo botones de Guardar, Limpiar y Eliminar
        }
    }
}

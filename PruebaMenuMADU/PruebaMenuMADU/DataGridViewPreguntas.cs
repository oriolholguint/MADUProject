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
        BindingList<Pregunta> Preguntas = new BindingList<Pregunta>();
        ModificarPregunta ModificarPregunta = new ModificarPregunta();

        public DataGridViewPreguntas()
        {
            InitializeComponent();
        }

        public void SetPreguntas (BindingList<Pregunta> Preguntas, ModificarPregunta ModificarPregunta)
        {
            this.Preguntas = Preguntas;
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
            Pregunta pregunta = (Pregunta) dataGridViewTablaPreguntas.CurrentRow.DataBoundItem;
            ModificarPregunta.SetPregunta(pregunta);
        }
    }
}

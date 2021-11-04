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
    public partial class Menu : Form
    {
        BindingList<Pregunta> Preguntas = new BindingList<Pregunta>();

        ModificarPregunta ModificarPregunta = new ModificarPregunta();
        DataGridViewPreguntas DgvPreguntas = new DataGridViewPreguntas();

        ModificarPersonaje ModificarPersonaje = new ModificarPersonaje();
        ModificarGenero ModificarGenero = new ModificarGenero();

        public Menu()
        {
            InitializeComponent();
            crearPreguntasPrueba();
        }

        public void crearPreguntasPrueba()
        {
            Respuesta r1 = new Respuesta(1, "Respuesta1", true);
            Respuesta r2 = new Respuesta(2, "Respuesta2", false);
            Respuesta r3 = new Respuesta(3, "Respuesta3", false);
            Respuesta r4 = new Respuesta(4, "Respuesta4", false);

            BindingList<Respuesta> respuestasPrueba = new BindingList<Respuesta>();
            respuestasPrueba.Add(r1);
            respuestasPrueba.Add(r2);
            respuestasPrueba.Add(r3);
            respuestasPrueba.Add(r4);

            Preguntas.Add(new Pregunta(1, "Pregunta 1", "Genero", "Tipo", "url", true, respuestasPrueba));
            Preguntas.Add(new Pregunta(2, "Pregunta 2", "Genero", "Tipo", "url", true, respuestasPrueba));
            Preguntas.Add(new Pregunta(3, "Pregunta 3", "Genero", "Tipo", "url", true, respuestasPrueba));
            Preguntas.Add(new Pregunta(4, "Pregunta 4", "Genero", "Tipo", "url", true, respuestasPrueba));
            Preguntas.Add(new Pregunta(5, "Pregunta 5", "Genero", "Tipo", "url", true, respuestasPrueba));

            String respuesta1 = Preguntas[1].ListaRespuestas[1].NombreRespuesta;
        }

        private void buttonPreguntas_Click(object sender, EventArgs e)
        {
            //Elimino el form del panel datagridview en el caso que haya uno diferente
            if (panelDatos.Controls.Count > 0)
            {
                panelDatos.Controls.RemoveAt(0);
            }

            //Muestro en el panel de DataGridViews el correspondiente a Preguntas
            DgvPreguntas.TopLevel = false;
            panelDatos.Controls.Add(DgvPreguntas);
            DgvPreguntas.Show();

            //Elimino el form del panel modificaciones en el caso que haya uno diferente
            if (panelModificar.Controls.Count > 0)
            {
                panelModificar.Controls.RemoveAt(0);
            }

            //Muestro en el panel de modificaciones el correspondiente a modificar una pregunta.
            ModificarPregunta.TopLevel = false;
            panelModificar.Controls.Add(ModificarPregunta);
            ModificarPregunta.Show();

            DgvPreguntas.SetPreguntas(Preguntas, ModificarPregunta);
        }

        private void buttonGeneros_Click(object sender, EventArgs e)
        {
            if(panelDatos.Controls.Count > 0)
            {
                panelDatos.Controls.RemoveAt(0);
            }

            DataGridViewGeneros dataGridViewGeneros = new DataGridViewGeneros();
            dataGridViewGeneros.TopLevel = false;
            panelDatos.Controls.Add(dataGridViewGeneros);
            dataGridViewGeneros.Show();

            if(panelModificar.Controls.Count > 0)
            {
                panelModificar.Controls.RemoveAt(0);
            }

            ModificarGenero modificarGenero = new ModificarGenero();
            modificarGenero.TopLevel = false;
            panelModificar.Controls.Add(modificarGenero);
            modificarGenero.Show();
        }

        

        private void buttonPersonajes_Click(object sender, EventArgs e)
        {
            if (panelDatos.Controls.Count > 0)
            {
                panelDatos.Controls.RemoveAt(0);
            }

            DataGridViewPersonajes dataGridViewPersonajes = new DataGridViewPersonajes();
            dataGridViewPersonajes.TopLevel = false;
            panelDatos.Controls.Add(dataGridViewPersonajes);
            dataGridViewPersonajes.Show();

            if (panelModificar.Controls.Count > 0)
            {
                panelModificar.Controls.RemoveAt(0);
            }

            ModificarPersonaje modificarPersonaje = new ModificarPersonaje();
            modificarPersonaje.TopLevel = false;
            panelModificar.Controls.Add(modificarPersonaje);
            modificarPersonaje.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearPreguntasForm cp = new CrearPreguntasForm();

            cp.ShowDialog();
        }
    }
}

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
        public Menu()
        {
            InitializeComponent();
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

        private void buttonPreguntas_Click(object sender, EventArgs e)
        {
            if (panelDatos.Controls.Count > 0)
            {
                panelDatos.Controls.RemoveAt(0);
            }

            DataGridViewPreguntas dataGridViewPreguntas = new DataGridViewPreguntas();
            dataGridViewPreguntas.TopLevel = false;
            panelDatos.Controls.Add(dataGridViewPreguntas);
            dataGridViewPreguntas.Show();

            if(panelModificar.Controls.Count > 0)
            {
                panelModificar.Controls.RemoveAt(0);
            }

            ModificarPregunta modificarPregunta = new ModificarPregunta();
            modificarPregunta.TopLevel = false;
            panelModificar.Controls.Add(modificarPregunta);
            modificarPregunta.Show();
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

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}

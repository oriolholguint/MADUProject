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
    public partial class DataGridViewPersonajes : Form
    {
        BindingList<Personaje> Personajes;
        Genero GeneroSeleccionadoEsp;
        Genero GeneroSeleccionadoEng;

        ModificarPersonaje ModificarPersonaje;

        public DataGridViewPersonajes()
        {
            InitializeComponent();
        }

        public DataGridViewPersonajes(Genero GeneroSeleccionadoEsp, Genero GeneroSeleccionadoEng, ModificarPersonaje ModificarPersonaje)
        {
            InitializeComponent();
            this.GeneroSeleccionadoEsp = GeneroSeleccionadoEsp;

            List<Personaje> PersonajesList = new List<Personaje>(GeneroSeleccionadoEsp.Personajes);
            Personajes = new BindingList<Personaje>(PersonajesList);

            this.ModificarPersonaje = ModificarPersonaje;

            RecargarDataGridView();
        }

        private void RecargarDataGridView()
        {
            dataGridViewTablaPersonajes.DataSource = Personajes;
            dataGridViewTablaPersonajes.Update();
            dataGridViewTablaPersonajes.Refresh();
        }
    }
}

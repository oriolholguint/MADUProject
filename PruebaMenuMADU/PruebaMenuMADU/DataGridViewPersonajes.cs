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
        Genero GeneroSeleccionado;

        ModificarPersonaje ModificarPersonaje;

        public DataGridViewPersonajes()
        {
            InitializeComponent();
        }

        public DataGridViewPersonajes(Genero GeneroSeleccionado, ModificarPersonaje ModificarPersonaje)
        {
            InitializeComponent();
            this.GeneroSeleccionado = GeneroSeleccionado;

            List<Personaje> PersonajesList = new List<Personaje>(GeneroSeleccionado.Personajes);
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

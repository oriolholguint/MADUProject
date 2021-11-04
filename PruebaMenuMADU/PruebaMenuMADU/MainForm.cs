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
        List<Genero> Generos = new List<Genero>();
        BindingList<Pregunta> Preguntas;

        ModificarPregunta ModificarPregunta;
        ModificarPersonaje ModificarPersonaje;
        ModificarGenero ModificarGenero = new ModificarGenero();

        public Menu()
        {
            InitializeComponent();
            crearGenerosPrueba();
        }

        public void crearGenerosPrueba()
        {
            Respuesta[] respuestasPrueba = {new Respuesta("Respuesta 1", true),
                                            new Respuesta("Respuesta 2", true),
                                            new Respuesta("Respuesta 3", true),
                                            new Respuesta("Respuesta 4", true)};

            Pregunta preguntaRockPrueba = new Pregunta("Pregunta Rock", "Imagen", "Sonido", false, respuestasPrueba);
            Pregunta preguntaRapPrueba = new Pregunta("Pregunta Rap", "Imagen", "Sonido", false, respuestasPrueba);

            Personaje[] personajesRock = new Personaje[1];
            Partida[] partidasRock = new Partida[1];
            Pregunta[] preguntasRock = new Pregunta[1];
            preguntasRock[0] = preguntaRockPrueba;

            Personaje[] personajesRap = new Personaje[1];
            Partida[] partidasRap = new Partida[1];
            Pregunta[] preguntasRap = new Pregunta[1];
            preguntasRap[0] = preguntaRapPrueba;

            Genero Rock = new Genero("Rock", "Musica", "Musica", "Imagen", personajesRock, partidasRock, preguntasRock);
            Genero Rap = new Genero("Rap", "Musica", "Musica", "Imagen", personajesRap, partidasRap, preguntasRap);

            Generos.Add(Rock);
            Generos.Add(Rap);

            List<Pregunta> PreguntasList = new List<Pregunta>();

            //Se añaden todas las preguntas a una lista global
            for(int i = 0; i < Generos.Count; i++)
            {
                PreguntasList.AddRange(Generos[i].Preguntas); 
            }

            Preguntas = new BindingList<Pregunta>(PreguntasList);

            ObtenerComboBoxGeneros(Generos);
        }

        private void ObtenerComboBoxGeneros(List<Genero> Generos)
        {
            cbxGeneros.Items.Add("Generos");
            cbxGeneros.SelectedIndex = 0;
            for(int i = 0; i < Generos.Count; i++)
            {
                cbxGeneros.Items.Add(Generos[i].Nombre);
            }
        }

        //Eventos Botones Click
        #region

        private void buttonPreguntas_Click(object sender, EventArgs e)
        {
            BorrarPanelModificar();

            MostrarFormModificarPregunta();

            BorrarPanelDatos();

            MostrarGridPreguntas();
        }

        private void buttonPersonajes_Click(object sender, EventArgs e)
        {
            BorrarPanelModificar();

            MostrarFormModificarPersonaje();

            BorrarPanelDatos();

            MostrarGridPersonajes();
        }

        #endregion

        private void cbxGeneros_SelectedIndexChanged(object sender, EventArgs e)
        {
            Genero generoSeleccionado = GetGeneroSeleccionado();

            if (generoSeleccionado != null)
            {
                ActivarBotonesOpciones();
                BorrarPanelDatos();
                BorrarPanelModificar();
            }
            else
            {
                DesactivarBotonesOpciones();
                BorrarPanelDatos();
                BorrarPanelModificar();
            }
        }

        public Genero GetGeneroSeleccionado()
        {
            Genero generoSeleccionado = null;
            Boolean generoEncontrado = false;
            int counter = 0;

            if(!cbxGeneros.SelectedItem.Equals("Generos"))
            {
                while(counter < Generos.Count && !generoEncontrado)
                {
                    if(Generos[counter].Nombre.Equals(cbxGeneros.SelectedItem))
                    {
                        generoEncontrado = true;
                        generoSeleccionado = Generos[counter];

                    }
                    else
                    {
                        counter++;
                    }
                }
            }

            return generoSeleccionado;
        }

        private void ActivarBotonesOpciones()
        {
            buttonPersonajes.Enabled = true;
            buttonPreguntas.Enabled = true;
        }

        private void DesactivarBotonesOpciones()
        {
            buttonPersonajes.Enabled = false;
            buttonPreguntas.Enabled = false;
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            CrearPreguntasForm cp = new CrearPreguntasForm();

            cp.ShowDialog();
        }*/

        //Metodos Paneles Datos y Modificar
        #region

        private void BorrarPanelDatos()
        {
            //Elimino el form del panel datagridview en el caso que haya uno diferente
            if (panelDatos.Controls.Count > 0)
            {
                panelDatos.Controls.RemoveAt(0);
            }
        }

        private void MostrarGridPreguntas()
        {
            //Muestro en el panel de DataGridViews el correspondiente a Preguntas
            DataGridViewPreguntas DgvPreguntas = new DataGridViewPreguntas(GetGeneroSeleccionado(), ModificarPregunta);
            DgvPreguntas.TopLevel = false;
            panelDatos.Controls.Add(DgvPreguntas);
            DgvPreguntas.Show();
        }

        private void BorrarPanelModificar()
        {
            //Elimino el form del panel modificaciones en el caso que haya uno diferente
            if (panelModificar.Controls.Count > 0)
            {
                panelModificar.Controls.RemoveAt(0);
            }
        }

        private void MostrarFormModificarPregunta()
        {
            //Muestro en el panel de modificaciones el correspondiente a modificar una pregunta.
            ModificarPregunta = new ModificarPregunta();
            ModificarPregunta.TopLevel = false;
            panelModificar.Controls.Add(ModificarPregunta);
            ModificarPregunta.Show();
        }

        private void MostrarGridPersonajes()
        {
            DataGridViewPersonajes DgvPersonajes = new DataGridViewPersonajes(GetGeneroSeleccionado(), ModificarPersonaje);
            DgvPersonajes.TopLevel = false;
            panelDatos.Controls.Add(DgvPersonajes);
            DgvPersonajes.Show();
        }

        private void MostrarFormModificarPersonaje()
        {
            ModificarPersonaje = new ModificarPersonaje();
            ModificarPersonaje.TopLevel = false;
            panelModificar.Controls.Add(ModificarPersonaje);
            ModificarPersonaje.Show();
        }

        #endregion

        private void btnCrearPreguntas_Click(object sender, EventArgs e)
        {

        }

    }
}

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
        List<Genero> GenerosEsp = new List<Genero>();
        List<Genero> GenerosEng = new List<Genero>();

        Genero GeneroSeleccionadoEsp;
        Genero GeneroSeleccionadoEng;

        //BindingList<Pregunta> Preguntas;

        ModificarPregunta ModificarPregunta;
        ModificarPersonaje ModificarPersonaje;
        ModificarGenero ModificarGenero = new ModificarGenero();

        public Menu()
        {
            InitializeComponent();
            crearGenerosPrueba();
        }

        public void SetPreguntasList(List<Pregunta> PreguntasEsp, List<Pregunta> PreguntasEng, Genero Genero)
        {
            int Indice = GenerosEsp.IndexOf(Genero);
            GenerosEsp[Indice].Preguntas = PreguntasEsp;
            GenerosEsp[Indice].Preguntas = PreguntasEng;
        }

        //Metodo de prueba para tener generos.
        public void crearGenerosPrueba()
        {
            List<Respuesta> respuestasPrueba = new List<Respuesta>();
            respuestasPrueba.Add(new Respuesta("Respuesta 1", true));
            respuestasPrueba.Add(new Respuesta("Respuesta 2", true));
            respuestasPrueba.Add(new Respuesta("Respuesta 3", true));
            respuestasPrueba.Add(new Respuesta("Respuesta 4", true));

            Pregunta preguntaRockPrueba = new Pregunta("Pregunta Rock", "Imagen", "Sonido", false, respuestasPrueba);
            Pregunta preguntaRockPrueba2 = new Pregunta("Pregunta Rock2", "Imagen", "Sonido", false, respuestasPrueba);
            Pregunta preguntaRapPrueba = new Pregunta("Pregunta Rap", "Imagen", "Sonido", false, respuestasPrueba);
            Pregunta preguntaRapPrueba2 = new Pregunta("Pregunta Rap2", "Imagen", "Sonido", false, respuestasPrueba);

            List<Personaje> personajesRock = new List<Personaje>();
            Partida[] partidasRock = new Partida[1];
            List<Pregunta> preguntasRock = new List<Pregunta>();
            preguntasRock.Add(preguntaRockPrueba);
            preguntasRock.Add(preguntaRockPrueba2);

            List<Personaje> personajesRap = new List<Personaje>();
            Partida[] partidasRap = new Partida[1];
            List<Pregunta> preguntasRap = new List<Pregunta>();
            preguntasRap.Add(preguntaRapPrueba);
            preguntasRap.Add(preguntaRapPrueba2);

            Genero Rock = new Genero("Rock", "Musica", "Musica", "Imagen", personajesRock, partidasRock, preguntasRock);
            Genero Rap = new Genero("Rap", "Musica", "Musica", "Imagen", personajesRap, partidasRap, preguntasRap);

            GenerosEsp.Add(Rock);
            GenerosEsp.Add(Rap);

            GenerosEng.Add(Rock);
            GenerosEng.Add(Rap);

            List<Pregunta> PreguntasList = new List<Pregunta>();

            ObtenerComboBoxGeneros(GenerosEsp);
        }

        //Rellenamos el combo box de generos
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
            GetGenerosSeleccionados();

            if (GeneroSeleccionadoEsp != null)
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

        public void GetGenerosSeleccionados()
        {
            Boolean generoEncontrado = false;
            int counter = 0;

            if(!cbxGeneros.SelectedItem.Equals("Generos"))
            {
                while(counter < GenerosEsp.Count && !generoEncontrado)
                {
                    if(GenerosEsp[counter].Nombre.Equals(cbxGeneros.SelectedItem))
                    {
                        generoEncontrado = true;
                        GeneroSeleccionadoEsp = GenerosEsp[counter];
                        GeneroSeleccionadoEng = GenerosEng[counter];
                    }
                    else
                    {
                        counter++;
                    }
                }

            }

        }

        //Formularios Crear y Modificar
        #region
        private void BorrarPanelDatos()
        {
            //Elimino el form del panel datagridview en el caso que haya uno diferente
            if (panelDatos.Controls.Count > 0)
            {
                panelDatos.Controls.RemoveAt(0);
            }
        }

        private void BorrarPanelModificar()
        {
            //Elimino el form del panel modificaciones en el caso que haya uno diferente
            if (panelModificar.Controls.Count > 0)
            {
                panelModificar.Controls.RemoveAt(0);
            }
        }

        private void MostrarGridPreguntas()
        {
            //Muestro en el panel de DataGridViews el correspondiente a PreguntasEsp
            DataGridViewPreguntas DgvPreguntas = new DataGridViewPreguntas(GeneroSeleccionadoEsp, GeneroSeleccionadoEng, ModificarPregunta);
            DgvPreguntas.TopLevel = false;
            panelDatos.Controls.Add(DgvPreguntas);
            DgvPreguntas.Show();
        }

        private void MostrarFormModificarPregunta()
        {
            //Muestro en el panel de modificaciones el correspondiente a modificar una pregunta.
            ModificarPregunta = new ModificarPregunta(ObtenerNombreGeneros(), this);
            ModificarPregunta.TopLevel = false;
            panelModificar.Controls.Add(ModificarPregunta);
            ModificarPregunta.Show();
        }

        private void MostrarGridPersonajes()
        {
            DataGridViewPersonajes DgvPersonajes = new DataGridViewPersonajes(GeneroSeleccionadoEsp, GeneroSeleccionadoEng, ModificarPersonaje);
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

        //Activar/Desactivar Botones Opciones
        #region
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

        #endregion

        //Metodos Para Enviar Datos a ModificarPregunta
        #region

        public List<String> ObtenerNombreGeneros()
        {
            List<String> NombreGeneros = new List<String>();

            for(int i = 0; i < GenerosEsp.Count; i++)
            {
                NombreGeneros.Add(GenerosEsp[i].Nombre);
            }

            return NombreGeneros;
        }

        public List<Pregunta> ObtenerPreguntasEsp(String NombreGenero)
        {
            List<Pregunta> PreguntasEspCambio = null;
            Boolean GeneroEncontrado = false;
            int counter = 0;

            while (!GeneroEncontrado && counter < GenerosEsp.Count)
            {
                if (GenerosEsp[counter].Nombre.Equals(NombreGenero))
                {
                    PreguntasEspCambio = GenerosEsp[counter].Preguntas;
                    GeneroEncontrado = true;
                }

                counter++;
            }

            return PreguntasEspCambio;
        }

        public List<Pregunta> ObtenerPreguntasEng(String NombreGenero)
        {
            List<Pregunta> PreguntasEngCambio = null;
            Boolean GeneroEncontrado = false;
            int counter = 0;

            while (!GeneroEncontrado && counter < GenerosEsp.Count)
            {
                if (GenerosEsp[counter].Nombre.Equals(NombreGenero))
                {
                    PreguntasEngCambio = GenerosEsp[counter].Preguntas;
                    GeneroEncontrado = true;
                }

                counter++;
            }


            return PreguntasEngCambio;
        }

        #endregion

        private void btnCrearPreguntas_Click(object sender, EventArgs e)
        {
            CrearPreguntasForm cp = new CrearPreguntasForm();

            cp.ShowDialog();
        }

    }
}

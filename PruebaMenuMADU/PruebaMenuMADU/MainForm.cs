using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PruebaMenuMADU
{
    public partial class MainForm : Form
    {
        String PathGenerosEsp = "..\\..\\json\\GenerosEsp.json";
        String PathGenerosEng = "..\\..\\json\\GenerosEng.json";

        List<Genero> GenerosEsp;
        List<Genero> GenerosEng;

        Genero GeneroSeleccionadoEsp;
        Genero GeneroSeleccionadoEng;

        DataGridViewPreguntas DgvPreguntas;

        ModificarPregunta ModificarPregunta;

        public MainForm()
        {
            InitializeComponent();
            LeerFicheroGeneros();
            ObtenerComboBoxGeneros(GenerosEsp);
        }

        public void SetPreguntasList(Genero GeneroEspCambio, Genero GeneroEngCambio, Genero GeneroEsp, Genero GeneroEng)
        {
            int IndiceGeneroCambio;
            int IndiceGenero;

            IndiceGeneroCambio = this.GenerosEsp.IndexOf(GeneroEspCambio);
            this.GenerosEsp[IndiceGeneroCambio].preguntas = GeneroEspCambio.preguntas;
            this.GenerosEng[IndiceGeneroCambio].preguntas = GeneroEngCambio.preguntas;

            IndiceGenero = this.GenerosEsp.IndexOf(GeneroEsp);
            this.GenerosEsp[IndiceGenero].preguntas = GeneroEsp.preguntas;
            this.GenerosEng[IndiceGenero].preguntas = GeneroEng.preguntas;

            DgvPreguntas.RecargarDataGridView();
            DgvPreguntas.CargarPreguntaSeleccionada();
        }

        public void SetPreguntasList(Genero GeneroEsp, Genero GeneroEng, String Genero)
        {
            Boolean GeneroEncontrado = false;
            int Counter = 0;
            int Indice = 0;

            while(!GeneroEncontrado && Counter < GenerosEsp.Count)
            {
                if(GenerosEsp[Counter].nombre.Equals(Genero))
                {
                    GeneroEncontrado = true;
                    Indice = Counter;
                }
                else
                {
                    Counter++;
                }
            }

            GenerosEsp[Indice] = GeneroEsp;
            GenerosEng[Indice] = GeneroEng;

            DgvPreguntas.RecargarDataGridView();
            DgvPreguntas.CargarPreguntaSeleccionada();
        }

        public void SetGeneros(List<Genero> GenerosEsp, List<Genero>GenerosEng)
        {
            this.GenerosEsp = GenerosEsp;
            this.GenerosEng = GenerosEng;
            
        }

        //Relleno el combo box de generos
        #region

        private void ObtenerComboBoxGeneros(List<Genero> Generos)
        {
            cbxGeneros.Items.Clear(); //Limpio todos los generos para no repetirlos al crear uno

            cbxGeneros.Items.Add("Generos"); //Añado string genero que no mostrara ninguno
            cbxGeneros.SelectedIndex = 0;
            //Recogo todos los nombres de los generos en español para mostrarlos en el combobox
            for(int i = 0; i < Generos.Count; i++)
            {
                cbxGeneros.Items.Add(Generos[i].nombre);
            }
        }

        #endregion

        //Metodos y Eventos de Generos
        #region

        private void cbxGeneros_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetGenerosSeleccionados(cbxGeneros.SelectedItem.ToString());

            if (GeneroSeleccionadoEsp != null)
            {
                ActivarBotonesOpciones();
                BorrarPanelDatos();
                BorrarPanelModificar();

                if (GeneroSeleccionadoEsp.preguntas.Count != 0)
                {
                    MostrarFormModificarPregunta();
                    MostrarGridPreguntas();
                }
            }
            else 
            {
                DesactivarBotonesOpciones();
                BorrarPanelDatos();
                BorrarPanelModificar();
            }
        }

        public void GetGenerosSeleccionados(String Genero)
        {
            GeneroSeleccionadoEsp = null;
            GeneroSeleccionadoEng = null;
            Boolean generoEncontrado = false;
            int counter = 0;

            if(!cbxGeneros.SelectedItem.Equals("Generos"))
            {
                while(counter < GenerosEsp.Count && !generoEncontrado)
                {
                    if(GenerosEsp[counter].nombre.Equals(Genero))
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

        public Genero GetGeneroEsp(String Genero)
        {
            Genero GeneroEsp = null;

            Boolean generoEncontrado = false;
            int counter = 0;

            if (!cbxGeneros.SelectedItem.Equals("Generos"))
            {
                while (counter < GenerosEsp.Count && !generoEncontrado)
                {
                    if (GenerosEsp[counter].nombre.Equals(Genero))
                    {
                        generoEncontrado = true;
                        GeneroEsp = GenerosEsp[counter];
                    }
                    else
                    {
                        counter++;
                    }
                }
            }

            return GeneroEsp;
        }

        public Genero GetGeneroEng(String Genero)
        {
            Genero GeneroEng = null;

            Boolean generoEncontrado = false;
            int counter = 0;

            if (!cbxGeneros.SelectedItem.Equals("Generos"))
            {
                while (counter < GenerosEsp.Count && !generoEncontrado)
                {
                    if (GenerosEsp[counter].nombre.Equals(Genero))
                    {
                        generoEncontrado = true;
                        GeneroEng = GenerosEng[counter];
                    }
                    else
                    {
                        counter++;
                    }
                }
            }

            return GeneroEng;
        }

        #endregion

        //Formularios Crear y Modificar
        #region
        private void BorrarPanelDatos()
        {
            //Elimino el form del panel datagridview en el caso que haya uno diferente
            if (pnlDatos.Controls.Count > 0)
            {
                pnlDatos.Controls.RemoveAt(0);
            }
        }

        private void BorrarPanelModificar()
        {
            //Elimino el form del panel modificaciones en el caso que haya uno diferente
            if (pnlModificar.Controls.Count > 0)
            {
                pnlModificar.Controls.RemoveAt(0);
            }
        }

        private void MostrarGridPreguntas()
        {
            //Muestro en el panel de DataGridViews el correspondiente a PreguntasEsp
            DgvPreguntas = new DataGridViewPreguntas(GeneroSeleccionadoEsp, GeneroSeleccionadoEng, ModificarPregunta);
            DgvPreguntas.TopLevel = false;
            pnlDatos.Controls.Add(DgvPreguntas);
            DgvPreguntas.Show();
        }

        private void MostrarFormModificarPregunta()
        {
            //Muestro en el panel de modificaciones el correspondiente a modificar una pregunta.
            ModificarPregunta = new ModificarPregunta(ObtenerNombreGeneros(), this);
            ModificarPregunta.TopLevel = false;
            pnlModificar.Controls.Add(ModificarPregunta);
            ModificarPregunta.Show();
        }

        #endregion

        //Activar/Desactivar Botones Opciones
        #region
        private void ActivarBotonesOpciones()
        {
            buttonPreguntas.Enabled = true;
            btnGenConfig.Enabled = true;
        }

        private void DesactivarBotonesOpciones()
        {
            buttonPreguntas.Enabled = false;
            btnGenConfig.Enabled = false;
        }

        #endregion

        //Metodos Para Enviar Datos a ModificarPregunta
        #region

        public List<String> ObtenerNombreGeneros()
        {
            List<String> NombreGeneros = new List<String>();

            for(int i = 0; i < GenerosEsp.Count; i++)
            {
                NombreGeneros.Add(GenerosEsp[i].nombre);
            }

            return NombreGeneros;
        }

        #endregion

        //Metodos Leer Ficheros de Generos
        #region

        private void LeerFicheroGeneros()
        {
            JArray jArrayGenerosEsp = JArray.Parse(File.ReadAllText(PathGenerosEsp));
            GenerosEsp = jArrayGenerosEsp.ToObject<List<Genero>>();

            JArray jArrayGenerosEng = JArray.Parse(File.ReadAllText(PathGenerosEng));
            GenerosEng = jArrayGenerosEng.ToObject<List<Genero>>();
        }

        #endregion

        //Metodos Crear Fichero JSON
        #region

        private void btnGenerarJSON_Click(object sender, EventArgs e)
        {
            CrearFicheroJson();
        }

        private void CrearFicheroJson()
        {
            JArray ArrayGenerosEsp = (JArray)JToken.FromObject(GenerosEsp);
            File.WriteAllText(PathGenerosEsp, ArrayGenerosEsp.ToString());

            JArray ArrayGenerosEng = (JArray)JToken.FromObject(GenerosEng);
            File.WriteAllText(PathGenerosEng, ArrayGenerosEng.ToString());

            if (File.Exists(PathGenerosEsp) && File.Exists(PathGenerosEng))
            {
                MessageBox.Show("JSON Generado Correctamente", "JSON", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        private void btnCrearPreguntas_Click(object sender, EventArgs e)
        {
            CrearPreguntasForm cp = new CrearPreguntasForm(GenerosEsp, GenerosEng);

            cp.ShowDialog();

            this.SetGeneros(cp.getArrays()[0],cp.getArrays()[1]);

            //DgvPreguntas.RecargarDataGridView();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            CrearGenero cg = new CrearGenero(this.GeneroSeleccionadoEsp, this.GeneroSeleccionadoEng);
            cg.ShowDialog();
            if (cg.getCreatedGenre("esp") == null || cg.manualCancel)
            {
                MessageBox.Show("No se ha añadido ningun genero", "Error en la creacion de Generos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                this.GenerosEsp.Add(cg.getCreatedGenre("esp"));
                this.GenerosEng.Add(cg.getCreatedGenre("eng"));
                ObtenerComboBoxGeneros(GenerosEsp); //Recargo combo box de generos
                Console.WriteLine(cg.getCreatedGenre("esp") + " " + cg.getCreatedGenre("eng"));
            }

        }

        private void btnGestionarPersonajes_Click(object sender, EventArgs e)
        {
            FormPersonajesGenero f = new FormPersonajesGenero(this.GenerosEsp, this.GenerosEng);
            f.ShowDialog();
        }

        private void btnGenConfig_Click(object sender, EventArgs e)
        {
            
            CrearGenero cg = new CrearGenero(this.GeneroSeleccionadoEsp,this.GeneroSeleccionadoEng);
            cg.ShowDialog();
            this.GeneroSeleccionadoEsp = cg.getCreatedGenre("esp") != null ? cg.getCreatedGenre("esp") : this.GeneroSeleccionadoEsp;
            this.GeneroSeleccionadoEng = cg.getCreatedGenre("eng") != null ? cg.getCreatedGenre("eng") : this.GeneroSeleccionadoEng;
            /*if (cg.deleteGenre)
            {
                Boolean found = false;
                while (found)
                {
                    if(this.lista)
                }
            }*/
            if (cg.getCreatedGenre("esp") == null) MessageBox.Show("Se ha cancelado la edicion del genero " + this.GeneroSeleccionadoEsp.nombre,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }

    }
}
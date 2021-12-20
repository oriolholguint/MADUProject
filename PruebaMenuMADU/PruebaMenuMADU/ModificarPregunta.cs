using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaMenuMADU
{
    public partial class ModificarPregunta : Form
    {
        Pregunta PreguntaEsp;
        Pregunta PreguntaEng;

        Genero GeneroSeleccionadoEsp;
        Genero GeneroSeleccionadoEng;

        //Se usa en el caso que el usuario quiera cambiar el genero de la pregunta
        Genero GeneroEspCambio = null;
        Genero GeneroEngCambio = null;

        MainForm MainForm;

        public ModificarPregunta()
        {
            InitializeComponent();
        }

        public ModificarPregunta(List<String> NombreGeneros, MainForm Menu)
        {
            InitializeComponent();
            RellenarComboBoxGeneros(NombreGeneros);
            this.MainForm = Menu;
        }

        public void setPregunta(Genero GeneroSeleccionadoEsp,
                                Genero GeneroSeleccionadoEng,
                                Pregunta PreguntaEsp,
                                Pregunta PreguntaEng)
        {
            this.GeneroSeleccionadoEsp = GeneroSeleccionadoEsp;
            this.GeneroSeleccionadoEng = GeneroSeleccionadoEng;
            this.PreguntaEsp = PreguntaEsp;
            this.PreguntaEng = PreguntaEng;
            txtRespuesta3.Enabled = true;
            txtRespuesta4.Enabled = true;
            txtAnwser3.Enabled = true;
            txtAnwser4.Enabled = true;
            rdbRespuesta3.Enabled = true;
            rdbRespuesta4.Enabled = true;

            RellenarDatosPregunta(PreguntaEsp, PreguntaEng);
        }

        //Metodos Rellenar datos de la pregunta
        #region

        private void RellenarDatosPregunta(Pregunta PreguntaEsp, Pregunta PreguntaEng)
        {
            if (PreguntaEsp != null)
            {
                //CheckBox Tipo de Pregunta
                if (PreguntaEsp.respuestas.Length == 2)
                {
                    cboTipoPregunta.Checked = true;

                    //Añado el texto de las Respuestas Esp
                    txtRespuesta1.Text = PreguntaEsp.respuestas[0].respuestaDescripcion;
                    txtRespuesta2.Text = PreguntaEsp.respuestas[1].respuestaDescripcion;
                    txtRespuesta3.Text = "";
                    txtRespuesta4.Text = "";
                    txtRespuesta1.Enabled = false;
                    txtRespuesta2.Enabled = false;
                    txtRespuesta3.Enabled = false;
                    txtRespuesta4.Enabled = false;

                    //Añado el texto de las Respuestas Eng
                    txtAnwser1.Text = PreguntaEng.respuestas[0].respuestaDescripcion;
                    txtAnwser2.Text = PreguntaEng.respuestas[1].respuestaDescripcion;
                    txtAnwser3.Text = "";
                    txtAnwser4.Text = "";
                    txtAnwser1.Enabled = false;
                    txtAnwser2.Enabled = false;
                    txtAnwser3.Enabled = false;
                    txtAnwser4.Enabled = false;

                    //Activa el radio button de la respuesta correcta
                    if (PreguntaEsp.respuestas[0].esCorrecta)
                    {
                        rdbRespuesta1.Checked = true;
                    }
                    else if (PreguntaEsp.respuestas[1].esCorrecta)
                    {
                        rdbRespuesta2.Checked = true;
                    }

                    rdbRespuesta3.Enabled = false;
                    rdbRespuesta4.Enabled = false;
                }
                else
                {
                    cboTipoPregunta.Checked = false;

                    //Respuestas en Esp
                    txtRespuesta1.Text = PreguntaEsp.respuestas[0].respuestaDescripcion;
                    txtRespuesta2.Text = PreguntaEsp.respuestas[1].respuestaDescripcion;
                    txtRespuesta3.Text = PreguntaEsp.respuestas[2].respuestaDescripcion;
                    txtRespuesta4.Text = PreguntaEsp.respuestas[3].respuestaDescripcion;

                    txtRespuesta1.Enabled = true;
                    txtRespuesta2.Enabled = true;
                    txtRespuesta3.Enabled = true;
                    txtRespuesta4.Enabled = true;

                    //Respuestas en Eng
                    txtAnwser1.Text = PreguntaEng.respuestas[0].respuestaDescripcion;
                    txtAnwser2.Text = PreguntaEng.respuestas[1].respuestaDescripcion;
                    txtAnwser3.Text = PreguntaEng.respuestas[2].respuestaDescripcion;
                    txtAnwser4.Text = PreguntaEng.respuestas[3].respuestaDescripcion;

                    txtAnwser1.Enabled = true;
                    txtAnwser2.Enabled = true;
                    txtAnwser3.Enabled = true;
                    txtAnwser4.Enabled = true;

                    rdbRespuesta3.Enabled = true;
                    rdbRespuesta4.Enabled = true;

                    //Activa el radio button de la respuesta correcta
                    SeleccionarRespuestaCorrecta(PreguntaEsp);
                }

                //Añado texto de la pregunta en Español
                txtPregunta.Text = PreguntaEsp.preguntaDescripcion;
                //Añado texto de la pregunta en Ingles
                txtQuestion.Text = PreguntaEng.preguntaDescripcion;

                //Añado informacion conjunta y utilizo la pregunta en español
                if (PreguntaEsp.esMayorEdad)
                {
                    cboMayorEdad.Checked = true;
                }
                else
                {
                    cboMayorEdad.Checked = false;
                }

                //Añado el genero de la pregunta en el combobox
                Boolean GeneroEncontrado = false;
                int counterGeneros = 0;
                while (counterGeneros < cbxGenero.Items.Count && !GeneroEncontrado)
                {
                    if (GeneroSeleccionadoEsp.nombre.Equals(cbxGenero.Items[counterGeneros].ToString()))
                    {
                        cbxGenero.SelectedIndex = counterGeneros;
                        GeneroEncontrado = true;
                    }

                    counterGeneros++;
                }

                txtImagen.Text = PreguntaEsp.imagen;
                txtSonido.Text = PreguntaEsp.sonido;
            }
        }

        private void RellenarComboBoxGeneros(List<String> NombreGeneros)
        {
            for (int i = 0; i < NombreGeneros.Count; i++)
            {
                cbxGenero.Items.Add(NombreGeneros[i]);
            }
        }

        #endregion

        //Evento Seleccion de Nuevo Genero
        #region

        private void cbxGenero_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GeneroEspCambio = MainForm.GetGeneroEsp(cbxGenero.SelectedItem.ToString());
            GeneroEngCambio = MainForm.GetGeneroEng(cbxGenero.SelectedItem.ToString());
        }

        #endregion

        //Evento Eliminar Pregunta
        #region

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Estas seguro que deseas eliminar la pregunta?", "Eliminar Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                EliminarPregunta();
            }
        }

        private void EliminarPregunta()
        {
            if(PreguntaEsp != null)
            {
                GeneroSeleccionadoEsp.preguntas.Remove(PreguntaEsp);
                GeneroSeleccionadoEng.preguntas.Remove(PreguntaEng);

                MainForm.SetPreguntasList(GeneroSeleccionadoEsp, GeneroSeleccionadoEng, GeneroSeleccionadoEsp.nombre);
            }
        }

        #endregion

        //Evento Limpiar Modificacion
        #region

        private void btnLimpiarModificacion_Click(object sender, EventArgs e)
        {
            RellenarDatosPregunta(PreguntaEsp, PreguntaEng);
            CambiarTipoPregunta();
        }

        #endregion

        //Evento Guardar Modificacion
        #region

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (PreguntaEsp != null && !ValidarCampos())
            {
                Pregunta PreguntaEspToAdd = CrearPreguntaEsp();
                Pregunta PreguntaEngToAdd = CrearPreguntaEng();

                if (GeneroEspCambio != null)
                {
                    if (!String.IsNullOrEmpty(txtImagen.Text))
                    {
                        ResourceManager.addImageToResources(txtImagen.Text);
                    }
                    if (!String.IsNullOrEmpty(txtSonido.Text))
                    {
                        ResourceManager.addSoundToResources(txtSonido.Text);
                    }
                    //Se devuelven la lista de un nuevo genero

                    GeneroSeleccionadoEsp.preguntas.Remove(PreguntaEsp);
                    GeneroSeleccionadoEng.preguntas.Remove(PreguntaEng);

                    GeneroEspCambio.preguntas.Add(PreguntaEspToAdd);
                    GeneroEngCambio.preguntas.Add(PreguntaEngToAdd);
                    MainForm.SetPreguntasList(GeneroEspCambio, GeneroEngCambio, GeneroSeleccionadoEsp, GeneroSeleccionadoEng);
                }
                else
                {
                    if (!String.IsNullOrEmpty(txtImagen.Text))
                    {
                        ResourceManager.addImageToResources(txtImagen.Text);
                    }
                    if (!String.IsNullOrEmpty(txtSonido.Text))
                    {
                        ResourceManager.addSoundToResources(txtSonido.Text);
                    }

                    GeneroSeleccionadoEsp.preguntas.Remove(PreguntaEsp);
                    GeneroSeleccionadoEng.preguntas.Remove(PreguntaEng);

                    //Se devuelven la lista de preguntasEsp del mismo generos
                    GeneroSeleccionadoEsp.preguntas.Add(PreguntaEspToAdd);
                    GeneroSeleccionadoEng.preguntas.Add(PreguntaEngToAdd);
                    MainForm.SetPreguntasList(GeneroSeleccionadoEsp, GeneroSeleccionadoEng, cbxGenero.Text);
                }

                errorProvider1.Clear();
            }
        }

        #endregion

        //Evento Cambiar Tipo Pregunta
        #region

        private void cboTipoPreguntaTipoPregunta_Click(object sender, EventArgs e)
        {
            CambiarTipoPregunta();
            CleanErrorProvider();
        }

        private void CambiarTipoPregunta()
        {
            if (PreguntaEsp != null)
            {
                if (cboTipoPregunta.Checked == true)
                {
                    //Si alguno de los radiobuttons no disponibles estan seleccionados, se selecciona el primer radio button.
                    if (rdbRespuesta3.Enabled == true || rdbRespuesta4.Enabled == true)
                    {
                        rdbRespuesta1.Checked = true;
                    }
                    //Añado las respuestas disponibles
                    txtRespuesta1.Text = "Verdadero";
                    txtRespuesta2.Text = "Falso";
                    txtAnwser1.Text = "True";
                    txtAnwser2.Text = "False";
                    //Deshabilito opcion de escribir en textbox no necesarios
                    txtRespuesta1.Enabled = false;
                    txtRespuesta2.Enabled = false;
                    txtRespuesta3.Enabled = false;
                    txtRespuesta4.Enabled = false;
                    txtAnwser1.Enabled = false;
                    txtAnwser2.Enabled = false;
                    txtAnwser3.Enabled = false;
                    txtAnwser4.Enabled = false;
                    //Borro el texto que hay en los textbox no necesarios
                    txtAnwser3.Text = "";
                    txtAnwser4.Text = "";
                    txtRespuesta3.Text = "";
                    txtRespuesta4.Text = "";
                    //Deshabilito la opcion de marcar radio buttons no necesarios.
                    rdbRespuesta3.Enabled = false;
                    rdbRespuesta4.Enabled = false;
                    rdbRespuesta3.Checked = false;
                    rdbRespuesta4.Checked = false;

                }
                else
                {
                    //Si la pregunta original es de 2 respuestas entrara aqui
                    if (PreguntaEsp.respuestas.Length == 2)
                    {
                        //Vaciamos los campos de textos de la pregunta 1 y 2
                        txtRespuesta1.Text = "";
                        txtRespuesta2.Text = "";
                        txtAnwser1.Text = "";
                        txtAnwser2.Text = "";
                        //Se activa las respuestas 3 y 4, ya que el tipo se cambia de 2 a 4 respuestas
                        txtRespuesta1.Enabled = true;
                        txtRespuesta2.Enabled = true;
                        txtRespuesta3.Enabled = true;
                        txtRespuesta4.Enabled = true;
                        txtAnwser1.Enabled = true;
                        txtAnwser2.Enabled = true;
                        txtAnwser3.Enabled = true;
                        txtAnwser4.Enabled = true;
                        //Se activa los radiobuttons de las respuestas 3 y 4
                        rdbRespuesta3.Enabled = true;
                        rdbRespuesta4.Enabled = true;

                        SeleccionarRespuestaCorrecta(PreguntaEsp);
                    }
                    else //Si la pregunta original es de 4 respuestas entrara aqui
                    {
                        //Se coloca el texto de la pregunta en los text box
                        txtRespuesta1.Text = PreguntaEsp.respuestas[0].respuestaDescripcion;
                        txtRespuesta2.Text = PreguntaEsp.respuestas[1].respuestaDescripcion;
                        txtAnwser1.Text = PreguntaEng.respuestas[0].respuestaDescripcion;
                        txtAnwser2.Text = PreguntaEng.respuestas[1].respuestaDescripcion;
                        txtRespuesta3.Text = PreguntaEsp.respuestas[2].respuestaDescripcion;
                        txtRespuesta4.Text = PreguntaEsp.respuestas[3].respuestaDescripcion;
                        txtAnwser3.Text = PreguntaEng.respuestas[2].respuestaDescripcion;
                        txtAnwser4.Text = PreguntaEng.respuestas[3].respuestaDescripcion;
                        //Se activa los radiobuttons de las respuestas 3 y 4
                        rdbRespuesta3.Enabled = true;
                        rdbRespuesta4.Enabled = true;
                        txtRespuesta1.Enabled = true;
                        txtRespuesta2.Enabled = true;
                        txtRespuesta3.Enabled = true;
                        txtRespuesta4.Enabled = true;
                        txtAnwser1.Enabled = true;
                        txtAnwser2.Enabled = true;
                        txtAnwser3.Enabled = true;
                        txtAnwser4.Enabled = true;

                        SeleccionarRespuestaCorrecta(PreguntaEsp);
                    }
                }
            }
        }

        private void CleanErrorProvider()
        {
            TextBox[] textBoxes = { txtAnwser1, txtAnwser2, txtAnwser3, txtAnwser4, txtRespuesta1, txtRespuesta2,
                txtRespuesta3, txtRespuesta4};

            for(int i = 0; i < textBoxes.Length; i++)
            {
                errorProvider1.SetError(textBoxes[i], null);
            }
        }

        #endregion

        //Metodos Creacion Objetos Nuevas preguntas Modificadas
        #region

        private Pregunta CrearPreguntaEsp()
        {
            Pregunta Pregunta = new Pregunta();

            Pregunta.preguntaDescripcion = txtPregunta.Text;
            if (cboMayorEdad.Checked == true)
            {
                Pregunta.esMayorEdad = true;
            }
            else
            {
                Pregunta.esMayorEdad = false;
            }

            if (!String.IsNullOrEmpty(txtImagen.Text))
            {
                String imageName = txtImagen.Text.Split('\\').Last();
                Pregunta.imagen = imageName;
            }

            if (!String.IsNullOrEmpty(txtSonido.Text))
            {
                String soundName = txtSonido.Text.Split('\\').Last();
                Pregunta.sonido = soundName;
            }
            Pregunta.respuestas = CrearRespuestaEsp();
            GuardarRespuestaCorrecta(Pregunta);

            return Pregunta;
        }

        private Pregunta CrearPreguntaEng()
        {
            Pregunta Pregunta = new Pregunta();

            Pregunta.preguntaDescripcion = txtQuestion.Text;
            if (cboMayorEdad.Checked == true)
            {
                Pregunta.esMayorEdad = true;
            }
            else
            {
                Pregunta.esMayorEdad = false;
            }

            if (!String.IsNullOrEmpty(txtImagen.Text))
            {
                String imageName = txtImagen.Text.Split('\\').Last();
                Pregunta.imagen = imageName;
            }

            if (!String.IsNullOrEmpty(txtSonido.Text))
            {
                String soundName = txtSonido.Text.Split('\\').Last();
                Pregunta.sonido = soundName;
            }
            Pregunta.respuestas = CrearRespuestasEng();
            GuardarRespuestaCorrecta(Pregunta);

            return Pregunta;
        }

        private Respuesta[] CrearRespuestasEng()
        {
            Respuesta[] Respuestas;
            int CantidadRespuestas = 4;

            if (cboTipoPregunta.Checked == true)
            {
                CantidadRespuestas = 2;
            }

            Respuestas = new Respuesta[CantidadRespuestas];

            Respuesta Respuesta1 = new Respuesta(txtAnwser1.Text, false);
            Respuesta Respuesta2 = new Respuesta(txtAnwser2.Text, false);

            Respuestas[0] = Respuesta1;
            Respuestas[1] = Respuesta2;

            if (CantidadRespuestas == 4)
            {
                Respuesta Respuesta3 = new Respuesta(txtAnwser3.Text, false);
                Respuesta Respuesta4 = new Respuesta(txtAnwser4.Text, false);

                Respuestas[2] = Respuesta3;
                Respuestas[3] = Respuesta4;
            }

            return Respuestas;
        }

        private Respuesta[] CrearRespuestaEsp()
        {
            Respuesta[] Respuestas;
            int CantidadRespuestas = 4;

            if (cboTipoPregunta.Checked == true)
            {
                CantidadRespuestas = 2;
            }

            Respuestas = new Respuesta[CantidadRespuestas];

            Respuesta Respuesta1 = new Respuesta(txtRespuesta1.Text, false);
            Respuesta Respuesta2 = new Respuesta(txtRespuesta2.Text, false);

            Respuestas[0] = Respuesta1;
            Respuestas[1] = Respuesta2;

            if (CantidadRespuestas == 4)
            {
                Respuesta Respuesta3 = new Respuesta(txtRespuesta3.Text, false);
                Respuesta Respuesta4 = new Respuesta(txtRespuesta4.Text, false);

                Respuestas[2] = Respuesta3;
                Respuestas[3] = Respuesta4;
            }

            return Respuestas;
        }

        private void GuardarRespuestaCorrecta(Pregunta Pregunta)
        {
            if(rdbRespuesta1.Checked == true)
            {
                Pregunta.respuestas[0].esCorrecta = true;
            }
            else if(rdbRespuesta2.Checked == true)
            {
                Pregunta.respuestas[1].esCorrecta = true;
            }
            else if(rdbRespuesta3.Checked == true)
            {
                Pregunta.respuestas[2].esCorrecta = true;
            }
            else if(rdbRespuesta4.Checked == true)
            {
                Pregunta.respuestas[3].esCorrecta = true;
            }
        }

        private void SeleccionarRespuestaCorrecta(Pregunta Pregunta)
        {
            Boolean RespuestaEncontrada = false;
            int counterRespuestas = 0;

            while (!RespuestaEncontrada && counterRespuestas < PreguntaEsp.respuestas.Count())
            {
                if (PreguntaEsp.respuestas[counterRespuestas].esCorrecta == true)
                {
                    switch (counterRespuestas + 1)
                    {
                        case 1:
                            rdbRespuesta1.Checked = true;
                            break;
                        case 2:
                            rdbRespuesta2.Checked = true;
                            break;
                        case 3:
                            rdbRespuesta3.Checked = true;
                            break;
                        case 4:
                            rdbRespuesta4.Checked = true;
                            break;
                    }

                    RespuestaEncontrada = true;
                }

                counterRespuestas++;
            }
        }


        #endregion

        public void ActivarBotonesOpciones()
        {
            btnGuardar.Enabled = true;
            btnLimpiarModificacion.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private Boolean ValidarCampos()
        {
            Boolean ErrorEncontrado = false;

            TextBox[] textBoxes = { txtAnwser1, txtAnwser2, txtAnwser3, txtAnwser4, txtRespuesta1, txtRespuesta2, 
                txtRespuesta3, txtRespuesta4, txtPregunta, txtQuestion };

            for(int i = 0; i < textBoxes.Length; i++)
            {
                if (String.IsNullOrEmpty(textBoxes[i].Text))
                {
                    if (textBoxes[i].Enabled == true)
                    {
                        errorProvider1.SetError(textBoxes[i], "El campo no puede quedar vacio");
                        ErrorEncontrado = true;
                    }
                }
            }

            return ErrorEncontrado;
        }

        private void btnAbrirFicherosImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImagenSeleccionada = new OpenFileDialog();
            ImagenSeleccionada.Filter = "Archivos de Imagen(*.jpg)(*.jpeg)(*.png)(*.gif)|*.jpg; *jpeg; *.png; *.png";
           

            if (ImagenSeleccionada.ShowDialog() == DialogResult.OK)
            {
                txtImagen.Text = ImagenSeleccionada.FileName;
            }
        }

        private void btnAbrirFicherosSonido_Click(object sender, EventArgs e)
        {
            OpenFileDialog SonidoSeleccionado = new OpenFileDialog();
            SonidoSeleccionado.Filter = "Archivos de Audio (*.mp3)(*.wav)(*.wma)|*.mp3; *.wav; *.wma";

            if (SonidoSeleccionado.ShowDialog() == DialogResult.OK)
            {
                txtSonido.Text = SonidoSeleccionado.FileName;

            }
        }

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            txtImagen.Text = "";
        }

        private void btnEliminarSonido_Click(object sender, EventArgs e)
        {
            txtSonido.Text = "";
        }
    }
}
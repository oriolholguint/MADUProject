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

        Menu MainForm;

        public ModificarPregunta()
        {
            InitializeComponent();
        }

        public ModificarPregunta(List<String> NombreGeneros, Menu Menu)
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
            textBoxRespuesta3.Enabled = true;
            textBoxRespuesta4.Enabled = true;
            textBoxAnwser3.Enabled = true;
            textBoxAnwser4.Enabled = true;
            radioButtonRespuesta3.Enabled = true;
            radioButtonRespuesta4.Enabled = true;

            RellenarDatosPregunta(PreguntaEsp, PreguntaEng);
        }

        //Metodos Rellenar datos de la pregunta
        #region

        private void RellenarDatosPregunta(Pregunta PreguntaEsp, Pregunta PreguntaEng)
        {
            if (PreguntaEsp != null)
            {
                //CheckBox Tipo de Pregunta
                if (PreguntaEsp.Respuestas.Length == 2)
                {
                    checkBoxTipoPregunta.Checked = true;

                    //Añado el texto de las Respuestas Esp
                    textBoxRespuesta1.Text = PreguntaEsp.Respuestas[0].RespuestaDescripcion;
                    textBoxRespuesta2.Text = PreguntaEsp.Respuestas[1].RespuestaDescripcion;
                    textBoxRespuesta3.Text = "";
                    textBoxRespuesta4.Text = "";
                    textBoxRespuesta3.Enabled = false;
                    textBoxRespuesta4.Enabled = false;

                    //Añado el texto de las Respuestas Eng
                    textBoxAnwser1.Text = PreguntaEng.Respuestas[0].RespuestaDescripcion;
                    textBoxAnwser2.Text = PreguntaEng.Respuestas[1].RespuestaDescripcion;
                    textBoxAnwser3.Text = "";
                    textBoxAnwser4.Text = "";
                    textBoxAnwser3.Enabled = false;
                    textBoxAnwser4.Enabled = false;

                    //Activa el radio button de la respuesta correcta
                    if (PreguntaEsp.Respuestas[0].EsCorrecta)
                    {
                        radioButtonRespuesta1.Checked = true;
                    }
                    else if (PreguntaEsp.Respuestas[1].EsCorrecta)
                    {
                        radioButtonRespuesta2.Checked = true;
                    }

                    radioButtonRespuesta3.Enabled = false;
                    radioButtonRespuesta4.Enabled = false;
                }
                else
                {
                    checkBoxTipoPregunta.Checked = false;

                    //Respuestas en Esp
                    textBoxRespuesta1.Text = PreguntaEsp.Respuestas[0].RespuestaDescripcion;
                    textBoxRespuesta2.Text = PreguntaEsp.Respuestas[1].RespuestaDescripcion;
                    textBoxRespuesta3.Text = PreguntaEsp.Respuestas[2].RespuestaDescripcion;
                    textBoxRespuesta4.Text = PreguntaEsp.Respuestas[3].RespuestaDescripcion;

                    //Respuestas en Eng
                    textBoxAnwser1.Text = PreguntaEng.Respuestas[0].RespuestaDescripcion;
                    textBoxAnwser2.Text = PreguntaEng.Respuestas[1].RespuestaDescripcion;
                    textBoxAnwser3.Text = PreguntaEng.Respuestas[2].RespuestaDescripcion;
                    textBoxAnwser4.Text = PreguntaEng.Respuestas[3].RespuestaDescripcion;

                    radioButtonRespuesta3.Enabled = true;
                    radioButtonRespuesta4.Enabled = true;

                    //Activa el radio button de la respuesta correcta
                    SeleccionarRespuestaCorrecta(PreguntaEsp);
                }

                //Añado texto de la pregunta en Español
                textBoxPregunta.Text = PreguntaEsp.PreguntaDescripcion;
                //Añado texto de la pregunta en Ingles
                textBoxQuestion.Text = PreguntaEng.PreguntaDescripcion;

                //Añado informacion conjunta y utilizo la pregunta en español
                if (PreguntaEsp.EsMayorEdad)
                {
                    checkBoxMayorEdad.Checked = true;
                }
                else
                {
                    checkBoxMayorEdad.Checked = false;
                }

                //Añado el genero de la pregunta en el combobox
                Boolean GeneroEncontrado = false;
                int counterGeneros = 0;
                while (counterGeneros < comboBoxGenero.Items.Count && !GeneroEncontrado)
                {
                    if (GeneroSeleccionadoEsp.Nombre.Equals(comboBoxGenero.Items[counterGeneros].ToString()))
                    {
                        comboBoxGenero.SelectedIndex = counterGeneros;
                        GeneroEncontrado = true;
                    }

                    counterGeneros++;
                }

                textBoxImagen.Text = PreguntaEsp.Imagen;
                textBoxSonido.Text = PreguntaEsp.Sonido;
            }
        }

        private void RellenarComboBoxGeneros(List<String> NombreGeneros)
        {
            for (int i = 0; i < NombreGeneros.Count; i++)
            {
                comboBoxGenero.Items.Add(NombreGeneros[i]);
            }
        }

        #endregion

        //Evento Seleccion de Nuevo Genero
        #region

        private void comboBoxGenero_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GeneroEspCambio = MainForm.GetGeneroEsp(comboBoxGenero.SelectedItem.ToString());
            GeneroEngCambio = MainForm.GetGeneroEng(comboBoxGenero.SelectedItem.ToString());
        }

        #endregion

        //Evento Eliminar Pregunta
        #region

        private void buttonEliminar_Click(object sender, EventArgs e)
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
                GeneroSeleccionadoEsp.Preguntas.Remove(PreguntaEsp);
                GeneroSeleccionadoEng.Preguntas.Remove(PreguntaEng);

                MainForm.SetPreguntasList(GeneroSeleccionadoEsp, GeneroSeleccionadoEng, GeneroSeleccionadoEsp.Nombre);
            }
        }

        #endregion

        //Evento Limpiar Modificacion
        #region

        private void buttonLimpiarModificacion_Click(object sender, EventArgs e)
        {
            RellenarDatosPregunta(PreguntaEsp, PreguntaEng);
            CambiarTipoPregunta();
        }

        #endregion

        //Evento Guardar Modificacion
        #region

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (PreguntaEsp != null && !ValidarCampos())
            {
                Pregunta PreguntaEspToAdd = CrearPreguntaEsp();
                Pregunta PreguntaEngToAdd = CrearPreguntaEng();

                if (GeneroEspCambio != null)
                {
                    ResourceManager.addImageToResources(textBoxImagen.Text);
                    ResourceManager.addSoundToResources(textBoxSonido.Text);
                    //Se devuelven la lista de un nuevo genero

                    GeneroSeleccionadoEsp.Preguntas.Remove(PreguntaEsp);
                    GeneroSeleccionadoEng.Preguntas.Remove(PreguntaEng);

                    GeneroEspCambio.Preguntas.Add(PreguntaEspToAdd);
                    GeneroEngCambio.Preguntas.Add(PreguntaEngToAdd);
                    MainForm.SetPreguntasList(GeneroEspCambio, GeneroEngCambio, GeneroSeleccionadoEsp, GeneroSeleccionadoEng);
                }
                else
                {
                    ResourceManager.addImageToResources(textBoxImagen.Text);
                    ResourceManager.addSoundToResources(textBoxSonido.Text);

                    GeneroSeleccionadoEsp.Preguntas.Remove(PreguntaEsp);
                    GeneroSeleccionadoEng.Preguntas.Remove(PreguntaEng);

                    //Se devuelven la lista de preguntasEsp del mismo generos
                    GeneroSeleccionadoEsp.Preguntas.Add(PreguntaEspToAdd);
                    GeneroSeleccionadoEng.Preguntas.Add(PreguntaEngToAdd);
                    MainForm.SetPreguntasList(GeneroSeleccionadoEsp, GeneroSeleccionadoEng, comboBoxGenero.Text);
                }

                errorProvider1.Clear();
            }
        }

        #endregion

        //Evento Cambiar Tipo Pregunta
        #region

        private void checkBoxTipoPregunta_Click(object sender, EventArgs e)
        {
            CambiarTipoPregunta();
            CleanErrorProvider();
        }

        private void CambiarTipoPregunta()
        {
            if (PreguntaEsp != null)
            {
                if (checkBoxTipoPregunta.Checked == true)
                {
                    //Si alguno de los radiobuttons no disponibles estan seleccionados, se selecciona el primer radio button.
                    if (radioButtonRespuesta3.Enabled == true || radioButtonRespuesta4.Enabled == true)
                    {
                        radioButtonRespuesta1.Checked = true;
                    }
                    //Añado las respuestas disponibles
                    textBoxRespuesta1.Text = "Verdadero";
                    textBoxRespuesta2.Text = "Falso";
                    textBoxAnwser1.Text = "True";
                    textBoxAnwser2.Text = "False";
                    //Deshabilito opcion de escribir en textbox no necesarios
                    textBoxRespuesta1.Enabled = false;
                    textBoxRespuesta2.Enabled = false;
                    textBoxRespuesta3.Enabled = false;
                    textBoxRespuesta4.Enabled = false;
                    textBoxAnwser1.Enabled = false;
                    textBoxAnwser2.Enabled = false;
                    textBoxAnwser3.Enabled = false;
                    textBoxAnwser4.Enabled = false;
                    //Borro el texto que hay en los textbox no necesarios
                    textBoxAnwser3.Text = "";
                    textBoxAnwser4.Text = "";
                    textBoxRespuesta3.Text = "";
                    textBoxRespuesta4.Text = "";
                    //Deshabilito la opcion de marcar radio buttons no necesarios.
                    radioButtonRespuesta3.Enabled = false;
                    radioButtonRespuesta4.Enabled = false;
                    radioButtonRespuesta3.Checked = false;
                    radioButtonRespuesta4.Checked = false;

                }
                else
                {
                    //Si la pregunta original es de 2 respuestas entrara aqui
                    if (PreguntaEsp.Respuestas.Length == 2)
                    {
                        //Vaciamos los campos de textos de la pregunta 1 y 2
                        textBoxRespuesta1.Text = "";
                        textBoxRespuesta2.Text = "";
                        textBoxAnwser1.Text = "";
                        textBoxAnwser2.Text = "";
                        //Se activa las respuestas 3 y 4, ya que el tipo se cambia de 2 a 4 respuestas
                        textBoxRespuesta1.Enabled = true;
                        textBoxRespuesta2.Enabled = true;
                        textBoxRespuesta3.Enabled = true;
                        textBoxRespuesta4.Enabled = true;
                        textBoxAnwser1.Enabled = true;
                        textBoxAnwser2.Enabled = true;
                        textBoxAnwser3.Enabled = true;
                        textBoxAnwser4.Enabled = true;
                        //Se activa los radiobuttons de las respuestas 3 y 4
                        radioButtonRespuesta3.Enabled = true;
                        radioButtonRespuesta4.Enabled = true;

                        SeleccionarRespuestaCorrecta(PreguntaEsp);
                    }
                    else //Si la pregunta original es de 4 respuestas entrara aqui
                    {
                        //Se coloca el texto de la pregunta en los text box
                        textBoxRespuesta1.Text = PreguntaEsp.Respuestas[0].RespuestaDescripcion;
                        textBoxRespuesta2.Text = PreguntaEsp.Respuestas[1].RespuestaDescripcion;
                        textBoxAnwser1.Text = PreguntaEng.Respuestas[0].RespuestaDescripcion;
                        textBoxAnwser2.Text = PreguntaEng.Respuestas[1].RespuestaDescripcion;
                        textBoxRespuesta3.Text = PreguntaEsp.Respuestas[2].RespuestaDescripcion;
                        textBoxRespuesta4.Text = PreguntaEsp.Respuestas[3].RespuestaDescripcion;
                        textBoxAnwser3.Text = PreguntaEng.Respuestas[2].RespuestaDescripcion;
                        textBoxAnwser4.Text = PreguntaEng.Respuestas[3].RespuestaDescripcion;
                        //Se activa los radiobuttons de las respuestas 3 y 4
                        radioButtonRespuesta3.Enabled = true;
                        radioButtonRespuesta4.Enabled = true;
                        textBoxRespuesta1.Enabled = true;
                        textBoxRespuesta2.Enabled = true;
                        textBoxRespuesta3.Enabled = true;
                        textBoxRespuesta4.Enabled = true;
                        textBoxAnwser1.Enabled = true;
                        textBoxAnwser2.Enabled = true;
                        textBoxAnwser3.Enabled = true;
                        textBoxAnwser4.Enabled = true;

                        SeleccionarRespuestaCorrecta(PreguntaEsp);
                    }
                }
            }
        }

        private void CleanErrorProvider()
        {
            TextBox[] textBoxes = { textBoxAnwser1, textBoxAnwser2, textBoxAnwser3, textBoxAnwser4, textBoxRespuesta1, textBoxRespuesta2,
                textBoxRespuesta3, textBoxRespuesta4};

            for(int i = 0; i < textBoxes.Length; i++)
            {
                errorProvider1.SetError(textBoxes[i], null);
            }
        }

        #endregion

        //Metodos Creacion Objetos Nuevas Preguntas Modificadas
        #region

        private Pregunta CrearPreguntaEsp()
        {
            Pregunta Pregunta = new Pregunta();

            Pregunta.PreguntaDescripcion = textBoxPregunta.Text;
            if (checkBoxMayorEdad.Checked == true)
            {
                Pregunta.EsMayorEdad = true;
            }
            else
            {
                Pregunta.EsMayorEdad = false;
            }
            String imageName = textBoxImagen.Text.Split('\\').Last();
            Pregunta.Imagen = ResourceManager.IMAGES_PATH + imageName;
            String soundName = textBoxSonido.Text.Split('\\').Last();
            Pregunta.Sonido = ResourceManager.SOUNDS_PATH + soundName;
            Pregunta.Respuestas = CrearRespuestaEsp();
            GuardarRespuestaCorrecta(Pregunta);

            return Pregunta;
        }

        private Pregunta CrearPreguntaEng()
        {
            Pregunta Pregunta = new Pregunta();

            Pregunta.PreguntaDescripcion = textBoxQuestion.Text;
            if (checkBoxMayorEdad.Checked == true)
            {
                Pregunta.EsMayorEdad = true;
            }
            else
            {
                Pregunta.EsMayorEdad = false;
            }
            String imageName = textBoxImagen.Text.Split('\\').Last();
            Pregunta.Imagen = ResourceManager.IMAGES_PATH + imageName;
            String soundName = textBoxSonido.Text.Split('\\').Last();
            Pregunta.Sonido = ResourceManager.SOUNDS_PATH + soundName;
            Pregunta.Respuestas = CrearRespuestasEng();
            GuardarRespuestaCorrecta(Pregunta);

            return Pregunta;
        }

        private Respuesta[] CrearRespuestasEng()
        {
            Respuesta[] Respuestas;
            int CantidadRespuestas = 4;

            if (checkBoxTipoPregunta.Checked == true)
            {
                CantidadRespuestas = 2;
            }

            Respuestas = new Respuesta[CantidadRespuestas];

            Respuesta Respuesta1 = new Respuesta(textBoxAnwser1.Text, false);
            Respuesta Respuesta2 = new Respuesta(textBoxAnwser2.Text, false);

            Respuestas[0] = Respuesta1;
            Respuestas[1] = Respuesta2;

            if (CantidadRespuestas == 4)
            {
                Respuesta Respuesta3 = new Respuesta(textBoxAnwser3.Text, false);
                Respuesta Respuesta4 = new Respuesta(textBoxAnwser4.Text, false);

                Respuestas[2] = Respuesta3;
                Respuestas[3] = Respuesta4;
            }

            return Respuestas;
        }

        private Respuesta[] CrearRespuestaEsp()
        {
            Respuesta[] Respuestas;
            int CantidadRespuestas = 4;

            if (checkBoxTipoPregunta.Checked == true)
            {
                CantidadRespuestas = 2;
            }

            Respuestas = new Respuesta[CantidadRespuestas];

            Respuesta Respuesta1 = new Respuesta(textBoxRespuesta1.Text, false);
            Respuesta Respuesta2 = new Respuesta(textBoxRespuesta2.Text, false);

            Respuestas[0] = Respuesta1;
            Respuestas[1] = Respuesta2;

            if (CantidadRespuestas == 4)
            {
                Respuesta Respuesta3 = new Respuesta(textBoxRespuesta3.Text, false);
                Respuesta Respuesta4 = new Respuesta(textBoxRespuesta4.Text, false);

                Respuestas[2] = Respuesta3;
                Respuestas[3] = Respuesta4;
            }

            return Respuestas;
        }

        private void GuardarRespuestaCorrecta(Pregunta Pregunta)
        {
            if(radioButtonRespuesta1.Checked == true)
            {
                Pregunta.Respuestas[0].EsCorrecta = true;
            }
            else if(radioButtonRespuesta2.Checked == true)
            {
                Pregunta.Respuestas[1].EsCorrecta = true;
            }
            else if(radioButtonRespuesta3.Checked == true)
            {
                Pregunta.Respuestas[2].EsCorrecta = true;
            }
            else if(radioButtonRespuesta4.Checked == true)
            {
                Pregunta.Respuestas[3].EsCorrecta = true;
            }
        }

        private void SeleccionarRespuestaCorrecta(Pregunta Pregunta)
        {
            Boolean RespuestaEncontrada = false;
            int counterRespuestas = 0;

            while (!RespuestaEncontrada && counterRespuestas < PreguntaEsp.Respuestas.Count())
            {
                if (PreguntaEsp.Respuestas[counterRespuestas].EsCorrecta == true)
                {
                    switch (counterRespuestas + 1)
                    {
                        case 1:
                            radioButtonRespuesta1.Checked = true;
                            break;
                        case 2:
                            radioButtonRespuesta2.Checked = true;
                            break;
                        case 3:
                            radioButtonRespuesta3.Checked = true;
                            break;
                        case 4:
                            radioButtonRespuesta4.Checked = true;
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
            buttonGuardar.Enabled = true;
            buttonLimpiarModificacion.Enabled = true;
            buttonEliminar.Enabled = true;
        }

        private Boolean ValidarCampos()
        {
            Boolean ErrorEncontrado = false;

            TextBox[] textBoxes = { textBoxAnwser1, textBoxAnwser2, textBoxAnwser3, textBoxAnwser4, textBoxRespuesta1, textBoxRespuesta2, 
                textBoxRespuesta3, textBoxRespuesta4, textBoxPregunta, textBoxQuestion };

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

        private void buttonAbrirFicherosImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ImagenSeleccionada = new OpenFileDialog();
            ImagenSeleccionada.Filter = "Archivos de Imagen(*.jpg)(*.jpeg)(*.png)(*.gif)|*.jpg; *jpeg; *.png; *.png";
           

            if (ImagenSeleccionada.ShowDialog() == DialogResult.OK)
            {
                textBoxImagen.Text = ImagenSeleccionada.FileName;
            }
        }

        private void buttonAbrirFicherosSonido_Click(object sender, EventArgs e)
        {
            OpenFileDialog SonidoSeleccionado = new OpenFileDialog();
            SonidoSeleccionado.Filter = "Archivos de Audio (*.mp3)(*.wav)(*.wma)|*.mp3; *.wav; *.wma";

            if (SonidoSeleccionado.ShowDialog() == DialogResult.OK)
            {
                textBoxSonido.Text = SonidoSeleccionado.FileName;

            }
        }
    }
}

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
    public partial class CrearPreguntasForm : Form
    {
        BindingList<Pregunta> preguntas = new BindingList<Pregunta>();
        


        public CrearPreguntasForm()
        {
            InitializeComponent();
        }

        private void CrearPreguntasForm_Load(object sender, EventArgs e)
        {
            OcultarColumna();
        }

        private void vaciarCampos() {

            txtNombrePreg.Text = "";
            cbxGeneroPreg.SelectedItem = null;
            cbxTipoPreg.SelectedItem = null;
            cbxEdad.SelectedItem = null;
            txtResp1.Text = "";
            txtResp2.Text = "";
            txtResp3.Text = "";
            txtResp4.Text = "";


        }

        private void OcultarColumna() {
            txtResp3.Visible = false;
            txtResp4.Visible = false;
            rdbResp3.Visible = false;
            rdbResp4.Visible = false;

            txtResp3.Text = "";
            txtResp4.Text = "";
            
            rdbResp3.Enabled = false;
            rdbResp4.Enabled = false;
        }
        private void MostrarColumna()
        {
            txtResp3.Visible = true;
            txtResp4.Visible = true;
            rdbResp3.Visible = true;
            rdbResp4.Visible = true;

            txtResp3.Enabled = true;
            txtResp4.Enabled = true;
            rdbResp3.Enabled = true;
            rdbResp4.Enabled = true;
        }



        private void btnAñadirPregunta_Click(object sender, EventArgs e)
        {
            Pregunta pregunta = new Pregunta();
            BindingList<Respuesta> respuestas = new BindingList<Respuesta>();

            pregunta.id = preguntas.Count() + 1;
            pregunta.NombrePregunta = txtNombrePreg.Text;
            pregunta.Genero = (String)cbxGeneroPreg.SelectedItem;
            pregunta.Tipo = (String)cbxTipoPreg.SelectedItem;
            pregunta.UrlImgAudio = "urlprueba";

            if (cbxEdad.SelectedItem.Equals("Mayor de edad"))
            {
                pregunta.MayorDeEdad = true;
            }
            else
            {
                pregunta.MayorDeEdad = false;
            }

            preguntas.Add(pregunta);

            Button btnSeleccionarPregunta = new Button();
            btnSeleccionarPregunta.Name = "btnSeleccionarPregunta";
            btnSeleccionarPregunta.Text = "Pregunta " + pregunta.id;
            btnSeleccionarPregunta.BackColor = Color.LightCyan;
            

            btnSeleccionarPregunta.Size = new Size(130,122);

            btnSeleccionarPregunta.Location = new Point(3, flpListaPreguntas.Controls.Count * 20);
            flpListaPreguntas.Controls.Add(btnSeleccionarPregunta);
            btnSeleccionarPregunta.Click += (sender2, e2) => btnSeleccionarPregunta_Click(sender2, e2, pregunta, respuestas);

            if (cbxTipoPreg.SelectedIndex == 0)
            {
                Respuesta respuesta1 = new Respuesta();
                respuesta1.id = 1;
                respuesta1.NombreRespuesta = txtResp1.Text;
                Respuesta respuesta2 = new Respuesta();
                respuesta2.id = 2;
                respuesta2.NombreRespuesta = txtResp2.Text;
                if (rdbResp1.Checked)
                {
                    respuesta1.Correcta = true;
                    respuesta2.Correcta = false;
                }
                if (rdbResp2.Checked)
                {
                    respuesta1.Correcta = false;
                    respuesta2.Correcta = true;
                }

                respuestas.Add(respuesta1);
                respuestas.Add(respuesta2);
            }
            else
            {

                Respuesta respuesta1 = new Respuesta();
                respuesta1.id = 1;
                respuesta1.NombreRespuesta = txtResp1.Text;
                Respuesta respuesta2 = new Respuesta();
                respuesta2.id = 2;
                respuesta2.NombreRespuesta = txtResp2.Text;

                Respuesta respuesta3 = new Respuesta();
                respuesta3.id = 3;
                respuesta3.NombreRespuesta = txtResp3.Text;
                Respuesta respuesta4 = new Respuesta();
                respuesta4.id = 4;
                respuesta4.NombreRespuesta = txtResp4.Text;
                if (rdbResp1.Checked)
                {
                    respuesta1.Correcta = true;
                    respuesta2.Correcta = false;
                    respuesta3.Correcta = false;
                    respuesta4.Correcta = false;
                }
                if (rdbResp2.Checked)
                {
                    respuesta1.Correcta = false;
                    respuesta2.Correcta = true;
                    respuesta3.Correcta = false;
                    respuesta4.Correcta = false;
                }
                if (rdbResp3.Checked)
                {
                    respuesta1.Correcta = false;
                    respuesta2.Correcta = false;
                    respuesta3.Correcta = true;
                    respuesta4.Correcta = false;
                }
                if (rdbResp2.Checked)
                {
                    respuesta1.Correcta = false;
                    respuesta2.Correcta = false;
                    respuesta3.Correcta = false;
                    respuesta4.Correcta = true;
                }


                respuestas.Add(respuesta1);
                respuestas.Add(respuesta2);
                respuestas.Add(respuesta3);
                respuestas.Add(respuesta4);

            }


            vaciarCampos();
            OcultarColumna();

        }
       

        private void btnSeleccionarPregunta_Click(object sender, EventArgs e, Pregunta preg, BindingList<Respuesta> respuestas)
        {
            

            txtNombrePreg.Text = preg.NombrePregunta;
            cbxGeneroPreg.SelectedItem = preg.Genero;
            cbxTipoPreg.SelectedItem = preg.Tipo;

            if (preg.MayorDeEdad)
            {
                cbxEdad.SelectedIndex = 1;
            }
            else
            {
                cbxEdad.SelectedIndex = 0;
            }

            if (cbxTipoPreg.SelectedIndex == 0)
            {
                
             
                txtResp1.Text = respuestas[0].NombreRespuesta;
                rdbResp1.Checked = respuestas[0].Correcta;

                txtResp2.Text = respuestas[1].NombreRespuesta;
                rdbResp2.Checked = respuestas[1].Correcta;

            }
            else
            {
                MostrarColumna();
                txtResp1.Text = respuestas[0].NombreRespuesta;
                rdbResp1.Checked = respuestas[0].Correcta;

                txtResp2.Text = respuestas[1].NombreRespuesta;
                rdbResp2.Checked = respuestas[1].Correcta;

                txtResp3.Text = respuestas[2].NombreRespuesta;
                rdbResp3.Checked = respuestas[2].Correcta;

                txtResp4.Text = respuestas[3].NombreRespuesta;
                rdbResp4.Checked = respuestas[3].Correcta;
            }

        }

        private void cbxGeneroPreg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                pbImagenPregunta.ImageLocation = getImage.FileName;
                txtUrlOculta.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);


            }
            else
            {
                MessageBox.Show("No se selecciono ninguna imagen", "Sin seleccion",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            //SaveFileDialog guardarImagen = new SaveFileDialog();
            //guardarImagen.InitialDirectory = "";


        }

        private void cbxTipoPreg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoPreg.SelectedIndex == 0)
            {
                
                OcultarColumna();
            }
            else
            {

                MostrarColumna();

            }
        }

        private void rdbResp1_CheckedChanged(object sender, EventArgs e)
        {
            rdbResp1.Text = "B";
            rdbResp1.BackColor = Color.LightGreen;

            rdbResp2.Text = "M";
            rdbResp2.BackColor = Color.Red;

            rdbResp3.Text = "M";
            rdbResp3.BackColor = Color.Red;

            rdbResp4.Text = "M";
            rdbResp4.BackColor = Color.Red;
        }

        private void rdbResp2_CheckedChanged(object sender, EventArgs e)
        {
            rdbResp1.Text = "M";
            rdbResp1.BackColor = Color.Red;

            rdbResp2.Text = "B";
            rdbResp2.BackColor = Color.LightGreen;

            rdbResp3.Text = "M";
            rdbResp3.BackColor = Color.Red;

            rdbResp4.Text = "M";
            rdbResp4.BackColor = Color.Red;
        }

        private void rdbResp3_CheckedChanged(object sender, EventArgs e)
        {

            rdbResp1.Text = "M";
            rdbResp1.BackColor = Color.Red;

            rdbResp2.Text = "M";
            rdbResp2.BackColor = Color.Red;

            rdbResp3.Text = "B";
            rdbResp3.BackColor = Color.LightGreen;

            rdbResp4.Text = "M";
            rdbResp4.BackColor = Color.Red;
        }

        private void rdbResp4_CheckedChanged(object sender, EventArgs e)
        {

            rdbResp1.Text = "M";
            rdbResp1.BackColor = Color.Red;

            rdbResp2.Text = "M";
            rdbResp2.BackColor = Color.Red;

            rdbResp3.Text = "M";
            rdbResp3.BackColor = Color.Red;

            rdbResp4.Text = "B";
            rdbResp4.BackColor = Color.LightGreen;
        }
    }
}

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

            rdbResp1.Text = "C";
            rdbResp1.BackColor = Color.DarkGray;
            rdbResp1.Checked = false;

            rdbResp2.Text = "C";
            rdbResp2.BackColor = Color.DarkGray;
            rdbResp2.Checked = false;

            rdbResp3.Text = "C";
            rdbResp3.BackColor = Color.DarkGray;
            rdbResp3.Checked = false;

            rdbResp4.Text = "C";
            rdbResp4.BackColor = Color.DarkGray;
            rdbResp4.Checked = false;

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

            //BindingList<Respuesta> respuestas = new BindingList<Respuesta>();
            int i = 1;
            foreach (var item in preguntas)
            {
                i++;
            }


            pregunta.id = i;
            pregunta.NombrePregunta = txtNombrePreg.Text;
            pregunta.Genero = (String)cbxGeneroPreg.SelectedItem;
            pregunta.Tipo = (String)cbxTipoPreg.SelectedItem;
            pregunta.UrlImgAudio = "urlprueba";

            if (cbxEdad.SelectedIndex == 0)
            {
                pregunta.MayorDeEdad = false;
            }
            else
            {
                pregunta.MayorDeEdad = true;
            }

            pregunta.ListaRespuestas = new BindingList<Respuesta>();


            //if (cbxTipoPreg.SelectedIndex == 0)
            //{


            //    Respuesta respuesta1;
            //    Respuesta respuesta2;

            //    if (rdbResp1.Checked)
            //    {
            //        respuesta1 = new Respuesta(1, txtResp1.Text, true);
            //        respuesta2 = new Respuesta(2, txtResp2.Text, false);
            //        pregunta.ListaRespuestas.Add(respuesta1);
            //        pregunta.ListaRespuestas.Add(respuesta2);

            //    }
            //    if (rdbResp2.Checked)
            //    {
            //        respuesta1 = new Respuesta(1, txtResp1.Text, false);
            //        respuesta2 = new Respuesta(2, txtResp2.Text, true);
            //        pregunta.ListaRespuestas.Add(respuesta1);
            //        pregunta.ListaRespuestas.Add(respuesta2);


            //    }

            //}
            //else
            //{

            //    Respuesta respuesta1;               
            //    Respuesta respuesta2;
            //    Respuesta respuesta3;
            //    Respuesta respuesta4;

            //    if (rdbResp1.Checked)
            //    {
            //        respuesta1 = new Respuesta(1, txtResp1.Text, true);
            //        respuesta2 = new Respuesta(2, txtResp2.Text, false);
            //        respuesta3 = new Respuesta(3, txtResp3.Text, false);
            //        respuesta4 = new Respuesta(4, txtResp4.Text, false);
                   
            //        pregunta.ListaRespuestas.Add(respuesta1);
            //        pregunta.ListaRespuestas.Add(respuesta2);
            //        pregunta.ListaRespuestas.Add(respuesta3);
            //        pregunta.ListaRespuestas.Add(respuesta4);
            //    }
            //    if (rdbResp2.Checked)
            //    {
            //        respuesta1 = new Respuesta(1, txtResp1.Text, false);
            //        respuesta2 = new Respuesta(2, txtResp2.Text, true);
            //        respuesta3 = new Respuesta(3, txtResp3.Text, false);
            //        respuesta4 = new Respuesta(4, txtResp4.Text, false);

            //        pregunta.ListaRespuestas.Add(respuesta1);
            //        pregunta.ListaRespuestas.Add(respuesta2);
            //        pregunta.ListaRespuestas.Add(respuesta3);
            //        pregunta.ListaRespuestas.Add(respuesta4);
            //    }
            //    if (rdbResp3.Checked)
            //    {
            //        respuesta1 = new Respuesta(1, txtResp1.Text, false);
            //        respuesta2 = new Respuesta(2, txtResp2.Text, false);
            //        respuesta3 = new Respuesta(3, txtResp3.Text, true);
            //        respuesta4 = new Respuesta(4, txtResp4.Text, false);

            //        pregunta.ListaRespuestas.Add(respuesta1);
            //        pregunta.ListaRespuestas.Add(respuesta2);
            //        pregunta.ListaRespuestas.Add(respuesta3);
            //        pregunta.ListaRespuestas.Add(respuesta4);
            //    }
            //    if (rdbResp2.Checked)
            //    {
            //        respuesta1 = new Respuesta(1, txtResp1.Text, false);
            //        respuesta2 = new Respuesta(2, txtResp2.Text, false);
            //        respuesta3 = new Respuesta(3, txtResp3.Text, false);
            //        respuesta4 = new Respuesta(4, txtResp4.Text, true);

            //        pregunta.ListaRespuestas.Add(respuesta1);
            //        pregunta.ListaRespuestas.Add(respuesta2);
            //        pregunta.ListaRespuestas.Add(respuesta3);
            //        pregunta.ListaRespuestas.Add(respuesta4);
            //    }


                

                
            //}

            preguntas.Add(pregunta);

            Button btnSeleccionarPregunta = new Button();
            btnSeleccionarPregunta.Name = "btnSeleccionarPregunta";
            btnSeleccionarPregunta.Text = "P " + pregunta.id;
            btnSeleccionarPregunta.BackColor = Color.LightCyan;
            btnSeleccionarPregunta.Font = new Font(new FontFamily("Microsoft Sans Serif"), 14);

            btnSeleccionarPregunta.Size = new Size(130, 122);

            btnSeleccionarPregunta.Location = new Point(3, flpListaPreguntas.Controls.Count * 20);
            flpListaPreguntas.Controls.Add(btnSeleccionarPregunta);
            btnSeleccionarPregunta.Click += (sender2, e2) => btnSeleccionarPregunta_Click(sender2, e2, pregunta);


            Button btnModificarPregunta = new Button();
            btnModificarPregunta.Name = "btnModificarPregunta";
            btnModificarPregunta.Text = "Modificar";
            btnModificarPregunta.BackColor = Color.PaleGoldenrod;
            btnModificarPregunta.FlatStyle = FlatStyle.Flat;
            btnModificarPregunta.FlatAppearance.BorderColor = Color.Goldenrod;
            btnModificarPregunta.FlatAppearance.BorderSize = 2;
            btnModificarPregunta.FlatAppearance.MouseOverBackColor = Color.LightYellow;



            btnModificarPregunta.Font = new Font(new FontFamily("Microsoft Sans Serif"), 14);
            btnModificarPregunta.Size = new Size(130, 40);
            btnModificarPregunta.Location = new Point(3, flpListaPreguntas.Controls.Count * 80);
            flpListaPreguntas.Controls.Add(btnModificarPregunta);
            btnModificarPregunta.Click += (sender2, e2) => btnModificarPregunta_Click(sender2, e2, pregunta.id);



            Button btnEliminarPregunta = new Button();
            btnEliminarPregunta.Name = "btnEliminarPregunta";
            btnEliminarPregunta.Text = "Eliminar";
            btnEliminarPregunta.BackColor = Color.LightCoral;
            btnEliminarPregunta.FlatStyle = FlatStyle.Flat;
            btnEliminarPregunta.FlatAppearance.BorderColor = Color.Red;
            btnEliminarPregunta.FlatAppearance.BorderSize = 2;
            btnEliminarPregunta.FlatAppearance.MouseOverBackColor = Color.MistyRose;



            btnEliminarPregunta.Font = new Font(new FontFamily("Microsoft Sans Serif"), 14);
            btnEliminarPregunta.Size = new Size(130, 40);
            btnEliminarPregunta.Location = new Point(3, flpListaPreguntas.Controls.Count * 50);
            flpListaPreguntas.Controls.Add(btnEliminarPregunta);
            btnEliminarPregunta.Click += (sender2, e2) => btnEliminarPregunta_Click(sender2, e2, pregunta, btnSeleccionarPregunta, btnEliminarPregunta, btnModificarPregunta);




            vaciarCampos();
            OcultarColumna();

        }
       

        private void btnSeleccionarPregunta_Click(object sender, EventArgs e, Pregunta preg)
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

            preg.ListaRespuestas = new BindingList<Respuesta>();

            //MessageBox.Show(preg.ListaRespuestas[0].NombreRespuesta);

            //if (cbxTipoPreg.SelectedIndex == 0)
            //{

            //    txtResp1.Text = preg.ListaRespuestas[0].NombreRespuesta;
            //    rdbResp1.Checked = preg.ListaRespuestas[0].Correcta;

            //    txtResp2.Text = preg.ListaRespuestas[1].NombreRespuesta;
            //    rdbResp2.Checked = preg.ListaRespuestas[1].Correcta;

            //    if (rdbResp1.Checked)
            //    {
            //        rdbResp1.Text = "B";
            //        rdbResp1.BackColor = Color.LightGreen;

            //        rdbResp2.Text = "M";
            //        rdbResp2.BackColor = Color.Red;

            //        rdbResp3.Text = "M";
            //        rdbResp3.BackColor = Color.Red;

            //        rdbResp4.Text = "M";
            //        rdbResp4.BackColor = Color.Red;
            //    }

            //    if (rdbResp2.Checked)
            //    {
            //        rdbResp1.Text = "M";
            //        rdbResp1.BackColor = Color.Red;

            //        rdbResp2.Text = "B";
            //        rdbResp2.BackColor = Color.LightGreen;

            //        rdbResp3.Text = "M";
            //        rdbResp3.BackColor = Color.Red;

            //        rdbResp4.Text = "M";
            //        rdbResp4.BackColor = Color.Red;
            //    }


            //}

            //if (cbxTipoPreg.SelectedIndex == 1)
            //{
            //    MostrarColumna();
            //    txtResp1.Text = preg.ListaRespuestas[0].NombreRespuesta;
            //    rdbResp1.Checked = preg.ListaRespuestas[0].Correcta;

            //    txtResp2.Text = preg.ListaRespuestas[1].NombreRespuesta;
            //    rdbResp2.Checked = preg.ListaRespuestas[1].Correcta;

            //    txtResp3.Text = preg.ListaRespuestas[2].NombreRespuesta;
            //    rdbResp3.Checked = preg.ListaRespuestas[2].Correcta;

            //    txtResp4.Text = preg.ListaRespuestas[3].NombreRespuesta;
            //    rdbResp4.Checked = preg.ListaRespuestas[3].Correcta;


            //    if (rdbResp1.Checked)
            //    {
            //        rdbResp1.Text = "B";
            //        rdbResp1.BackColor = Color.LightGreen;

            //        rdbResp2.Text = "M";
            //        rdbResp2.BackColor = Color.Red;

            //        rdbResp3.Text = "M";
            //        rdbResp3.BackColor = Color.Red;

            //        rdbResp4.Text = "M";
            //        rdbResp4.BackColor = Color.Red;
            //    }

            //    if (rdbResp2.Checked)
            //    {
            //        rdbResp1.Text = "M";
            //        rdbResp1.BackColor = Color.Red;

            //        rdbResp2.Text = "B";
            //        rdbResp2.BackColor = Color.LightGreen;

            //        rdbResp3.Text = "M";
            //        rdbResp3.BackColor = Color.Red;

            //        rdbResp4.Text = "M";
            //        rdbResp4.BackColor = Color.Red;
            //    }

            //    if (rdbResp3.Checked)
            //    {
            //        rdbResp1.Text = "M";
            //        rdbResp1.BackColor = Color.Red;

            //        rdbResp2.Text = "M";
            //        rdbResp2.BackColor = Color.Red;

            //        rdbResp3.Text = "B";
            //        rdbResp3.BackColor = Color.LightGreen;

            //        rdbResp4.Text = "M";
            //        rdbResp4.BackColor = Color.Red;
            //    }


            //    if (rdbResp4.Checked)
            //    {
            //        rdbResp1.Text = "M";
            //        rdbResp1.BackColor = Color.Red;

            //        rdbResp2.Text = "M";
            //        rdbResp2.BackColor = Color.Red;

            //        rdbResp3.Text = "M";
            //        rdbResp3.BackColor = Color.Red;

            //        rdbResp4.Text = "B";
            //        rdbResp4.BackColor = Color.LightGreen;
            //    }

            //}





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


        private void btnModificarPregunta_Click(object sender, EventArgs e, int id)
        {

            foreach (var pregunta in preguntas)
            {
                if (pregunta.id == id)
                {
                    pregunta.NombrePregunta = txtNombrePreg.Text;
                    pregunta.Genero = (String)cbxGeneroPreg.SelectedItem;
                    pregunta.Tipo = (String)cbxGeneroPreg.SelectedItem;
                    if (cbxEdad.SelectedIndex == 0)
                    {
                        pregunta.MayorDeEdad = false;
                    }
                    else
                    {
                        pregunta.MayorDeEdad = true;
                    }

                    pregunta.UrlImgAudio = "mod";

                    
                    //pregunta.ListaRespuestas = new BindingList<Respuesta>();
                    

                    //if (cbxTipoPreg.SelectedIndex == 0)
                    //{

                    //    Respuesta respuesta1;
                    //    Respuesta respuesta2;

                    //    if (rdbResp1.Checked)
                    //    {
                    //        respuesta1 = new Respuesta(1, txtResp1.Text, true);
                    //        respuesta2 = new Respuesta(2, txtResp2.Text, false);
                    //        pregunta.ListaRespuestas.Add(respuesta1);
                    //        pregunta.ListaRespuestas.Add(respuesta2);

                    //    }
                    //    if (rdbResp2.Checked)
                    //    {
                    //        respuesta1 = new Respuesta(1, txtResp1.Text, false);
                    //        respuesta2 = new Respuesta(2, txtResp2.Text, true);
                    //        pregunta.ListaRespuestas.Add(respuesta1);
                    //        pregunta.ListaRespuestas.Add(respuesta2);
                    //    }




                    //}
                    //else
                    //{

                    //    Respuesta respuesta1;
                    //    Respuesta respuesta2;
                    //    Respuesta respuesta3;
                    //    Respuesta respuesta4;

                    //    if (rdbResp1.Checked)
                    //    {
                    //        respuesta1 = new Respuesta(1, txtResp1.Text, true);
                    //        respuesta2 = new Respuesta(2, txtResp2.Text, false);
                    //        respuesta3 = new Respuesta(3, txtResp3.Text, false);
                    //        respuesta4 = new Respuesta(4, txtResp4.Text, false);

                    //        pregunta.ListaRespuestas.Add(respuesta1);
                    //        pregunta.ListaRespuestas.Add(respuesta2);
                    //        pregunta.ListaRespuestas.Add(respuesta3);
                    //        pregunta.ListaRespuestas.Add(respuesta4);
                    //    }
                    //    if (rdbResp2.Checked)
                    //    {
                    //        respuesta1 = new Respuesta(1, txtResp1.Text, false);
                    //        respuesta2 = new Respuesta(2, txtResp2.Text, true);
                    //        respuesta3 = new Respuesta(3, txtResp3.Text, false);
                    //        respuesta4 = new Respuesta(4, txtResp4.Text, false);

                    //        pregunta.ListaRespuestas.Add(respuesta1);
                    //        pregunta.ListaRespuestas.Add(respuesta2);
                    //        pregunta.ListaRespuestas.Add(respuesta3);
                    //        pregunta.ListaRespuestas.Add(respuesta4);
                    //    }
                    //    if (rdbResp3.Checked)
                    //    {
                    //        respuesta1 = new Respuesta(1, txtResp1.Text, false);
                    //        respuesta2 = new Respuesta(2, txtResp2.Text, false);
                    //        respuesta3 = new Respuesta(3, txtResp3.Text, true);
                    //        respuesta4 = new Respuesta(4, txtResp4.Text, false);

                    //        pregunta.ListaRespuestas.Add(respuesta1);
                    //        pregunta.ListaRespuestas.Add(respuesta2);
                    //        pregunta.ListaRespuestas.Add(respuesta3);
                    //        pregunta.ListaRespuestas.Add(respuesta4);
                    //    }
                    //    if (rdbResp2.Checked)
                    //    {
                    //        respuesta1 = new Respuesta(1, txtResp1.Text, false);
                    //        respuesta2 = new Respuesta(2, txtResp2.Text, false);
                    //        respuesta3 = new Respuesta(3, txtResp3.Text, false);
                    //        respuesta4 = new Respuesta(4, txtResp4.Text, true);

                    //        pregunta.ListaRespuestas.Add(respuesta1);
                    //        pregunta.ListaRespuestas.Add(respuesta2);
                    //        pregunta.ListaRespuestas.Add(respuesta3);
                    //        pregunta.ListaRespuestas.Add(respuesta4);
                    //    }


                    //}




                }
            }

        }



        private void btnEliminarPregunta_Click(object sender, EventArgs e, Pregunta preg, Button botonSeleccionar, Button BotonEliminar, Button botonModificar)
        {
            
            preguntas.Remove(preg);            
            flpListaPreguntas.Controls.Remove(botonSeleccionar);
            flpListaPreguntas.Controls.Remove(BotonEliminar);
            flpListaPreguntas.Controls.Remove(botonModificar);

        }

        private void btnCrearPreguntas_Click(object sender, EventArgs e)
        {
            int id = 1;
            //Generar Json
            foreach (var pregunta in preguntas)
            {
                MessageBox.Show(pregunta.ToString());

            }



        }

       


    }
}

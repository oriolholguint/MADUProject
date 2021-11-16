using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PruebaMenuMADU
{
    public partial class CrearPreguntasForm : Form
    {
        List<Pregunta> preguntas = new List<Pregunta>();
        List<Pregunta> preguntasEng = new List<Pregunta>();

        List<Genero> generosEsp = new List<Genero>();
        List<Genero> generosEng = new List<Genero>();

        
        

        public CrearPreguntasForm()
        {
            InitializeComponent();

           
        }

        public CrearPreguntasForm(List<Genero> generosEsp, List<Genero> generosEng)
        {
            InitializeComponent();
            this.generosEng = generosEsp;
            this.generosEng = generosEng;
        }


        private void CrearPreguntasForm_Load(object sender, EventArgs e)
        {

            OcultarColumna();
            Genero Rock = new Genero("Rock", "xx", "xx", "xx", null, null, null);
            Genero Electronica = new Genero("Electronica", "xx", "xx", "xx", null, null, null);
            Genero HipHop = new Genero("Hip-Hop", "xx", "xx", "xx", null, null, null);
            Genero Pop = new Genero("Pop", "xx", "xx", "xx", null, null, null);

            Genero RockEng = new Genero("Rock", "xx", "xx", "xx", null, null, null);
            Genero ElectronicEng = new Genero("Electronic", "xx", "xx", "xx", null, null, null);
            Genero HipHopEng = new Genero("Hip-Hop", "xx", "xx", "xx", null, null, null);
            Genero PopEng = new Genero("Pop", "xx", "xx", "xx", null, null, null);

            generosEsp.Add(Rock);
            generosEsp.Add(Electronica);
            generosEsp.Add(HipHop);
            generosEsp.Add(Pop);


            generosEng.Add(RockEng);
            generosEng.Add(ElectronicEng);
            generosEng.Add(HipHopEng);
            generosEng.Add(PopEng);

            cbxGeneroPreg.DataSource = generosEsp;
            cbxGeneroPreg.DisplayMember = "Nombre";
            cbxGeneroPreg.ValueMember = "Nombre";

            cbxGenreQuest.DataSource = generosEng;
            cbxGenreQuest.DisplayMember = "Nombre";
            cbxGenreQuest.ValueMember = "Nombre";


        }


        private void vaciarCampos()
        {

            txtNombrePreg.Text = "";
            cbxGeneroPreg.SelectedItem = null;
            cbxTipoPreg.SelectedItem = null;
            cbxEdad.SelectedItem = null;
            pbImagenPregunta.Image = null;

            txtImgAnt.Text = "";
            txtImgOrigen.Text = "";
            txtUrlImg.Text = "";

            Reproductor.URL = null;
            txtAudioAnt.Text = "";
            txtAudioNuevo.Text = "";
            txtAudioOrigen.Text = "";

            txtResp1.Text = "";
            txtResp2.Text = "";
            txtResp3.Text = "";
            txtResp4.Text = "";

           
            rdbResp1.BackColor = Color.DarkGray;
            rdbResp1.Checked = false;
          
            rdbResp2.BackColor = Color.DarkGray;
            rdbResp2.Checked = false;
           
            rdbResp3.BackColor = Color.DarkGray;
            rdbResp3.Checked = false;
                       
            rdbResp4.BackColor = Color.DarkGray;
            rdbResp4.Checked = false;

        }

        private void OcultarColumna()
        {
            txtResp3.Visible = false;
            txtResp4.Visible = false;
            rdbResp3.Visible = false;
            rdbResp4.Visible = false;

            txtResp3.Text = "";
            txtResp4.Text = "";

            rdbResp3.Enabled = false;
            rdbResp4.Enabled = false;




            txtAns3.Visible = false;
            txtAns4.Visible = false;
            rdbAns3.Visible = false;
            rdbAns4.Visible = false;

            txtAns3.Text = "";
            txtAns4.Text = "";

            rdbAns3.Enabled = false;
            rdbAns4.Enabled = false;


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



            txtAns3.Visible = true;
            txtAns4.Visible = true;
            rdbAns3.Visible = true;
            rdbAns4.Visible = true;

            txtAns3.Enabled = true;
            txtAns4.Enabled = true;
            rdbAns3.Enabled = true;
            rdbAns4.Enabled = true;


        }



        private void btnAñadirPregunta_Click(object sender, EventArgs e)
        {
            Pregunta pregunta = new Pregunta();
            Pregunta preguntaEng = new Pregunta();


            //Pregunta en Español


            pregunta.PreguntaDescripcion = txtNombrePreg.Text;
            pregunta.Genero = (String)cbxGeneroPreg.SelectedValue;


            if (txtImgOrigen.Text.Equals("") && txtImgOrigen.Text.Equals(""))
            {
                pregunta.Imagen = "";
            }
            else {
                if (!File.Exists(txtUrlImg.Text))
                {
                    pregunta.Imagen = txtUrlImg.Text;
                    File.Copy(txtImgOrigen.Text, txtUrlImg.Text);

                }
                else
                {
                    MessageBox.Show("La ruta de destino ya contiene un archivo con el mismo nombre.");
                }

            }



            if (txtAudioNuevo.Text.Equals("") && txtAudioOrigen.Text.Equals(""))
            {
                pregunta.Sonido = "";
            }
            else
            {
                if (!File.Exists(txtAudioNuevo.Text))
                {
                    pregunta.Sonido = txtAudioNuevo.Text;
                    File.Copy(txtAudioOrigen.Text, txtAudioNuevo.Text);

                }
                else
                {
                    MessageBox.Show("La ruta de destino ya contiene un archivo con el mismo nombre.");
                }

            }


            if (cbxEdad.SelectedIndex == 0)
            {
                pregunta.EsMayorEdad = false;
            }
            else
            {
                pregunta.EsMayorEdad = true;
            }




            if (cbxTipoPreg.SelectedIndex == 0)
            {
                pregunta.Respuestas = new Respuesta[2];

                Respuesta respuesta1;
                Respuesta respuesta2;

                if (rdbResp1.Checked)
                {

                    respuesta1 = new Respuesta("Verdadero", true);
                    respuesta2 = new Respuesta("False", false);
                    pregunta.Respuestas.SetValue(respuesta1, 0);
                    pregunta.Respuestas.SetValue(respuesta2, 1);

                }
                if (rdbResp2.Checked)
                {

                    respuesta1 = new Respuesta("Falso", false);
                    respuesta2 = new Respuesta("Verdadero", true);
                    pregunta.Respuestas.SetValue(respuesta1, 0);
                    pregunta.Respuestas.SetValue(respuesta2, 1);


                }

            }
            else
            {
                pregunta.Respuestas = new Respuesta[4];

                Respuesta respuesta1;
                Respuesta respuesta2;
                Respuesta respuesta3;
                Respuesta respuesta4;

                if (rdbResp1.Checked)
                {


                    respuesta1 = new Respuesta(txtResp1.Text, true);
                    respuesta2 = new Respuesta(txtResp2.Text, false);
                    respuesta3 = new Respuesta(txtResp3.Text, false);
                    respuesta4 = new Respuesta(txtResp4.Text, false);

                    pregunta.Respuestas.SetValue(respuesta1, 0);
                    pregunta.Respuestas.SetValue(respuesta2, 1);
                    pregunta.Respuestas.SetValue(respuesta3, 2);
                    pregunta.Respuestas.SetValue(respuesta4, 3);

                }
                if (rdbResp2.Checked)
                {
                    respuesta1 = new Respuesta(txtResp1.Text, false);
                    respuesta2 = new Respuesta(txtResp2.Text, true);
                    respuesta3 = new Respuesta(txtResp3.Text, false);
                    respuesta4 = new Respuesta(txtResp4.Text, false);

                    pregunta.Respuestas.SetValue(respuesta1, 0);
                    pregunta.Respuestas.SetValue(respuesta2, 1);
                    pregunta.Respuestas.SetValue(respuesta3, 2);
                    pregunta.Respuestas.SetValue(respuesta4, 3);
                }
                if (rdbResp3.Checked)
                {
                    respuesta1 = new Respuesta(txtResp1.Text, false);
                    respuesta2 = new Respuesta(txtResp2.Text, false);
                    respuesta3 = new Respuesta(txtResp3.Text, true);
                    respuesta4 = new Respuesta(txtResp4.Text, false);

                    pregunta.Respuestas.SetValue(respuesta1, 0);
                    pregunta.Respuestas.SetValue(respuesta2, 1);
                    pregunta.Respuestas.SetValue(respuesta3, 2);
                    pregunta.Respuestas.SetValue(respuesta4, 3);
                }
                if (rdbResp4.Checked)
                {
                    respuesta1 = new Respuesta(txtResp1.Text, false);
                    respuesta2 = new Respuesta(txtResp2.Text, false);
                    respuesta3 = new Respuesta(txtResp3.Text, false);
                    respuesta4 = new Respuesta(txtResp4.Text, true);

                    pregunta.Respuestas.SetValue(respuesta1, 0);
                    pregunta.Respuestas.SetValue(respuesta2, 1);
                    pregunta.Respuestas.SetValue(respuesta3, 2);
                    pregunta.Respuestas.SetValue(respuesta4, 3);
                }


            }


            preguntas.Add(pregunta);

            foreach (Genero gen in generosEsp)
            {
                if (cbxGeneroPreg.SelectedItem.Equals(gen.Nombre))
                {
                    gen.Preguntas = preguntas;
                }
            }




            //preguntas en Ingles


            preguntaEng.PreguntaDescripcion = txtAnsName.Text;
            preguntaEng.Genero = (String)cbxGenreQuest.SelectedValue;


            if (txtUrlImageEngl.Text.Equals("") && txtOriginImg.Text.Equals(""))
            {
                preguntaEng.Imagen = "";
            }
            else
            {
                if (!File.Exists(txtUrlImageEngl.Text))
                {
                    preguntaEng.Imagen = txtUrlImageEngl.Text;
                    File.Copy(txtOriginImg.Text, txtUrlImageEngl.Text);

                }
                else
                {
                    MessageBox.Show("La ruta de destino ya contiene un archivo con el mismo nombre.");
                }

            }



            if (txtNewAudio.Text.Equals("") && txtOriginAudio.Text.Equals(""))
            {
                preguntaEng.Sonido = "";
            }
            else
            {
                if (!File.Exists(txtNewAudio.Text))
                {
                    preguntaEng.Sonido = txtNewAudio.Text;
                    File.Copy(txtOriginAudio.Text, txtNewAudio.Text);

                }
                else
                {
                    MessageBox.Show("La ruta de destino ya contiene un archivo con el mismo nombre.");
                }

            }


            if (cbxQuestAge.SelectedIndex == 0)
            {
                preguntaEng.EsMayorEdad = false;
            }
            else
            {
                preguntaEng.EsMayorEdad = true;
            }




            if (cbxQuestType.SelectedIndex == 0)
            {
                preguntaEng.Respuestas = new Respuesta[2];

                Respuesta respuesta1;
                Respuesta respuesta2;

                if (rdbAns1.Checked)
                {

                    respuesta1 = new Respuesta("True", true);
                    respuesta2 = new Respuesta("False", false);
                    preguntaEng.Respuestas.SetValue(respuesta1, 0);
                    preguntaEng.Respuestas.SetValue(respuesta2, 1);

                }
                if (rdbAns2.Checked)
                {
                    respuesta1 = new Respuesta("True", false);
                    respuesta2 = new Respuesta("False", true);
                    preguntaEng.Respuestas.SetValue(respuesta1, 0);
                    preguntaEng.Respuestas.SetValue(respuesta2, 1);


                }

            }
            else
            {
                pregunta.Respuestas = new Respuesta[4];

                Respuesta respuesta1;
                Respuesta respuesta2;
                Respuesta respuesta3;
                Respuesta respuesta4;

                if (rdbAns1.Checked)
                {


                    respuesta1 = new Respuesta(txtAns1.Text, true);
                    respuesta2 = new Respuesta(txtAns2.Text, false);
                    respuesta3 = new Respuesta(txtAns3.Text, false);
                    respuesta4 = new Respuesta(txtAns4.Text, false);

                    preguntaEng.Respuestas.SetValue(respuesta1, 0);
                    preguntaEng.Respuestas.SetValue(respuesta2, 1);
                    preguntaEng.Respuestas.SetValue(respuesta3, 2);
                    preguntaEng.Respuestas.SetValue(respuesta4, 3);

                }
                if (rdbAns2.Checked)
                {
                    respuesta1 = new Respuesta(txtAns1.Text, false);
                    respuesta2 = new Respuesta(txtAns1.Text, true);
                    respuesta3 = new Respuesta(txtAns3.Text, false);
                    respuesta4 = new Respuesta(txtAns4.Text, false);

                    preguntaEng.Respuestas.SetValue(respuesta1, 0);
                    preguntaEng.Respuestas.SetValue(respuesta2, 1);
                    preguntaEng.Respuestas.SetValue(respuesta3, 2);
                    preguntaEng.Respuestas.SetValue(respuesta4, 3);
                }
                if (rdbAns3.Checked)
                {
                    respuesta1 = new Respuesta(txtAns1.Text, false);
                    respuesta2 = new Respuesta(txtAns2.Text, false);
                    respuesta3 = new Respuesta(txtAns3.Text, true);
                    respuesta4 = new Respuesta(txtAns4.Text, false);

                    preguntaEng.Respuestas.SetValue(respuesta1, 0);
                    preguntaEng.Respuestas.SetValue(respuesta2, 1);
                    preguntaEng.Respuestas.SetValue(respuesta3, 2);
                    preguntaEng.Respuestas.SetValue(respuesta4, 3);
                }
                if (rdbAns4.Checked)
                {
                    respuesta1 = new Respuesta(txtAns1.Text, false);
                    respuesta2 = new Respuesta(txtAns2.Text, false);
                    respuesta3 = new Respuesta(txtAns3.Text, false);
                    respuesta4 = new Respuesta(txtAns4.Text, true);

                    preguntaEng.Respuestas.SetValue(respuesta1, 0);
                    preguntaEng.Respuestas.SetValue(respuesta2, 1);
                    preguntaEng.Respuestas.SetValue(respuesta3, 2);
                    preguntaEng.Respuestas.SetValue(respuesta4, 3);
                }


            }

            preguntasEng.Add(preguntaEng);

            foreach (Genero gen in generosEng)
            {
                if (cbxGenreQuest.SelectedItem.Equals(gen.Nombre))
                {
                    gen.Preguntas = preguntasEng;
                }
            }



            Button btnSeleccionarPregunta = new Button();
            btnSeleccionarPregunta.Name = "btnSeleccionarPregunta";
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
            btnModificarPregunta.Click += (sender2, e2) => btnModificarPregunta_Click(sender2, e2, pregunta);



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

            txtNombrePreg.Text = preg.PreguntaDescripcion;

            cbxGeneroPreg.SelectedItem = preg.Genero;

            if (preg.EsMayorEdad)
            {
                cbxEdad.SelectedIndex = 1;
            }
            else
            {
                cbxEdad.SelectedIndex = 0;
            }

            txtImgAnt.Text = preg.Imagen;
            txtAudioAnt.Text = preg.Sonido;


            if (!preg.Imagen.Equals("")) {
                pbImagenPregunta.ImageLocation = preg.Imagen;
            }

            if (!preg.Sonido.Equals("")) {
                Reproductor.URL = preg.Sonido;
            }

            int num = preg.Respuestas.Length;

            if (num == 2) {
                cbxTipoPreg.SelectedIndex = 0;

            } else if(num == 4){
                cbxTipoPreg.SelectedIndex = 1;
            }



            if (cbxTipoPreg.SelectedIndex == 0)
            {

                txtResp1.Text = preg.Respuestas[0].RespuestaDescripcion;
                rdbResp1.Checked = preg.Respuestas[0].EsCorrecta;

                txtResp1.Text = preg.Respuestas[0].RespuestaDescripcion;
                rdbResp1.Checked = preg.Respuestas[0].EsCorrecta;

                txtResp2.Text = preg.Respuestas[1].RespuestaDescripcion;
                rdbResp2.Checked = preg.Respuestas[1].EsCorrecta;

                if (rdbResp1.Checked)
                {
                   
                    rdbResp1.BackColor = Color.LightGreen;                  
                    rdbResp2.BackColor = Color.Red;                    
                    rdbResp3.BackColor = Color.Red;                    
                    rdbResp4.BackColor = Color.Red;
                }

                if (rdbResp2.Checked)
                {
                    
                    rdbResp1.BackColor = Color.Red;                
                    rdbResp2.BackColor = Color.LightGreen;                                        
                    rdbResp3.BackColor = Color.Red;                   
                    rdbResp4.BackColor = Color.Red;
                }


            }

            if (cbxTipoPreg.SelectedIndex == 1)
            {


                MostrarColumna();
                txtResp1.Text = preg.Respuestas[0].RespuestaDescripcion;
                rdbResp1.Checked = preg.Respuestas[0].EsCorrecta;

                txtResp2.Text = preg.Respuestas[1].RespuestaDescripcion;
                rdbResp2.Checked = preg.Respuestas[1].EsCorrecta;

                txtResp3.Text = preg.Respuestas[2].RespuestaDescripcion;
                rdbResp3.Checked = preg.Respuestas[2].EsCorrecta;

                txtResp4.Text = preg.Respuestas[3].RespuestaDescripcion;
                rdbResp4.Checked = preg.Respuestas[3].EsCorrecta;


                if (rdbResp1.Checked)
                {
                    
                    rdbResp1.BackColor = Color.LightGreen;                   
                    rdbResp2.BackColor = Color.Red;                   
                    rdbResp3.BackColor = Color.Red;                   
                    rdbResp4.BackColor = Color.Red;
                }

                if (rdbResp2.Checked)
                {
                    
                    rdbResp1.BackColor = Color.Red;                    
                    rdbResp2.BackColor = Color.LightGreen;                    
                    rdbResp3.BackColor = Color.Red;                    
                    rdbResp4.BackColor = Color.Red;
                }

                if (rdbResp3.Checked)
                {
                    
                    rdbResp1.BackColor = Color.Red;                   
                    rdbResp2.BackColor = Color.Red;                    
                    rdbResp3.BackColor = Color.LightGreen;                    
                    rdbResp4.BackColor = Color.Red;
                }


                if (rdbResp4.Checked)
                {
                    
                    rdbResp1.BackColor = Color.Red;                
                    rdbResp2.BackColor = Color.Red;                   
                    rdbResp3.BackColor = Color.Red;                    
                    rdbResp4.BackColor = Color.LightGreen;
                }

            }





        }

        private void cbxGeneroPreg_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          cbxGenreQuest.SelectedIndex = cbxGeneroPreg.SelectedIndex;
            
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";

            if (getImage.ShowDialog() == DialogResult.OK)
            {

                String []palabras = getImage.FileName.Split('\\');
                String nombreImagen = palabras[palabras.Length - 1];




                pbImagenPregunta.ImageLocation = getImage.FileName;
                pbQuestImage.ImageLocation = getImage.FileName;
               

                txtImgOrigen.Text = getImage.FileName;
                txtOriginImg.Text = getImage.FileName;

                txtUrlImg.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                txtUrlImageEngl.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

                string path = System.IO.Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
                if (Environment.OSVersion.Version.Major >= 6)
                {
                    path = System.IO.Directory.GetParent(path).ToString();
                    String rutaCompleta = path + "\\source\\repos\\MADUProject\\MADUProject\\PruebaMenuMADU\\PruebaMenuMADU\\Resources\\";
                    
                    txtUrlImg.Text = rutaCompleta + nombreImagen;
                    txtUrlImageEngl.Text = rutaCompleta + nombreImagen;

                }



            }
            else
            {
                MessageBox.Show("No se selecciono ninguna imagen", "Sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }




        }

        private void cbxTipoPreg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoPreg.SelectedIndex == 0)
            {

                OcultarColumna();
                cbxQuestType.SelectedIndex = 0;
                txtResp1.Text = "Verdadero";
                txtResp2.Text = "Falso";

                txtAns1.Text = "True";
                txtAns2.Text = "False";
                
            }
            else
            {

                MostrarColumna();
                cbxQuestType.SelectedIndex = 1;
                txtResp1.Text = "";
                txtResp2.Text = "";

                txtAns1.Text = "";
                txtAns2.Text = "";
                
            }
        }

        private void rdbResp1_CheckedChanged(object sender, EventArgs e)
        {
           
            rdbResp1.BackColor = Color.LightGreen;
            rdbResp2.BackColor = Color.Red;
            rdbResp3.BackColor = Color.Red;
            rdbResp4.BackColor = Color.Red;

            rdbAns1.BackColor = Color.LightGreen;
            rdbAns2.BackColor = Color.Red;
            rdbAns3.BackColor = Color.Red;
            rdbAns4.BackColor = Color.Red;


        }

        private void rdbResp2_CheckedChanged(object sender, EventArgs e)
        {
            
            rdbResp1.BackColor = Color.Red;
            rdbResp2.BackColor = Color.LightGreen;
            rdbResp3.BackColor = Color.Red;
            rdbResp4.BackColor = Color.Red;

            rdbAns1.BackColor = Color.Red;
            rdbAns2.BackColor = Color.LightGreen;
            rdbAns3.BackColor = Color.Red;
            rdbAns4.BackColor = Color.Red;

        }

        private void rdbResp3_CheckedChanged(object sender, EventArgs e)
        {

           
            rdbResp1.BackColor = Color.Red;
            rdbResp2.BackColor = Color.Red;
            rdbResp3.BackColor = Color.LightGreen;
            rdbResp4.BackColor = Color.Red;


            rdbAns1.BackColor = Color.Red;
            rdbAns2.BackColor = Color.Red;
            rdbAns3.BackColor = Color.LightGreen;
            rdbAns4.BackColor = Color.Red;

        }

        private void rdbResp4_CheckedChanged(object sender, EventArgs e)
        {

            
            rdbResp1.BackColor = Color.Red;
            rdbResp2.BackColor = Color.Red;           
            rdbResp3.BackColor = Color.Red;
            rdbResp4.BackColor = Color.LightGreen;


            rdbAns1.BackColor = Color.Red;
            rdbAns2.BackColor = Color.Red;
            rdbAns3.BackColor = Color.Red;
            rdbAns4.BackColor = Color.LightGreen;

        }


        private void btnModificarPregunta_Click(object sender, EventArgs e, Pregunta preg)
        {


            preg.PreguntaDescripcion = txtNombrePreg.Text;

            preg.Genero = (String)cbxGeneroPreg.SelectedItem;


            if (cbxEdad.SelectedIndex == 0)
            {
                preg.EsMayorEdad = false;
            }
            else
            {
                preg.EsMayorEdad = true;
            }




            if (txtImgOrigen.Text.Equals("") && txtImgOrigen.Text.Equals(""))
            {

                if(File.Exists(preg.Imagen))
                {
                    File.Delete(preg.Imagen);

                }
                preg.Imagen = "";
            }
            else
            {
                if (!File.Exists(txtUrlImg.Text))
                {
                    File.Delete(txtImgAnt.Text);

                    preg.Imagen = txtUrlImg.Text;

                    File.Copy(txtImgOrigen.Text, txtUrlImg.Text);

                }
                else
                {

                    MessageBox.Show("La ruta de destino ya contiene un archivo con el mismo nombre.");
                }

            }



            if (txtAudioNuevo.Text.Equals("") && txtAudioOrigen.Text.Equals(""))
            {


                if (File.Exists(preg.Sonido))
                {
                    File.Delete(preg.Sonido);

                }
                preg.Sonido = "";

            }
            else
            {
                if (!File.Exists(txtAudioNuevo.Text))
                {
                    File.Delete(txtAudioAnt.Text);

                    preg.Sonido = txtAudioNuevo.Text;
                    File.Copy(txtAudioOrigen.Text, txtAudioNuevo.Text);

                }
                else
                {
                    MessageBox.Show("La ruta de destino ya contiene un archivo con el mismo nombre.");
                }

            }



            if (cbxTipoPreg.SelectedIndex == 0)
                    {

                        Respuesta respuesta1;
                        Respuesta respuesta2;

                        if (rdbResp1.Checked)
                        {
                            respuesta1 = new Respuesta(txtResp1.Text, true);
                            respuesta2 = new Respuesta(txtResp2.Text, false);
                            preg.Respuestas.SetValue(respuesta1, 0);
                            preg.Respuestas.SetValue(respuesta2, 1);

                        }
                        if (rdbResp2.Checked)
                        {
                            respuesta1 = new Respuesta(txtResp1.Text, false);
                            respuesta2 = new Respuesta(txtResp2.Text, true);
                            preg.Respuestas.SetValue(respuesta1, 0);
                            preg.Respuestas.SetValue(respuesta2, 1);
                        }


                    }
                    else
                    {


                        Respuesta respuesta1;
                        Respuesta respuesta2;
                        Respuesta respuesta3;
                        Respuesta respuesta4;

                        if (rdbResp1.Checked)
                        {
                            respuesta1 = new Respuesta(txtResp1.Text, true);
                            respuesta2 = new Respuesta(txtResp2.Text, false);
                            respuesta3 = new Respuesta(txtResp3.Text, false);
                            respuesta4 = new Respuesta(txtResp4.Text, false);

                            preg.Respuestas.SetValue(respuesta1, 0);
                            preg.Respuestas.SetValue(respuesta2, 1);
                            preg.Respuestas.SetValue(respuesta3, 2);
                            preg.Respuestas.SetValue(respuesta4, 3);
                        }
                        if (rdbResp2.Checked)
                        {
                            respuesta1 = new Respuesta(txtResp1.Text, false);
                            respuesta2 = new Respuesta(txtResp2.Text, true);
                            respuesta3 = new Respuesta(txtResp3.Text, false);
                            respuesta4 = new Respuesta(txtResp4.Text, false);

                            preg.Respuestas.SetValue(respuesta1, 0);
                            preg.Respuestas.SetValue(respuesta2, 1);
                            preg.Respuestas.SetValue(respuesta3, 2);
                            preg.Respuestas.SetValue(respuesta4, 3);
                        }
                        if (rdbResp3.Checked)
                        {
                            respuesta1 = new Respuesta(txtResp1.Text, false);
                            respuesta2 = new Respuesta(txtResp2.Text, false);
                            respuesta3 = new Respuesta(txtResp3.Text, true);
                            respuesta4 = new Respuesta(txtResp4.Text, false);

                            preg.Respuestas.SetValue(respuesta1, 0);
                            preg.Respuestas.SetValue(respuesta2, 1);
                            preg.Respuestas.SetValue(respuesta3, 2);
                            preg.Respuestas.SetValue(respuesta4, 3);
                        }
                        if (rdbResp2.Checked)
                        {
                            respuesta1 = new Respuesta(txtResp1.Text, false);
                            respuesta2 = new Respuesta(txtResp2.Text, false);
                            respuesta3 = new Respuesta(txtResp3.Text, false);
                            respuesta4 = new Respuesta(txtResp4.Text, true);

                            preg.Respuestas.SetValue(respuesta1, 0);
                            preg.Respuestas.SetValue(respuesta2, 1);
                            preg.Respuestas.SetValue(respuesta3, 2);
                            preg.Respuestas.SetValue(respuesta4, 3);
                        }


                    }


        }



        private void btnEliminarPregunta_Click(object sender, EventArgs e, Pregunta preg, Button botonSeleccionar, Button BotonEliminar, Button botonModificar)
        {

            preguntas.Remove(preg);
            flpListaPreguntas.Controls.Remove(botonSeleccionar);
            flpListaPreguntas.Controls.Remove(BotonEliminar);
            flpListaPreguntas.Controls.Remove(botonModificar);

            vaciarCampos();

            
            rdbResp1.BackColor = Color.DarkGray;
            rdbResp1.Checked = false;

           
            rdbResp2.BackColor = Color.DarkGray;
            rdbResp2.Checked = false;

            
            rdbResp3.BackColor = Color.DarkGray;
            rdbResp3.Checked = false;

            
            rdbResp4.BackColor = Color.DarkGray;
            rdbResp4.Checked = false;

            OcultarColumna();

        }

        private void btnCrearPreguntas_Click(object sender, EventArgs e)
        {
            JArray arrayGenerosEsp = (JArray)JToken.FromObject(generosEsp);
            JArray arrayGenerosEng = (JArray)JToken.FromObject(generosEng);

            File.WriteAllText(@"C:\Users\cep.CEPNET0\Desktop\jsonPrueba\esp.json",arrayGenerosEsp.ToString());
            File.WriteAllText(@"C:\Users\cep.CEPNET0\Desktop\jsonPrueba\eng.json", arrayGenerosEng.ToString());


        }

        private void btnCargarAudio_Click(object sender, EventArgs e)
        {

            OpenFileDialog getAudio = new OpenFileDialog();
            getAudio.InitialDirectory = "C:\\";
            getAudio.Filter = "Archivos de Audio (*.mp3)(*.mp4)|*.mp3;*mp4|WAV (*.wav)|*.wav|WMA (*.wma)|*.wma";

            if (getAudio.ShowDialog() == DialogResult.OK)
            {

                String[] palabras = getAudio.FileName.Split('\\');
                String nombreAudio = palabras[palabras.Length - 1];
                String[] nombreSinExtension = palabras[palabras.Length - 1].Split('.');

                
                txtAudioOrigen.Text = getAudio.FileName;
                txtOriginAudio.Text = getAudio.FileName;

                txtAudioNuevo.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                txtNewAudio.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

                string path = System.IO.Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
                if (Environment.OSVersion.Version.Major >= 6)
                {
                    path = System.IO.Directory.GetParent(path).ToString();
                    String rutaCompleta = path + "\\source\\repos\\MADUProject\\MADUProject\\PruebaMenuMADU\\PruebaMenuMADU\\Resources\\";

                    txtAudioNuevo.Text = rutaCompleta + nombreAudio;
                    txtNewAudio.Text = rutaCompleta + nombreAudio;

                    Reproductor.URL = txtAudioOrigen.Text;
                    Player.URL = txtOriginAudio.Text;

                }



            }
            else
            {
                MessageBox.Show("No se selecciono ningun audio", "Sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }



        private void btnSinImagen_Click(object sender, EventArgs e)
        {
            pbImagenPregunta.Image = null;


            txtImgOrigen.Text = "";
            txtUrlImg.Text = "";



            pbQuestImage.Image = null;
            txtOriginImg.Text = "";
            txtUrlImageEngl.Text = "";


        }

        private void btnSinAudio_Click(object sender, EventArgs e)
        {
            Reproductor.URL = null;

            txtAudioNuevo.Text = "";
            txtAudioOrigen.Text = "";

            Player.URL = null;

            txtNewAudio.Text = "";
            txtOriginAudio.Text = "";

        }
        

        private void btnEspañol_Click(object sender, EventArgs e)
        {
            tabIdioma.SelectedTab = tabEspañol;            
        }

        private void btnIngles_Click(object sender, EventArgs e)
        {
            tabIdioma.SelectedTab = tabIngles;
        }

        private void cbxQuestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxQuestType.SelectedIndex == 0)
            {

                OcultarColumna();
                cbxTipoPreg.SelectedIndex = 0;
                txtResp1.Text = "Verdadero";
                txtResp2.Text = "Falso";

                txtAns1.Text = "True";
                txtAns2.Text = "False";
                
            }
            else
            {

                MostrarColumna();
                cbxTipoPreg.SelectedIndex = 1;
                txtResp1.Text = "";
                txtResp2.Text = "";

                txtAns1.Text = "";
                txtAns2.Text = "";

            }
        }

        private void cbxGenreQuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxGeneroPreg.SelectedIndex = cbxGenreQuest.SelectedIndex;
        }

        private void cbxEdad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxQuestAge.SelectedIndex = cbxEdad.SelectedIndex;
        }

        private void cbxQuestAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxEdad.SelectedIndex = cbxQuestAge.SelectedIndex;
        }

        private void rdbAns1_CheckedChanged(object sender, EventArgs e)
        {

            rdbAns1.BackColor = Color.LightGreen;
            rdbAns2.BackColor = Color.Red;
            rdbAns3.BackColor = Color.Red;
            rdbAns4.BackColor = Color.Red;


            rdbResp1.BackColor = Color.LightGreen;
            rdbResp2.BackColor = Color.Red;
            rdbResp3.BackColor = Color.Red;
            rdbResp4.BackColor = Color.Red;

        }

        private void rdbAns2_CheckedChanged(object sender, EventArgs e)
        {
            rdbAns1.BackColor = Color.Red;
            rdbAns2.BackColor = Color.LightGreen;
            rdbAns3.BackColor = Color.Red;
            rdbAns4.BackColor = Color.Red;

            rdbResp1.BackColor = Color.Red;
            rdbResp2.BackColor = Color.LightGreen;
            rdbResp3.BackColor = Color.Red;
            rdbResp4.BackColor = Color.Red;

            
        }

        private void rdbAns3_CheckedChanged(object sender, EventArgs e)
        {
            
            rdbAns1.BackColor = Color.Red;
            rdbAns2.BackColor = Color.Red;
            rdbAns3.BackColor = Color.LightGreen;
            rdbAns4.BackColor = Color.Red;

            rdbResp1.BackColor = Color.Red;
            rdbResp2.BackColor = Color.Red;
            rdbResp3.BackColor = Color.LightGreen;
            rdbResp4.BackColor = Color.Red;

        }

        private void rdbAns4_CheckedChanged(object sender, EventArgs e)
        {
            
            rdbAns1.BackColor = Color.Red;
            rdbAns2.BackColor = Color.Red;
            rdbAns3.BackColor = Color.Red;
            rdbAns4.BackColor = Color.LightGreen;

            rdbResp1.BackColor = Color.Red;
            rdbResp2.BackColor = Color.Red;
            rdbResp3.BackColor = Color.Red;
            rdbResp4.BackColor = Color.LightGreen;

        }
    }
}

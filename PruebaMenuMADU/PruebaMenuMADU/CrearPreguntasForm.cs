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
            Genero Rock = new Genero("Rock", "xx", "xx", "xx", null, null, preguntas);
            Genero Electronica = new Genero("Electronica", "xx", "xx", "xx", null, null, preguntas);
            Genero HipHop = new Genero("Hip-Hop", "xx", "xx", "xx", null, null, preguntas);
            Genero Pop = new Genero("Pop", "xx", "xx", "xx", null, null, preguntas);

            Genero RockEng = new Genero("Rock", "xx", "xx", "xx", null, null, preguntasEng);
            Genero ElectronicEng = new Genero("Electronic", "xx", "xx", "xx", null, null, preguntasEng);
            Genero HipHopEng = new Genero("Hip-Hop", "xx", "xx", "xx", null, null, preguntasEng);
            Genero PopEng = new Genero("Pop", "xx", "xx", "xx", null, null, preguntasEng);

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

            tabIdioma.SelectedTab = tabEspañol;

            btnEspañol.FlatStyle = FlatStyle.Flat;
            btnEspañol.FlatAppearance.BorderColor = Color.Blue;
            btnEspañol.FlatAppearance.BorderSize = 3;

           
        }


        private void vaciarCampos()
        {
            cbxTipoPreg.SelectedIndex = 0;

            txtResp1.ReadOnly = true;
            txtResp2.ReadOnly = true;

            txtNombrePreg.Text = "";
            cbxGeneroPreg.SelectedItem = null;
            cbxTipoPreg.SelectedItem = null;
            cbxEdad.SelectedItem = null;
            pbImagenPregunta.Image = null;
            pbQuestImage.Image = null;

            txtImgAnt.Text = "";
            txtImgOrigen.Text = "";
            txtUrlImg.Text = "";

            Reproductor.URL = null;
            txtAudioAnt.Text = "";
            txtAudioNuevo.Text = "";
            txtAudioOrigen.Text = "";

            //txtResp1.Text = "";
            //txtResp2.Text = "";
            //txtResp3.Text = "";
            //txtResp4.Text = "";

           
            rdbResp1.BackColor = Color.DarkGray;
            rdbResp1.Checked = false;
          
            rdbResp2.BackColor = Color.DarkGray;
            rdbResp2.Checked = false;
           
            rdbResp3.BackColor = Color.DarkGray;
            rdbResp3.Checked = false;
                       
            rdbResp4.BackColor = Color.DarkGray;
            rdbResp4.Checked = false;


            rdbAns1.BackColor = Color.DarkGray;
            rdbAns2.BackColor = Color.DarkGray;
            rdbAns3.BackColor = Color.DarkGray;
            rdbAns4.BackColor = Color.DarkGray;


            rdbAns1.Checked = false;
            rdbAns2.Checked = false;
            rdbAns3.Checked = false;
            rdbAns4.Checked = false;

            tabIdioma.SelectedTab = tabEspañol;

            btnEspañol.FlatStyle = FlatStyle.Flat;
            btnEspañol.FlatAppearance.BorderColor = Color.Blue;
            btnEspañol.FlatAppearance.BorderSize = 3;

            btnIngles.FlatStyle = FlatStyle.Standard;

        }

        private void OcultarColumna()
        {
            txtResp1.ReadOnly = true;
            txtResp2.ReadOnly = true;
            txtAns1.ReadOnly = true;
            txtAns2.ReadOnly = true;

            txtResp3.Visible = false;
            txtResp4.Visible = false;
            rdbResp3.Visible = false;
            rdbResp4.Visible = false;

          
            txtAns3.Visible = false;
            txtAns4.Visible = false;
            rdbAns3.Visible = false;
            rdbAns4.Visible = false;                      

         


        }

        private void DesactivarRadiobutons()
        {
            txtResp1.Text = "";
            txtResp2.Text = "";
            

            rdbResp1.BackColor = Color.DarkGray;
            rdbResp1.Checked = false;

            rdbResp2.BackColor = Color.DarkGray;
            rdbResp2.Checked = false;

            rdbResp3.BackColor = Color.DarkGray;
            rdbResp3.Checked = false;

            rdbResp4.BackColor = Color.DarkGray;
            rdbResp4.Checked = false;


            rdbAns1.BackColor = Color.DarkGray;
            rdbAns2.BackColor = Color.DarkGray;
            rdbAns3.BackColor = Color.DarkGray;
            rdbAns4.BackColor = Color.DarkGray;


            rdbAns1.Checked = false;
            rdbAns2.Checked = false;
            rdbAns3.Checked = false;
            rdbAns4.Checked = false;
        }


        private void MostrarColumna()
        {
            
            txtResp1.ReadOnly = false;
            txtResp2.ReadOnly = false;
            txtAns1.ReadOnly = false;
            txtAns2.ReadOnly = false;

            txtResp3.Visible = true;
            txtResp4.Visible = true;
            rdbResp3.Visible = true;
            rdbResp4.Visible = true;


            txtAns3.Visible = true;
            txtAns4.Visible = true;
            rdbAns3.Visible = true;
            rdbAns4.Visible = true;

        }



        private void btnAñadirPregunta_Click(object sender, EventArgs e)
        {
            Pregunta pregunta = new Pregunta();
            Pregunta preguntaEng = new Pregunta();


            //Pregunta en Español


            pregunta.PreguntaDescripcion = txtNombrePreg.Text;
            pregunta.Genero = (String)cbxGeneroPreg.SelectedValue;


            if (txtUrlImg.Text.Equals("") && txtImgOrigen.Text.Equals(""))
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
                   //Si la imagen exite coge la imagen existente
                    pregunta.Imagen = txtUrlImg.Text;
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
                    //Si el audio existe cogeme el audio existente
                    pregunta.Sonido = txtAudioNuevo.Text;
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

                Respuesta respuesta1 = new Respuesta("Verdadero", false);
                Respuesta respuesta2 = new Respuesta("Falso", false);

                if (rdbResp1.BackColor == Color.LightGreen)
                {
                    respuesta1.EsCorrecta = true;
                }
                if (rdbResp2.BackColor == Color.LightGreen)
                {
                    respuesta2.EsCorrecta = true;
                }

                pregunta.Respuestas[0] = respuesta1;
                pregunta.Respuestas[1] = respuesta2;

            }
            else
            {
                pregunta.Respuestas = new Respuesta[4];

               
                Respuesta respuesta1 = new Respuesta(txtResp1.Text, false);
                Respuesta respuesta2 = new Respuesta(txtResp2.Text, false);
                Respuesta respuesta3 = new Respuesta(txtResp3.Text, false);
                Respuesta respuesta4 = new Respuesta(txtResp4.Text, false);

                if (rdbResp1.BackColor == Color.LightGreen)
                {
                    respuesta1.EsCorrecta = true;                    

                }
                else if (rdbResp2.BackColor == Color.LightGreen)
                {
                    respuesta2.EsCorrecta = true;
                }
                else if (rdbResp3.BackColor == Color.LightGreen)
                {
                    respuesta3.EsCorrecta = true;
                }
                else if (rdbResp4.BackColor == Color.LightGreen)
                {
                    respuesta4.EsCorrecta = true;
                }

                pregunta.Respuestas[0] = respuesta1;
                pregunta.Respuestas[1] = respuesta2;
                pregunta.Respuestas[2] = respuesta3;
                pregunta.Respuestas[3] = respuesta4;

            }

            preguntas.Add(pregunta);



            //preguntas en Ingles


            preguntaEng.PreguntaDescripcion = txtQuestName.Text;
            preguntaEng.Genero = (String)cbxGenreQuest.SelectedValue;


            preguntaEng.Imagen = txtUrlImg.Text;
            preguntaEng.Sonido = txtNewAudio.Text;  

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

                Respuesta respuesta1 = new Respuesta("True", false);
                Respuesta respuesta2 = new Respuesta("False", false);

                if (rdbAns1.BackColor == Color.LightGreen)
                {
                    respuesta1.EsCorrecta = true;
                }
                if (rdbAns2.BackColor == Color.LightGreen)
                {
                    respuesta2.EsCorrecta = true;
                }

                preguntaEng.Respuestas[0] = respuesta1;
                preguntaEng.Respuestas[1] = respuesta2;
            }
            else
            {
                preguntaEng.Respuestas = new Respuesta[4];

                Respuesta respuesta1 = new Respuesta(txtAns1.Text, false);
                Respuesta respuesta2 = new Respuesta(txtAns2.Text, false);
                Respuesta respuesta3 = new Respuesta(txtAns3.Text, false);
                Respuesta respuesta4 = new Respuesta(txtAns4.Text, false);


                if (rdbAns1.BackColor == Color.LightGreen)
                {
                    respuesta1.EsCorrecta = true;    
                }
                else if (rdbAns2.BackColor == Color.LightGreen)
                {
                    respuesta2.EsCorrecta = true;
                }
                else if (rdbAns3.BackColor == Color.LightGreen)
                {
                    respuesta3.EsCorrecta = true;
                }
                else if (rdbAns4.BackColor == Color.LightGreen)
                {
                    respuesta4.EsCorrecta = true;

                }

                preguntaEng.Respuestas[0] = respuesta1;
                preguntaEng.Respuestas[1] = respuesta2;
                preguntaEng.Respuestas[2] = respuesta3;
                preguntaEng.Respuestas[3] = respuesta4;

            }

            if (txtQuestName.Text.Equals("") || txtNombrePreg.Text.Equals(""))
            {
                MessageBox.Show("Pregunta descripcion esta vacia");

            } else if (cbxTipoPreg.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un tipo");
            }
            else if (cbxEdad.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una edad");
            }
            else if (cbxTipoPreg.SelectedIndex == 0 && rdbResp1.BackColor == Color.DarkGray || rdbResp2.BackColor == Color.DarkGray)
            {
                MessageBox.Show("Selecciona la respuesta correcta de las 2 opciones");
            }
            else if (cbxTipoPreg.SelectedIndex == 1 && rdbResp1.BackColor == Color.DarkGray && rdbResp2.BackColor == Color.DarkGray && rdbResp3.BackColor == Color.DarkGray && rdbResp4.BackColor == Color.DarkGray)
            {
                MessageBox.Show("Selecciona la respuesta correcta de las 4 opciones");
            }
            else if (cbxTipoPreg.SelectedIndex == 1 && txtResp1.Text.Equals("") || txtResp2.Text.Equals("") || txtResp3.Text.Equals("") || txtResp4.Text.Equals("") || txtAns1.Text.Equals("") || txtAns2.Text.Equals("") || txtAns3.Text.Equals("") || txtAns4.Text.Equals(""))
            {
                MessageBox.Show("Hay respuestas vacias de las 4 opciones" );
            }
            else
            {

                preguntasEng.Add(preguntaEng);

                RadioButton btnSeleccionarPregunta = new RadioButton();
                btnSeleccionarPregunta.Appearance = Appearance.Button;

                //Button btnSeleccionarPregunta = new Button();
                btnSeleccionarPregunta.Name = "btnSeleccionarPregunta";
                String url = "..\\..\\Resources\\ImageQuiz.jpg";
                Image bkg = Image.FromFile(url);

                btnSeleccionarPregunta.BackgroundImage = bkg;
                btnSeleccionarPregunta.BackgroundImageLayout = ImageLayout.Stretch;
                btnSeleccionarPregunta.Font = new Font(new FontFamily("Microsoft Sans Serif"), 14);

                btnSeleccionarPregunta.Size = new Size(130, 122);

                btnSeleccionarPregunta.FlatAppearance.CheckedBackColor = Color.Blue;
                btnSeleccionarPregunta.Location = new Point(3, flpListaPreguntas.Controls.Count * 20);
                flpListaPreguntas.Controls.Add(btnSeleccionarPregunta);
                btnSeleccionarPregunta.Click += (sender2, e2) => btnSeleccionarPregunta_Click(sender2, e2, pregunta, preguntaEng);


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
                btnModificarPregunta.Click += (sender2, e2) => btnModificarPregunta_Click(sender2, e2, pregunta, preguntaEng);



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
                btnEliminarPregunta.Click += (sender2, e2) => btnEliminarPregunta_Click(sender2, e2, pregunta, preguntaEng, btnSeleccionarPregunta, btnEliminarPregunta, btnModificarPregunta);




                vaciarCampos();
                OcultarColumna();
            }
            


        }


        private void btnSeleccionarPregunta_Click(object sender, EventArgs e, Pregunta preg, Pregunta pregEng)
        {

            tabIdioma.SelectedTab = tabEspañol;

            btnEspañol.FlatStyle = FlatStyle.Flat;
            btnEspañol.FlatAppearance.BorderColor = Color.Blue;
            btnEspañol.FlatAppearance.BorderSize = 3;

            btnIngles.FlatStyle = FlatStyle.Standard;


            //Seleccionar preguntas Español

            txtNombrePreg.Text = preg.PreguntaDescripcion;

            cbxGeneroPreg.SelectedValue = preg.Genero;

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
            else
            {
                pbImagenPregunta.ImageLocation = null;
            }

            if (!preg.Sonido.Equals("")) {
                Reproductor.URL = preg.Sonido;
            }
            else
            {
                Reproductor.URL = null;
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

           else
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


            //Seleccionar pregunta Ingles


            txtQuestName.Text = pregEng.PreguntaDescripcion;

            cbxGenreQuest.SelectedValue = pregEng.Genero;

            if (pregEng.EsMayorEdad)
            {
                cbxQuestAge.SelectedIndex = 1;
            }
            else
            {
                cbxQuestAge.SelectedIndex = 0;
            }

            txtOldImg.Text = pregEng.Imagen;
            txtOldAudio.Text = pregEng.Sonido;


            if (!pregEng.Imagen.Equals(""))
            {
                pbQuestImage.ImageLocation = pregEng.Imagen;
            }

            if (!pregEng.Sonido.Equals(""))
            {
                Player.URL = pregEng.Sonido;
            }

            int num2 = pregEng.Respuestas.Length;

            if (num2 == 2)
            {
                cbxQuestType.SelectedIndex = 0;

            }
            else if (num2 == 4)
            {
                cbxQuestType.SelectedIndex = 1;
            }



            if (cbxQuestType.SelectedIndex == 0)
            {

                txtAns1.Text = pregEng.Respuestas[0].RespuestaDescripcion;
                rdbAns1.Checked = pregEng.Respuestas[0].EsCorrecta;

                txtAns2.Text = pregEng.Respuestas[1].RespuestaDescripcion;
                rdbAns2.Checked = pregEng.Respuestas[1].EsCorrecta;

                if (rdbAns1.Checked)
                {

                    rdbAns1.BackColor = Color.LightGreen;
                    rdbAns2.BackColor = Color.Red;
                    rdbAns3.BackColor = Color.Red;
                    rdbAns4.BackColor = Color.Red;
                }

                if (rdbAns2.Checked)
                {

                    rdbAns1.BackColor = Color.Red;
                    rdbAns2.BackColor = Color.LightGreen;
                    rdbAns3.BackColor = Color.Red;
                    rdbAns4.BackColor = Color.Red;
                }


            }

           else
            {


                MostrarColumna();
                txtAns1.Text = pregEng.Respuestas[0].RespuestaDescripcion;
                rdbAns1.Checked = pregEng.Respuestas[0].EsCorrecta;

                txtAns2.Text = pregEng.Respuestas[1].RespuestaDescripcion;
                rdbAns2.Checked = pregEng.Respuestas[1].EsCorrecta;

                txtAns3.Text = pregEng.Respuestas[2].RespuestaDescripcion;
                rdbAns3.Checked = pregEng.Respuestas[2].EsCorrecta;

                txtAns4.Text = pregEng.Respuestas[3].RespuestaDescripcion;
                rdbAns4.Checked = pregEng.Respuestas[3].EsCorrecta;


                if (rdbAns1.Checked)
                {

                    rdbAns1.BackColor = Color.LightGreen;
                    rdbAns2.BackColor = Color.Red;
                    rdbAns3.BackColor = Color.Red;
                    rdbAns4.BackColor = Color.Red;
                }

                if (rdbAns2.Checked)
                {

                    rdbAns1.BackColor = Color.Red;
                    rdbAns2.BackColor = Color.LightGreen;
                    rdbAns3.BackColor = Color.Red;
                    rdbAns4.BackColor = Color.Red;
                }

                if (rdbAns1.Checked)
                {

                    rdbAns1.BackColor = Color.Red;
                    rdbAns2.BackColor = Color.Red;
                    rdbAns3.BackColor = Color.LightGreen;
                    rdbAns4.BackColor = Color.Red;
                }

                if (rdbAns2.Checked)
                {

                    rdbAns1.BackColor = Color.Red;
                    rdbAns2.BackColor = Color.Red;
                    rdbAns3.BackColor = Color.Red;
                    rdbAns4.BackColor = Color.LightGreen;
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
                    String rutaCompleta = "..\\..\\Resources\\";
                    

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
                txtResp1.Text = "Resp1";
                txtResp2.Text = "Resp2";

                txtAns1.Text = "Ans1";
                txtAns2.Text = "Ans2";
                
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


        private void btnModificarPregunta_Click(object sender, EventArgs e, Pregunta preg, Pregunta pregEng)
        {

            //modificar Español

            preg.PreguntaDescripcion = txtNombrePreg.Text;
            preg.Genero = (String)cbxGeneroPreg.SelectedValue;

            if (cbxEdad.SelectedIndex == 0)
            {
                preg.EsMayorEdad = false;
            }
            else
            {
                preg.EsMayorEdad = true;
            }


            if (txtUrlImg.Text.Equals("") && txtImgOrigen.Text.Equals(""))
            {
                               
                preg.Imagen = "";
            }
            else
            {
                if (!File.Exists(txtUrlImg.Text))
                {
                        
                    preg.Imagen = txtUrlImg.Text;

                    File.Copy(txtImgOrigen.Text, txtUrlImg.Text);

                }
                else
                {
                   //Si la imagen existe cogeme la existente
                    preg.Imagen = txtUrlImg.Text;
                   
                }

            }


            if (txtAudioNuevo.Text.Equals("") && txtAudioOrigen.Text.Equals(""))
            {
                                
                preg.Sonido = "";

            }
            else
            {
                if (!File.Exists(txtAudioNuevo.Text))
                {
                    
                    preg.Sonido = txtAudioNuevo.Text;
                    File.Copy(txtAudioOrigen.Text, txtAudioNuevo.Text);

                }
                else
                {
                    //Si el audio existe coger el audo existente
                    preg.Sonido = txtAudioNuevo.Text;
                }

            }


            if (cbxTipoPreg.SelectedIndex == 0)
            {
                
                preg.Respuestas = new Respuesta[2];

                Respuesta resp1 = new Respuesta("Verdadero", false);
                Respuesta resp2 = new Respuesta("Falso", false);


                if (rdbResp1.BackColor == Color.LightGreen)
                {
                    resp1.EsCorrecta = true;

                }
                if (rdbResp2.BackColor == Color.LightGreen)
                {
                    resp2.EsCorrecta = true;
                }

                preg.Respuestas.SetValue(resp1, 0);
                preg.Respuestas.SetValue(resp2, 1);

            }
            else
            {
                preg.Respuestas = new Respuesta[4];

                Respuesta resp1 = new Respuesta(txtResp1.Text,false);
                Respuesta resp2 = new Respuesta(txtResp2.Text, false);
                Respuesta resp3 = new Respuesta(txtResp3.Text, false);
                Respuesta resp4 = new Respuesta(txtResp4.Text, false);
                                

                if (rdbResp1.BackColor == Color.LightGreen)
                {
                    resp1.EsCorrecta = true;                                        
                }
                if (rdbResp2.BackColor == Color.LightGreen)
                {
                    resp2.EsCorrecta = true;
                   
                }
                if (rdbResp3.BackColor == Color.LightGreen)
                {
                    resp3.EsCorrecta = true;
                }
                if (rdbResp4.BackColor == Color.LightGreen)
                {
                    resp4.EsCorrecta = true;
                }
                               

                preg.Respuestas.SetValue(resp1, 0);
                preg.Respuestas.SetValue(resp2, 1);
                preg.Respuestas.SetValue(resp3, 2);
                preg.Respuestas.SetValue(resp4, 3);

            }


            //Modificar Ingles


            pregEng.PreguntaDescripcion = txtQuestName.Text;
            pregEng.Genero = (String)cbxGenreQuest.SelectedValue;

            if (cbxQuestAge.SelectedIndex == 0)
            {
                pregEng.EsMayorEdad = false;
            }
            else
            {
                pregEng.EsMayorEdad = true;
            }

            pregEng.Imagen = txtUrlImg.Text;
            pregEng.Sonido = txtNewAudio.Text;
            


            if (cbxQuestType.SelectedIndex == 0)
            {

                pregEng.Respuestas = new Respuesta[2];

                Respuesta resp1 = new Respuesta("Verdadero", false);
                Respuesta resp2 = new Respuesta("Falso", false);


                if (rdbAns1.BackColor == Color.LightGreen)
                {
                    resp1.EsCorrecta = true;

                }
                if (rdbAns2.BackColor == Color.LightGreen)
                {
                    resp2.EsCorrecta = true;
                }

                pregEng.Respuestas.SetValue(resp1, 0);
                pregEng.Respuestas.SetValue(resp2, 1);

            }
            else
            {
                pregEng.Respuestas = new Respuesta[4];

                Respuesta resp1 = new Respuesta(txtAns1.Text, false);
                Respuesta resp2 = new Respuesta(txtAns2.Text, false);
                Respuesta resp3 = new Respuesta(txtAns3.Text, false);
                Respuesta resp4 = new Respuesta(txtAns4.Text, false);


                if (rdbAns1.BackColor == Color.LightGreen)
                {
                    resp1.EsCorrecta = true;
                }
                if (rdbAns2.BackColor == Color.LightGreen)
                {
                    resp2.EsCorrecta = true;
                }
                if (rdbAns3.BackColor == Color.LightGreen)
                {
                    resp3.EsCorrecta = true;
                }
                if (rdbAns4.BackColor == Color.LightGreen)
                {
                    resp4.EsCorrecta = true;
                }


                pregEng.Respuestas.SetValue(resp1, 0);
                pregEng.Respuestas.SetValue(resp2, 1);
                pregEng.Respuestas.SetValue(resp3, 2);
                pregEng.Respuestas.SetValue(resp4, 3);

            }



        }



        private void btnEliminarPregunta_Click(object sender, EventArgs e, Pregunta preg,Pregunta pregEng, RadioButton botonSeleccionar, Button BotonEliminar, Button botonModificar)
        {

            //if (!preg.Imagen.Equals(""))
            //{
            //    File.Delete(preg.Imagen);
            //}
            //if (!preg.Sonido.Equals(""))
            //{
            //    File.Delete(preg.Sonido);
            //}


            preguntas.Remove(preg);
            preguntasEng.Remove(pregEng);

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

            foreach (Genero gen in generosEsp)
            {
                List<Pregunta> preguntasPorGenero = new List<Pregunta>();

                foreach (Pregunta pregunt in preguntas)
                {
                    if (pregunt.Genero.Equals(gen.Nombre))
                    {

                        preguntasPorGenero.Add(pregunt);
                                               
                    }
                }

                gen.Preguntas = preguntasPorGenero;

            }

            foreach (Genero gen in generosEng)
            {
                List<Pregunta> preguntasPorGeneroEng = new List<Pregunta>();

                foreach (Pregunta pregunt in preguntasEng)
                {
                    if (pregunt.Genero.Equals(gen.Nombre))
                    {
                        preguntasPorGeneroEng.Add(pregunt);
                       
                    }
                }

                gen.Preguntas = preguntasPorGeneroEng;

            }


            JArray arrayGenerosEsp = (JArray)JToken.FromObject(generosEsp);
            JArray arrayGenerosEng = (JArray)JToken.FromObject(generosEng);

            File.WriteAllText(@"C:\Users\david\Desktop\Jsonpruebas\esp.json", arrayGenerosEsp.ToString());
            File.WriteAllText(@"C:\Users\david\Desktop\Jsonpruebas\eng.json", arrayGenerosEng.ToString());


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
                    String rutaCompleta = "..\\..\\Resources\\";

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

            btnEspañol.FlatStyle = FlatStyle.Flat;
            btnEspañol.FlatAppearance.BorderColor = Color.Blue;
            btnEspañol.FlatAppearance.BorderSize = 3;

            btnIngles.FlatStyle = FlatStyle.Standard;

        }

        private void btnIngles_Click(object sender, EventArgs e)
        {
            tabIdioma.SelectedTab = tabIngles;

            btnIngles.FlatStyle = FlatStyle.Flat;
            btnIngles.FlatAppearance.BorderColor = Color.Blue;
            btnIngles.FlatAppearance.BorderSize = 3;

            btnEspañol.FlatStyle = FlatStyle.Standard;

        }

        private void cbxQuestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxQuestType.SelectedIndex == 0)
            {

                OcultarColumna();
                cbxTipoPreg.SelectedIndex = 0;
                DesactivarRadiobutons();
                txtResp1.Text = "Verdadero";
                txtResp2.Text = "Falso";


                txtAns1.Text = "True";
                txtAns2.Text = "False";

               

            }
            else
            {

                MostrarColumna();
                cbxTipoPreg.SelectedIndex = 1;
                DesactivarRadiobutons();
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

        private void btnLoadImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";

            if (getImage.ShowDialog() == DialogResult.OK)
            {

                String[] palabras = getImage.FileName.Split('\\');
                String nombreImagen = palabras[palabras.Length - 1];



                pbQuestImage.ImageLocation = getImage.FileName;
                pbImagenPregunta.ImageLocation = getImage.FileName;


                txtOriginImg.Text = getImage.FileName;
                txtImgOrigen.Text = getImage.FileName;

                txtUrlImageEngl.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                txtUrlImg.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                
                string path = System.IO.Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
                if (Environment.OSVersion.Version.Major >= 6)
                {
                    path = System.IO.Directory.GetParent(path).ToString();
                    String rutaCompleta = "..\\..\\Resources\\";

                    txtUrlImageEngl.Text = rutaCompleta + nombreImagen;
                    txtImgAnt.Text = rutaCompleta + nombreImagen;
                    txtUrlImg.Text = rutaCompleta + nombreImagen;
                   

                }



            }
            else
            {
                MessageBox.Show("No se selecciono ninguna imagen", "Sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void btnWithoutImage_Click(object sender, EventArgs e)
        {

            pbQuestImage.Image = null;
            txtOriginImg.Text = "";
            txtUrlImageEngl.Text = "";

            pbImagenPregunta.Image = null;
            txtImgOrigen.Text = "";
            txtUrlImg.Text = "";



        }

        private void btnLoadAudio_Click(object sender, EventArgs e)
        {

            OpenFileDialog getAudio = new OpenFileDialog();
            getAudio.InitialDirectory = "C:\\";
            getAudio.Filter = "Archivos de Audio (*.mp3)(*.mp4)|*.mp3;*mp4|WAV (*.wav)|*.wav|WMA (*.wma)|*.wma";

            if (getAudio.ShowDialog() == DialogResult.OK)
            {

                String[] palabras = getAudio.FileName.Split('\\');
                String nombreAudio = palabras[palabras.Length - 1];
                String[] nombreSinExtension = palabras[palabras.Length - 1].Split('.');
                               
                txtOriginAudio.Text = getAudio.FileName;
                txtAudioOrigen.Text = getAudio.FileName;
                               
                txtNewAudio.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                txtAudioNuevo.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

                string path = System.IO.Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName;
                if (Environment.OSVersion.Version.Major >= 6)
                {
                    path = System.IO.Directory.GetParent(path).ToString();
                    String rutaCompleta = "..\\..\\Resources\\";

                    txtNewAudio.Text = rutaCompleta + nombreAudio;
                    txtAudioAnt.Text = rutaCompleta + nombreAudio;
                    txtAudioNuevo.Text = rutaCompleta + nombreAudio;

                    Player.URL = txtOriginAudio.Text;
                    Reproductor.URL = txtAudioOrigen.Text;
                   

                }



            }
            else
            {
                MessageBox.Show("No se selecciono ningun audio", "Sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnOutAudio_Click(object sender, EventArgs e)
        {
            Player.URL = null;
            txtNewAudio.Text = "";
            txtOriginAudio.Text = "";

            Reproductor.URL = null;
            txtAudioNuevo.Text = "";
            txtAudioOrigen.Text = "";
           
        }
    }
}

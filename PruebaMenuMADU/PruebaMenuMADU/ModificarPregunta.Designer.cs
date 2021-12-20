
namespace PruebaMenuMADU
{
    partial class ModificarPregunta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarPregunta));
            this.lblPregunta = new System.Windows.Forms.Label();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.cboMayorEdad = new System.Windows.Forms.CheckBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblSonido = new System.Windows.Forms.Label();
            this.lblRespuesta1 = new System.Windows.Forms.Label();
            this.lblRespuesta2 = new System.Windows.Forms.Label();
            this.lblRespuesta3 = new System.Windows.Forms.Label();
            this.lblRespuesta4 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiarModificacion = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblModificarPregunta = new System.Windows.Forms.Label();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.txtSonido = new System.Windows.Forms.TextBox();
            this.gbRespuestas = new System.Windows.Forms.GroupBox();
            this.txtRespuesta4 = new System.Windows.Forms.TextBox();
            this.txtRespuesta3 = new System.Windows.Forms.TextBox();
            this.txtRespuesta2 = new System.Windows.Forms.TextBox();
            this.txtRespuesta1 = new System.Windows.Forms.TextBox();
            this.rdbRespuesta4 = new System.Windows.Forms.RadioButton();
            this.rdbRespuesta3 = new System.Windows.Forms.RadioButton();
            this.rdbRespuesta2 = new System.Windows.Forms.RadioButton();
            this.rdbRespuesta1 = new System.Windows.Forms.RadioButton();
            this.btnAbrirFicherosSonido = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.gbAnwsers = new System.Windows.Forms.GroupBox();
            this.txtAnwser4 = new System.Windows.Forms.TextBox();
            this.txtAnwser3 = new System.Windows.Forms.TextBox();
            this.txtAnwser2 = new System.Windows.Forms.TextBox();
            this.txtAnwser1 = new System.Windows.Forms.TextBox();
            this.lblAnwser1 = new System.Windows.Forms.Label();
            this.lblAnwser2 = new System.Windows.Forms.Label();
            this.lblAnwser3 = new System.Windows.Forms.Label();
            this.lblAnwser4 = new System.Windows.Forms.Label();
            this.cboTipoPregunta = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAbrirFicherosImagen = new System.Windows.Forms.Button();
            this.btnEliminarImagen = new System.Windows.Forms.Button();
            this.btnEliminarSonido = new System.Windows.Forms.Button();
            this.gbRespuestas.SuspendLayout();
            this.gbAnwsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.Location = new System.Drawing.Point(19, 106);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(86, 24);
            this.lblPregunta.TabIndex = 1;
            this.lblPregunta.Text = "Pregunta";
            // 
            // cbxGenero
            // 
            this.cbxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Location = new System.Drawing.Point(22, 58);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(170, 32);
            this.cbxGenero.TabIndex = 1;
            this.cbxGenero.SelectionChangeCommitted += new System.EventHandler(this.cbxGenero_SelectionChangeCommitted);
            // 
            // cboMayorEdad
            // 
            this.cboMayorEdad.AutoSize = true;
            this.cboMayorEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMayorEdad.Location = new System.Drawing.Point(548, 60);
            this.cboMayorEdad.Name = "cboMayorEdad";
            this.cboMayorEdad.Size = new System.Drawing.Size(60, 28);
            this.cboMayorEdad.TabIndex = 3;
            this.cboMayorEdad.Text = "+18";
            this.cboMayorEdad.UseVisualStyleBackColor = true;
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(11, 605);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(73, 24);
            this.lblImagen.TabIndex = 5;
            this.lblImagen.Text = "Imagen";
            // 
            // lblSonido
            // 
            this.lblSonido.AutoSize = true;
            this.lblSonido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonido.Location = new System.Drawing.Point(14, 644);
            this.lblSonido.Name = "lblSonido";
            this.lblSonido.Size = new System.Drawing.Size(70, 24);
            this.lblSonido.TabIndex = 6;
            this.lblSonido.Text = "Sonido";
            // 
            // lblRespuesta1
            // 
            this.lblRespuesta1.AutoSize = true;
            this.lblRespuesta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta1.Location = new System.Drawing.Point(6, 26);
            this.lblRespuesta1.Name = "lblRespuesta1";
            this.lblRespuesta1.Size = new System.Drawing.Size(114, 24);
            this.lblRespuesta1.TabIndex = 7;
            this.lblRespuesta1.Text = "Respuesta 1";
            // 
            // lblRespuesta2
            // 
            this.lblRespuesta2.AutoSize = true;
            this.lblRespuesta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta2.Location = new System.Drawing.Point(6, 60);
            this.lblRespuesta2.Name = "lblRespuesta2";
            this.lblRespuesta2.Size = new System.Drawing.Size(114, 24);
            this.lblRespuesta2.TabIndex = 8;
            this.lblRespuesta2.Text = "Respuesta 2";
            // 
            // lblRespuesta3
            // 
            this.lblRespuesta3.AutoSize = true;
            this.lblRespuesta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta3.Location = new System.Drawing.Point(6, 94);
            this.lblRespuesta3.Name = "lblRespuesta3";
            this.lblRespuesta3.Size = new System.Drawing.Size(114, 24);
            this.lblRespuesta3.TabIndex = 9;
            this.lblRespuesta3.Text = "Respuesta 3";
            // 
            // lblRespuesta4
            // 
            this.lblRespuesta4.AutoSize = true;
            this.lblRespuesta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta4.Location = new System.Drawing.Point(6, 128);
            this.lblRespuesta4.Name = "lblRespuesta4";
            this.lblRespuesta4.Size = new System.Drawing.Size(114, 24);
            this.lblRespuesta4.TabIndex = 10;
            this.lblRespuesta4.Text = "Respuesta 4";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(14, 916);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 35);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiarModificacion
            // 
            this.btnLimpiarModificacion.Enabled = false;
            this.btnLimpiarModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarModificacion.Location = new System.Drawing.Point(300, 916);
            this.btnLimpiarModificacion.Name = "btnLimpiarModificacion";
            this.btnLimpiarModificacion.Size = new System.Drawing.Size(200, 35);
            this.btnLimpiarModificacion.TabIndex = 23;
            this.btnLimpiarModificacion.Text = "Limpiar Modificacion";
            this.btnLimpiarModificacion.UseVisualStyleBackColor = true;
            this.btnLimpiarModificacion.Click += new System.EventHandler(this.btnLimpiarModificacion_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(506, 916);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 35);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblModificarPregunta
            // 
            this.lblModificarPregunta.AutoSize = true;
            this.lblModificarPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarPregunta.Location = new System.Drawing.Point(190, 9);
            this.lblModificarPregunta.Name = "lblModificarPregunta";
            this.lblModificarPregunta.Size = new System.Drawing.Size(241, 31);
            this.lblModificarPregunta.TabIndex = 15;
            this.lblModificarPregunta.Text = "Modificar Pregunta";
            // 
            // txtPregunta
            // 
            this.txtPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPregunta.Location = new System.Drawing.Point(107, 103);
            this.txtPregunta.MaxLength = 112;
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(480, 26);
            this.txtPregunta.TabIndex = 4;
            // 
            // txtImagen
            // 
            this.txtImagen.Enabled = false;
            this.txtImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagen.Location = new System.Drawing.Point(87, 605);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(450, 26);
            this.txtImagen.TabIndex = 18;
            // 
            // txtSonido
            // 
            this.txtSonido.Enabled = false;
            this.txtSonido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSonido.Location = new System.Drawing.Point(87, 644);
            this.txtSonido.Name = "txtSonido";
            this.txtSonido.Size = new System.Drawing.Size(450, 26);
            this.txtSonido.TabIndex = 20;
            // 
            // gbRespuestas
            // 
            this.gbRespuestas.Controls.Add(this.txtRespuesta4);
            this.gbRespuestas.Controls.Add(this.txtRespuesta3);
            this.gbRespuestas.Controls.Add(this.txtRespuesta2);
            this.gbRespuestas.Controls.Add(this.txtRespuesta1);
            this.gbRespuestas.Controls.Add(this.lblRespuesta1);
            this.gbRespuestas.Controls.Add(this.lblRespuesta2);
            this.gbRespuestas.Controls.Add(this.lblRespuesta3);
            this.gbRespuestas.Controls.Add(this.lblRespuesta4);
            this.gbRespuestas.Location = new System.Drawing.Point(18, 171);
            this.gbRespuestas.Name = "gbRespuestas";
            this.gbRespuestas.Size = new System.Drawing.Size(590, 166);
            this.gbRespuestas.TabIndex = 19;
            this.gbRespuestas.TabStop = false;
            this.gbRespuestas.Text = "Respuestas";
            // 
            // txtRespuesta4
            // 
            this.txtRespuesta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta4.Location = new System.Drawing.Point(126, 128);
            this.txtRespuesta4.MaxLength = 45;
            this.txtRespuesta4.Name = "txtRespuesta4";
            this.txtRespuesta4.Size = new System.Drawing.Size(440, 26);
            this.txtRespuesta4.TabIndex = 9;
            // 
            // txtRespuesta3
            // 
            this.txtRespuesta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta3.Location = new System.Drawing.Point(126, 94);
            this.txtRespuesta3.MaxLength = 45;
            this.txtRespuesta3.Name = "txtRespuesta3";
            this.txtRespuesta3.Size = new System.Drawing.Size(440, 26);
            this.txtRespuesta3.TabIndex = 8;
            // 
            // txtRespuesta2
            // 
            this.txtRespuesta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta2.Location = new System.Drawing.Point(126, 60);
            this.txtRespuesta2.MaxLength = 45;
            this.txtRespuesta2.Name = "txtRespuesta2";
            this.txtRespuesta2.Size = new System.Drawing.Size(440, 26);
            this.txtRespuesta2.TabIndex = 7;
            // 
            // txtRespuesta1
            // 
            this.txtRespuesta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuesta1.Location = new System.Drawing.Point(126, 25);
            this.txtRespuesta1.MaxLength = 45;
            this.txtRespuesta1.Name = "txtRespuesta1";
            this.txtRespuesta1.Size = new System.Drawing.Size(440, 26);
            this.txtRespuesta1.TabIndex = 6;
            // 
            // rdbRespuesta4
            // 
            this.rdbRespuesta4.BackColor = System.Drawing.Color.Transparent;
            this.rdbRespuesta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRespuesta4.Location = new System.Drawing.Point(244, 559);
            this.rdbRespuesta4.Margin = new System.Windows.Forms.Padding(2);
            this.rdbRespuesta4.Name = "rdbRespuesta4";
            this.rdbRespuesta4.Size = new System.Drawing.Size(190, 32);
            this.rdbRespuesta4.TabIndex = 17;
            this.rdbRespuesta4.TabStop = true;
            this.rdbRespuesta4.Text = "Pregunta/Anwser 4";
            this.rdbRespuesta4.UseVisualStyleBackColor = false;
            // 
            // rdbRespuesta3
            // 
            this.rdbRespuesta3.BackColor = System.Drawing.Color.Transparent;
            this.rdbRespuesta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRespuesta3.Location = new System.Drawing.Point(18, 559);
            this.rdbRespuesta3.Margin = new System.Windows.Forms.Padding(2);
            this.rdbRespuesta3.Name = "rdbRespuesta3";
            this.rdbRespuesta3.Size = new System.Drawing.Size(190, 32);
            this.rdbRespuesta3.TabIndex = 16;
            this.rdbRespuesta3.TabStop = true;
            this.rdbRespuesta3.Text = "Pregunta/Anwser 3";
            this.rdbRespuesta3.UseVisualStyleBackColor = false;
            // 
            // rdbRespuesta2
            // 
            this.rdbRespuesta2.BackColor = System.Drawing.Color.Transparent;
            this.rdbRespuesta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRespuesta2.Location = new System.Drawing.Point(244, 522);
            this.rdbRespuesta2.Margin = new System.Windows.Forms.Padding(2);
            this.rdbRespuesta2.Name = "rdbRespuesta2";
            this.rdbRespuesta2.Size = new System.Drawing.Size(190, 32);
            this.rdbRespuesta2.TabIndex = 15;
            this.rdbRespuesta2.TabStop = true;
            this.rdbRespuesta2.Text = "Pregunta/Anwser 2";
            this.rdbRespuesta2.UseVisualStyleBackColor = false;
            // 
            // rdbRespuesta1
            // 
            this.rdbRespuesta1.BackColor = System.Drawing.Color.Transparent;
            this.rdbRespuesta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRespuesta1.Location = new System.Drawing.Point(18, 522);
            this.rdbRespuesta1.Margin = new System.Windows.Forms.Padding(2);
            this.rdbRespuesta1.Name = "rdbRespuesta1";
            this.rdbRespuesta1.Size = new System.Drawing.Size(190, 32);
            this.rdbRespuesta1.TabIndex = 14;
            this.rdbRespuesta1.TabStop = true;
            this.rdbRespuesta1.Text = "Pregunta/Anwser 1";
            this.rdbRespuesta1.UseVisualStyleBackColor = false;
            // 
            // btnAbrirFicherosSonido
            // 
            this.btnAbrirFicherosSonido.BackgroundImage = global::PruebaMenuMADU.Properties.Resources.carpeta;
            this.btnAbrirFicherosSonido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbrirFicherosSonido.Location = new System.Drawing.Point(542, 642);
            this.btnAbrirFicherosSonido.Name = "btnAbrirFicherosSonido";
            this.btnAbrirFicherosSonido.Size = new System.Drawing.Size(30, 30);
            this.btnAbrirFicherosSonido.TabIndex = 21;
            this.btnAbrirFicherosSonido.UseVisualStyleBackColor = true;
            this.btnAbrirFicherosSonido.Click += new System.EventHandler(this.btnAbrirFicherosSonido_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(19, 140);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(86, 24);
            this.lblQuestion.TabIndex = 22;
            this.lblQuestion.Text = "Question";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(107, 137);
            this.txtQuestion.MaxLength = 112;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(480, 26);
            this.txtQuestion.TabIndex = 5;
            // 
            // gbAnwsers
            // 
            this.gbAnwsers.Controls.Add(this.txtAnwser4);
            this.gbAnwsers.Controls.Add(this.txtAnwser3);
            this.gbAnwsers.Controls.Add(this.txtAnwser2);
            this.gbAnwsers.Controls.Add(this.txtAnwser1);
            this.gbAnwsers.Controls.Add(this.lblAnwser1);
            this.gbAnwsers.Controls.Add(this.lblAnwser2);
            this.gbAnwsers.Controls.Add(this.lblAnwser3);
            this.gbAnwsers.Controls.Add(this.lblAnwser4);
            this.gbAnwsers.Location = new System.Drawing.Point(18, 344);
            this.gbAnwsers.Name = "gbAnwsers";
            this.gbAnwsers.Size = new System.Drawing.Size(590, 165);
            this.gbAnwsers.TabIndex = 24;
            this.gbAnwsers.TabStop = false;
            this.gbAnwsers.Text = "Anwsers";
            // 
            // txtAnwser4
            // 
            this.txtAnwser4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnwser4.Location = new System.Drawing.Point(126, 128);
            this.txtAnwser4.MaxLength = 45;
            this.txtAnwser4.Name = "txtAnwser4";
            this.txtAnwser4.Size = new System.Drawing.Size(440, 26);
            this.txtAnwser4.TabIndex = 13;
            // 
            // txtAnwser3
            // 
            this.txtAnwser3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnwser3.Location = new System.Drawing.Point(126, 94);
            this.txtAnwser3.MaxLength = 45;
            this.txtAnwser3.Name = "txtAnwser3";
            this.txtAnwser3.Size = new System.Drawing.Size(440, 26);
            this.txtAnwser3.TabIndex = 12;
            // 
            // txtAnwser2
            // 
            this.txtAnwser2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnwser2.Location = new System.Drawing.Point(126, 60);
            this.txtAnwser2.MaxLength = 45;
            this.txtAnwser2.Name = "txtAnwser2";
            this.txtAnwser2.Size = new System.Drawing.Size(440, 26);
            this.txtAnwser2.TabIndex = 11;
            // 
            // txtAnwser1
            // 
            this.txtAnwser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnwser1.Location = new System.Drawing.Point(124, 26);
            this.txtAnwser1.MaxLength = 45;
            this.txtAnwser1.Name = "txtAnwser1";
            this.txtAnwser1.Size = new System.Drawing.Size(440, 26);
            this.txtAnwser1.TabIndex = 10;
            // 
            // lblAnwser1
            // 
            this.lblAnwser1.AutoSize = true;
            this.lblAnwser1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnwser1.Location = new System.Drawing.Point(6, 26);
            this.lblAnwser1.Name = "lblAnwser1";
            this.lblAnwser1.Size = new System.Drawing.Size(89, 24);
            this.lblAnwser1.TabIndex = 7;
            this.lblAnwser1.Text = "Anwser 1";
            // 
            // lblAnwser2
            // 
            this.lblAnwser2.AutoSize = true;
            this.lblAnwser2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnwser2.Location = new System.Drawing.Point(6, 60);
            this.lblAnwser2.Name = "lblAnwser2";
            this.lblAnwser2.Size = new System.Drawing.Size(89, 24);
            this.lblAnwser2.TabIndex = 8;
            this.lblAnwser2.Text = "Anwser 2";
            // 
            // lblAnwser3
            // 
            this.lblAnwser3.AutoSize = true;
            this.lblAnwser3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnwser3.Location = new System.Drawing.Point(6, 94);
            this.lblAnwser3.Name = "lblAnwser3";
            this.lblAnwser3.Size = new System.Drawing.Size(89, 24);
            this.lblAnwser3.TabIndex = 9;
            this.lblAnwser3.Text = "Anwser 3";
            // 
            // lblAnwser4
            // 
            this.lblAnwser4.AutoSize = true;
            this.lblAnwser4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnwser4.Location = new System.Drawing.Point(6, 128);
            this.lblAnwser4.Name = "lblAnwser4";
            this.lblAnwser4.Size = new System.Drawing.Size(89, 24);
            this.lblAnwser4.TabIndex = 10;
            this.lblAnwser4.Text = "Anwser 4";
            // 
            // cboTipoPregunta
            // 
            this.cboTipoPregunta.AutoSize = true;
            this.cboTipoPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoPregunta.Location = new System.Drawing.Point(234, 60);
            this.cboTipoPregunta.Name = "cboTipoPregunta";
            this.cboTipoPregunta.Size = new System.Drawing.Size(251, 28);
            this.cboTipoPregunta.TabIndex = 2;
            this.cboTipoPregunta.Text = "Pregunta Verdadero/Falso";
            this.cboTipoPregunta.UseVisualStyleBackColor = true;
            this.cboTipoPregunta.Click += new System.EventHandler(this.cboTipoPreguntaTipoPregunta_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAbrirFicherosImagen
            // 
            this.btnAbrirFicherosImagen.BackgroundImage = global::PruebaMenuMADU.Properties.Resources.carpeta;
            this.btnAbrirFicherosImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbrirFicherosImagen.Location = new System.Drawing.Point(542, 605);
            this.btnAbrirFicherosImagen.Name = "btnAbrirFicherosImagen";
            this.btnAbrirFicherosImagen.Size = new System.Drawing.Size(30, 30);
            this.btnAbrirFicherosImagen.TabIndex = 19;
            this.btnAbrirFicherosImagen.UseVisualStyleBackColor = true;
            this.btnAbrirFicherosImagen.Click += new System.EventHandler(this.btnAbrirFicherosImagen_Click);
            // 
            // btnEliminarImagen
            // 
            this.btnEliminarImagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarImagen.BackgroundImage")));
            this.btnEliminarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarImagen.Location = new System.Drawing.Point(578, 605);
            this.btnEliminarImagen.Name = "btnEliminarImagen";
            this.btnEliminarImagen.Size = new System.Drawing.Size(30, 30);
            this.btnEliminarImagen.TabIndex = 25;
            this.btnEliminarImagen.UseVisualStyleBackColor = true;
            this.btnEliminarImagen.Click += new System.EventHandler(this.btnEliminarImagen_Click);
            // 
            // btnEliminarSonido
            // 
            this.btnEliminarSonido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarSonido.BackgroundImage")));
            this.btnEliminarSonido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarSonido.Location = new System.Drawing.Point(578, 642);
            this.btnEliminarSonido.Name = "btnEliminarSonido";
            this.btnEliminarSonido.Size = new System.Drawing.Size(30, 30);
            this.btnEliminarSonido.TabIndex = 26;
            this.btnEliminarSonido.UseVisualStyleBackColor = true;
            this.btnEliminarSonido.Click += new System.EventHandler(this.btnEliminarSonido_Click);
            // 
            // ModificarPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(620, 963);
            this.Controls.Add(this.btnEliminarSonido);
            this.Controls.Add(this.btnEliminarImagen);
            this.Controls.Add(this.cboTipoPregunta);
            this.Controls.Add(this.rdbRespuesta4);
            this.Controls.Add(this.gbAnwsers);
            this.Controls.Add(this.rdbRespuesta3);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.rdbRespuesta2);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.rdbRespuesta1);
            this.Controls.Add(this.btnAbrirFicherosSonido);
            this.Controls.Add(this.btnAbrirFicherosImagen);
            this.Controls.Add(this.gbRespuestas);
            this.Controls.Add(this.txtSonido);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.lblModificarPregunta);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiarModificacion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblSonido);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.cboMayorEdad);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.lblPregunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarPregunta";
            this.gbRespuestas.ResumeLayout(false);
            this.gbRespuestas.PerformLayout();
            this.gbAnwsers.ResumeLayout(false);
            this.gbAnwsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.CheckBox cboMayorEdad;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblSonido;
        private System.Windows.Forms.Label lblRespuesta1;
        private System.Windows.Forms.Label lblRespuesta2;
        private System.Windows.Forms.Label lblRespuesta3;
        private System.Windows.Forms.Label lblRespuesta4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiarModificacion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblModificarPregunta;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.TextBox txtSonido;
        private System.Windows.Forms.GroupBox gbRespuestas;
        private System.Windows.Forms.TextBox txtRespuesta4;
        private System.Windows.Forms.TextBox txtRespuesta3;
        private System.Windows.Forms.TextBox txtRespuesta2;
        private System.Windows.Forms.TextBox txtRespuesta1;
        private System.Windows.Forms.Button btnAbrirFicherosImagen;
        private System.Windows.Forms.Button btnAbrirFicherosSonido;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.GroupBox gbAnwsers;
        private System.Windows.Forms.TextBox txtAnwser4;
        private System.Windows.Forms.TextBox txtAnwser3;
        private System.Windows.Forms.TextBox txtAnwser2;
        private System.Windows.Forms.TextBox txtAnwser1;
        private System.Windows.Forms.Label lblAnwser1;
        private System.Windows.Forms.Label lblAnwser2;
        private System.Windows.Forms.Label lblAnwser3;
        private System.Windows.Forms.Label lblAnwser4;
        private System.Windows.Forms.RadioButton rdbRespuesta4;
        private System.Windows.Forms.RadioButton rdbRespuesta3;
        private System.Windows.Forms.RadioButton rdbRespuesta2;
        private System.Windows.Forms.RadioButton rdbRespuesta1;
        private System.Windows.Forms.CheckBox cboTipoPregunta;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnEliminarSonido;
        private System.Windows.Forms.Button btnEliminarImagen;
    }
}
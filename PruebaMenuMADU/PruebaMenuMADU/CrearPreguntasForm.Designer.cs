namespace PruebaMenuMADU
{
    partial class CrearPreguntasForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtNombrePreg = new System.Windows.Forms.TextBox();
            this.cbxGeneroPreg = new System.Windows.Forms.ComboBox();
            this.cbxEdad = new System.Windows.Forms.ComboBox();
            this.cbxTipoPreg = new System.Windows.Forms.ComboBox();
            this.gbImagen = new System.Windows.Forms.GroupBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbAudio = new System.Windows.Forms.GroupBox();
            this.cbxAudio = new System.Windows.Forms.CheckBox();
            this.btnCargarAudio = new System.Windows.Forms.Button();
            this.btnAñadirPregunta = new System.Windows.Forms.Button();
            this.flpListaPreguntas = new System.Windows.Forms.FlowLayoutPanel();
            this.gbImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbAudio.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1924, 81);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // txtNombrePreg
            // 
            this.txtNombrePreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePreg.Location = new System.Drawing.Point(227, 115);
            this.txtNombrePreg.Multiline = true;
            this.txtNombrePreg.Name = "txtNombrePreg";
            this.txtNombrePreg.Size = new System.Drawing.Size(1662, 103);
            this.txtNombrePreg.TabIndex = 2;
            // 
            // cbxGeneroPreg
            // 
            this.cbxGeneroPreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGeneroPreg.FormattingEnabled = true;
            this.cbxGeneroPreg.Items.AddRange(new object[] {
            "Rock",
            "Electronica",
            "Hip-Hop",
            "Pop",
            "Añadir nuevo genero..."});
            this.cbxGeneroPreg.Location = new System.Drawing.Point(356, 259);
            this.cbxGeneroPreg.Name = "cbxGeneroPreg";
            this.cbxGeneroPreg.Size = new System.Drawing.Size(236, 37);
            this.cbxGeneroPreg.TabIndex = 4;
            // 
            // cbxEdad
            // 
            this.cbxEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEdad.FormattingEnabled = true;
            this.cbxEdad.Items.AddRange(new object[] {
            "Menor de edad",
            "Mayor de edad"});
            this.cbxEdad.Location = new System.Drawing.Point(1686, 259);
            this.cbxEdad.Name = "cbxEdad";
            this.cbxEdad.Size = new System.Drawing.Size(203, 37);
            this.cbxEdad.TabIndex = 5;
            // 
            // cbxTipoPreg
            // 
            this.cbxTipoPreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoPreg.FormattingEnabled = true;
            this.cbxTipoPreg.Items.AddRange(new object[] {
            "De 2 respuestas",
            "De 4 respuestas",
            "Imagen de 2 respuestas",
            "Imagen de 4 respuestas",
            "Audio de 2 respuestas",
            "Audio de 4 respuestas"});
            this.cbxTipoPreg.Location = new System.Drawing.Point(992, 254);
            this.cbxTipoPreg.Name = "cbxTipoPreg";
            this.cbxTipoPreg.Size = new System.Drawing.Size(295, 37);
            this.cbxTipoPreg.TabIndex = 6;
            // 
            // gbImagen
            // 
            this.gbImagen.Controls.Add(this.btnCargarImagen);
            this.gbImagen.Controls.Add(this.pictureBox1);
            this.gbImagen.Location = new System.Drawing.Point(242, 327);
            this.gbImagen.Name = "gbImagen";
            this.gbImagen.Size = new System.Drawing.Size(660, 358);
            this.gbImagen.TabIndex = 7;
            this.gbImagen.TabStop = false;
            this.gbImagen.Text = "Imagen";
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarImagen.Location = new System.Drawing.Point(222, 287);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(210, 49);
            this.btnCargarImagen.TabIndex = 1;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(648, 241);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Genero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1565, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Edad: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(899, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo:";
            // 
            // gbAudio
            // 
            this.gbAudio.Controls.Add(this.btnCargarAudio);
            this.gbAudio.Controls.Add(this.cbxAudio);
            this.gbAudio.Location = new System.Drawing.Point(1170, 327);
            this.gbAudio.Name = "gbAudio";
            this.gbAudio.Size = new System.Drawing.Size(660, 358);
            this.gbAudio.TabIndex = 11;
            this.gbAudio.TabStop = false;
            this.gbAudio.Text = "Audio";
            // 
            // cbxAudio
            // 
            this.cbxAudio.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxAudio.Location = new System.Drawing.Point(209, 21);
            this.cbxAudio.Name = "cbxAudio";
            this.cbxAudio.Size = new System.Drawing.Size(274, 224);
            this.cbxAudio.TabIndex = 0;
            this.cbxAudio.Text = "Play";
            this.cbxAudio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxAudio.UseVisualStyleBackColor = true;
            // 
            // btnCargarAudio
            // 
            this.btnCargarAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarAudio.Location = new System.Drawing.Point(233, 287);
            this.btnCargarAudio.Name = "btnCargarAudio";
            this.btnCargarAudio.Size = new System.Drawing.Size(210, 49);
            this.btnCargarAudio.TabIndex = 1;
            this.btnCargarAudio.Text = "Cargar Audio";
            this.btnCargarAudio.UseVisualStyleBackColor = true;
            // 
            // btnAñadirPregunta
            // 
            this.btnAñadirPregunta.Location = new System.Drawing.Point(820, 825);
            this.btnAñadirPregunta.Name = "btnAñadirPregunta";
            this.btnAñadirPregunta.Size = new System.Drawing.Size(166, 34);
            this.btnAñadirPregunta.TabIndex = 12;
            this.btnAñadirPregunta.Text = "Añadir pregunta";
            this.btnAñadirPregunta.UseVisualStyleBackColor = true;
            this.btnAñadirPregunta.Click += new System.EventHandler(this.btnAñadirPregunta_Click);
            // 
            // flpListaPreguntas
            // 
            this.flpListaPreguntas.AutoScroll = true;
            this.flpListaPreguntas.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flpListaPreguntas.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpListaPreguntas.Location = new System.Drawing.Point(0, 81);
            this.flpListaPreguntas.Name = "flpListaPreguntas";
            this.flpListaPreguntas.Size = new System.Drawing.Size(206, 902);
            this.flpListaPreguntas.TabIndex = 13;
            // 
            // CrearPreguntasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 983);
            this.Controls.Add(this.flpListaPreguntas);
            this.Controls.Add(this.btnAñadirPregunta);
            this.Controls.Add(this.gbAudio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbImagen);
            this.Controls.Add(this.cbxTipoPreg);
            this.Controls.Add(this.cbxEdad);
            this.Controls.Add(this.cbxGeneroPreg);
            this.Controls.Add(this.txtNombrePreg);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "CrearPreguntasForm";
            this.Text = "CrearPreguntasForm";
            this.Load += new System.EventHandler(this.CrearPreguntasForm_Load);
            this.gbImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbAudio.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtNombrePreg;
        private System.Windows.Forms.ComboBox cbxGeneroPreg;
        private System.Windows.Forms.ComboBox cbxEdad;
        private System.Windows.Forms.ComboBox cbxTipoPreg;
        private System.Windows.Forms.GroupBox gbImagen;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbAudio;
        private System.Windows.Forms.Button btnCargarAudio;
        private System.Windows.Forms.CheckBox cbxAudio;
        private System.Windows.Forms.Button btnAñadirPregunta;
        private System.Windows.Forms.FlowLayoutPanel flpListaPreguntas;
    }
}
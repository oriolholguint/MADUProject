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
            this.pbImagenPregunta = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbAudio = new System.Windows.Forms.GroupBox();
            this.btnCargarAudio = new System.Windows.Forms.Button();
            this.cbxAudio = new System.Windows.Forms.CheckBox();
            this.btnAñadirPregunta = new System.Windows.Forms.Button();
            this.flpListaPreguntas = new System.Windows.Forms.FlowLayoutPanel();
            this.txtUrlOculta = new System.Windows.Forms.TextBox();
            this.gbRespuestas = new System.Windows.Forms.GroupBox();
            this.tlp2Respuestas = new System.Windows.Forms.TableLayoutPanel();
            this.txtResp1 = new System.Windows.Forms.TextBox();
            this.txtResp2 = new System.Windows.Forms.TextBox();
            this.rdbResp1 = new System.Windows.Forms.RadioButton();
            this.rdbResp2 = new System.Windows.Forms.RadioButton();
            this.gbImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPregunta)).BeginInit();
            this.gbAudio.SuspendLayout();
            this.gbRespuestas.SuspendLayout();
            this.tlp2Respuestas.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1924, 96);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // txtNombrePreg
            // 
            this.txtNombrePreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePreg.Location = new System.Drawing.Point(227, 126);
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
            this.cbxGeneroPreg.SelectedIndexChanged += new System.EventHandler(this.cbxGeneroPreg_SelectedIndexChanged);
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
            "De 4 respuestas"});
            this.cbxTipoPreg.Location = new System.Drawing.Point(992, 254);
            this.cbxTipoPreg.Name = "cbxTipoPreg";
            this.cbxTipoPreg.Size = new System.Drawing.Size(295, 37);
            this.cbxTipoPreg.TabIndex = 6;
            this.cbxTipoPreg.SelectedIndexChanged += new System.EventHandler(this.cbxTipoPreg_SelectedIndexChanged);
            // 
            // gbImagen
            // 
            this.gbImagen.Controls.Add(this.txtUrlOculta);
            this.gbImagen.Controls.Add(this.btnCargarImagen);
            this.gbImagen.Controls.Add(this.pbImagenPregunta);
            this.gbImagen.Location = new System.Drawing.Point(240, 305);
            this.gbImagen.Name = "gbImagen";
            this.gbImagen.Size = new System.Drawing.Size(660, 358);
            this.gbImagen.TabIndex = 7;
            this.gbImagen.TabStop = false;
            this.gbImagen.Text = "Imagen";
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarImagen.Location = new System.Drawing.Point(230, 296);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(210, 49);
            this.btnCargarImagen.TabIndex = 1;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // pbImagenPregunta
            // 
            this.pbImagenPregunta.Location = new System.Drawing.Point(6, 21);
            this.pbImagenPregunta.Name = "pbImagenPregunta";
            this.pbImagenPregunta.Size = new System.Drawing.Size(648, 241);
            this.pbImagenPregunta.TabIndex = 0;
            this.pbImagenPregunta.TabStop = false;
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
            this.gbAudio.Location = new System.Drawing.Point(1169, 305);
            this.gbAudio.Name = "gbAudio";
            this.gbAudio.Size = new System.Drawing.Size(660, 358);
            this.gbAudio.TabIndex = 11;
            this.gbAudio.TabStop = false;
            this.gbAudio.Text = "Audio";
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
            // btnAñadirPregunta
            // 
            this.btnAñadirPregunta.Location = new System.Drawing.Point(967, 431);
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
            this.flpListaPreguntas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flpListaPreguntas.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpListaPreguntas.Location = new System.Drawing.Point(0, 96);
            this.flpListaPreguntas.Name = "flpListaPreguntas";
            this.flpListaPreguntas.Size = new System.Drawing.Size(206, 887);
            this.flpListaPreguntas.TabIndex = 13;
            // 
            // txtUrlOculta
            // 
            this.txtUrlOculta.Location = new System.Drawing.Point(38, 268);
            this.txtUrlOculta.Name = "txtUrlOculta";
            this.txtUrlOculta.Size = new System.Drawing.Size(584, 22);
            this.txtUrlOculta.TabIndex = 2;
            // 
            // gbRespuestas
            // 
            this.gbRespuestas.Controls.Add(this.tlp2Respuestas);
            this.gbRespuestas.Location = new System.Drawing.Point(240, 669);
            this.gbRespuestas.Name = "gbRespuestas";
            this.gbRespuestas.Size = new System.Drawing.Size(1657, 302);
            this.gbRespuestas.TabIndex = 14;
            this.gbRespuestas.TabStop = false;
            this.gbRespuestas.Text = "Respuestas";
            // 
            // tlp2Respuestas
            // 
            this.tlp2Respuestas.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tlp2Respuestas.ColumnCount = 4;
            this.tlp2Respuestas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.26057F));
            this.tlp2Respuestas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tlp2Respuestas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.tlp2Respuestas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tlp2Respuestas.Controls.Add(this.rdbResp2, 3, 0);
            this.tlp2Respuestas.Controls.Add(this.txtResp2, 2, 0);
            this.tlp2Respuestas.Controls.Add(this.txtResp1, 0, 0);
            this.tlp2Respuestas.Controls.Add(this.rdbResp1, 1, 0);
            this.tlp2Respuestas.Location = new System.Drawing.Point(6, 21);
            this.tlp2Respuestas.Name = "tlp2Respuestas";
            this.tlp2Respuestas.RowCount = 1;
            this.tlp2Respuestas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp2Respuestas.Size = new System.Drawing.Size(1643, 85);
            this.tlp2Respuestas.TabIndex = 1;
            // 
            // txtResp1
            // 
            this.txtResp1.BackColor = System.Drawing.Color.LightBlue;
            this.txtResp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResp1.Location = new System.Drawing.Point(3, 3);
            this.txtResp1.Name = "txtResp1";
            this.txtResp1.Size = new System.Drawing.Size(738, 75);
            this.txtResp1.TabIndex = 0;
            // 
            // txtResp2
            // 
            this.txtResp2.BackColor = System.Drawing.Color.SteelBlue;
            this.txtResp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResp2.Location = new System.Drawing.Point(845, 3);
            this.txtResp2.Name = "txtResp2";
            this.txtResp2.Size = new System.Drawing.Size(700, 75);
            this.txtResp2.TabIndex = 1;
            // 
            // rdbResp1
            // 
            this.rdbResp1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbResp1.BackColor = System.Drawing.Color.LightBlue;
            this.rdbResp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbResp1.Location = new System.Drawing.Point(747, 3);
            this.rdbResp1.Name = "rdbResp1";
            this.rdbResp1.Size = new System.Drawing.Size(92, 78);
            this.rdbResp1.TabIndex = 2;
            this.rdbResp1.TabStop = true;
            this.rdbResp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbResp1.UseVisualStyleBackColor = false;
            // 
            // rdbResp2
            // 
            this.rdbResp2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbResp2.BackColor = System.Drawing.Color.SteelBlue;
            this.rdbResp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbResp2.Location = new System.Drawing.Point(1551, 3);
            this.rdbResp2.Name = "rdbResp2";
            this.rdbResp2.Size = new System.Drawing.Size(89, 79);
            this.rdbResp2.TabIndex = 3;
            this.rdbResp2.TabStop = true;
            this.rdbResp2.UseVisualStyleBackColor = false;
            // 
            // CrearPreguntasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 983);
            this.Controls.Add(this.gbRespuestas);
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
            this.gbImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPregunta)).EndInit();
            this.gbAudio.ResumeLayout(false);
            this.gbRespuestas.ResumeLayout(false);
            this.tlp2Respuestas.ResumeLayout(false);
            this.tlp2Respuestas.PerformLayout();
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
        private System.Windows.Forms.PictureBox pbImagenPregunta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbAudio;
        private System.Windows.Forms.Button btnCargarAudio;
        private System.Windows.Forms.CheckBox cbxAudio;
        private System.Windows.Forms.Button btnAñadirPregunta;
        private System.Windows.Forms.FlowLayoutPanel flpListaPreguntas;
        private System.Windows.Forms.TextBox txtUrlOculta;
        private System.Windows.Forms.GroupBox gbRespuestas;
        private System.Windows.Forms.TableLayoutPanel tlp2Respuestas;
        private System.Windows.Forms.TextBox txtResp1;
        private System.Windows.Forms.TextBox txtResp2;
        private System.Windows.Forms.RadioButton rdbResp1;
        private System.Windows.Forms.RadioButton rdbResp2;
    }
}
/*namespace PruebaMenuMADU
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
            this.txtNombrePreg = new System.Windows.Forms.TextBox();
            this.cbxGeneroPreg = new System.Windows.Forms.ComboBox();
            this.cbxEdad = new System.Windows.Forms.ComboBox();
            this.cbxTipoPreg = new System.Windows.Forms.ComboBox();
            this.gbImagen = new System.Windows.Forms.GroupBox();
            this.txtUrlOculta = new System.Windows.Forms.TextBox();
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
            this.gbRespuestas = new System.Windows.Forms.GroupBox();
            this.tlpRespuestas = new System.Windows.Forms.TableLayoutPanel();
            this.rdbResp4 = new System.Windows.Forms.RadioButton();
            this.rdbResp3 = new System.Windows.Forms.RadioButton();
            this.txtResp3 = new System.Windows.Forms.TextBox();
            this.txtResp2 = new System.Windows.Forms.TextBox();
            this.txtResp1 = new System.Windows.Forms.TextBox();
            this.rdbResp1 = new System.Windows.Forms.RadioButton();
            this.rdbResp2 = new System.Windows.Forms.RadioButton();
            this.txtResp4 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCrearPreguntas = new System.Windows.Forms.Panel();
            this.btnCrearPreguntas = new System.Windows.Forms.Button();
            this.gbImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenPregunta)).BeginInit();
            this.gbAudio.SuspendLayout();
            this.gbRespuestas.SuspendLayout();
            this.tlpRespuestas.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlCrearPreguntas.SuspendLayout();
            this.SuspendLayout();
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
            this.cbxGeneroPreg.AutoCompleteCustomSource.AddRange(new string[] {
            "Rock",
            "Electronica",
            "Pop",
            "Hip-Hop"});
            this.cbxGeneroPreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGeneroPreg.FormattingEnabled = true;
            this.cbxGeneroPreg.Items.AddRange(new object[] {
            "Rock",
            "Electronica",
            "Hip-Hop",
            "Pop"});
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
            // txtUrlOculta
            // 
            this.txtUrlOculta.Location = new System.Drawing.Point(38, 268);
            this.txtUrlOculta.Name = "txtUrlOculta";
            this.txtUrlOculta.Size = new System.Drawing.Size(584, 22);
            this.txtUrlOculta.TabIndex = 2;
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
            this.gbAudio.Location = new System.Drawing.Point(1226, 305);
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
            this.btnAñadirPregunta.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAñadirPregunta.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAñadirPregunta.FlatAppearance.BorderSize = 2;
            this.btnAñadirPregunta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAñadirPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirPregunta.Location = new System.Drawing.Point(616, 225);
            this.btnAñadirPregunta.Name = "btnAñadirPregunta";
            this.btnAñadirPregunta.Size = new System.Drawing.Size(229, 49);
            this.btnAñadirPregunta.TabIndex = 12;
            this.btnAñadirPregunta.Text = "Añadir pregunta";
            this.btnAñadirPregunta.UseVisualStyleBackColor = false;
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
            // gbRespuestas
            // 
            this.gbRespuestas.Controls.Add(this.tlpRespuestas);
            this.gbRespuestas.Controls.Add(this.btnAñadirPregunta);
            this.gbRespuestas.Location = new System.Drawing.Point(240, 669);
            this.gbRespuestas.Name = "gbRespuestas";
            this.gbRespuestas.Size = new System.Drawing.Size(1657, 302);
            this.gbRespuestas.TabIndex = 14;
            this.gbRespuestas.TabStop = false;
            this.gbRespuestas.Text = "Respuestas";
            // 
            // tlpRespuestas
            // 
            this.tlpRespuestas.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tlpRespuestas.ColumnCount = 4;
            this.tlpRespuestas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.26057F));
            this.tlpRespuestas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tlpRespuestas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 706F));
            this.tlpRespuestas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tlpRespuestas.Controls.Add(this.rdbResp4, 3, 1);
            this.tlpRespuestas.Controls.Add(this.rdbResp3, 0, 1);
            this.tlpRespuestas.Controls.Add(this.txtResp3, 0, 1);
            this.tlpRespuestas.Controls.Add(this.txtResp2, 2, 0);
            this.tlpRespuestas.Controls.Add(this.txtResp1, 0, 0);
            this.tlpRespuestas.Controls.Add(this.rdbResp1, 1, 0);
            this.tlpRespuestas.Controls.Add(this.rdbResp2, 3, 0);
            this.tlpRespuestas.Controls.Add(this.txtResp4, 2, 1);
            this.tlpRespuestas.Location = new System.Drawing.Point(6, 21);
            this.tlpRespuestas.Name = "tlpRespuestas";
            this.tlpRespuestas.RowCount = 2;
            this.tlpRespuestas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRespuestas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tlpRespuestas.Size = new System.Drawing.Size(1643, 173);
            this.tlpRespuestas.TabIndex = 1;
            // 
            // rdbResp4
            // 
            this.rdbResp4.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbResp4.BackColor = System.Drawing.Color.DarkGray;
            this.rdbResp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbResp4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rdbResp4.Location = new System.Drawing.Point(1551, 87);
            this.rdbResp4.Name = "rdbResp4";
            this.rdbResp4.Size = new System.Drawing.Size(89, 78);
            this.rdbResp4.TabIndex = 7;
            this.rdbResp4.TabStop = true;
            this.rdbResp4.Text = "C";
            this.rdbResp4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbResp4.UseVisualStyleBackColor = false;
            this.rdbResp4.CheckedChanged += new System.EventHandler(this.rdbResp4_CheckedChanged);
            // 
            // rdbResp3
            // 
            this.rdbResp3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbResp3.BackColor = System.Drawing.Color.DarkGray;
            this.rdbResp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbResp3.Location = new System.Drawing.Point(747, 87);
            this.rdbResp3.Name = "rdbResp3";
            this.rdbResp3.Size = new System.Drawing.Size(92, 78);
            this.rdbResp3.TabIndex = 6;
            this.rdbResp3.TabStop = true;
            this.rdbResp3.Text = "C";
            this.rdbResp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbResp3.UseVisualStyleBackColor = false;
            this.rdbResp3.CheckedChanged += new System.EventHandler(this.rdbResp3_CheckedChanged);
            // 
            // txtResp3
            // 
            this.txtResp3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtResp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResp3.Location = new System.Drawing.Point(3, 87);
            this.txtResp3.Name = "txtResp3";
            this.txtResp3.Size = new System.Drawing.Size(738, 75);
            this.txtResp3.TabIndex = 5;
            // 
            // txtResp2
            // 
            this.txtResp2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtResp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResp2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtResp2.Location = new System.Drawing.Point(845, 3);
            this.txtResp2.Name = "txtResp2";
            this.txtResp2.Size = new System.Drawing.Size(700, 75);
            this.txtResp2.TabIndex = 1;
            // 
            // txtResp1
            // 
            this.txtResp1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtResp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResp1.Location = new System.Drawing.Point(3, 3);
            this.txtResp1.Name = "txtResp1";
            this.txtResp1.Size = new System.Drawing.Size(738, 75);
            this.txtResp1.TabIndex = 0;
            // 
            // rdbResp1
            // 
            this.rdbResp1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbResp1.BackColor = System.Drawing.Color.DarkGray;
            this.rdbResp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbResp1.Location = new System.Drawing.Point(747, 3);
            this.rdbResp1.Name = "rdbResp1";
            this.rdbResp1.Size = new System.Drawing.Size(92, 78);
            this.rdbResp1.TabIndex = 2;
            this.rdbResp1.TabStop = true;
            this.rdbResp1.Text = "C";
            this.rdbResp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbResp1.UseVisualStyleBackColor = false;
            this.rdbResp1.CheckedChanged += new System.EventHandler(this.rdbResp1_CheckedChanged);
            // 
            // rdbResp2
            // 
            this.rdbResp2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbResp2.BackColor = System.Drawing.Color.DarkGray;
            this.rdbResp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbResp2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rdbResp2.Location = new System.Drawing.Point(1551, 3);
            this.rdbResp2.Name = "rdbResp2";
            this.rdbResp2.Size = new System.Drawing.Size(89, 78);
            this.rdbResp2.TabIndex = 3;
            this.rdbResp2.TabStop = true;
            this.rdbResp2.Text = "C";
            this.rdbResp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbResp2.UseVisualStyleBackColor = false;
            this.rdbResp2.CheckedChanged += new System.EventHandler(this.rdbResp2_CheckedChanged);
            // 
            // txtResp4
            // 
            this.txtResp4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtResp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResp4.Location = new System.Drawing.Point(845, 87);
            this.txtResp4.Name = "txtResp4";
            this.txtResp4.Size = new System.Drawing.Size(700, 75);
            this.txtResp4.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel1.Controls.Add(this.pnlCrearPreguntas);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1907, 96);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlCrearPreguntas
            // 
            this.pnlCrearPreguntas.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlCrearPreguntas.Controls.Add(this.btnCrearPreguntas);
            this.pnlCrearPreguntas.Location = new System.Drawing.Point(3, 3);
            this.pnlCrearPreguntas.Name = "pnlCrearPreguntas";
            this.pnlCrearPreguntas.Size = new System.Drawing.Size(1921, 87);
            this.pnlCrearPreguntas.TabIndex = 0;
            // 
            // btnCrearPreguntas
            // 
            this.btnCrearPreguntas.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCrearPreguntas.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnCrearPreguntas.FlatAppearance.BorderSize = 2;
            this.btnCrearPreguntas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCrearPreguntas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPreguntas.Location = new System.Drawing.Point(1665, 18);
            this.btnCrearPreguntas.Name = "btnCrearPreguntas";
            this.btnCrearPreguntas.Size = new System.Drawing.Size(229, 49);
            this.btnCrearPreguntas.TabIndex = 13;
            this.btnCrearPreguntas.Text = "Crear Preguntas";
            this.btnCrearPreguntas.UseVisualStyleBackColor = false;
            this.btnCrearPreguntas.Click += new System.EventHandler(this.btnCrearPreguntas_Click);
            // 
            // CrearPreguntasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1907, 983);
            this.Controls.Add(this.gbRespuestas);
            this.Controls.Add(this.flpListaPreguntas);
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
            this.tlpRespuestas.ResumeLayout(false);
            this.tlpRespuestas.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlCrearPreguntas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TableLayoutPanel tlpRespuestas;
        private System.Windows.Forms.TextBox txtResp1;
        private System.Windows.Forms.TextBox txtResp2;
        private System.Windows.Forms.RadioButton rdbResp1;
        private System.Windows.Forms.RadioButton rdbResp2;
        private System.Windows.Forms.RadioButton rdbResp4;
        private System.Windows.Forms.RadioButton rdbResp3;
        private System.Windows.Forms.TextBox txtResp3;
        private System.Windows.Forms.TextBox txtResp4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlCrearPreguntas;
        private System.Windows.Forms.Button btnCrearPreguntas;
    }
}*/
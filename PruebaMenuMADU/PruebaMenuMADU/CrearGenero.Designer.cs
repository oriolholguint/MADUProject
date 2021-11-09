
namespace PruebaMenuMADU
{
    partial class CrearGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearGenero));
            this.gbImagen = new System.Windows.Forms.GroupBox();
            this.txtUrlOculta = new System.Windows.Forms.TextBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.pbImagenGenero = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUrlBackground = new System.Windows.Forms.TextBox();
            this.BntCargarFondo = new System.Windows.Forms.Button();
            this.pbBg = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.wmpMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.txtUrlMusic = new System.Windows.Forms.TextBox();
            this.btnCargarMusica = new System.Windows.Forms.Button();
            this.txtNombreGenero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGenreName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenGenero)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBg)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbImagen
            // 
            this.gbImagen.Controls.Add(this.txtUrlOculta);
            this.gbImagen.Controls.Add(this.btnCargarImagen);
            this.gbImagen.Controls.Add(this.pbImagenGenero);
            this.gbImagen.Location = new System.Drawing.Point(11, 203);
            this.gbImagen.Margin = new System.Windows.Forms.Padding(2);
            this.gbImagen.Name = "gbImagen";
            this.gbImagen.Padding = new System.Windows.Forms.Padding(2);
            this.gbImagen.Size = new System.Drawing.Size(446, 372);
            this.gbImagen.TabIndex = 8;
            this.gbImagen.TabStop = false;
            this.gbImagen.Text = "Imagen principal del Género";
            // 
            // txtUrlOculta
            // 
            this.txtUrlOculta.Location = new System.Drawing.Point(40, 248);
            this.txtUrlOculta.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrlOculta.Name = "txtUrlOculta";
            this.txtUrlOculta.Size = new System.Drawing.Size(364, 20);
            this.txtUrlOculta.TabIndex = 2;
            this.txtUrlOculta.TextChanged += new System.EventHandler(this.txtUrlOculta_TextChanged);
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarImagen.Location = new System.Drawing.Point(143, 284);
            this.btnCargarImagen.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(158, 40);
            this.btnCargarImagen.TabIndex = 1;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // pbImagenGenero
            // 
            this.pbImagenGenero.Location = new System.Drawing.Point(68, 17);
            this.pbImagenGenero.Margin = new System.Windows.Forms.Padding(2);
            this.pbImagenGenero.Name = "pbImagenGenero";
            this.pbImagenGenero.Size = new System.Drawing.Size(307, 209);
            this.pbImagenGenero.TabIndex = 0;
            this.pbImagenGenero.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUrlBackground);
            this.groupBox1.Controls.Add(this.BntCargarFondo);
            this.groupBox1.Controls.Add(this.pbBg);
            this.groupBox1.Location = new System.Drawing.Point(473, 203);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(405, 372);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imagen para el fondo del Género";
            // 
            // txtUrlBackground
            // 
            this.txtUrlBackground.Location = new System.Drawing.Point(15, 248);
            this.txtUrlBackground.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrlBackground.Name = "txtUrlBackground";
            this.txtUrlBackground.Size = new System.Drawing.Size(371, 20);
            this.txtUrlBackground.TabIndex = 2;
            // 
            // BntCargarFondo
            // 
            this.BntCargarFondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BntCargarFondo.Location = new System.Drawing.Point(93, 284);
            this.BntCargarFondo.Margin = new System.Windows.Forms.Padding(2);
            this.BntCargarFondo.Name = "BntCargarFondo";
            this.BntCargarFondo.Size = new System.Drawing.Size(235, 40);
            this.BntCargarFondo.TabIndex = 1;
            this.BntCargarFondo.Text = "Elegir imagen de fondo";
            this.BntCargarFondo.UseVisualStyleBackColor = true;
            this.BntCargarFondo.Click += new System.EventHandler(this.BntCargarFondo_Click);
            // 
            // pbBg
            // 
            this.pbBg.Location = new System.Drawing.Point(44, 26);
            this.pbBg.Margin = new System.Windows.Forms.Padding(2);
            this.pbBg.Name = "pbBg";
            this.pbBg.Size = new System.Drawing.Size(313, 200);
            this.pbBg.TabIndex = 0;
            this.pbBg.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.wmpMusic);
            this.groupBox2.Controls.Add(this.txtUrlMusic);
            this.groupBox2.Controls.Add(this.btnCargarMusica);
            this.groupBox2.Location = new System.Drawing.Point(893, 203);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(398, 372);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cargar musica de fondo para el Género";
            // 
            // wmpMusic
            // 
            this.wmpMusic.Enabled = true;
            this.wmpMusic.Location = new System.Drawing.Point(43, 26);
            this.wmpMusic.Name = "wmpMusic";
            this.wmpMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpMusic.OcxState")));
            this.wmpMusic.Size = new System.Drawing.Size(306, 190);
            this.wmpMusic.TabIndex = 3;
            // 
            // txtUrlMusic
            // 
            this.txtUrlMusic.Location = new System.Drawing.Point(13, 248);
            this.txtUrlMusic.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrlMusic.Name = "txtUrlMusic";
            this.txtUrlMusic.Size = new System.Drawing.Size(368, 20);
            this.txtUrlMusic.TabIndex = 2;
            // 
            // btnCargarMusica
            // 
            this.btnCargarMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarMusica.Location = new System.Drawing.Point(125, 284);
            this.btnCargarMusica.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargarMusica.Name = "btnCargarMusica";
            this.btnCargarMusica.Size = new System.Drawing.Size(158, 40);
            this.btnCargarMusica.TabIndex = 1;
            this.btnCargarMusica.Text = "Cargar Musica de fondo";
            this.btnCargarMusica.UseVisualStyleBackColor = true;
            this.btnCargarMusica.Click += new System.EventHandler(this.btnCargarMusica_Click);
            // 
            // txtNombreGenero
            // 
            this.txtNombreGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreGenero.Location = new System.Drawing.Point(30, 71);
            this.txtNombreGenero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreGenero.Multiline = true;
            this.txtNombreGenero.Name = "txtNombreGenero";
            this.txtNombreGenero.Size = new System.Drawing.Size(489, 84);
            this.txtNombreGenero.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre del nuevo género :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtGenreName);
            this.panel1.Controls.Add(this.txtNombreGenero);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 172);
            this.panel1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1033, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 84);
            this.button1.TabIndex = 3;
            this.button1.Text = "Crear Género";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGenreName
            // 
            this.txtGenreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenreName.Location = new System.Drawing.Point(543, 71);
            this.txtGenreName.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenreName.Multiline = true;
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(486, 84);
            this.txtGenreName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(553, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name of the new genre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CrearGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbImagen);
            this.Controls.Add(this.panel1);
            this.Name = "CrearGenero";
            this.Text = "CrearGenero";
            this.gbImagen.ResumeLayout(false);
            this.gbImagen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenGenero)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBg)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMusic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbImagen;
        private System.Windows.Forms.TextBox txtUrlOculta;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.PictureBox pbImagenGenero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUrlBackground;
        private System.Windows.Forms.Button BntCargarFondo;
        private System.Windows.Forms.PictureBox pbBg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUrlMusic;
        private System.Windows.Forms.Button btnCargarMusica;
        private System.Windows.Forms.TextBox txtNombreGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private AxWMPLib.AxWindowsMediaPlayer wmpMusic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGenreName;
    }
}
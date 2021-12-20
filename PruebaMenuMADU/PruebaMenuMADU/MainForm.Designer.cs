
namespace PruebaMenuMADU
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlModificar = new System.Windows.Forms.Panel();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.btnCrearPreguntas = new System.Windows.Forms.Button();
            this.cbxGeneros = new System.Windows.Forms.ComboBox();
            this.btnGenerarJSON = new System.Windows.Forms.Button();
            this.btnGestionarPersonajes = new System.Windows.Forms.Button();
            this.btnGenConfig = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlModificar
            // 
            this.pnlModificar.BackColor = System.Drawing.Color.DarkGray;
            this.pnlModificar.Location = new System.Drawing.Point(1292, 48);
            this.pnlModificar.Name = "pnlModificar";
            this.pnlModificar.Size = new System.Drawing.Size(620, 963);
            this.pnlModificar.TabIndex = 7;
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.DarkGray;
            this.pnlDatos.Location = new System.Drawing.Point(10, 49);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(1276, 962);
            this.pnlDatos.TabIndex = 11;
            // 
            // btnCrearPreguntas
            // 
            this.btnCrearPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPreguntas.Location = new System.Drawing.Point(453, 11);
            this.btnCrearPreguntas.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearPreguntas.Name = "btnCrearPreguntas";
            this.btnCrearPreguntas.Size = new System.Drawing.Size(242, 32);
            this.btnCrearPreguntas.TabIndex = 12;
            this.btnCrearPreguntas.Text = "Crear Preguntas";
            this.btnCrearPreguntas.UseVisualStyleBackColor = true;
            this.btnCrearPreguntas.Click += new System.EventHandler(this.btnCrearPreguntas_Click);
            // 
            // cbxGeneros
            // 
            this.cbxGeneros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGeneros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGeneros.FormattingEnabled = true;
            this.cbxGeneros.Location = new System.Drawing.Point(81, 11);
            this.cbxGeneros.Name = "cbxGeneros";
            this.cbxGeneros.Size = new System.Drawing.Size(121, 32);
            this.cbxGeneros.TabIndex = 0;
            this.cbxGeneros.SelectedIndexChanged += new System.EventHandler(this.cbxGeneros_SelectedIndexChanged);
            // 
            // btnGenerarJSON
            // 
            this.btnGenerarJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarJSON.Location = new System.Drawing.Point(1719, 11);
            this.btnGenerarJSON.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarJSON.Name = "btnGenerarJSON";
            this.btnGenerarJSON.Size = new System.Drawing.Size(194, 32);
            this.btnGenerarJSON.TabIndex = 14;
            this.btnGenerarJSON.Text = "Generar JSON";
            this.btnGenerarJSON.UseVisualStyleBackColor = true;
            this.btnGenerarJSON.Click += new System.EventHandler(this.btnGenerarJSON_Click);
            // 
            // btnGestionarPersonajes
            // 
            this.btnGestionarPersonajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarPersonajes.Location = new System.Drawing.Point(206, 11);
            this.btnGestionarPersonajes.Margin = new System.Windows.Forms.Padding(2);
            this.btnGestionarPersonajes.Name = "btnGestionarPersonajes";
            this.btnGestionarPersonajes.Size = new System.Drawing.Size(242, 32);
            this.btnGestionarPersonajes.TabIndex = 15;
            this.btnGestionarPersonajes.Text = "Gestionar personajes";
            this.btnGestionarPersonajes.UseVisualStyleBackColor = true;
            this.btnGestionarPersonajes.Click += new System.EventHandler(this.btnGestionarPersonajes_Click);
            // 
            // btnGenConfig
            // 
            this.btnGenConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenConfig.BackgroundImage")));
            this.btnGenConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenConfig.Enabled = false;
            this.btnGenConfig.Location = new System.Drawing.Point(45, 11);
            this.btnGenConfig.Name = "btnGenConfig";
            this.btnGenConfig.Size = new System.Drawing.Size(30, 32);
            this.btnGenConfig.TabIndex = 16;
            this.btnGenConfig.UseVisualStyleBackColor = true;
            this.btnGenConfig.Click += new System.EventHandler(this.btnGenConfig_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(11, 1016);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(170, 32);
            this.btnCerrarSesion.TabIndex = 17;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarUsuario.BackgroundImage")));
            this.btnAgregarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(9, 11);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(30, 32);
            this.btnAgregarUsuario.TabIndex = 18;
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGenre.Location = new System.Drawing.Point(700, 11);
            this.btnAddGenre.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(242, 32);
            this.btnAddGenre.TabIndex = 13;
            this.btnAddGenre.Text = "Crear Generos";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnGenConfig);
            this.Controls.Add(this.btnGestionarPersonajes);
            this.Controls.Add(this.btnGenerarJSON);
            this.Controls.Add(this.cbxGeneros);
            this.Controls.Add(this.btnCrearPreguntas);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlModificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlModificar;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Button btnCrearPreguntas;
        private System.Windows.Forms.ComboBox cbxGeneros;
        private System.Windows.Forms.Button btnGenerarJSON;
        private System.Windows.Forms.Button btnGestionarPersonajes;
        private System.Windows.Forms.Button btnGenConfig;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnAddGenre;
    }
}

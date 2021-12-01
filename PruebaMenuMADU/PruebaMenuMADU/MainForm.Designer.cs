
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
            this.buttonPreguntas = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pnlModificar = new System.Windows.Forms.Panel();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.btnCrearPreguntas = new System.Windows.Forms.Button();
            this.cbxGeneros = new System.Windows.Forms.ComboBox();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.btnGenerarJSON = new System.Windows.Forms.Button();
            this.btnGestionarPersonajes = new System.Windows.Forms.Button();
            this.btnGenConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPreguntas
            // 
            this.buttonPreguntas.Location = new System.Drawing.Point(0, 0);
            this.buttonPreguntas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPreguntas.Name = "buttonPreguntas";
            this.buttonPreguntas.Size = new System.Drawing.Size(75, 23);
            this.buttonPreguntas.TabIndex = 17;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1924, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pnlModificar
            // 
            this.pnlModificar.BackColor = System.Drawing.Color.DarkGray;
            this.pnlModificar.Location = new System.Drawing.Point(1211, 85);
            this.pnlModificar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlModificar.Name = "pnlModificar";
            this.pnlModificar.Size = new System.Drawing.Size(827, 940);
            this.pnlModificar.TabIndex = 7;
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.Color.DarkGray;
            this.pnlDatos.Location = new System.Drawing.Point(13, 85);
            this.pnlDatos.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(1189, 940);
            this.pnlDatos.TabIndex = 11;
            // 
            // btnCrearPreguntas
            // 
            this.btnCrearPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPreguntas.Location = new System.Drawing.Point(885, 37);
            this.btnCrearPreguntas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearPreguntas.Name = "btnCrearPreguntas";
            this.btnCrearPreguntas.Size = new System.Drawing.Size(323, 39);
            this.btnCrearPreguntas.TabIndex = 12;
            this.btnCrearPreguntas.Text = "Gestionar preguntas";
            this.btnCrearPreguntas.UseVisualStyleBackColor = true;
            this.btnCrearPreguntas.Click += new System.EventHandler(this.btnCrearPreguntas_Click);
            // 
            // cbxGeneros
            // 
            this.cbxGeneros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGeneros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGeneros.FormattingEnabled = true;
            this.cbxGeneros.Location = new System.Drawing.Point(61, 36);
            this.cbxGeneros.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGeneros.Name = "cbxGeneros";
            this.cbxGeneros.Size = new System.Drawing.Size(160, 37);
            this.cbxGeneros.TabIndex = 0;
            this.cbxGeneros.SelectedIndexChanged += new System.EventHandler(this.cbxGeneros_SelectedIndexChanged);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGenre.Location = new System.Drawing.Point(557, 37);
            this.btnAddGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(323, 39);
            this.btnAddGenre.TabIndex = 13;
            this.btnAddGenre.Text = "Gestionar Generos";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // btnGenerarJSON
            // 
            this.btnGenerarJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarJSON.Location = new System.Drawing.Point(1779, 36);
            this.btnGenerarJSON.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarJSON.Name = "btnGenerarJSON";
            this.btnGenerarJSON.Size = new System.Drawing.Size(259, 39);
            this.btnGenerarJSON.TabIndex = 14;
            this.btnGenerarJSON.Text = "Generar JSON";
            this.btnGenerarJSON.UseVisualStyleBackColor = true;
            this.btnGenerarJSON.Click += new System.EventHandler(this.btnGenerarJSON_Click);
            // 
            // btnGestionarPersonajes
            // 
            this.btnGestionarPersonajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarPersonajes.Location = new System.Drawing.Point(228, 37);
            this.btnGestionarPersonajes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGestionarPersonajes.Name = "btnGestionarPersonajes";
            this.btnGestionarPersonajes.Size = new System.Drawing.Size(323, 39);
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
            this.btnGenConfig.Location = new System.Drawing.Point(13, 36);
            this.btnGenConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenConfig.Name = "btnGenConfig";
            this.btnGenConfig.Size = new System.Drawing.Size(40, 39);
            this.btnGenConfig.TabIndex = 16;
            this.btnGenConfig.UseVisualStyleBackColor = true;
            this.btnGenConfig.Click += new System.EventHandler(this.btnGenConfig_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1040);
            this.Controls.Add(this.btnGenConfig);
            this.Controls.Add(this.btnGestionarPersonajes);
            this.Controls.Add(this.btnGenerarJSON);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.cbxGeneros);
            this.Controls.Add(this.btnCrearPreguntas);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlModificar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonPreguntas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPreguntas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel pnlModificar;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Button btnCrearPreguntas;
        private System.Windows.Forms.ComboBox cbxGeneros;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button btnGenerarJSON;
        private System.Windows.Forms.Button btnGestionarPersonajes;
        private System.Windows.Forms.Button btnGenConfig;
    }
}


namespace PruebaMenuMADU
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonPreguntas = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panelModificar = new System.Windows.Forms.Panel();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.btnCrearPreguntas = new System.Windows.Forms.Button();
            this.cbxGeneros = new System.Windows.Forms.ComboBox();
            this.buttAddGenre = new System.Windows.Forms.Button();
            this.buttonGenerarJSON = new System.Windows.Forms.Button();
            this.buttonGestionarPersonajes = new System.Windows.Forms.Button();
            this.BtnGenConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPreguntas
            // 
            this.buttonPreguntas.Location = new System.Drawing.Point(0, 0);
            this.buttonPreguntas.Name = "buttonPreguntas";
            this.buttonPreguntas.Size = new System.Drawing.Size(75, 23);
            this.buttonPreguntas.TabIndex = 17;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(2053, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panelModificar
            // 
            this.panelModificar.BackColor = System.Drawing.Color.DarkGray;
            this.panelModificar.Location = new System.Drawing.Point(1211, 85);
            this.panelModificar.Margin = new System.Windows.Forms.Padding(4);
            this.panelModificar.Name = "panelModificar";
            this.panelModificar.Size = new System.Drawing.Size(827, 940);
            this.panelModificar.TabIndex = 7;
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.DarkGray;
            this.panelDatos.Location = new System.Drawing.Point(13, 85);
            this.panelDatos.Margin = new System.Windows.Forms.Padding(4);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(1189, 940);
            this.panelDatos.TabIndex = 11;
            // 
            // btnCrearPreguntas
            // 
            this.btnCrearPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPreguntas.Location = new System.Drawing.Point(822, 37);
            this.btnCrearPreguntas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearPreguntas.Name = "btnCrearPreguntas";
            this.btnCrearPreguntas.Size = new System.Drawing.Size(259, 39);
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
            this.cbxGeneros.Location = new System.Drawing.Point(61, 36);
            this.cbxGeneros.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGeneros.Name = "cbxGeneros";
            this.cbxGeneros.Size = new System.Drawing.Size(160, 37);
            this.cbxGeneros.TabIndex = 0;
            this.cbxGeneros.SelectedIndexChanged += new System.EventHandler(this.cbxGeneros_SelectedIndexChanged);
            // 
            // buttAddGenre
            // 
            this.buttAddGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttAddGenre.Location = new System.Drawing.Point(557, 37);
            this.buttAddGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttAddGenre.Name = "buttAddGenre";
            this.buttAddGenre.Size = new System.Drawing.Size(259, 39);
            this.buttAddGenre.TabIndex = 13;
            this.buttAddGenre.Text = "Crear Generos";
            this.buttAddGenre.UseVisualStyleBackColor = true;
            this.buttAddGenre.Click += new System.EventHandler(this.buttAddGenre_Click);
            // 
            // buttonGenerarJSON
            // 
            this.buttonGenerarJSON.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerarJSON.Location = new System.Drawing.Point(1779, 36);
            this.buttonGenerarJSON.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGenerarJSON.Name = "buttonGenerarJSON";
            this.buttonGenerarJSON.Size = new System.Drawing.Size(259, 39);
            this.buttonGenerarJSON.TabIndex = 14;
            this.buttonGenerarJSON.Text = "Generar JSON";
            this.buttonGenerarJSON.UseVisualStyleBackColor = true;
            this.buttonGenerarJSON.Click += new System.EventHandler(this.buttonGenerarJSON_Click);
            // 
            // buttonGestionarPersonajes
            // 
            this.buttonGestionarPersonajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestionarPersonajes.Location = new System.Drawing.Point(228, 36);
            this.buttonGestionarPersonajes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGestionarPersonajes.Name = "buttonGestionarPersonajes";
            this.buttonGestionarPersonajes.Size = new System.Drawing.Size(323, 39);
            this.buttonGestionarPersonajes.TabIndex = 15;
            this.buttonGestionarPersonajes.Text = "Gestionar Personajes";
            this.buttonGestionarPersonajes.UseVisualStyleBackColor = true;
            this.buttonGestionarPersonajes.Click += new System.EventHandler(this.ButtonCrearP_Click);
            // 
            // BtnGenConfig
            // 
            this.BtnGenConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGenConfig.BackgroundImage")));
            this.BtnGenConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGenConfig.Enabled = false;
            this.BtnGenConfig.Location = new System.Drawing.Point(13, 36);
            this.BtnGenConfig.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGenConfig.Name = "BtnGenConfig";
            this.BtnGenConfig.Size = new System.Drawing.Size(40, 40);
            this.BtnGenConfig.TabIndex = 16;
            this.BtnGenConfig.UseVisualStyleBackColor = true;
            this.BtnGenConfig.Click += new System.EventHandler(this.BtnGenConfig_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2053, 1040);
            this.Controls.Add(this.BtnGenConfig);
            this.Controls.Add(this.buttonGestionarPersonajes);
            this.Controls.Add(this.buttonGenerarJSON);
            this.Controls.Add(this.buttAddGenre);
            this.Controls.Add(this.cbxGeneros);
            this.Controls.Add(this.btnCrearPreguntas);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panelModificar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonPreguntas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPreguntas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panelModificar;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Button btnCrearPreguntas;
        private System.Windows.Forms.ComboBox cbxGeneros;
        private System.Windows.Forms.Button buttAddGenre;
        private System.Windows.Forms.Button buttonGenerarJSON;
        private System.Windows.Forms.Button buttonGestionarPersonajes;
        private System.Windows.Forms.Button BtnGenConfig;
    }
}

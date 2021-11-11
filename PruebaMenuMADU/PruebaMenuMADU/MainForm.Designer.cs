
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
            this.buttonPreguntas = new System.Windows.Forms.Button();
            this.buttonPersonajes = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panelModificar = new System.Windows.Forms.Panel();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.btnCrearPreguntas = new System.Windows.Forms.Button();
            this.cbxGeneros = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            //
            // buttonPreguntas
            //
            this.buttonPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreguntas.Location = new System.Drawing.Point(184, 36);
            this.buttonPreguntas.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPreguntas.Name = "buttonPreguntas";
            this.buttonPreguntas.Size = new System.Drawing.Size(160, 39);
            this.buttonPreguntas.TabIndex = 0;
            this.buttonPreguntas.Text = "Preguntas";
            this.buttonPreguntas.UseVisualStyleBackColor = true;
            this.buttonPreguntas.Click += new System.EventHandler(this.buttonPreguntas_Click);

            // buttonPersonajes
            //
            this.buttonPersonajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPersonajes.Location = new System.Drawing.Point(351, 36);
            this.buttonPersonajes.Name = "buttonPersonajes";
            this.buttonPersonajes.Size = new System.Drawing.Size(160, 39);
            this.buttonPersonajes.TabIndex = 2;
            this.buttonPersonajes.Text = "Personajes";
            this.buttonPersonajes.UseVisualStyleBackColor = true;
            this.buttonPersonajes.Click += new System.EventHandler(this.buttonPersonajes_Click);
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
            // panelModificar
            //
            this.panelModificar.BackColor = System.Drawing.Color.DarkGray;
            this.panelModificar.Location = new System.Drawing.Point(1211, 83);
            this.panelModificar.Margin = new System.Windows.Forms.Padding(4);
            this.panelModificar.Name = "panelModificar";
            this.panelModificar.Size = new System.Drawing.Size(700, 886);
            this.panelModificar.TabIndex = 7;
            //
            // panelDatos
            //
            this.panelDatos.BackColor = System.Drawing.Color.DarkGray;
            this.panelDatos.Location = new System.Drawing.Point(16, 85);
            this.panelDatos.Margin = new System.Windows.Forms.Padding(4);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(1187, 886);
            this.panelDatos.TabIndex = 11;
            //
            // btnCrearPreguntas
            //
            this.btnCrearPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPreguntas.Location = new System.Drawing.Point(944, 34);
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
            this.cbxGeneros.Location = new System.Drawing.Point(16, 36);
            this.cbxGeneros.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGeneros.Name = "cbxGeneros";
            this.cbxGeneros.Size = new System.Drawing.Size(160, 37);
            this.cbxGeneros.TabIndex = 0;
            this.cbxGeneros.SelectedIndexChanged += new System.EventHandler(this.cbxGeneros_SelectedIndexChanged);
            //
            // Menu
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 967);
            this.Controls.Add(this.buttonPersonajes);
            this.Controls.Add(this.cbxGeneros);
            this.Controls.Add(this.btnCrearPreguntas);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panelModificar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonPreguntas);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPreguntas;
        private System.Windows.Forms.Button buttonPersonajes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panelModificar;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Button btnCrearPreguntas;
        private System.Windows.Forms.ComboBox cbxGeneros;
    }
}

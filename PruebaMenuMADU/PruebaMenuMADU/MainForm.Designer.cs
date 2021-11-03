
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
            this.buttonGeneros = new System.Windows.Forms.Button();
            this.buttonPersonajes = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonFiltro = new System.Windows.Forms.Button();
            this.panelModificar = new System.Windows.Forms.Panel();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // buttonPreguntas
            //
            this.buttonPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreguntas.Location = new System.Drawing.Point(177, 34);
            this.buttonPreguntas.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPreguntas.Name = "buttonPreguntas";
            this.buttonPreguntas.Size = new System.Drawing.Size(153, 43);
            this.buttonPreguntas.TabIndex = 0;
            this.buttonPreguntas.Text = "Preguntas";
            this.buttonPreguntas.UseVisualStyleBackColor = true;
            this.buttonPreguntas.Click += new System.EventHandler(this.buttonPreguntas_Click);
            //
            // buttonGeneros
            //
            this.buttonGeneros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGeneros.Location = new System.Drawing.Point(16, 34);
            this.buttonGeneros.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGeneros.Name = "buttonGeneros";
            this.buttonGeneros.Size = new System.Drawing.Size(153, 43);
            this.buttonGeneros.TabIndex = 1;
            this.buttonGeneros.Text = "Generos";
            this.buttonGeneros.UseVisualStyleBackColor = true;
            this.buttonGeneros.Click += new System.EventHandler(this.buttonGeneros_Click);
            //
            // buttonPersonajes
            //
            this.buttonPersonajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPersonajes.Location = new System.Drawing.Point(339, 34);
            this.buttonPersonajes.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPersonajes.Name = "buttonPersonajes";
            this.buttonPersonajes.Size = new System.Drawing.Size(175, 43);
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
            // buttonFiltro
            //
            this.buttonFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltro.Location = new System.Drawing.Point(1336, 34);
            this.buttonFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFiltro.Name = "buttonFiltro";
            this.buttonFiltro.Size = new System.Drawing.Size(80, 43);
            this.buttonFiltro.TabIndex = 6;
            this.buttonFiltro.UseVisualStyleBackColor = true;
            //
            // panelModificar
            //
            this.panelModificar.BackColor = System.Drawing.Color.DarkGray;
            this.panelModificar.Location = new System.Drawing.Point(1424, 85);
            this.panelModificar.Margin = new System.Windows.Forms.Padding(4);
            this.panelModificar.Name = "panelModificar";
            this.panelModificar.Size = new System.Drawing.Size(613, 886);
            this.panelModificar.TabIndex = 7;
            //
            // panelDatos
            //
            this.panelDatos.BackColor = System.Drawing.Color.DarkGray;
            this.panelDatos.Location = new System.Drawing.Point(16, 85);
            this.panelDatos.Margin = new System.Windows.Forms.Padding(4);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(1400, 886);
            this.panelDatos.TabIndex = 11;
            //
            // button1
            //
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(593, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Crear Preguntas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // Menu
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 983);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panelModificar);
            this.Controls.Add(this.buttonFiltro);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonPersonajes);
            this.Controls.Add(this.buttonGeneros);
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
        private System.Windows.Forms.Button buttonGeneros;
        private System.Windows.Forms.Button buttonPersonajes;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Button buttonFiltro;
        private System.Windows.Forms.Panel panelModificar;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Button button1;
    }
}

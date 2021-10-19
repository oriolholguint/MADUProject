
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
            this.SuspendLayout();
            // 
            // buttonPreguntas
            // 
            this.buttonPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreguntas.Location = new System.Drawing.Point(133, 28);
            this.buttonPreguntas.Name = "buttonPreguntas";
            this.buttonPreguntas.Size = new System.Drawing.Size(115, 35);
            this.buttonPreguntas.TabIndex = 0;
            this.buttonPreguntas.Text = "Preguntas";
            this.buttonPreguntas.UseVisualStyleBackColor = true;
            this.buttonPreguntas.Click += new System.EventHandler(this.buttonPreguntas_Click);
            // 
            // buttonGeneros
            // 
            this.buttonGeneros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGeneros.Location = new System.Drawing.Point(12, 28);
            this.buttonGeneros.Name = "buttonGeneros";
            this.buttonGeneros.Size = new System.Drawing.Size(115, 35);
            this.buttonGeneros.TabIndex = 1;
            this.buttonGeneros.Text = "Generos";
            this.buttonGeneros.UseVisualStyleBackColor = true;
            this.buttonGeneros.Click += new System.EventHandler(this.buttonGeneros_Click);
            // 
            // buttonPersonajes
            // 
            this.buttonPersonajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPersonajes.Location = new System.Drawing.Point(254, 28);
            this.buttonPersonajes.Name = "buttonPersonajes";
            this.buttonPersonajes.Size = new System.Drawing.Size(115, 35);
            this.buttonPersonajes.TabIndex = 2;
            this.buttonPersonajes.Text = "Personajes";
            this.buttonPersonajes.UseVisualStyleBackColor = true;
            this.buttonPersonajes.Click += new System.EventHandler(this.buttonPersonajes_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1540, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonFiltro
            // 
            this.buttonFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltro.Location = new System.Drawing.Point(1002, 28);
            this.buttonFiltro.Name = "buttonFiltro";
            this.buttonFiltro.Size = new System.Drawing.Size(60, 35);
            this.buttonFiltro.TabIndex = 6;
            this.buttonFiltro.UseVisualStyleBackColor = true;
            // 
            // panelModificar
            // 
            this.panelModificar.BackColor = System.Drawing.Color.DarkGray;
            this.panelModificar.Location = new System.Drawing.Point(1068, 69);
            this.panelModificar.Name = "panelModificar";
            this.panelModificar.Size = new System.Drawing.Size(460, 720);
            this.panelModificar.TabIndex = 7;
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.DarkGray;
            this.panelDatos.Location = new System.Drawing.Point(12, 69);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(1050, 720);
            this.panelDatos.TabIndex = 11;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 799);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panelModificar);
            this.Controls.Add(this.buttonFiltro);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonPersonajes);
            this.Controls.Add(this.buttonGeneros);
            this.Controls.Add(this.buttonPreguntas);
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
    }
}


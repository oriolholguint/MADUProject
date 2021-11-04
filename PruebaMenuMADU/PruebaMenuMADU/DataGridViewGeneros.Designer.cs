
namespace PruebaMenuMADU
{
    partial class DataGridViewGeneros
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
            this.dataGridViewTablaGeneros = new System.Windows.Forms.DataGridView();
            this.NombreGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImagenPreguntaGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImagenMiniaturaGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SonidoGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablaGeneros)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTablaGeneros
            // 
            this.dataGridViewTablaGeneros.AllowUserToDeleteRows = false;
            this.dataGridViewTablaGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTablaGeneros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreGenero,
            this.ImagenPreguntaGenero,
            this.ImagenMiniaturaGenero,
            this.SonidoGenero});
            this.dataGridViewTablaGeneros.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTablaGeneros.Name = "dataGridViewTablaGeneros";
            this.dataGridViewTablaGeneros.ReadOnly = true;
            this.dataGridViewTablaGeneros.Size = new System.Drawing.Size(1050, 720);
            this.dataGridViewTablaGeneros.TabIndex = 0;
            // 
            // NombreGenero
            // 
            this.NombreGenero.HeaderText = "Nombre";
            this.NombreGenero.Name = "NombreGenero";
            this.NombreGenero.ReadOnly = true;
            // 
            // ImagenPreguntaGenero
            // 
            this.ImagenPreguntaGenero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImagenPreguntaGenero.HeaderText = "Imagen Pregunta";
            this.ImagenPreguntaGenero.Name = "ImagenPreguntaGenero";
            this.ImagenPreguntaGenero.ReadOnly = true;
            // 
            // ImagenMiniaturaGenero
            // 
            this.ImagenMiniaturaGenero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImagenMiniaturaGenero.HeaderText = "Imagen Miniatura";
            this.ImagenMiniaturaGenero.Name = "ImagenMiniaturaGenero";
            this.ImagenMiniaturaGenero.ReadOnly = true;
            // 
            // SonidoGenero
            // 
            this.SonidoGenero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SonidoGenero.HeaderText = "Sonido";
            this.SonidoGenero.Name = "SonidoGenero";
            this.SonidoGenero.ReadOnly = true;
            // 
            // DataGridViewGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 720);
            this.Controls.Add(this.dataGridViewTablaGeneros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataGridViewGeneros";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablaGeneros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTablaGeneros;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImagenPreguntaGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImagenMiniaturaGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn SonidoGenero;
    }
}
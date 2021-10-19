
namespace PruebaMenuMADU
{
    partial class DataGridViewPersonajes
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
            this.dataGridViewTablaPersonajes = new System.Windows.Forms.DataGridView();
            this.GeneroPersonaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePersonaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImagenPersonaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablaPersonajes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTablaPersonajes
            // 
            this.dataGridViewTablaPersonajes.AllowUserToAddRows = false;
            this.dataGridViewTablaPersonajes.AllowUserToDeleteRows = false;
            this.dataGridViewTablaPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTablaPersonajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GeneroPersonaje,
            this.NombrePersonaje,
            this.ImagenPersonaje});
            this.dataGridViewTablaPersonajes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTablaPersonajes.Name = "dataGridViewTablaPersonajes";
            this.dataGridViewTablaPersonajes.ReadOnly = true;
            this.dataGridViewTablaPersonajes.Size = new System.Drawing.Size(1050, 720);
            this.dataGridViewTablaPersonajes.TabIndex = 0;
            // 
            // GeneroPersonaje
            // 
            this.GeneroPersonaje.HeaderText = "Genero";
            this.GeneroPersonaje.Name = "GeneroPersonaje";
            // 
            // NombrePersonaje
            // 
            this.NombrePersonaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombrePersonaje.HeaderText = "Nombre";
            this.NombrePersonaje.Name = "NombrePersonaje";
            // 
            // ImagenPersonaje
            // 
            this.ImagenPersonaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImagenPersonaje.HeaderText = "Imagen";
            this.ImagenPersonaje.Name = "ImagenPersonaje";
            // 
            // DataGridViewPersonajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 720);
            this.Controls.Add(this.dataGridViewTablaPersonajes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataGridViewPersonajes";
            this.Text = "DataGridViewPersonajes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablaPersonajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTablaPersonajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneroPersonaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePersonaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImagenPersonaje;
    }
}
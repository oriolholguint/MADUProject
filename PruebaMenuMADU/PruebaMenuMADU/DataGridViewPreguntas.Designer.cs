
namespace PruebaMenuMADU
{
    partial class DataGridViewPreguntas
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
            this.dataGridViewTablaPreguntas = new System.Windows.Forms.DataGridView();
            this.PreguntaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImagenPregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SonidoPregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsMayorEdadPregunta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablaPreguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTablaPreguntas
            // 
            this.dataGridViewTablaPreguntas.AllowUserToAddRows = false;
            this.dataGridViewTablaPreguntas.AllowUserToDeleteRows = false;
            this.dataGridViewTablaPreguntas.AllowUserToResizeRows = false;
            this.dataGridViewTablaPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTablaPreguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PreguntaDescripcion,
            this.ImagenPregunta,
            this.SonidoPregunta,
            this.EsMayorEdadPregunta});
            this.dataGridViewTablaPreguntas.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTablaPreguntas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewTablaPreguntas.MultiSelect = false;
            this.dataGridViewTablaPreguntas.Name = "dataGridViewTablaPreguntas";
            this.dataGridViewTablaPreguntas.ReadOnly = true;
            this.dataGridViewTablaPreguntas.RowHeadersVisible = false;
            this.dataGridViewTablaPreguntas.RowHeadersWidth = 51;
            this.dataGridViewTablaPreguntas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTablaPreguntas.Size = new System.Drawing.Size(1189, 940);
            this.dataGridViewTablaPreguntas.TabIndex = 0;
            this.dataGridViewTablaPreguntas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTablaPreguntas_CellClick);
            // 
            // PreguntaDescripcion
            // 
            this.PreguntaDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PreguntaDescripcion.DataPropertyName = "PreguntaDescripcion";
            this.PreguntaDescripcion.HeaderText = "Pregunta";
            this.PreguntaDescripcion.MinimumWidth = 6;
            this.PreguntaDescripcion.Name = "PreguntaDescripcion";
            this.PreguntaDescripcion.ReadOnly = true;
            // 
            // ImagenPregunta
            // 
            this.ImagenPregunta.DataPropertyName = "Imagen";
            this.ImagenPregunta.HeaderText = "Imagen";
            this.ImagenPregunta.MinimumWidth = 6;
            this.ImagenPregunta.Name = "ImagenPregunta";
            this.ImagenPregunta.ReadOnly = true;
            this.ImagenPregunta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ImagenPregunta.Width = 125;
            // 
            // SonidoPregunta
            // 
            this.SonidoPregunta.DataPropertyName = "Sonido";
            this.SonidoPregunta.HeaderText = "Sonido";
            this.SonidoPregunta.MinimumWidth = 6;
            this.SonidoPregunta.Name = "SonidoPregunta";
            this.SonidoPregunta.ReadOnly = true;
            this.SonidoPregunta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SonidoPregunta.Width = 125;
            // 
            // EsMayorEdadPregunta
            // 
            this.EsMayorEdadPregunta.DataPropertyName = "esMayorEdad";
            this.EsMayorEdadPregunta.HeaderText = "Mayor Edad";
            this.EsMayorEdadPregunta.MinimumWidth = 6;
            this.EsMayorEdadPregunta.Name = "EsMayorEdadPregunta";
            this.EsMayorEdadPregunta.ReadOnly = true;
            this.EsMayorEdadPregunta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsMayorEdadPregunta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsMayorEdadPregunta.Width = 125;
            // 
            // DataGridViewPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 884);
            this.Controls.Add(this.dataGridViewTablaPreguntas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DataGridViewPreguntas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablaPreguntas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTablaPreguntas;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreguntaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImagenPregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn SonidoPregunta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsMayorEdadPregunta;
    }
}
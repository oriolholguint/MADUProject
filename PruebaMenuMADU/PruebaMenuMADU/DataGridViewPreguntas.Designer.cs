
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
            this.IdPregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneroPregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MayorEdadPregunta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TipoPregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrlImagenAudio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablaPreguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTablaPreguntas
            // 
            this.dataGridViewTablaPreguntas.AllowUserToAddRows = false;
            this.dataGridViewTablaPreguntas.AllowUserToDeleteRows = false;
            this.dataGridViewTablaPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTablaPreguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPregunta,
            this.Pregunta,
            this.GeneroPregunta,
            this.MayorEdadPregunta,
            this.TipoPregunta,
            this.UrlImagenAudio});
            this.dataGridViewTablaPreguntas.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTablaPreguntas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewTablaPreguntas.Name = "dataGridViewTablaPreguntas";
            this.dataGridViewTablaPreguntas.ReadOnly = true;
            this.dataGridViewTablaPreguntas.RowHeadersWidth = 51;
            this.dataGridViewTablaPreguntas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTablaPreguntas.Size = new System.Drawing.Size(1400, 886);
            this.dataGridViewTablaPreguntas.TabIndex = 0;
            this.dataGridViewTablaPreguntas.SelectionChanged += new System.EventHandler(this.dataGridViewTablaPreguntas_SelectionChanged);
            // 
            // IdPregunta
            // 
            this.IdPregunta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdPregunta.DataPropertyName = "id";
            this.IdPregunta.HeaderText = "Id";
            this.IdPregunta.MinimumWidth = 6;
            this.IdPregunta.Name = "IdPregunta";
            this.IdPregunta.ReadOnly = true;
            this.IdPregunta.Width = 125;
            // 
            // Pregunta
            // 
            this.Pregunta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pregunta.DataPropertyName = "NombrePregunta";
            this.Pregunta.HeaderText = "Pregunta";
            this.Pregunta.MinimumWidth = 6;
            this.Pregunta.Name = "Pregunta";
            this.Pregunta.ReadOnly = true;
            // 
            // GeneroPregunta
            // 
            this.GeneroPregunta.DataPropertyName = "Genero";
            this.GeneroPregunta.HeaderText = "Genero";
            this.GeneroPregunta.MinimumWidth = 6;
            this.GeneroPregunta.Name = "GeneroPregunta";
            this.GeneroPregunta.ReadOnly = true;
            this.GeneroPregunta.Width = 125;
            // 
            // MayorEdadPregunta
            // 
            this.MayorEdadPregunta.DataPropertyName = "MayorDeEdad";
            this.MayorEdadPregunta.HeaderText = "Mayor Edad";
            this.MayorEdadPregunta.MinimumWidth = 6;
            this.MayorEdadPregunta.Name = "MayorEdadPregunta";
            this.MayorEdadPregunta.ReadOnly = true;
            this.MayorEdadPregunta.Width = 125;
            // 
            // TipoPregunta
            // 
            this.TipoPregunta.DataPropertyName = "Tipo";
            this.TipoPregunta.HeaderText = "Tipo";
            this.TipoPregunta.MinimumWidth = 6;
            this.TipoPregunta.Name = "TipoPregunta";
            this.TipoPregunta.ReadOnly = true;
            this.TipoPregunta.Width = 125;
            // 
            // UrlImagenAudio
            // 
            this.UrlImagenAudio.DataPropertyName = "UrlImgAudio";
            this.UrlImagenAudio.HeaderText = "Url Imagen/Audio";
            this.UrlImagenAudio.MinimumWidth = 6;
            this.UrlImagenAudio.Name = "UrlImagenAudio";
            this.UrlImagenAudio.ReadOnly = true;
            this.UrlImagenAudio.Width = 125;
            // 
            // DataGridViewPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 886);
            this.Controls.Add(this.dataGridViewTablaPreguntas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DataGridViewPreguntas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablaPreguntas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTablaPreguntas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneroPregunta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MayorEdadPregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrlImagenAudio;
    }
}
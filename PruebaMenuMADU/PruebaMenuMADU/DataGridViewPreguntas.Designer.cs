
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
            this.Respuesta1Pregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Respuesta2Pregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Respuesta3Pregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Respuesta4Pregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Respuesta1Pregunta,
            this.Respuesta2Pregunta,
            this.Respuesta3Pregunta,
            this.Respuesta4Pregunta});
            this.dataGridViewTablaPreguntas.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTablaPreguntas.Name = "dataGridViewTablaPreguntas";
            this.dataGridViewTablaPreguntas.ReadOnly = true;
            this.dataGridViewTablaPreguntas.Size = new System.Drawing.Size(1050, 720);
            this.dataGridViewTablaPreguntas.TabIndex = 0;
            // 
            // IdPregunta
            // 
            this.IdPregunta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdPregunta.HeaderText = "Id";
            this.IdPregunta.Name = "IdPregunta";
            // 
            // Pregunta
            // 
            this.Pregunta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pregunta.HeaderText = "Pregunta";
            this.Pregunta.Name = "Pregunta";
            // 
            // GeneroPregunta
            // 
            this.GeneroPregunta.HeaderText = "Genero";
            this.GeneroPregunta.Name = "GeneroPregunta";
            // 
            // MayorEdadPregunta
            // 
            this.MayorEdadPregunta.HeaderText = "Mayor Edad";
            this.MayorEdadPregunta.Name = "MayorEdadPregunta";
            // 
            // TipoPregunta
            // 
            this.TipoPregunta.HeaderText = "Tipo";
            this.TipoPregunta.Name = "TipoPregunta";
            // 
            // Respuesta1Pregunta
            // 
            this.Respuesta1Pregunta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Respuesta1Pregunta.HeaderText = "Respuesta 1";
            this.Respuesta1Pregunta.Name = "Respuesta1Pregunta";
            // 
            // Respuesta2Pregunta
            // 
            this.Respuesta2Pregunta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Respuesta2Pregunta.HeaderText = "Respuesta 2";
            this.Respuesta2Pregunta.Name = "Respuesta2Pregunta";
            // 
            // Respuesta3Pregunta
            // 
            this.Respuesta3Pregunta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Respuesta3Pregunta.HeaderText = "Respuesta 3";
            this.Respuesta3Pregunta.Name = "Respuesta3Pregunta";
            // 
            // Respuesta4Pregunta
            // 
            this.Respuesta4Pregunta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Respuesta4Pregunta.HeaderText = "Respuesta 4";
            this.Respuesta4Pregunta.Name = "Respuesta4Pregunta";
            // 
            // DataGridViewPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 720);
            this.Controls.Add(this.dataGridViewTablaPreguntas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Respuesta1Pregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Respuesta2Pregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Respuesta3Pregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Respuesta4Pregunta;
    }
}
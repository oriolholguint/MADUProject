
namespace PruebaMenuMADU
{
    partial class ModificarGenero
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
            this.labelModificarGenero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelModificarGenero
            // 
            this.labelModificarGenero.AutoSize = true;
            this.labelModificarGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificarGenero.Location = new System.Drawing.Point(120, 9);
            this.labelModificarGenero.Name = "labelModificarGenero";
            this.labelModificarGenero.Size = new System.Drawing.Size(221, 31);
            this.labelModificarGenero.TabIndex = 16;
            this.labelModificarGenero.Text = "Modificar Genero";
            // 
            // ModificarGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(460, 720);
            this.Controls.Add(this.labelModificarGenero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarGenero";
            this.Text = "ModificarGenero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModificarGenero;
    }
}
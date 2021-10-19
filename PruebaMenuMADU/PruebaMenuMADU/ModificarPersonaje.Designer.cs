
namespace PruebaMenuMADU
{
    partial class ModificarPersonaje
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
            this.labelModificarPersonaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelModificarPersonaje
            // 
            this.labelModificarPersonaje.AutoSize = true;
            this.labelModificarPersonaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificarPersonaje.Location = new System.Drawing.Point(120, 9);
            this.labelModificarPersonaje.Name = "labelModificarPersonaje";
            this.labelModificarPersonaje.Size = new System.Drawing.Size(253, 31);
            this.labelModificarPersonaje.TabIndex = 17;
            this.labelModificarPersonaje.Text = "Modificar Personaje";
            // 
            // ModificarPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(460, 720);
            this.Controls.Add(this.labelModificarPersonaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarPersonaje";
            this.Text = "ModificarPersonaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModificarPersonaje;
    }
}
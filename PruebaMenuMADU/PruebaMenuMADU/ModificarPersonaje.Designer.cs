
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.btnAbrirFicherosImagen = new System.Windows.Forms.Button();
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
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(12, 92);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(73, 24);
            this.lblImagen.TabIndex = 19;
            this.lblImagen.Text = "Imagen";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(97, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(351, 29);
            this.txtNombre.TabIndex = 20;
            // 
            // txtImagen
            // 
            this.txtImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagen.Location = new System.Drawing.Point(97, 89);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(316, 29);
            this.txtImagen.TabIndex = 21;
            // 
            // btnAbrirFicherosImagen
            // 
            this.btnAbrirFicherosImagen.Location = new System.Drawing.Point(419, 90);
            this.btnAbrirFicherosImagen.Name = "btnAbrirFicherosImagen";
            this.btnAbrirFicherosImagen.Size = new System.Drawing.Size(29, 29);
            this.btnAbrirFicherosImagen.TabIndex = 22;
            this.btnAbrirFicherosImagen.UseVisualStyleBackColor = true;
            // 
            // ModificarPersonaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(460, 720);
            this.Controls.Add(this.btnAbrirFicherosImagen);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.labelModificarPersonaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificarPersonaje";
            this.Text = "ModificarPersonaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModificarPersonaje;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Button btnAbrirFicherosImagen;
    }
}
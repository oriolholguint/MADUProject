
using System;

namespace PruebaMenuMADU
{
    partial class Login
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
            this.groupBoxLoginG = new System.Windows.Forms.GroupBox();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMADU = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupBoxLoginG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLoginG
            // 
            this.groupBoxLoginG.Controls.Add(this.labelError);
            this.groupBoxLoginG.Controls.Add(this.buttonLogIn);
            this.groupBoxLoginG.Controls.Add(this.labelRegistro);
            this.groupBoxLoginG.Controls.Add(this.textBoxPassword);
            this.groupBoxLoginG.Controls.Add(this.textBoxUser);
            this.groupBoxLoginG.Controls.Add(this.label3);
            this.groupBoxLoginG.Controls.Add(this.label2);
            this.groupBoxLoginG.Controls.Add(this.labelMADU);
            this.groupBoxLoginG.Controls.Add(this.pictureBoxLogo);
            this.groupBoxLoginG.Location = new System.Drawing.Point(12, 8);
            this.groupBoxLoginG.Name = "groupBoxLoginG";
            this.groupBoxLoginG.Size = new System.Drawing.Size(981, 622);
            this.groupBoxLoginG.TabIndex = 1;
            this.groupBoxLoginG.TabStop = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(413, 510);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(188, 20);
            this.labelError.TabIndex = 9;
            this.labelError.Text = "¡Invalid user or Password!";
            this.labelError.Visible = false;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.Location = new System.Drawing.Point(398, 533);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(215, 60);
            this.buttonLogIn.TabIndex = 7;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistro.Location = new System.Drawing.Point(430, 463);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(162, 18);
            this.labelRegistro.TabIndex = 6;
            this.labelRegistro.Text = "Forgot your password?";
            this.labelRegistro.Click += new System.EventHandler(this.labelRegistro_Click_1);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(383, 425);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(268, 20);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(382, 358);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(268, 20);
            this.textBoxUser.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "User: ";
            // 
            // labelMADU
            // 
            this.labelMADU.AutoSize = true;
            this.labelMADU.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMADU.Location = new System.Drawing.Point(425, 288);
            this.labelMADU.Name = "labelMADU";
            this.labelMADU.Size = new System.Drawing.Size(168, 43);
            this.labelMADU.TabIndex = 1;
            this.labelMADU.Text = "M.A.D.U";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::PruebaMenuMADU.Properties.Resources.logoAGeneral__1_;
            this.pictureBoxLogo.Location = new System.Drawing.Point(386, 14);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(254, 268);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 646);
            this.Controls.Add(this.groupBoxLoginG);
            this.Name = "Login";
            this.Text = "Login";
            this.groupBoxLoginG.ResumeLayout(false);
            this.groupBoxLoginG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLoginG;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMADU;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}
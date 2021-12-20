
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
            this.lblError = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblMADU = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupBoxLoginG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLoginG
            // 
            this.groupBoxLoginG.Controls.Add(this.lblError);
            this.groupBoxLoginG.Controls.Add(this.btnLogin);
            this.groupBoxLoginG.Controls.Add(this.lblRegistro);
            this.groupBoxLoginG.Controls.Add(this.txtPassword);
            this.groupBoxLoginG.Controls.Add(this.txtUser);
            this.groupBoxLoginG.Controls.Add(this.lblPassword);
            this.groupBoxLoginG.Controls.Add(this.lblUser);
            this.groupBoxLoginG.Controls.Add(this.lblMADU);
            this.groupBoxLoginG.Controls.Add(this.pictureBoxLogo);
            this.groupBoxLoginG.Location = new System.Drawing.Point(16, 10);
            this.groupBoxLoginG.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxLoginG.Name = "groupBoxLoginG";
            this.groupBoxLoginG.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxLoginG.Size = new System.Drawing.Size(1308, 766);
            this.groupBoxLoginG.TabIndex = 1;
            this.groupBoxLoginG.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(551, 628);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(237, 25);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "¡Invalid user or Password!";
            this.lblError.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(531, 656);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(287, 74);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(573, 570);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(203, 24);
            this.lblRegistro.TabIndex = 6;
            this.lblRegistro.Text = "Forgot your password?";
            this.lblRegistro.Click += new System.EventHandler(this.lblRegistro_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(511, 523);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(356, 22);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(509, 441);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(356, 22);
            this.txtUser.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(304, 516);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(176, 34);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password: ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(385, 433);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(102, 34);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User: ";
            // 
            // lblMADU
            // 
            this.lblMADU.AutoSize = true;
            this.lblMADU.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMADU.Location = new System.Drawing.Point(567, 354);
            this.lblMADU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMADU.Name = "lblMADU";
            this.lblMADU.Size = new System.Drawing.Size(212, 54);
            this.lblMADU.TabIndex = 1;
            this.lblMADU.Text = "M.A.D.U";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::PruebaMenuMADU.Properties.Resources.logoAGeneral;
            this.pictureBoxLogo.ImageLocation = "";
            this.pictureBoxLogo.Location = new System.Drawing.Point(515, 17);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(339, 330);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 795);
            this.Controls.Add(this.groupBoxLoginG);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblMADU;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}
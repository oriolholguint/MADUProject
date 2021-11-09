﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaMenuMADU
{
    public partial class CrearGenero : Form
    {
        public CrearGenero()
        {
            InitializeComponent();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagePick = new OpenFileDialog();
            if (imagePick.ShowDialog() == DialogResult.OK)
            {
                txtUrlOculta.Text = imagePick.FileName;
                Bitmap image = new Bitmap(imagePick.FileName);
                pbImagenGenero.Dock = DockStyle.Fill;
                pbImagenGenero.Image = (Image)image;
            }
            
        }

        private void txtUrlOculta_TextChanged(object sender, EventArgs e)
        {

        }

        private void BntCargarFondo_Click(object sender, EventArgs e)
        {
            OpenFileDialog bgPick = new OpenFileDialog();
            if (bgPick.ShowDialog() == DialogResult.OK)
            {
                txtUrlBackground.Text = bgPick.FileName;
                Bitmap image = new Bitmap(bgPick.FileName);
                pbBg.Dock = DockStyle.Fill;
                pbBg.Image = (Image)image;
            }
        }

        private void btnCargarMusica_Click(object sender, EventArgs e)
        {
            OpenFileDialog musicFile = new OpenFileDialog();
            if (musicFile.ShowDialog() == DialogResult.OK)
            {
                txtUrlMusic.Text = musicFile.FileName;
                wmpMusic.URL = txtUrlMusic.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personaje[] personajesRap = new Personaje[5];
            Partida[] partidasRap = new Partida[10];
            Pregunta[] preguntasRap = new Pregunta[60];
            String[] nonNullableStrings = { txtNombreGenero.Text, txtGenreName.Text, txtUrlBackground.Text, txtUrlMusic.Text, txtUrlOculta.Text };
            foreach(String element in nonNullableStrings)
            {
                if (String.IsNullOrEmpty(element){

                    MessageBox.Show("Llena todos los campos del genero y vuelve a intentarlo", "Error al crear el Genero", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;                
                }
            }
            
            Genero spanish = new Genero(txtNombreGenero.Text, txtUrlMusic.Text, txtUrlBackground.Text, txtUrlOculta.Text, personajesRap, partidasRap, preguntasRap);
            Genero english = new Genero(txtGenreName.Text, txtUrlMusic.Text, txtUrlBackground.Text, txtUrlOculta.Text, personajesRap, partidasRap, preguntasRap);


            Console.WriteLine(spanish.ToString() + " , " + english.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

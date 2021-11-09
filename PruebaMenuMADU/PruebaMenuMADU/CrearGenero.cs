using System;
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
            FolderBrowserDialog imagePick = new FolderBrowserDialog();
            if (imagePick.ShowDialog() == DialogResult.OK)
            {
                txtUrlOculta.Text = imagePick.SelectedPath;
                Bitmap image = new Bitmap(imagePick.SelectedPath);
                pbImagenGenero.Dock = DockStyle.Fill;
                pbImagenGenero.Image = (Image)image;
            }
            
        }

        private void txtUrlOculta_TextChanged(object sender, EventArgs e)
        {

        }

        private void BntCargarFondo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog bgPick = new FolderBrowserDialog();
            if (bgPick.ShowDialog() == DialogResult.OK)
            {
                txtUrlBackground.Text = bgPick.SelectedPath;
                Bitmap image = new Bitmap(bgPick.SelectedPath);
                pbBg.Dock = DockStyle.Fill;
                pbBg.Image = (Image)image;
            }
        }

        private void btnCargarMusica_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog bgPick = new FolderBrowserDialog();
            if (bgPick.ShowDialog() == DialogResult.OK)
            {
                txtUrlBackground.Text = bgPick.SelectedPath;
                /*Bitmap image = new Bitmap(bgPick.SelectedPath);
                pbBg.Dock = DockStyle.Fill;
                pbBg.Image = (Image)image;*/
            }
        }
    }
}

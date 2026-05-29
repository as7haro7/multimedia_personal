using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                pictureBox2.Image = null;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, cargue una imagen primero.");
                return;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un filtro del menú desplegable.");
                return;
            }

            btnApply.Text = "Procesando...";
            btnApply.Enabled = false;
            Application.DoEvents();

            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            string filter = comboBox1.SelectedItem.ToString();
            Color c;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    c = bmp.GetPixel(i, j);
                    if (filter == "Rojo")
                        bmp2.SetPixel(i, j, Color.FromArgb(c.R, 0, 0));
                    else if (filter == "Verde")
                        bmp2.SetPixel(i, j, Color.FromArgb(0, c.G, 0));
                    else if (filter == "Azul")
                        bmp2.SetPixel(i, j, Color.FromArgb(0, 0, c.B));
                    else if (filter == "Escala de grises")
                    {
                        int prom = (c.R + c.G + c.B) / 3;
                        bmp2.SetPixel(i, j, Color.FromArgb(prom, prom, prom));
                    }
                    else if (filter == "Negativo")
                    {
                        bmp2.SetPixel(i, j, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                    }
                }
            }

            pictureBox2.Image = bmp2;
            btnApply.Text = "Aplicar Filtro";
            btnApply.Enabled = true;
        }
    }
}

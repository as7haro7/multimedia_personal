using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form6 : Form
    {
        public Form6()
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

        private void btnSuavizar_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, cargue una imagen primero.");
                return;
            }

            btnSuavizar.Text = "Procesando...";
            btnSuavizar.Enabled = false;
            Application.DoEvents();

            int iteraciones = (int)numIteraciones.Value;
            Bitmap bmpActual = new Bitmap(pictureBox1.Image);

            // Aplicar el filtro de suavizado la cantidad de iteraciones solicitada
            for (int iter = 0; iter < iteraciones; iter++)
            {
                bmpActual = AplicarFiltroPromedio3x3(bmpActual);
                Application.DoEvents();
            }

            pictureBox2.Image = bmpActual;
            btnSuavizar.Text = "Aplicar Suavizado";
            btnSuavizar.Enabled = true;

            string msg = "Suavizado completado.";
            if (iteraciones > 1)
                msg += " Se aplicaron " + iteraciones + " iteraciones del filtro.";
            MessageBox.Show(msg, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Aplica un filtro de promedio con ventana de 3×3 píxeles.
        /// Para cada píxel, se calcula el promedio de los 9 píxeles vecinos
        /// (incluyendo el píxel central). En los bordes de la imagen se
        /// promedian solamente los vecinos que existen dentro de los límites.
        /// </summary>
        private Bitmap AplicarFiltroPromedio3x3(Bitmap bmpOriginal)
        {
            int ancho = bmpOriginal.Width;
            int alto = bmpOriginal.Height;
            Bitmap bmpResult = new Bitmap(ancho, alto);

            // Ignoramos los bordes (empezamos en 1 y terminamos en ancho-1 / alto-1)
            // para no complicar el código con verificaciones de límites.
            for (int x = 1; x < ancho - 1; x++)
            {
                for (int y = 1; y < alto - 1; y++)
                {
                    int sumaR = 0, sumaG = 0, sumaB = 0;

                    // Recorrer la ventana de 3x3 centrada en (x, y)
                    for (int dx = -1; dx <= 1; dx++)
                    {
                        for (int dy = -1; dy <= 1; dy++)
                        {
                            Color c = bmpOriginal.GetPixel(x + dx, y + dy);
                            sumaR += c.R;
                            sumaG += c.G;
                            sumaB += c.B;
                        }
                    }

                    // Promediamos entre los 9 píxeles vecinos
                    bmpResult.SetPixel(x, y, Color.FromArgb(sumaR / 9, sumaG / 9, sumaB / 9));
                }
            }

            return bmpResult;
        }
    }
}

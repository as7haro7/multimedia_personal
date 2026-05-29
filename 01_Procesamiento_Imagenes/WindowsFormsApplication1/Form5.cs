using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        // Colores representativos para cada categoría
        private static readonly Color colorCesped = Color.FromArgb(0, 180, 0);
        private static readonly Color colorTierra = Color.FromArgb(160, 100, 40);
        private static readonly Color colorCemento = Color.FromArgb(140, 140, 140);
        private static readonly Color colorAgua = Color.FromArgb(0, 120, 255);

        public Form5()
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

        private void btnClasificar_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Por favor, cargue una imagen primero.");
                return;
            }

            btnClasificar.Text = "Procesando...";
            btnClasificar.Enabled = false;
            Application.DoEvents();

            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmpResult = new Bitmap(bmp.Width, bmp.Height);

            // Escalamos el umbral (de 5-100) para que tenga sentido como "distancia máxima" permitida (0 a 765)
            int distanciaMaxima = (int)numUmbral.Value * 5;

            // Centroides matemáticos (colores REALES aproximados en fotografías, no colores puros)
            Color centroidCesped  = Color.FromArgb(70, 120, 50);   // Verde natural oscuro/medio
            Color centroidTierra  = Color.FromArgb(130, 90, 60);   // Marrón tierra
            Color centroidCemento = Color.FromArgb(160, 160, 160); // Gris neutro medio
            Color centroidAgua    = Color.FromArgb(100, 150, 210); // Azul cielo/agua natural

            // Recorrer la imagen píxel por píxel
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color p = bmp.GetPixel(x, y);

                    // Algoritmo de Distancia Mínima usando los centroides fotográficos
                    int dCesped  = Math.Abs(p.R - centroidCesped.R)  + Math.Abs(p.G - centroidCesped.G)  + Math.Abs(p.B - centroidCesped.B);
                    int dTierra  = Math.Abs(p.R - centroidTierra.R)  + Math.Abs(p.G - centroidTierra.G)  + Math.Abs(p.B - centroidTierra.B);
                    int dCemento = Math.Abs(p.R - centroidCemento.R) + Math.Abs(p.G - centroidCemento.G) + Math.Abs(p.B - centroidCemento.B);
                    int dAgua    = Math.Abs(p.R - centroidAgua.R)    + Math.Abs(p.G - centroidAgua.G)    + Math.Abs(p.B - centroidAgua.B);

                    // Encontramos cuál es la menor distancia (a qué clase se parece más)
                    int minD = Math.Min(Math.Min(dCesped, dTierra), Math.Min(dCemento, dAgua));

                    Color colorAsignado = Color.Black; // No clasificada por defecto (Negro para máximo contraste)

                    // Si la distancia mínima es aceptable (menor que la tolerancia), asignamos esa clase
                    if (minD < distanciaMaxima)
                    {
                        if (minD == dCesped)       colorAsignado = colorCesped;
                        else if (minD == dTierra)  colorAsignado = colorTierra;
                        else if (minD == dCemento) colorAsignado = colorCemento;
                        else if (minD == dAgua)    colorAsignado = colorAgua;
                    }

                    bmpResult.SetPixel(x, y, colorAsignado);
                }
            }

            pictureBox2.Image = bmpResult;
            btnClasificar.Text = "Clasificar Texturas";
            btnClasificar.Enabled = true;
            MessageBox.Show("Clasificación completada.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

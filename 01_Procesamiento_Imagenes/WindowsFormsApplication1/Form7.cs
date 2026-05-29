using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.Image != null)
                    pictureBox1.Image.Dispose();
                if (pictureBox2.Image != null)
                    pictureBox2.Image.Dispose();

                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                pictureBox2.Image = null;
            }
        }

        private async void btnClasificar_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Cargue una imagen primero");
                return;
            }

            btnClasificar.Enabled = false;
            btnClasificar.Text = "Procesando...";

            try
            {
                Bitmap original = new Bitmap(pictureBox1.Image);

                Bitmap resultado = await Task.Run(() =>
                    ClasificarPorTextura(original));

                if (pictureBox2.Image != null)
                    pictureBox2.Image.Dispose();
                pictureBox2.Image = resultado;

                MessageBox.Show("Clasificación completada!");
            }
            finally
            {
                btnClasificar.Enabled = true;
                btnClasificar.Text = "Clasificar Texturas";
            }
        }

        private unsafe Bitmap ClasificarPorTextura(Bitmap source)
        {
            int width = source.Width;
            int height = source.Height;
            int radio = 3; // Ventana de 7x7 para análisis de textura

            Bitmap result = new Bitmap(width, height);

            // Paso 1: Calcular características de textura para cada píxel
            byte[,] varianzaMap = new byte[width, height];
            byte[,] brilloMap = new byte[width, height];

            BitmapData srcData = source.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

            try
            {
                byte* srcPtr = (byte*)srcData.Scan0;
                int stride = srcData.Stride;

                // Calcular varianza local y brillo para cada píxel
                for (int y = radio; y < height - radio; y++)
                {
                    for (int x = radio; x < width - radio; x++)
                    {
                        // Calcular varianza en ventana local
                        double varianza = CalcularVarianzaLocal(srcPtr, stride, x, y, radio);
                        byte brillo = CalcularBrilloPromedio(srcPtr, stride, x, y, radio);

                        varianzaMap[x, y] = (byte)Math.Min(255, varianza);
                        brilloMap[x, y] = brillo;
                    }
                }
            }
            finally
            {
                source.UnlockBits(srcData);
            }

            // Paso 2: Clasificar basado en textura + color
            BitmapData dstData = result.LockBits(
                new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            try
            {
                byte* dstPtr = (byte*)dstData.Scan0;
                int stride = dstData.Stride;

                for (int y = 0; y < height; y++)
                {
                    byte* rowPtr = dstPtr + y * stride;

                    for (int x = 0; x < width; x++)
                    {
                        Color clasificado;

                        if (y < radio || y >= height - radio || x < radio || x >= width - radio)
                        {
                            // Bordes: clasificación simple
                            clasificado = Color.Black;
                        }
                        else
                        {
                            // Clasificar usando textura y color
                            clasificado = ClasificarConTextura(
                                source, x, y,
                                varianzaMap[x, y],
                                brilloMap[x, y]);
                        }

                        rowPtr[x * 3] = clasificado.B;
                        rowPtr[x * 3 + 1] = clasificado.G;
                        rowPtr[x * 3 + 2] = clasificado.R;
                    }
                }
            }
            finally
            {
                result.UnlockBits(dstData);
            }

            return result;
        }

        private unsafe double CalcularVarianzaLocal(byte* ptr, int stride, int cx, int cy, int radio)
        {
            double suma = 0;
            double sumaCuadrados = 0;
            int total = 0;

            for (int dy = -radio; dy <= radio; dy++)
            {
                byte* rowPtr = ptr + (cy + dy) * stride;

                for (int dx = -radio; dx <= radio; dx++)
                {
                    int offset = (cx + dx) * 3;
                    // Usar escala de grises
                    byte gris = (byte)((rowPtr[offset + 2] + rowPtr[offset + 1] + rowPtr[offset]) / 3);

                    suma += gris;
                    sumaCuadrados += gris * gris;
                    total++;
                }
            }

            double media = suma / total;
            double varianza = (sumaCuadrados / total) - (media * media);

            return Math.Sqrt(varianza); // Desviación estándar
        }

        private unsafe byte CalcularBrilloPromedio(byte* ptr, int stride, int cx, int cy, int radio)
        {
            double suma = 0;
            int total = 0;

            for (int dy = -radio; dy <= radio; dy++)
            {
                byte* rowPtr = ptr + (cy + dy) * stride;

                for (int dx = -radio; dx <= radio; dx++)
                {
                    int offset = (cx + dx) * 3;
                    byte gris = (byte)((rowPtr[offset + 2] + rowPtr[offset + 1] + rowPtr[offset]) / 3);
                    suma += gris;
                    total++;
                }
            }

            return (byte)(suma / total);
        }

        private Color ClasificarConTextura(Bitmap bmp, int x, int y, byte varianza, byte brillo)
        {
            // Obtener color del píxel central
            Color pixel = bmp.GetPixel(x, y);
            int height = bmp.Height;

            // =====================================================
            // CLASIFICACIÓN POR TEXTURA + COLOR
            // =====================================================

            // 1. CIELO: Parte superior + azul + textura variable (nubes)
            if (y < height * 0.30 && pixel.B > pixel.R + 50)
            {
                return Color.FromArgb(0, 120, 255); // Azul
            }

            // 2. AGUA: Superficie MUY lisa (varianza baja) + azul/cyan
            if (varianza < 15 && pixel.B > pixel.R + 30)
            {
                return Color.FromArgb(0, 120, 255); // Azul agua
            }

            // 3. CEMENTO/CONCRETO: Superficie lisa (varianza baja) + gris
            if (varianza < 20 && EsGris(pixel))
            {
                if (brillo > 150)
                    return Color.FromArgb(140, 140, 140); // Cemento claro
                else
                    return Color.FromArgb(80, 80, 85); // Asfalto/concreto oscuro
            }

            // 4. CÉSPED: Textura media-alta + verde dominante
            if (varianza > 15 && pixel.G > pixel.R + 30 && pixel.G > pixel.B + 30)
            {
                return Color.FromArgb(0, 180, 0); // Verde
            }

            // 5. TIERRA: Textura media + marrón/rojizo
            if (varianza > 10 && pixel.R > pixel.B + 20 && pixel.R >= pixel.G - 20)
            {
                return Color.FromArgb(160, 100, 40); // Marrón
            }

            // 6. Por defecto: según color dominante si no hay textura clara
            if (pixel.G > pixel.R + 20)
                return Color.FromArgb(0, 180, 0); // Verde (césped)
            else if (EsGris(pixel))
                return Color.FromArgb(140, 140, 140); // Gris (cemento)
            else if (pixel.B > pixel.R + 40)
                return Color.FromArgb(0, 120, 255); // Azul (agua/cielo)

            return Color.Black; // No clasificado
        }

        private bool EsGris(Color c)
        {
            int diff = Math.Max(c.R, Math.Max(c.G, c.B)) - Math.Min(c.R, Math.Min(c.G, c.B));
            return diff < 30; // Baja saturación = gris
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
            if (pictureBox2.Image != null)
            {
                pictureBox2.Image.Dispose();
                pictureBox2.Image = null;
            }
            base.OnFormClosing(e);
        }
    }
}
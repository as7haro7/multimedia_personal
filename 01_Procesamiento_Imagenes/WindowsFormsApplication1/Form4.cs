using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        private class TexturaData
        {
            public int R { get; set; }
            public int G { get; set; }
            public int B { get; set; }
            public string Descripcion { get; set; }
        }

        private int ventana = 10;
        private Dictionary<string, Color> coloresZonas = new Dictionary<string, Color>();
        private readonly Color[] paleta = { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Cyan, Color.Magenta, Color.Orange, Color.Purple };
        private int paletaIndex = 0;

        public Form4()
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

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null) return;
            if (string.IsNullOrEmpty(txtCategoria.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre de la textura a guardar antes de hacer clic en la imagen.");
                return;
            }

            Bitmap bmp = new Bitmap(pictureBox1.Image);

            int cwR = 0, cwG = 0, cwB = 0;
            int limitX = Math.Min(e.X + (ventana / 2), bmp.Width);
            int limitY = Math.Min(e.Y + (ventana / 2), bmp.Height);
            int startX = Math.Max(e.X - (ventana / 2), 0);
            int startY = Math.Max(e.Y - (ventana / 2), 0);
            int count = 0;

            for (int i = startX; i < limitX; i++)
            {
                for (int j = startY; j < limitY; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    cwR += color.R;
                    cwG += color.G;
                    cwB += color.B;
                    count++;
                }
            }
            if (count > 0)
            {
                cwR /= count;
                cwG /= count;
                cwB /= count;
            }

            GuardarTexturaBD(cwR, cwG, cwB, txtCategoria.Text);
        }

        private void GuardarTexturaBD(int r, int g, int b, string descripcion)
        {
            string conexion = "server=.\\SQLEXPRESS;database=texturas;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(conexion))
            {
                string sql = "INSERT INTO texturas (r, g, b, descripcion) VALUES (@r, @g, @b, @desc)";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@r", r);
                    cmd.Parameters.AddWithValue("@g", g);
                    cmd.Parameters.AddWithValue("@b", b);
                    cmd.Parameters.AddWithValue("@desc", descripcion);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        lblStatus.Text = "Textura guardada: " + descripcion;
                        txtCategoria.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error BD: " + ex.Message);
                    }
                }
            }
        }

        private void btnDetectar_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Cargue una imagen primero.");
                return;
            }

            btnDetectar.Text = "Procesando...";
            btnDetectar.Enabled = false;
            Application.DoEvents();

            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
            
            // Cargar texturas de la BD
            List<TexturaData> texturasBD = new List<TexturaData>();
            string conexion = "server=.\\SQLEXPRESS;database=texturas;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(conexion))
            {
                string query = "SELECT r, g, b, descripcion FROM texturas";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int dbR = Convert.ToInt32(reader["r"]);
                                int dbG = Convert.ToInt32(reader["g"]);
                                int dbB = Convert.ToInt32(reader["b"]);
                                string desc = reader["descripcion"].ToString();
                                
                                TexturaData td = new TexturaData();
                                td.R = dbR; td.G = dbG; td.B = dbB; td.Descripcion = desc;
                                texturasBD.Add(td);
                                
                                // Asignar color uniforme representativo si no existe en el diccionario
                                if (!coloresZonas.ContainsKey(desc))
                                {
                                    string dLower = desc.ToLower();
                                    if (dLower.Contains("agua") || dLower.Contains("cielo"))
                                        coloresZonas[desc] = Color.FromArgb(0, 120, 255); // azul
                                    else if (dLower.Contains("vegetacion") || dLower.Contains("pasto"))
                                        coloresZonas[desc] = Color.FromArgb(0, 180, 0); // verde
                                    else if (dLower.Contains("tierra") || dLower.Contains("edificio"))
                                        coloresZonas[desc] = Color.FromArgb(139, 90, 43); // marrón
                                    else
                                    {
                                        coloresZonas[desc] = paleta[paletaIndex % paleta.Length];
                                        paletaIndex++;
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error BD: " + ex.Message);
                        btnDetectar.Text = "Detectar Texturas";
                        btnDetectar.Enabled = true;
                        return;
                    }
                }
            }

            int cRm, cGm, cBm;
            int umbral = 35; // Tolerancia

            for (int i = 0; i < bmp.Width - ventana; i += ventana)
            {
                for (int j = 0; j < bmp.Height - ventana; j += ventana)
                {
                    cRm = 0; cGm = 0; cBm = 0;
                    
                    for (int k = i; k < i + ventana; k++)
                    {
                        for (int l = j; l < j + ventana; l++)
                        {
                            // Validación por si hay recortes al borde inferior/derecho exacto
                            if (k < bmp.Width && l < bmp.Height)
                            {
                                Color c = bmp.GetPixel(k, l);
                                cRm += c.R;
                                cGm += c.G;
                                cBm += c.B;
                            }
                        }
                    }
                    cRm /= (ventana * ventana);
                    cGm /= (ventana * ventana);
                    cBm /= (ventana * ventana);

                    bool encontrado = false;
                    Color colorReconocido = Color.Black;

                    foreach (var tx in texturasBD)
                    {
                        if (Math.Abs(cRm - tx.R) < umbral && 
                            Math.Abs(cGm - tx.G) < umbral && 
                            Math.Abs(cBm - tx.B) < umbral)
                        {
                            encontrado = true;
                            colorReconocido = coloresZonas[tx.Descripcion];
                            break;
                        }
                    }

                    for (int k = i; k < i + ventana; k++)
                    {
                        for (int l = j; l < j + ventana; l++)
                        {
                            if (k < bmp.Width && l < bmp.Height)
                            {
                                if (encontrado)
                                {
                                    bmp2.SetPixel(k, l, colorReconocido);
                                }
                                else
                                {
                                    Color c = bmp.GetPixel(k, l);
                                    int prom = (c.R + c.G + c.B) / 3;
                                    bmp2.SetPixel(k, l, Color.FromArgb(prom, prom, prom));
                                }
                            }
                        }
                    }
                }
            }

            // Para los bordes que no entran en ventanas de 10x10, pintar de gris
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    if (i >= bmp.Width - (bmp.Width % ventana) || j >= bmp.Height - (bmp.Height % ventana))
                    {
                        Color c = bmp.GetPixel(i, j);
                        int prom = (c.R + c.G + c.B) / 3;
                        bmp2.SetPixel(i, j, Color.FromArgb(prom, prom, prom));
                    }
                }
            }

            pictureBox2.Image = bmp2;
            btnDetectar.Text = "Detectar Texturas";
            btnDetectar.Enabled = true;
            MessageBox.Show("Detección Completada.");
        }
    }
}

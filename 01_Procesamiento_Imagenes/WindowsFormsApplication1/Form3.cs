using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        private bool modoReconocer = false;
        private int ventana = 10;
        private Dictionary<string, int> conteoReconocimientos = new Dictionary<string, int>();

        public Form3()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void btnToggleModo_Click(object sender, EventArgs e)
        {
            modoReconocer = !modoReconocer;
            if (modoReconocer)
            {
                btnToggleModo.Text = "Modo: RECONOCER ZONA";
                btnToggleModo.BackColor = Color.LightGreen;
                txtCategoria.Enabled = false;
            }
            else
            {
                btnToggleModo.Text = "Modo: GUARDAR MUESTRA";
                btnToggleModo.BackColor = Color.LightCoral;
                txtCategoria.Enabled = true;
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null) return;
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

            if (!modoReconocer)
            {
                if (string.IsNullOrEmpty(txtCategoria.Text))
                {
                    MessageBox.Show("Por favor, ingrese un nombre de categoría antes de hacer clic para guardar.");
                    return;
                }
                GuardarMuestraBD(cwR, cwG, cwB, txtCategoria.Text);
            }
            else
            {
                ReconocerZonaBD(cwR, cwG, cwB);
            }
        }

        private void GuardarMuestraBD(int r, int g, int b, string descripcion)
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
                        lblStatus.Text = "Guardado en BD: " + descripcion;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error BD: " + ex.Message);
                    }
                }
            }
        }

        private void ReconocerZonaBD(int cR, int cG, int cB)
        {
            string conexion = "server=.\\SQLEXPRESS;database=texturas;Integrated Security=True;";
            string identificada = "Desconocida";
            
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
                                
                                int umbral = 25; // Algo de margen de tolerancia
                                if (Math.Abs(cR - dbR) < umbral && Math.Abs(cG - dbG) < umbral && Math.Abs(cB - dbB) < umbral)
                                {
                                    identificada = desc;
                                    break;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error BD: " + ex.Message);
                        return;
                    }
                }
            }

            lblStatus.Text = "Zona reconocida: " + identificada;

            if (identificada != "Desconocida")
            {
                if (conteoReconocimientos.ContainsKey(identificada))
                    conteoReconocimientos[identificada]++;
                else
                    conteoReconocimientos[identificada] = 1;
                    
                MostrarConteoCategorias();
            }
        }

        private void MostrarConteoCategorias()
        {
            string mensaje = "Conteo de Coincidencias por Categoría (Historial):\n\n";
            foreach (var item in conteoReconocimientos)
            {
                mensaje += "- " + item.Key + ": " + item.Value + " veces\n";
            }
            MessageBox.Show(mensaje, "Estadísticas de Reconocimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

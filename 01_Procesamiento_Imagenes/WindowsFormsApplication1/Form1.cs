using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void btnForm4_Click(object sender, EventArgs e)
        {
            // Try to load Form4. If not available, we need to create it.
            try {
                // By using Reflection we could avoid compiler errors if not added yet
                // but since we will create Form4 before compiling, we just call it.
                Form4 f4 = new Form4();
                f4.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Formulario 4 (Ejercicio 5) no disponible aún.");
            }
        }

        private void btnForm5_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void btnForm6_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void btnForm7_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}

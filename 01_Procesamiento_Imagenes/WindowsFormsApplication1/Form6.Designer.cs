namespace WindowsFormsApplication1
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSuavizar = new System.Windows.Forms.Button();
            this.numIteraciones = new System.Windows.Forms.NumericUpDown();
            this.lblIteraciones = new System.Windows.Forms.Label();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.lblSuavizada = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIteraciones)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(422, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 350);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(12, 390);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 35);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Cargar Imagen";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSuavizar
            // 
            this.btnSuavizar.BackColor = System.Drawing.Color.Black;
            this.btnSuavizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuavizar.FlatAppearance.BorderSize = 0;
            this.btnSuavizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnSuavizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuavizar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuavizar.ForeColor = System.Drawing.Color.White;
            this.btnSuavizar.Location = new System.Drawing.Point(523, 390);
            this.btnSuavizar.Name = "btnSuavizar";
            this.btnSuavizar.Size = new System.Drawing.Size(180, 40);
            this.btnSuavizar.TabIndex = 3;
            this.btnSuavizar.Text = "Aplicar Suavizado";
            this.btnSuavizar.UseVisualStyleBackColor = false;
            this.btnSuavizar.Click += new System.EventHandler(this.btnSuavizar_Click);
            // 
            // numIteraciones
            // 
            this.numIteraciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numIteraciones.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numIteraciones.Location = new System.Drawing.Point(230, 392);
            this.numIteraciones.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numIteraciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIteraciones.Name = "numIteraciones";
            this.numIteraciones.Size = new System.Drawing.Size(55, 25);
            this.numIteraciones.TabIndex = 4;
            this.numIteraciones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblIteraciones
            // 
            this.lblIteraciones.AutoSize = true;
            this.lblIteraciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIteraciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblIteraciones.Location = new System.Drawing.Point(155, 396);
            this.lblIteraciones.Name = "lblIteraciones";
            this.lblIteraciones.Size = new System.Drawing.Size(67, 15);
            this.lblIteraciones.TabIndex = 5;
            this.lblIteraciones.Text = "Iteraciones:";
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblOriginal.Location = new System.Drawing.Point(130, 8);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(93, 15);
            this.lblOriginal.TabIndex = 20;
            this.lblOriginal.Text = "Imagen Original";
            // 
            // lblSuavizada
            // 
            this.lblSuavizada.AutoSize = true;
            this.lblSuavizada.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuavizada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblSuavizada.Location = new System.Drawing.Point(530, 8);
            this.lblSuavizada.Name = "lblSuavizada";
            this.lblSuavizada.Size = new System.Drawing.Size(105, 15);
            this.lblSuavizada.TabIndex = 21;
            this.lblSuavizada.Text = "Imagen Suavizada";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 470);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.lblSuavizada);
            this.Controls.Add(this.numIteraciones);
            this.Controls.Add(this.lblIteraciones);
            this.Controls.Add(this.btnSuavizar);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro de Suavizado - Promedio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIteraciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSuavizar;
        private System.Windows.Forms.NumericUpDown numIteraciones;
        private System.Windows.Forms.Label lblIteraciones;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Label lblSuavizada;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

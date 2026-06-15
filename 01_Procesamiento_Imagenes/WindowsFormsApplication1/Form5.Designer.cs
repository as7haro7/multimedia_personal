namespace WindowsFormsApplication1
{
    partial class Form5
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClasificar = new System.Windows.Forms.Button();
            this.numUmbral = new System.Windows.Forms.NumericUpDown();
            this.lblUmbral = new System.Windows.Forms.Label();
            this.panelLeyenda = new System.Windows.Forms.Panel();
            this.lblLeyendaTitulo = new System.Windows.Forms.Label();
            this.panelColorCesped = new System.Windows.Forms.Panel();
            this.lblCesped = new System.Windows.Forms.Label();
            this.panelColorTierra = new System.Windows.Forms.Panel();
            this.lblTierra = new System.Windows.Forms.Label();
            this.panelColorCemento = new System.Windows.Forms.Panel();
            this.lblCemento = new System.Windows.Forms.Label();
            this.panelColorAgua = new System.Windows.Forms.Panel();
            this.lblAgua = new System.Windows.Forms.Label();
            this.panelColorNC = new System.Windows.Forms.Panel();
            this.lblNoClasificada = new System.Windows.Forms.Label();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.lblClasificada = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUmbral)).BeginInit();
            this.panelLeyenda.SuspendLayout();
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
            this.btnLoad.Location = new System.Drawing.Point(115, 384);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 35);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Cargar Imagen";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClasificar
            // 
            this.btnClasificar.BackColor = System.Drawing.Color.Black;
            this.btnClasificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClasificar.FlatAppearance.BorderSize = 0;
            this.btnClasificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnClasificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClasificar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasificar.ForeColor = System.Drawing.Color.White;
            this.btnClasificar.Location = new System.Drawing.Point(523, 386);
            this.btnClasificar.Name = "btnClasificar";
            this.btnClasificar.Size = new System.Drawing.Size(180, 40);
            this.btnClasificar.TabIndex = 3;
            this.btnClasificar.Text = "Clasificar Texturas";
            this.btnClasificar.UseVisualStyleBackColor = false;
            this.btnClasificar.Click += new System.EventHandler(this.btnClasificar_Click);
            // 
            // numUmbral
            // 
            this.numUmbral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUmbral.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUmbral.Location = new System.Drawing.Point(387, 425);
            this.numUmbral.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUmbral.Name = "numUmbral";
            this.numUmbral.Size = new System.Drawing.Size(60, 25);
            this.numUmbral.TabIndex = 4;
            this.numUmbral.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblUmbral
            // 
            this.lblUmbral.AutoSize = true;
            this.lblUmbral.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUmbral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblUmbral.Location = new System.Drawing.Point(322, 429);
            this.lblUmbral.Name = "lblUmbral";
            this.lblUmbral.Size = new System.Drawing.Size(59, 15);
            this.lblUmbral.TabIndex = 5;
            this.lblUmbral.Text = "tolerancia";
            // 
            // panelLeyenda
            // 
            this.panelLeyenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panelLeyenda.Controls.Add(this.lblLeyendaTitulo);
            this.panelLeyenda.Controls.Add(this.panelColorCesped);
            this.panelLeyenda.Controls.Add(this.lblCesped);
            this.panelLeyenda.Controls.Add(this.panelColorTierra);
            this.panelLeyenda.Controls.Add(this.lblTierra);
            this.panelLeyenda.Controls.Add(this.panelColorCemento);
            this.panelLeyenda.Controls.Add(this.lblCemento);
            this.panelLeyenda.Controls.Add(this.panelColorAgua);
            this.panelLeyenda.Controls.Add(this.lblAgua);
            this.panelLeyenda.Controls.Add(this.panelColorNC);
            this.panelLeyenda.Controls.Add(this.lblNoClasificada);
            this.panelLeyenda.Location = new System.Drawing.Point(12, 480);
            this.panelLeyenda.Name = "panelLeyenda";
            this.panelLeyenda.Size = new System.Drawing.Size(760, 50);
            this.panelLeyenda.TabIndex = 10;
            // 
            // lblLeyendaTitulo
            // 
            this.lblLeyendaTitulo.AutoSize = true;
            this.lblLeyendaTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyendaTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblLeyendaTitulo.Location = new System.Drawing.Point(5, 5);
            this.lblLeyendaTitulo.Name = "lblLeyendaTitulo";
            this.lblLeyendaTitulo.Size = new System.Drawing.Size(54, 15);
            this.lblLeyendaTitulo.TabIndex = 0;
            this.lblLeyendaTitulo.Text = "Leyenda:";
            // 
            // panelColorCesped
            // 
            this.panelColorCesped.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.panelColorCesped.Location = new System.Drawing.Point(5, 25);
            this.panelColorCesped.Name = "panelColorCesped";
            this.panelColorCesped.Size = new System.Drawing.Size(16, 16);
            this.panelColorCesped.TabIndex = 1;
            // 
            // lblCesped
            // 
            this.lblCesped.AutoSize = true;
            this.lblCesped.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCesped.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblCesped.Location = new System.Drawing.Point(24, 26);
            this.lblCesped.Name = "lblCesped";
            this.lblCesped.Size = new System.Drawing.Size(112, 13);
            this.lblCesped.TabIndex = 2;
            this.lblCesped.Text = "Césped / Vegetación";
            // 
            // panelColorTierra
            // 
            this.panelColorTierra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))));
            this.panelColorTierra.Location = new System.Drawing.Point(145, 25);
            this.panelColorTierra.Name = "panelColorTierra";
            this.panelColorTierra.Size = new System.Drawing.Size(16, 16);
            this.panelColorTierra.TabIndex = 3;
            // 
            // lblTierra
            // 
            this.lblTierra.AutoSize = true;
            this.lblTierra.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTierra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTierra.Location = new System.Drawing.Point(164, 26);
            this.lblTierra.Name = "lblTierra";
            this.lblTierra.Size = new System.Drawing.Size(36, 13);
            this.lblTierra.TabIndex = 4;
            this.lblTierra.Text = "Tierra";
            // 
            // panelColorCemento
            // 
            this.panelColorCemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.panelColorCemento.Location = new System.Drawing.Point(265, 25);
            this.panelColorCemento.Name = "panelColorCemento";
            this.panelColorCemento.Size = new System.Drawing.Size(16, 16);
            this.panelColorCemento.TabIndex = 5;
            // 
            // lblCemento
            // 
            this.lblCemento.AutoSize = true;
            this.lblCemento.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCemento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblCemento.Location = new System.Drawing.Point(284, 26);
            this.lblCemento.Name = "lblCemento";
            this.lblCemento.Size = new System.Drawing.Size(99, 13);
            this.lblCemento.TabIndex = 6;
            this.lblCemento.Text = "Cemento / Asfalto";
            // 
            // panelColorAgua
            // 
            this.panelColorAgua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.panelColorAgua.Location = new System.Drawing.Point(410, 25);
            this.panelColorAgua.Name = "panelColorAgua";
            this.panelColorAgua.Size = new System.Drawing.Size(16, 16);
            this.panelColorAgua.TabIndex = 7;
            // 
            // lblAgua
            // 
            this.lblAgua.AutoSize = true;
            this.lblAgua.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblAgua.Location = new System.Drawing.Point(429, 26);
            this.lblAgua.Name = "lblAgua";
            this.lblAgua.Size = new System.Drawing.Size(70, 13);
            this.lblAgua.TabIndex = 8;
            this.lblAgua.Text = "Agua / Cielo";
            // 
            // panelColorNC
            // 
            this.panelColorNC.BackColor = System.Drawing.Color.Black;
            this.panelColorNC.Location = new System.Drawing.Point(540, 25);
            this.panelColorNC.Name = "panelColorNC";
            this.panelColorNC.Size = new System.Drawing.Size(16, 16);
            this.panelColorNC.TabIndex = 9;
            // 
            // lblNoClasificada
            // 
            this.lblNoClasificada.AutoSize = true;
            this.lblNoClasificada.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoClasificada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblNoClasificada.Location = new System.Drawing.Point(559, 26);
            this.lblNoClasificada.Name = "lblNoClasificada";
            this.lblNoClasificada.Size = new System.Drawing.Size(78, 13);
            this.lblNoClasificada.TabIndex = 10;
            this.lblNoClasificada.Text = "No clasificada";
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
            // lblClasificada
            // 
            this.lblClasificada.AutoSize = true;
            this.lblClasificada.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasificada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblClasificada.Location = new System.Drawing.Point(530, 8);
            this.lblClasificada.Name = "lblClasificada";
            this.lblClasificada.Size = new System.Drawing.Size(107, 15);
            this.lblClasificada.TabIndex = 21;
            this.lblClasificada.Text = "Imagen Clasificada";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 581);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.lblClasificada);
            this.Controls.Add(this.numUmbral);
            this.Controls.Add(this.lblUmbral);
            this.Controls.Add(this.btnClasificar);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelLeyenda);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clasificación de Texturas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUmbral)).EndInit();
            this.panelLeyenda.ResumeLayout(false);
            this.panelLeyenda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClasificar;
        private System.Windows.Forms.NumericUpDown numUmbral;
        private System.Windows.Forms.Label lblUmbral;
        private System.Windows.Forms.Panel panelLeyenda;
        private System.Windows.Forms.Label lblLeyendaTitulo;
        private System.Windows.Forms.Label lblCesped;
        private System.Windows.Forms.Label lblTierra;
        private System.Windows.Forms.Label lblCemento;
        private System.Windows.Forms.Label lblAgua;
        private System.Windows.Forms.Label lblNoClasificada;
        private System.Windows.Forms.Panel panelColorCesped;
        private System.Windows.Forms.Panel panelColorTierra;
        private System.Windows.Forms.Panel panelColorCemento;
        private System.Windows.Forms.Panel panelColorAgua;
        private System.Windows.Forms.Panel panelColorNC;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Label lblClasificada;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.btnForm5 = new System.Windows.Forms.Button();
            this.btnForm6 = new System.Windows.Forms.Button();
            this.btnForm7 = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnForm5
            // 
            this.btnForm5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnForm5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForm5.FlatAppearance.BorderSize = 0;
            this.btnForm5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnForm5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForm5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnForm5.Location = new System.Drawing.Point(33, 77);
            this.btnForm5.Name = "btnForm5";
            this.btnForm5.Size = new System.Drawing.Size(200, 45);
            this.btnForm5.TabIndex = 4;
            this.btnForm5.Text = "Clasificación Texturas";
            this.btnForm5.UseVisualStyleBackColor = false;
            this.btnForm5.Click += new System.EventHandler(this.btnForm5_Click);
            // 
            // btnForm6
            // 
            this.btnForm6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnForm6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForm6.FlatAppearance.BorderSize = 0;
            this.btnForm6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnForm6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForm6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnForm6.Location = new System.Drawing.Point(33, 137);
            this.btnForm6.Name = "btnForm6";
            this.btnForm6.Size = new System.Drawing.Size(200, 45);
            this.btnForm6.TabIndex = 5;
            this.btnForm6.Text = "Filtro Suavizado 3x3";
            this.btnForm6.UseVisualStyleBackColor = false;
            this.btnForm6.Click += new System.EventHandler(this.btnForm6_Click);
            // 
            // btnForm7
            // 
            this.btnForm7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnForm7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForm7.FlatAppearance.BorderSize = 0;
            this.btnForm7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnForm7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForm7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnForm7.Location = new System.Drawing.Point(33, 197);
            this.btnForm7.Name = "btnForm7";
            this.btnForm7.Size = new System.Drawing.Size(200, 45);
            this.btnForm7.TabIndex = 6;
            this.btnForm7.Text = "Clasificación Índices";
            this.btnForm7.UseVisualStyleBackColor = false;
            this.btnForm7.Click += new System.EventHandler(this.btnForm7_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.labelTitulo.Location = new System.Drawing.Point(103, 27);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(67, 30);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Menu";
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(280, 277);
            this.Controls.Add(this.btnForm5);
            this.Controls.Add(this.btnForm6);
            this.Controls.Add(this.btnForm7);
            this.Controls.Add(this.labelTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Multimedia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button btnForm5;
        private System.Windows.Forms.Button btnForm6;
        private System.Windows.Forms.Button btnForm7;
        private System.Windows.Forms.Label labelTitulo;
    }
}

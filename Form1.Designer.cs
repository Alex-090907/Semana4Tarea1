namespace Semana4Tarea1
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblEstado = new Label();
            txtDigitos = new TextBox();
            pnlImagenes = new Panel();
            picImagen = new PictureBox();
            btnTimer = new Button();
            lblTimer = new Label();
            timer = new System.Windows.Forms.Timer(components);
            pnlImagenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagen).BeginInit();
            SuspendLayout();
            // 
            // lblEstado
            // 
            lblEstado.BorderStyle = BorderStyle.FixedSingle;
            lblEstado.Location = new Point(20, 20);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(440, 30);
            lblEstado.TabIndex = 0;
            lblEstado.Text = "Haz clic aquí";
            lblEstado.TextAlign = ContentAlignment.MiddleCenter;
            lblEstado.Click += lblEstado_Click;
            // 
            // txtDigitos
            // 
            txtDigitos.Location = new Point(20, 70);
            txtDigitos.Name = "txtDigitos";
            txtDigitos.PlaceholderText = "Solo números";
            txtDigitos.Size = new Size(440, 23);
            txtDigitos.TabIndex = 1;
            txtDigitos.KeyPress += txtDigitos_KeyPress;
            // 
            // pnlImagenes
            // 
            pnlImagenes.AllowDrop = true;
            pnlImagenes.BackColor = Color.WhiteSmoke;
            pnlImagenes.BorderStyle = BorderStyle.FixedSingle;
            pnlImagenes.Controls.Add(picImagen);
            pnlImagenes.Location = new Point(20, 115);
            pnlImagenes.Name = "pnlImagenes";
            pnlImagenes.Size = new Size(440, 220);
            pnlImagenes.TabIndex = 2;
            pnlImagenes.DragDrop += pnlImagenes_DragDrop;
            pnlImagenes.DragEnter += pnlImagenes_DragEnter;
            // 
            // picImagen
            // 
            picImagen.Dock = DockStyle.Fill;
            picImagen.Location = new Point(0, 0);
            picImagen.Name = "picImagen";
            picImagen.Size = new Size(438, 218);
            picImagen.SizeMode = PictureBoxSizeMode.Zoom;
            picImagen.TabIndex = 0;
            picImagen.TabStop = false;
            // 
            // btnTimer
            // 
            btnTimer.Location = new Point(20, 355);
            btnTimer.Name = "btnTimer";
            btnTimer.Size = new Size(150, 35);
            btnTimer.TabIndex = 3;
            btnTimer.Text = "Iniciar Timer";
            btnTimer.UseVisualStyleBackColor = true;
            btnTimer.Click += btnTimer_Click;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Location = new Point(190, 363);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(70, 15);
            lblTimer.TabIndex = 4;
            lblTimer.Text = "Segundos: 0";
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 411);
            Controls.Add(lblTimer);
            Controls.Add(btnTimer);
            Controls.Add(pnlImagenes);
            Controls.Add(txtDigitos);
            Controls.Add(lblEstado);
            Name = "Form1";
            Text = "Semana 4 - Tarea 1";
            pnlImagenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEstado;
        private TextBox txtDigitos;
        private Panel pnlImagenes;
        private PictureBox picImagen;
        private Button btnTimer;
        private Label lblTimer;
        private System.Windows.Forms.Timer timer;
    }
}
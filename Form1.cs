using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Semana4Tarea1
{
    public partial class Form1 : Form
    {
        private int segundos = 0;
        private int clicks = 0;

        public Form1()
        {
            InitializeComponent();

            // Ejemplo de += con lambda (documentar en el README)
            lblEstado.MouseEnter += (s, e) => lblEstado.Cursor = Cursors.Hand;
        }

        // Label: cambia al Click
        private void lblEstado_Click(object sender, EventArgs e)
        {
            clicks++;
            lblEstado.Text = $"Clic número {clicks}";
            lblEstado.BackColor = clicks % 2 == 0 ? Color.LightGreen : Color.LightSkyBlue;
        }

        // TextBox: solo dígitos
        private void txtDigitos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Panel: DragEnter
        private void pnlImagenes_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        // Panel: DragDrop
        private void pnlImagenes_DragDrop(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);
            string ext = Path.GetExtension(archivos[0]).ToLower();

            if (ext == ".png" || ext == ".jpg" || ext == ".jpeg" || ext == ".bmp" || ext == ".gif")
                picImagen.Image = Image.FromFile(archivos[0]);
            else
                MessageBox.Show("Solo se aceptan imágenes.");
        }

        // Button: arranca / detiene el Timer
        private void btnTimer_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                btnTimer.Text = "Iniciar Timer";
            }
            else
            {
                timer.Start();
                btnTimer.Text = "Detener Timer";
            }
        }

        // Timer: cada segundo
        private void timer_Tick(object sender, EventArgs e)
        {
            segundos++;
            lblTimer.Text = $"Segundos: {segundos}";
        }
    }
}
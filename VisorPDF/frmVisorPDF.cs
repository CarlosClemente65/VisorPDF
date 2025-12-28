using System.Runtime.InteropServices;


namespace VisorPDF
{
    public partial class frmVisorPDF : Form
    {
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(
            IntPtr hWnd,
            int msg,
            IntPtr wParam,
            IntPtr lParam);

        // Constantes para mover la ventana
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        // Constantes para los bordes de la ventana
        private const int HTRIGHT = 11;



        public frmVisorPDF()
        {
            InitializeComponent();
            this.Cursor = Cursors.Default;
            this.TopMost = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFijar_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            this.btnFijar.Image = this.TopMost ? Properties.Resources.Activo : Properties.Resources.Inactivo;
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            // Doble clic para maximizar/restaurar
            if (e.Clicks == 2)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                }

                return;
            }

            // Clic simple para mover la 
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HTCAPTION, IntPtr.Zero);
        }

        private void pnlDerecho_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(
                    this.Handle,
                    WM_NCLBUTTONDOWN,
                    (IntPtr)HTRIGHT,
                    IntPtr.Zero
                );
            }
        }

        //private void pnlDerecho_MouseUp(object sender, MouseEventArgs e)
        //{
        //    this.Cursor = Cursors.Default;
        //}

        //private void pnlDerecho_MouseLeave(object sender, EventArgs e)
        //{
        //    this.Cursor = Cursors.Default;
        //}
    }
}

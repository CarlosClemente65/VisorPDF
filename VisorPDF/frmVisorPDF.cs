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
        private const int HTLEFT = 10;
        private const int HTTOP = 12;
        private const int HTBOTTOM = 15;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;

        // Variables para controlar el cursor en los bordes
        const int MARGEN_ESQUINA = 10;
        private Cursor cursorRedimension;
        private bool redimensionando = false;



        public frmVisorPDF()
        {
            InitializeComponent();
            this.TopMost = true;

            // Creamos un ToolTip (si no lo añadiste desde el diseñador)
            ToolTip toolTip1 = new ToolTip();

            // Opcional: configuraciones generales del tooltip
            toolTip1.AutoPopDelay = 3000;   // tiempo que se muestra
            toolTip1.InitialDelay = 200;    // tiempo antes de aparecer
            toolTip1.ReshowDelay = 100;     // tiempo entre reapariciones
            toolTip1.ShowAlways = true;     // se muestra aunque el formulario no esté activo

            // Asignamos el texto de ayuda a cada botón
            toolTip1.SetToolTip(btnPrimero, "Primera página");
            toolTip1.SetToolTip(btnUltimo, "Ultima página");
            toolTip1.SetToolTip(btnAvance, "Página siguiente");
            toolTip1.SetToolTip(btnRetroceso, "Página anterior");
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


        // Manejo del panel de título para mover y maximizar/restaurar
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

            // Clic normal para mover la ventana
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HTCAPTION, IntPtr.Zero);
        }


        #region Redimensionamiento de borde derecho
        private void pnlDerecho_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            ReleaseCapture();
            redimensionando = true;
            pnlDerecho.Cursor = cursorRedimension;

            // Esquina superior derecha
            if (e.Y <= MARGEN_ESQUINA)
            {
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTTOPRIGHT, 0);
            }
            // Esquina inferior derecha
            else if (e.Y >= pnlDerecho.Height - MARGEN_ESQUINA)
            {
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTBOTTOMRIGHT, 0);
            }
            // Borde derecho normal
            else
            {
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTRIGHT, 0);
            }
        }

        // Manejo del borde derecho al soltar el raton
        private void pnlDerecho_MouseUp(object sender, MouseEventArgs e)
        {
            redimensionando = false;
            pnlDerecho.Cursor = Cursors.Default;
        }


        // Manejo del borde derecho al mover el ratón (cambia el cursor)
        private void pnlDerecho_MouseMove(object sender, MouseEventArgs e)
        {
            // Esquina superior derecha
            if (e.Y <= MARGEN_ESQUINA)
            {
                cursorRedimension = Cursors.SizeNESW;
            }
            // Esquina inferior derecha
            else if (e.Y >= pnlDerecho.Height - MARGEN_ESQUINA)
            {
                cursorRedimension = Cursors.SizeNWSE;
            }
            // Borde derecho normal
            else
            {
                cursorRedimension = Cursors.SizeWE;
            }

            pnlDerecho.Cursor = cursorRedimension;
        }


        // Manejo del borde derecho al salir del área (restaura el cursor)
        private void pnlDerecho_MouseLeave(object sender, EventArgs e)
        {
            if (!redimensionando)
            {
                pnlDerecho.Cursor = Cursors.Default;
            }

        }

        #endregion


        #region Redimensionamiento de borde izquierdo
        private void pnlIzquierdo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            ReleaseCapture();
            redimensionando = true;
            pnlIzquierdo.Cursor = cursorRedimension;

            // Esquina superior izquierda
            if (e.Y <= MARGEN_ESQUINA)
            {
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTTOPLEFT, 0);
            }
            // Esquina inferior izquierda
            else if (e.Y >= pnlIzquierdo.Height - MARGEN_ESQUINA)
            {
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTBOTTOMLEFT, 0);
            }
            // Borde izquierdo normal
            else
            {
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTLEFT, 0);
            }
        }

        // Manejo del borde izquierdo al soltar el raton
        private void pnlIzquierdo_MouseUp(object sender, MouseEventArgs e)
        {
            redimensionando = false;
            pnlIzquierdo.Cursor = Cursors.Default;
        }


        // Manejo del borde izquierdo al mover el ratón (cambia el cursor)
        private void pnlIzquierdo_MouseMove(object sender, MouseEventArgs e)
        {
            // Esquina superior izquierda
            if (e.Y <= MARGEN_ESQUINA)
            {
                cursorRedimension = Cursors.SizeNWSE;
            }
            // Esquina inferior izquierda
            else if (e.Y >= pnlIzquierdo.Height - MARGEN_ESQUINA)
            {
                cursorRedimension = Cursors.SizeNESW;
            }
            // Borde izquierdo
            else
            {
                cursorRedimension = Cursors.SizeWE;
            }

            pnlIzquierdo.Cursor = cursorRedimension;
        }


        // Manejo del borde izquierdo al salir del área (restaura el cursor)
        private void pnlIzquierdo_MouseLeave(object sender, EventArgs e)
        {
            if (!redimensionando)
            {
                pnlIzquierdo.Cursor = Cursors.Default;
            }

        }

        #endregion


        #region Redimensionamiento de borde superior

        // Manejo del borde superior al hacer clic (permite mover y redimensionar)
        private void pnlSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            ReleaseCapture();
            redimensionando = true;
            pnlSuperior.Cursor = cursorRedimension;

            // Esquina superior izquierda
            if (e.X <= MARGEN_ESQUINA)
            {
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTTOPLEFT, 0);
            }
            // Esquina superior derecha
            else if (e.X >= pnlSuperior.Width - MARGEN_ESQUINA)
            {
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTTOPRIGHT, 0);
            }
            // Borde superior normal
            else
            {
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTTOP, 0);
            }
        }


        // Manejo del borde superior al soltar el clic
        private void pnlSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            redimensionando = false;
            pnlSuperior.Cursor = Cursors.Default;
        }


        // Manejo del borde superior al mover el ratón (cambia el cursor)
        private void pnlSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            // Esquina superior izquierda
            if (e.X <= MARGEN_ESQUINA)
            {
                cursorRedimension = Cursors.SizeNWSE;
            }
            // Esquina superior derecha
            else if (e.X >= pnlSuperior.Width - MARGEN_ESQUINA)
            {
                cursorRedimension= Cursors.SizeNESW;
            }
            // Borde superior
            else
            {
                cursorRedimension = Cursors.SizeNS;
            }

            pnlSuperior.Cursor = cursorRedimension;
        }


        // Manejo del borde superior al salir del área (restaura el cursor)
        private void pnlSuperior_MouseLeave(object sender, EventArgs e)
        {
            if (!redimensionando)
            {
               pnlSuperior.Cursor = Cursors.Default;
            }

        }

        #endregion


        #region Redimensionamiento de borde inferior
        private void pnlInferior_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            ReleaseCapture();
            redimensionando = true;
            pnlInferior.Cursor = cursorRedimension;

            // Esquina inferior izquierda
            if (e.X <= MARGEN_ESQUINA)
            {
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTBOTTOMLEFT, 0);
            }
            // Esquina inferior derecha
            else if (e.X >= pnlInferior.Width - MARGEN_ESQUINA)
            {
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTBOTTOMRIGHT, 0);
            }
            // Borde inferior normal
            else
            {
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTBOTTOM, 0);
            }
        }

        // Manejo del borde inferior al soltar el clic
        private void pnlInferior_MouseUp(object sender, MouseEventArgs e)
        {
            redimensionando = false;
            pnlInferior.Cursor = Cursors.Default;
        }


        // Manejo del borde inferior al mover el ratón (cambia el cursor)
        private void pnlInferior_MouseMove(object sender, MouseEventArgs e)
        {
            // Esquina inferior izquierda
            if (e.X <= MARGEN_ESQUINA)
            {
                cursorRedimension = Cursors.SizeNESW;
            }
            // Esquina inferior derecha
            else if (e.X >= pnlInferior.Width - MARGEN_ESQUINA)
            {
                cursorRedimension = Cursors.SizeNWSE;
            }
            // Borde inferior
            else
            {
                cursorRedimension = Cursors.SizeNS;
            }

            pnlInferior.Cursor = cursorRedimension;
        }


        // Manejo del borde inferior al salir del área (restaura el cursor)
        private void pnlInferior_MouseLeave(object sender, EventArgs e)
        {
            if (!redimensionando)
            {
                pnlInferior.Cursor = Cursors.Default;
            }

        }


        #endregion
    }
}

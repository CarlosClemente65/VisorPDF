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
        private const int MARGEN_ESQUINA = 10;
        private Cursor cursorRedimension;
        private bool redimensionandoVentana = false;
        private bool moviendoVentana = false;

        // Variables para controlar el zoom
        public static int zoomActual = Configuracion.ParametrosVisor.NivelZoom;
        public static PictureBoxSizeMode modoEscalaActual = PictureBoxSizeMode.AutoSize;


        // Variables para gestionar el archivo PDF
        public static string rutaArchivoPDF = string.Empty;
        public static string nombreArchivoVisor = string.Empty;
        public static bool rutaArchivoCompleta = Configuracion.ParametrosGenerales.RutaPDFCompleta;
        public static int paginaActual = 1;
        public static int totalPaginas = 1;


        // Instancia del control del visor PDF
        private PDFViewerControl visorPdf;


        public frmVisorPDF()
        {
            InitializeComponent();

            // Posicionamos la ventana según la configuración
            this.StartPosition = Configuracion.ParametrosVisor.PosicionFormulario;
            this.Location = new Point(Configuracion.ParametrosVisor.PosicionX, Configuracion.ParametrosVisor.PosicionY);
            this.Size = new Size(Configuracion.ParametrosVisor.Ancho, Configuracion.ParametrosVisor.Alto);

            // Fijamos la ventana como siempre encima (opcional)
            this.TopMost = Configuracion.ParametrosGenerales.FijarVentana;

            // Muestra en la interfaz el estado de la ventana (fijada o flotante)
            EstadoVentana();

            // Cargamos los valores del zoom en el comboBox
            cbxZoom.Items.Clear();
            cbxZoom.DataSource = Configuracion.ValoresZoom;

            // Mostramos el zoom inicial
            ActualizarZoom();

            // Fijamos el foco en el panel del visor
            pnlVisor.Focus();

            // Creamos un ToolTip para mostrar ayudas sobre los controles
            ToolTip mensajesAyuda = new ToolTip();

            // Opcional: configuraciones generales del tooltip
            mensajesAyuda.AutoPopDelay = 3000;   // tiempo que se muestra
            mensajesAyuda.InitialDelay = 200;    // tiempo antes de aparecer
            mensajesAyuda.ReshowDelay = 100;     // tiempo entre reapariciones
            mensajesAyuda.ShowAlways = true;     // se muestra aunque el formulario no esté activo

            // Asignamos el texto de ayuda a cada botón
            mensajesAyuda.SetToolTip(btnPrimero, "Primera página");
            mensajesAyuda.SetToolTip(btnUltimo, "Ultima página");
            mensajesAyuda.SetToolTip(btnAvance, "Página siguiente");
            mensajesAyuda.SetToolTip(btnRetroceso, "Página anterior");
            mensajesAyuda.SetToolTip(btnAumentar, "Aumentar zoom");
            mensajesAyuda.SetToolTip(btnDisminuir, "Disminuir zoom");
            mensajesAyuda.SetToolTip(cbxZoom, "Establecer zoom (10% - 500%)");
            mensajesAyuda.SetToolTip(btnAjusteAlto, "Ajuste alto");
            mensajesAyuda.SetToolTip(btnAjusteAncho, "Ajuste ancho");
            mensajesAyuda.SetToolTip(btnAjustePagina, "Ajuste página");

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            moviendoVentana = true;
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HTCAPTION, IntPtr.Zero);
        }

        private void pnlTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            moviendoVentana = false;
        }


        #region Redimensionamiento de borde derecho
        private void pnlDerecho_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            ReleaseCapture();
            redimensionandoVentana = true;
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
            redimensionandoVentana = false;
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
            if (!redimensionandoVentana)
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
            redimensionandoVentana = true;
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
            redimensionandoVentana = false;
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
            if (!redimensionandoVentana)
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
            redimensionandoVentana = true;
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
            redimensionandoVentana = false;
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
                cursorRedimension = Cursors.SizeNESW;
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
            if (!redimensionandoVentana)
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
            redimensionandoVentana = true;
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
            redimensionandoVentana = false;
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
            if (!redimensionandoVentana)
            {
                pnlInferior.Cursor = Cursors.Default;
            }
        }


        #endregion


        #region Control de Zoom
        private void btnAumentar_Click(object sender, EventArgs e)
        {
            if (zoomActual < 500)
            {
                zoomActual += 10;
            }

            visorPdf.ajustarEscala = PDFViewerControl.TipoEscala.ZoomPersonalizado;
            ActualizarZoom();
            visorPdf.recalcularImagen = true; // Al modificar elzoom se recalcula la imagen
        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            if (zoomActual > 10)
            {
                zoomActual -= 10;
            }

            visorPdf.ajustarEscala = PDFViewerControl.TipoEscala.ZoomPersonalizado;
            ActualizarZoom();
            visorPdf.recalcularImagen = true; // Al modificar elzoom se recalcula la imagen
        }

        private void cbxZoom_Validated(object sender, EventArgs e)
        {
            txtNumeroPagina.Focus();
            AplicarZoom();
        }

        private void cbxZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumeroPagina.Focus();
            AplicarZoom();
        }

        private void btnAjusteAncho_Click(object sender, EventArgs e)
        {
            // Aplicar el ajuste de ancho
            if (visorPdf != null)
            {
                visorPdf.ajustarEscala = PDFViewerControl.TipoEscala.AjusteAncho;
                visorPdf.ActualizarZoom();
                cbxZoom.Text = visorPdf.ZoomAplicado.ToString("0.##") + " %";
                visorPdf.recalcularImagen = false; // En el ajuste al ancho no se recalcula la imagen
            }
        }

        private void btnAjusteAlto_Click(object sender, EventArgs e)
        {
            // Aplicar el ajuste de alto
            if (visorPdf != null)
            {
                visorPdf.ajustarEscala = PDFViewerControl.TipoEscala.AjusteAlto;
                visorPdf.ActualizarZoom();
                cbxZoom.Text = visorPdf.ZoomAplicado.ToString("0.##") + " %";
                visorPdf.recalcularImagen = false; // En el ajuste al alto no se recalcula la imagen
            }
        }

        private void btnAjustePagina_Click(object sender, EventArgs e)
        {
            // Aplicar el ajuste a la pagina
            if (visorPdf != null)
            {
                visorPdf.ajustarEscala = PDFViewerControl.TipoEscala.AjustePagina;
                visorPdf.ActualizarZoom();
                cbxZoom.Text = visorPdf.ZoomAplicado.ToString("0.##") + " %";
                visorPdf.recalcularImagen = false; // En el ajuste al ancho no se recalcula la imagen
            }
        }

        private void AplicarZoom()
        {
            // Evitar errores si el visor no está inicializado
            if (visorPdf == null)
            {
                return;
            }

            // Obtener el valor del zoom del comboBox
            string textoZoom = cbxZoom.Text.Replace("%", "");
            zoomActual = Math.Max(10, Math.Min(500, int.TryParse(textoZoom, out int valor) ? valor : 100));

            visorPdf.ajustarEscala = PDFViewerControl.TipoEscala.ZoomPersonalizado;
            ActualizarZoom();
            visorPdf.recalcularImagen = true; // Al modificar elzoom se recalcula la imagen

            cbxZoom.Text = $"{zoomActual} %";
        }

        private void ActualizarZoom()
        {
            cbxZoom.Text = $"{zoomActual} %";
            Configuracion.ParametrosVisor.NivelZoom = zoomActual;
            if (visorPdf != null)
            {
                visorPdf.ActualizarZoom();
            }
        }

        #endregion


        // Carga el archivo PDF en el visor y actualiza la interfaz
        private void CargarArchivo()
        {
            // Obtenemos el nombre del archivo según la configuración
            if (!string.IsNullOrEmpty(rutaArchivoPDF))
            {
                nombreArchivoVisor = rutaArchivoCompleta ? Path.GetFullPath(rutaArchivoPDF) : Path.GetFileName(rutaArchivoPDF);
            }

            // Carga el archivo PDF en el visor
            if (visorPdf != null && !string.IsNullOrEmpty(rutaArchivoPDF))
            {
                visorPdf.CargarPdf(rutaArchivoPDF);
            }

            ActualizaCamposVisor();

        }

        private void ActualizaCamposVisor()
        {
            // Mostramos el nombre del archivo en la interfaz
            lbArchivo.Text = $"Archivo: {nombreArchivoVisor}";

            // Habilitamos o deshabilitamos las opciones del menú según si hay un archivo cargado
            bool activarOpciones = !string.IsNullOrEmpty(rutaArchivoPDF) ? true : false;
            archivoCerrarItem.Enabled = activarOpciones;
            archivoGuardarComoItem.Enabled = activarOpciones;
            enviarEmailItem.Enabled = activarOpciones;
            enviarImprimirItem.Enabled = activarOpciones;
            txtNumeroPagina.Enabled = activarOpciones;

            // Actualiza numero de paginas del PDF en el visor
            var numPagVisor = activarOpciones ? paginaActual.ToString() : "";
            var totalPagVisor = activarOpciones ? $" / {totalPaginas.ToString()}" : "";
            txtNumeroPagina.Text = numPagVisor;
            txtTotalPaginas.Text = totalPagVisor;
        }


        // Opción de abrir archivo PDF
        private void archivoAbrirItem_Click(object sender, EventArgs e)
        {
            // Lógica para abrir el archivo PDF
            GestionArchivos.AbrirArchivo(rutaArchivoPDF);

            // Actualizar el nombre del archivo en la interfaz
            CargarArchivo();
        }


        // Opción de cerrar archivo PDF
        private void archivoCerrarItem_Click(object sender, EventArgs e)
        {
            // Se borra la ruta del archivo del visor
            rutaArchivoPDF = string.Empty;
            nombreArchivoVisor = string.Empty;

            // Se borra la informacion de las paginas
            paginaActual = 1;
            totalPaginas = 1;

            // Actualizar el nombre del archivo en la interfaz
            ActualizaCamposVisor();

            // Limpiamos el visor PDF
            visorPdf.LimpiarVisor();

            // Limpiamos el documento PDF cargado en el visor
            visorPdf.CerrarDocumento();
        }


        // Opción de guardar como archivo PDF
        private void archivoGuardarComoItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaArchivoPDF))
                return;

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Archivos PDF (*.pdf)|*.pdf|Todos los archivos (*.*)|*.*",
                Title = "Guardar archivo PDF como",
                FileName = Path.GetFileName(rutaArchivoPDF)
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.Copy(rutaArchivoPDF, sfd.FileName, true);
            }

        }


        // Alterna entre fijar la ventana o dejarla flotante desde el menu Configuracion
        private void fijarConfiguracionItem_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            //configuracionFijarVentanaItem.Checked = this.TopMost;

            // Guardamos la configuración
            Configuracion.ParametrosGenerales.FijarVentana = this.TopMost;
            EstadoVentana();
        }

        // Alterna entre mostrar la ruta completa o solo el nombre del archivo desde el menu de Configuracion
        private void configuracionRutaCompletaItem_Click(object sender, EventArgs e)
        {
            rutaArchivoCompleta = !rutaArchivoCompleta;
            //configuracionRutaCompletaItem.Checked = rutaArchivoCompleta;

            // Guardamos la configuración
            Configuracion.ParametrosGenerales.RutaPDFCompleta = rutaArchivoCompleta;

            CargarArchivo();
        }

        // Muestra en la interfaz el estado de la ventana (fijada o flotante)
        private void EstadoVentana()
        {
            lbEstadoVentana.Text = this.TopMost ? "Ventana fijada" : "Ventana flotante";
            configuracionFijarVentanaItem.Checked = this.TopMost;
            configuracionRutaCompletaItem.Checked = rutaArchivoCompleta;
        }



        #region Gestion de envios
        // Opcion de impresion del archivo PDF
        private void enviarImprimirItem_Click(object sender, EventArgs e)
        {
            GestionEnvios.ImprimirPDF();
        }


        // Opcion de envio por email del archivo PDF
        private void enviarEmailItem_Click(object sender, EventArgs e)
        {
            GestionEnvios.EnvioEmail();
        }

        #endregion


        #region Navegacion de paginas

        // Gestiona el cambio de pagina al validar el cuadro de texto
        private void txtNumeroPagina_Validated(object sender, EventArgs e)
        {
            paginaActual = int.TryParse(txtNumeroPagina.Text, out int valor) ? valor : 1;
            if (paginaActual > totalPaginas)
            {
                paginaActual = totalPaginas;
            }

            if (paginaActual <= 0)
            {
                paginaActual = 1;
            }

            ActualizarPaginaActual();

        }

        // Actualiza el cuadro de texto con la pagina actual
        private void ActualizarPaginaActual()
        {
            txtNumeroPagina.Text = paginaActual.ToString();

            // Muestra la pagina actual en el visor PDF
            visorPdf.MostrarPagina(paginaActual);
        }


        // Gestiona el avance a la siguiente pagina
        private void btnAvance_Click(object sender, EventArgs e)
        {
            // Controla si el cuadro de texto de pagina esta habilitado
            if (txtNumeroPagina.Enabled == false)
                return;

            if (paginaActual < totalPaginas)
            {
                paginaActual += 1;
            }

            ActualizarPaginaActual();
        }


        // Gestiona el retroceso a la pagina anterior
        private void btnRetroceso_Click(object sender, EventArgs e)
        {
            // Controla si el cuadro de texto de pagina esta habilitado
            if (txtNumeroPagina.Enabled == false)
                return;

            if (paginaActual > 1)
            {
                paginaActual -= 1;
            }

            ActualizarPaginaActual();
        }


        // Gestiona el salto a la primera pagina
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            // Controla si el cuadro de texto de pagina esta habilitado
            if (txtNumeroPagina.Enabled == false)
                return;

            paginaActual = 1;

            ActualizarPaginaActual();
        }


        // Gestiona el salto a la ultima pagina
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            // Controla si el cuadro de texto de pagina esta habilitado
            if (txtNumeroPagina.Enabled == false)
                return;


            paginaActual = totalPaginas;
            ActualizarPaginaActual();
        }
        #endregion


        #region Arrastre de archivos PDF
        // Gestiona el arrastre de archivos PDF al panel del visor
        private void pnlVisor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (archivos.Length > 0 && Path.GetExtension(archivos[0]).ToLower() == ".pdf")
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
        }


        // Gestiona al soltar archivos PDF en el panel del visor
        private void pnlVisor_DragDrop(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (archivos.Length > 0 && Path.GetExtension(archivos[0]).ToLower() == ".pdf")
            {
                rutaArchivoPDF = archivos[0];
                CargarArchivo();
            }
        }

        #endregion


        #region Gestion de posicion y tamaño de ventana
        private void frmVisorPDF_ResizeEnd(object sender, EventArgs e)
        {
            // Al finalizar el redimensionamiento de la ventana se recalcula la posicion del PDF en el visor
            visorPdf.MostrarPagina(paginaActual);

        }

        #endregion

        private void frmVisorPDF_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Una vez redimensionada la ventana guardamos la nueva posición y tamaño en la configuración
            Configuracion.ActualizarPosicionVentana(
                this.Location.X,
                this.Location.Y,
                this.Size.Width,
                this.Size.Height
                );
        }



        private void frmVisorPDF_Load(object sender, EventArgs e)
        {
            visorPdf = new PDFViewerControl();
            visorPdf.Dock = DockStyle.Fill;

            pnlVisor.Controls.Clear();
            pnlVisor.Controls.Add(visorPdf);
        }


    }
}
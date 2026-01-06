using PdfiumViewer;


namespace VisorPDF
{
    public partial class PDFViewerControl : UserControl
    {
        // Campo para mostrar la página del PDF
        private PictureBox picBoxPagina;
        public SizeF tamañoPaginaOriginal;

        // Campo para manejar el documento PDF
        private PdfDocument documentoPdf;

        // Página que se está mostrando actualmente
        private int paginaActual = 1;

        // Control del tamaño de pagina segun el zoom
        private int anchoPaginaZoom;
        private int altoPaginaZoom;
        private int paginaActualZoom;
        private PictureBoxSizeMode modoEscalaActual = frmVisorPDF.modoEscalaActual;
        public bool recalcularImagen = true;
        private float zoomAplicado = 1.0f;
        public float ZoomAplicado
        {
            get
            {
                if (documentoPdf == null)
                {
                    return 100f;
                }

                return zoomAplicado * 100f; // Devuelve valor con decimales
            }
            private set
            {
                zoomAplicado = value / 100f; // Guardar como factor 0..1
            }
        }

        public enum TipoEscala
        {
            AjusteAncho,
            AjusteAlto,
            AjustePagina,
            ZoomPersonalizado
        }

        public TipoEscala ajustarEscala = TipoEscala.ZoomPersonalizado;


        public PDFViewerControl()
        {
            InitializeComponent();
            InicializarPictureBox();
        }

        private void InicializarPictureBox()
        {
            // Activar scroll en el panel contenedor
            pnlContenido.AutoScroll = true;
            pnlContenido.BackColor = Color.FromArgb(225, 225, 225);

            // Crear pictureBox para mostrar la página del PDF
            picBoxPagina = new PictureBox();
            picBoxPagina.SizeMode = modoEscalaActual;
            picBoxPagina.Dock = DockStyle.None;

            // Agregar el PictureBox al panel contenedor
            pnlContenido.Controls.Clear();
            pnlContenido.Controls.Add(picBoxPagina);
        }

        public void CargarPdf(string rutaPdf)
        {
            if (string.IsNullOrEmpty(rutaPdf) || !File.Exists(rutaPdf))
                return;

            // Cerramos un documento anterior si existía
            documentoPdf?.Dispose();

            // Cargamos el PDF
            documentoPdf = PdfDocument.Load(rutaPdf);

            // Obtener tamaño original de la página
            tamañoPaginaOriginal = documentoPdf.PageSizes[paginaActual - 1]; // Ancho y alto reales de la pagina

            // Actualizasmos el total de páginas
            frmVisorPDF.totalPaginas = documentoPdf.PageCount;

            // Ajustamos el zoom inicial
            AjusteZoomPagina();

            // Mostramos la primera página en el PictureBox
            MostrarPagina(paginaActual);
        }


        public void MostrarPagina(int numeroPagina)
        {
            if (documentoPdf == null) return;

            paginaActual = numeroPagina;

            if (recalcularImagen)
            {
                // Liberar la imagen anterior
                LimpiarVisor();

                // Renderizar la página a un Bitmap
                var tamaño = picBoxPagina.Size; // Tamaño del PictureBox
                Image imagenPagina = documentoPdf.Render(
                    paginaActual - 1,
                    anchoPaginaZoom, altoPaginaZoom,
                    96, 96,
                    PdfiumViewer.PdfRenderFlags.Annotations);

                // Asignar la nueva imagen al PictureBox
                picBoxPagina.Image = imagenPagina;
            }

            // Centrar la página si cabe
            CentrarPictureBox();
        }

        public void LimpiarVisor()
        {
            // Liberar la imagen actual
            picBoxPagina.Image?.Dispose();
            picBoxPagina.Image = null;
        }

        public void CerrarDocumento()
        {
            // Cerrar el documento PDF si está abierto
            documentoPdf?.Dispose();
            documentoPdf = null;
            paginaActual = 1;
        }

        public void AjusteZoomPagina()
        {
            switch (ajustarEscala)
            {
                case TipoEscala.AjusteAncho:
                    anchoPaginaZoom = pnlContenido.Width;
                    altoPaginaZoom = (int)(anchoPaginaZoom * tamañoPaginaOriginal.Height / tamañoPaginaOriginal.Width);
                    break;

                case TipoEscala.AjusteAlto:
                    altoPaginaZoom = pnlContenido.Height;
                    anchoPaginaZoom = (int)(altoPaginaZoom * tamañoPaginaOriginal.Width / tamañoPaginaOriginal.Height);
                    break;

                case TipoEscala.AjustePagina:
                    float factorAncho = (float)pnlContenido.Width / tamañoPaginaOriginal.Width;
                    float factorAlto = (float)pnlContenido.Height / tamañoPaginaOriginal.Height;
                    float factor = Math.Min(factorAncho, factorAlto);
                    anchoPaginaZoom = (int)(tamañoPaginaOriginal.Width * factor);
                    altoPaginaZoom = (int)(tamañoPaginaOriginal.Height * factor);
                    break;

                case TipoEscala.ZoomPersonalizado:
                    // Calcular nuevo tamaño según el zoom
                    float factorZoom = frmVisorPDF.zoomActual / 100f;
                    anchoPaginaZoom = (int)(tamañoPaginaOriginal.Width * factorZoom);
                    altoPaginaZoom = (int)(tamañoPaginaOriginal.Height * factorZoom);
                    break;
            }

            zoomAplicado = anchoPaginaZoom / tamañoPaginaOriginal.Width;
        }

        public void ActualizarZoom()
        {
            if (documentoPdf == null) return;

            // Recalcular tamaño de página según el nuevo zoom
            AjusteZoomPagina();

            // Renderizar de nuevo la página actual
            MostrarPagina(paginaActual);
        }


        private void CentrarPictureBox()
        {
            if (picBoxPagina == null || pnlContenido.ClientSize.Width == 0 || pnlContenido.ClientSize.Height == 0)
                return;

            int x = 0;
            int y = 0;

            // Si el PictureBox es más pequeño que el panel, calcular offset para centrar
            if (picBoxPagina.Width < pnlContenido.ClientSize.Width)
                x = (pnlContenido.ClientSize.Width - picBoxPagina.Width) / 2;

            if (picBoxPagina.Height < pnlContenido.ClientSize.Height)
                y = (pnlContenido.ClientSize.Height - picBoxPagina.Height) / 2;

            picBoxPagina.Location = new Point(x, y);
        }

        public void CalcularZoomActual()
        {

            // Tamaño visible del visor
            int anchoVisor = pnlContenido.ClientSize.Width;
            int altoVisor = pnlContenido.ClientSize.Height;

            // Factor de escala para ancho y alto
            float factorAncho = pnlContenido.ClientSize.Width / tamañoPaginaOriginal.Width;
            float factorAlto = altoVisor / tamañoPaginaOriginal.Height;

            // Elegimos el menor para que la página quepa completa
            float factorFinal = Math.Min(factorAncho, factorAlto);

            // Convertimos a porcentaje
            int zoomCalculado = (int)(factorFinal * 100);

            // Limitamos el rango (opcional, pero recomendable)
            zoomCalculado = Math.Max(10, Math.Min(500, zoomCalculado));


        }
    }
}
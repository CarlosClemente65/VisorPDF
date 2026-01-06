namespace VisorPDF
{
    partial class frmVisorPDF
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisorPDF));
            pnlTitulo = new Panel();
            label1 = new Label();
            btnMaximizar = new Button();
            ctrlVentana = new ImageList(components);
            btnMinimizar = new Button();
            btnCerrar = new Button();
            pnlSuperior = new Panel();
            pnlHerramientas = new Panel();
            cbxZoom = new ComboBox();
            btnAjustePagina = new Button();
            ctrlPDF = new ImageList(components);
            btnAjusteAlto = new Button();
            btnAjusteAncho = new Button();
            txtTotalPaginas = new TextBox();
            txtNumeroPagina = new TextBox();
            btnDisminuir = new Button();
            btnAumentar = new Button();
            btnPrimero = new Button();
            btnRetroceso = new Button();
            btnAvance = new Button();
            btnUltimo = new Button();
            pnlVisor = new Panel();
            pnlIzquierdo = new Panel();
            pnlDerecho = new Panel();
            pnlInferior = new Panel();
            menuStrip = new MenuStrip();
            archivoItem = new ToolStripMenuItem();
            archivoAbrirItem = new ToolStripMenuItem();
            archivoCerrarItem = new ToolStripMenuItem();
            archivoGuardarComoItem = new ToolStripMenuItem();
            envioItem = new ToolStripMenuItem();
            enviarImprimirItem = new ToolStripMenuItem();
            enviarEmailItem = new ToolStripMenuItem();
            configuracionItem = new ToolStripMenuItem();
            configuracionFijarVentanaItem = new ToolStripMenuItem();
            configuracionRutaCompletaItem = new ToolStripMenuItem();
            AarchivoGuardarComoItem = new ToolStripMenuItem();
            pnlMensajes = new Panel();
            lbArchivo = new Label();
            lbEstadoVentana = new Label();
            pnlTitulo.SuspendLayout();
            pnlHerramientas.SuspendLayout();
            menuStrip.SuspendLayout();
            pnlMensajes.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.Silver;
            pnlTitulo.Controls.Add(label1);
            pnlTitulo.Controls.Add(btnMaximizar);
            pnlTitulo.Controls.Add(btnMinimizar);
            pnlTitulo.Controls.Add(btnCerrar);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(4, 4);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(492, 40);
            pnlTitulo.TabIndex = 0;
            pnlTitulo.MouseDown += pnlTitulo_MouseDown;
            pnlTitulo.MouseUp += pnlTitulo_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 9);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 3;
            label1.Text = "Visor PDF";
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.BackColor = Color.Transparent;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.ImageIndex = 1;
            btnMaximizar.ImageList = ctrlVentana;
            btnMaximizar.Location = new Point(410, 5);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(30, 30);
            btnMaximizar.TabIndex = 41;
            btnMaximizar.UseVisualStyleBackColor = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // ctrlVentana
            // 
            ctrlVentana.ColorDepth = ColorDepth.Depth32Bit;
            ctrlVentana.ImageStream = (ImageListStreamer)resources.GetObject("ctrlVentana.ImageStream");
            ctrlVentana.TransparentColor = Color.Transparent;
            ctrlVentana.Images.SetKeyName(0, "Cerrar_ventana.png");
            ctrlVentana.Images.SetKeyName(1, "Maximizar_ventana.png");
            ctrlVentana.Images.SetKeyName(2, "Minimizar_ventana.png");
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.ImageIndex = 2;
            btnMinimizar.ImageList = ctrlVentana;
            btnMinimizar.Location = new Point(370, 5);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(30, 30);
            btnMinimizar.TabIndex = 40;
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.Transparent;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ImageIndex = 0;
            btnCerrar.ImageList = ctrlVentana;
            btnCerrar.Location = new Point(450, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 30);
            btnCerrar.TabIndex = 42;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.DarkGray;
            pnlSuperior.Cursor = Cursors.SizeNS;
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(4, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(492, 4);
            pnlSuperior.TabIndex = 1;
            pnlSuperior.MouseDown += pnlSuperior_MouseDown;
            pnlSuperior.MouseLeave += pnlSuperior_MouseLeave;
            pnlSuperior.MouseMove += pnlSuperior_MouseMove;
            pnlSuperior.MouseUp += pnlSuperior_MouseUp;
            // 
            // pnlHerramientas
            // 
            pnlHerramientas.BackColor = Color.FromArgb(237, 237, 237);
            pnlHerramientas.Controls.Add(cbxZoom);
            pnlHerramientas.Controls.Add(btnAjustePagina);
            pnlHerramientas.Controls.Add(btnAjusteAlto);
            pnlHerramientas.Controls.Add(btnAjusteAncho);
            pnlHerramientas.Controls.Add(txtTotalPaginas);
            pnlHerramientas.Controls.Add(txtNumeroPagina);
            pnlHerramientas.Controls.Add(btnDisminuir);
            pnlHerramientas.Controls.Add(btnAumentar);
            pnlHerramientas.Controls.Add(btnPrimero);
            pnlHerramientas.Controls.Add(btnRetroceso);
            pnlHerramientas.Controls.Add(btnAvance);
            pnlHerramientas.Controls.Add(btnUltimo);
            pnlHerramientas.Dock = DockStyle.Top;
            pnlHerramientas.ForeColor = Color.Black;
            pnlHerramientas.Location = new Point(4, 70);
            pnlHerramientas.Name = "pnlHerramientas";
            pnlHerramientas.Size = new Size(492, 30);
            pnlHerramientas.TabIndex = 1;
            // 
            // cbxZoom
            // 
            cbxZoom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbxZoom.FlatStyle = FlatStyle.Flat;
            cbxZoom.FormatString = " %";
            cbxZoom.FormattingEnabled = true;
            cbxZoom.Location = new Point(380, 4);
            cbxZoom.Name = "cbxZoom";
            cbxZoom.Size = new Size(80, 23);
            cbxZoom.TabIndex = 26;
            cbxZoom.SelectedIndexChanged += cbxZoom_SelectedIndexChanged;
            cbxZoom.Validated += cbxZoom_Validated;
            // 
            // btnAjustePagina
            // 
            btnAjustePagina.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAjustePagina.BackColor = Color.Transparent;
            btnAjustePagina.FlatAppearance.BorderSize = 0;
            btnAjustePagina.FlatStyle = FlatStyle.Flat;
            btnAjustePagina.ImageIndex = 8;
            btnAjustePagina.ImageList = ctrlPDF;
            btnAjustePagina.Location = new Point(330, 2);
            btnAjustePagina.Margin = new Padding(0);
            btnAjustePagina.Name = "btnAjustePagina";
            btnAjustePagina.Size = new Size(25, 25);
            btnAjustePagina.TabIndex = 25;
            btnAjustePagina.UseVisualStyleBackColor = false;
            btnAjustePagina.Click += btnAjustePagina_Click;
            // 
            // ctrlPDF
            // 
            ctrlPDF.ColorDepth = ColorDepth.Depth32Bit;
            ctrlPDF.ImageStream = (ImageListStreamer)resources.GetObject("ctrlPDF.ImageStream");
            ctrlPDF.TransparentColor = Color.Transparent;
            ctrlPDF.Images.SetKeyName(0, "Avance.png");
            ctrlPDF.Images.SetKeyName(1, "Primero.png");
            ctrlPDF.Images.SetKeyName(2, "Retroceso.png");
            ctrlPDF.Images.SetKeyName(3, "Ultimo.png");
            ctrlPDF.Images.SetKeyName(4, "Aumentar.png");
            ctrlPDF.Images.SetKeyName(5, "Disminuir.png");
            ctrlPDF.Images.SetKeyName(6, "Ajuste alto.png");
            ctrlPDF.Images.SetKeyName(7, "Ajuste ancho.png");
            ctrlPDF.Images.SetKeyName(8, "Ajuste pagina.png");
            // 
            // btnAjusteAlto
            // 
            btnAjusteAlto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAjusteAlto.BackColor = Color.Transparent;
            btnAjusteAlto.FlatAppearance.BorderSize = 0;
            btnAjusteAlto.FlatStyle = FlatStyle.Flat;
            btnAjusteAlto.ImageIndex = 6;
            btnAjusteAlto.ImageList = ctrlPDF;
            btnAjusteAlto.Location = new Point(300, 2);
            btnAjusteAlto.Margin = new Padding(0);
            btnAjusteAlto.Name = "btnAjusteAlto";
            btnAjusteAlto.Size = new Size(25, 25);
            btnAjusteAlto.TabIndex = 24;
            btnAjusteAlto.UseVisualStyleBackColor = false;
            btnAjusteAlto.Click += btnAjusteAlto_Click;
            // 
            // btnAjusteAncho
            // 
            btnAjusteAncho.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAjusteAncho.BackColor = Color.Transparent;
            btnAjusteAncho.FlatAppearance.BorderSize = 0;
            btnAjusteAncho.FlatStyle = FlatStyle.Flat;
            btnAjusteAncho.ImageIndex = 7;
            btnAjusteAncho.ImageList = ctrlPDF;
            btnAjusteAncho.Location = new Point(270, 2);
            btnAjusteAncho.Margin = new Padding(0);
            btnAjusteAncho.Name = "btnAjusteAncho";
            btnAjusteAncho.Size = new Size(25, 25);
            btnAjusteAncho.TabIndex = 23;
            btnAjusteAncho.UseVisualStyleBackColor = false;
            btnAjusteAncho.Click += btnAjusteAncho_Click;
            // 
            // txtTotalPaginas
            // 
            txtTotalPaginas.BackColor = Color.Snow;
            txtTotalPaginas.BorderStyle = BorderStyle.None;
            txtTotalPaginas.Enabled = false;
            txtTotalPaginas.Location = new Point(80, 7);
            txtTotalPaginas.Margin = new Padding(0);
            txtTotalPaginas.Name = "txtTotalPaginas";
            txtTotalPaginas.Size = new Size(35, 16);
            txtTotalPaginas.TabIndex = 0;
            // 
            // txtNumeroPagina
            // 
            txtNumeroPagina.BackColor = Color.Snow;
            txtNumeroPagina.BorderStyle = BorderStyle.None;
            txtNumeroPagina.Enabled = false;
            txtNumeroPagina.Location = new Point(55, 7);
            txtNumeroPagina.Margin = new Padding(0);
            txtNumeroPagina.Name = "txtNumeroPagina";
            txtNumeroPagina.Size = new Size(25, 16);
            txtNumeroPagina.TabIndex = 4;
            txtNumeroPagina.TextAlign = HorizontalAlignment.Right;
            txtNumeroPagina.Validated += txtNumeroPagina_Validated;
            // 
            // btnDisminuir
            // 
            btnDisminuir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDisminuir.BackColor = Color.Transparent;
            btnDisminuir.FlatAppearance.BorderSize = 0;
            btnDisminuir.FlatStyle = FlatStyle.Flat;
            btnDisminuir.ImageIndex = 5;
            btnDisminuir.ImageList = ctrlPDF;
            btnDisminuir.Location = new Point(355, 2);
            btnDisminuir.Margin = new Padding(0);
            btnDisminuir.Name = "btnDisminuir";
            btnDisminuir.Size = new Size(25, 25);
            btnDisminuir.TabIndex = 22;
            btnDisminuir.UseVisualStyleBackColor = false;
            btnDisminuir.Click += btnDisminuir_Click;
            // 
            // btnAumentar
            // 
            btnAumentar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAumentar.BackColor = Color.Transparent;
            btnAumentar.FlatAppearance.BorderSize = 0;
            btnAumentar.FlatStyle = FlatStyle.Flat;
            btnAumentar.ImageIndex = 4;
            btnAumentar.ImageList = ctrlPDF;
            btnAumentar.Location = new Point(460, 2);
            btnAumentar.Margin = new Padding(0);
            btnAumentar.Name = "btnAumentar";
            btnAumentar.Size = new Size(25, 25);
            btnAumentar.TabIndex = 20;
            btnAumentar.UseVisualStyleBackColor = false;
            btnAumentar.Click += btnAumentar_Click;
            // 
            // btnPrimero
            // 
            btnPrimero.BackColor = Color.Transparent;
            btnPrimero.FlatAppearance.BorderSize = 0;
            btnPrimero.FlatStyle = FlatStyle.Flat;
            btnPrimero.ImageIndex = 1;
            btnPrimero.ImageList = ctrlPDF;
            btnPrimero.Location = new Point(5, 2);
            btnPrimero.Margin = new Padding(0);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(25, 25);
            btnPrimero.TabIndex = 2;
            btnPrimero.UseVisualStyleBackColor = false;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // btnRetroceso
            // 
            btnRetroceso.BackColor = Color.Transparent;
            btnRetroceso.FlatAppearance.BorderSize = 0;
            btnRetroceso.FlatStyle = FlatStyle.Flat;
            btnRetroceso.ImageIndex = 2;
            btnRetroceso.ImageList = ctrlPDF;
            btnRetroceso.Location = new Point(30, 2);
            btnRetroceso.Margin = new Padding(0);
            btnRetroceso.Name = "btnRetroceso";
            btnRetroceso.Size = new Size(25, 25);
            btnRetroceso.TabIndex = 3;
            btnRetroceso.UseVisualStyleBackColor = false;
            btnRetroceso.Click += btnRetroceso_Click;
            // 
            // btnAvance
            // 
            btnAvance.BackColor = Color.Transparent;
            btnAvance.FlatAppearance.BorderSize = 0;
            btnAvance.FlatStyle = FlatStyle.Flat;
            btnAvance.ImageIndex = 0;
            btnAvance.ImageList = ctrlPDF;
            btnAvance.Location = new Point(115, 2);
            btnAvance.Margin = new Padding(0);
            btnAvance.Name = "btnAvance";
            btnAvance.Size = new Size(25, 25);
            btnAvance.TabIndex = 5;
            btnAvance.UseVisualStyleBackColor = false;
            btnAvance.Click += btnAvance_Click;
            // 
            // btnUltimo
            // 
            btnUltimo.BackColor = Color.Transparent;
            btnUltimo.FlatAppearance.BorderSize = 0;
            btnUltimo.FlatStyle = FlatStyle.Flat;
            btnUltimo.ImageIndex = 3;
            btnUltimo.ImageList = ctrlPDF;
            btnUltimo.Location = new Point(140, 2);
            btnUltimo.Margin = new Padding(0);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(25, 25);
            btnUltimo.TabIndex = 6;
            btnUltimo.UseVisualStyleBackColor = false;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // pnlVisor
            // 
            pnlVisor.AllowDrop = true;
            pnlVisor.BackColor = Color.WhiteSmoke;
            pnlVisor.Dock = DockStyle.Fill;
            pnlVisor.Location = new Point(4, 100);
            pnlVisor.Name = "pnlVisor";
            pnlVisor.Size = new Size(492, 476);
            pnlVisor.TabIndex = 1;
            pnlVisor.DragDrop += pnlVisor_DragDrop;
            pnlVisor.DragEnter += pnlVisor_DragEnter;
            // 
            // pnlIzquierdo
            // 
            pnlIzquierdo.BackColor = Color.DarkGray;
            pnlIzquierdo.Cursor = Cursors.SizeWE;
            pnlIzquierdo.Dock = DockStyle.Left;
            pnlIzquierdo.Location = new Point(0, 0);
            pnlIzquierdo.Name = "pnlIzquierdo";
            pnlIzquierdo.Size = new Size(4, 600);
            pnlIzquierdo.TabIndex = 2;
            pnlIzquierdo.MouseDown += pnlIzquierdo_MouseDown;
            pnlIzquierdo.MouseLeave += pnlIzquierdo_MouseLeave;
            pnlIzquierdo.MouseMove += pnlIzquierdo_MouseMove;
            pnlIzquierdo.MouseUp += pnlIzquierdo_MouseUp;
            // 
            // pnlDerecho
            // 
            pnlDerecho.BackColor = Color.DarkGray;
            pnlDerecho.Cursor = Cursors.SizeWE;
            pnlDerecho.Dock = DockStyle.Right;
            pnlDerecho.Location = new Point(496, 0);
            pnlDerecho.Name = "pnlDerecho";
            pnlDerecho.Size = new Size(4, 600);
            pnlDerecho.TabIndex = 1;
            pnlDerecho.MouseDown += pnlDerecho_MouseDown;
            pnlDerecho.MouseLeave += pnlDerecho_MouseLeave;
            pnlDerecho.MouseMove += pnlDerecho_MouseMove;
            pnlDerecho.MouseUp += pnlDerecho_MouseUp;
            // 
            // pnlInferior
            // 
            pnlInferior.BackColor = Color.DarkGray;
            pnlInferior.Cursor = Cursors.SizeNS;
            pnlInferior.Dock = DockStyle.Bottom;
            pnlInferior.Location = new Point(4, 596);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(492, 4);
            pnlInferior.TabIndex = 0;
            pnlInferior.MouseDown += pnlInferior_MouseDown;
            pnlInferior.MouseLeave += pnlInferior_MouseLeave;
            pnlInferior.MouseMove += pnlInferior_MouseMove;
            pnlInferior.MouseUp += pnlInferior_MouseUp;
            // 
            // menuStrip
            // 
            menuStrip.AccessibleRole = AccessibleRole.Grip;
            menuStrip.BackColor = Color.Gainsboro;
            menuStrip.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip.Items.AddRange(new ToolStripItem[] { archivoItem, envioItem, configuracionItem });
            menuStrip.Location = new Point(4, 44);
            menuStrip.Name = "menuStrip";
            menuStrip.RenderMode = ToolStripRenderMode.Professional;
            menuStrip.Size = new Size(492, 26);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // archivoItem
            // 
            archivoItem.BackColor = Color.Gainsboro;
            archivoItem.DropDownItems.AddRange(new ToolStripItem[] { archivoAbrirItem, archivoCerrarItem, archivoGuardarComoItem });
            archivoItem.Name = "archivoItem";
            archivoItem.Size = new Size(67, 22);
            archivoItem.Text = "Archivo";
            // 
            // archivoAbrirItem
            // 
            archivoAbrirItem.Name = "archivoAbrirItem";
            archivoAbrirItem.Size = new Size(174, 22);
            archivoAbrirItem.Text = "Abrir...";
            archivoAbrirItem.Click += archivoAbrirItem_Click;
            // 
            // archivoCerrarItem
            // 
            archivoCerrarItem.Enabled = false;
            archivoCerrarItem.Name = "archivoCerrarItem";
            archivoCerrarItem.Size = new Size(174, 22);
            archivoCerrarItem.Text = "Cerrar";
            archivoCerrarItem.Click += archivoCerrarItem_Click;
            // 
            // archivoGuardarComoItem
            // 
            archivoGuardarComoItem.Enabled = false;
            archivoGuardarComoItem.Name = "archivoGuardarComoItem";
            archivoGuardarComoItem.Size = new Size(174, 22);
            archivoGuardarComoItem.Text = "Guardar como...";
            archivoGuardarComoItem.Click += archivoGuardarComoItem_Click;
            // 
            // envioItem
            // 
            envioItem.DropDownItems.AddRange(new ToolStripItem[] { enviarImprimirItem, enviarEmailItem });
            envioItem.Name = "envioItem";
            envioItem.Size = new Size(58, 22);
            envioItem.Text = "Enviar";
            // 
            // enviarImprimirItem
            // 
            enviarImprimirItem.Name = "enviarImprimirItem";
            enviarImprimirItem.Size = new Size(152, 22);
            enviarImprimirItem.Text = "Imprimir";
            enviarImprimirItem.Click += enviarImprimirItem_Click;
            // 
            // enviarEmailItem
            // 
            enviarEmailItem.Name = "enviarEmailItem";
            enviarEmailItem.Size = new Size(152, 22);
            enviarEmailItem.Text = "Enviar email";
            enviarEmailItem.Click += enviarEmailItem_Click;
            // 
            // configuracionItem
            // 
            configuracionItem.DropDownItems.AddRange(new ToolStripItem[] { configuracionFijarVentanaItem, configuracionRutaCompletaItem });
            configuracionItem.Name = "configuracionItem";
            configuracionItem.Size = new Size(105, 22);
            configuracionItem.Text = "Configuracion";
            // 
            // configuracionFijarVentanaItem
            // 
            configuracionFijarVentanaItem.BackColor = SystemColors.ControlDark;
            configuracionFijarVentanaItem.Checked = true;
            configuracionFijarVentanaItem.CheckOnClick = true;
            configuracionFijarVentanaItem.CheckState = CheckState.Checked;
            configuracionFijarVentanaItem.DoubleClickEnabled = true;
            configuracionFijarVentanaItem.Name = "configuracionFijarVentanaItem";
            configuracionFijarVentanaItem.Size = new Size(213, 22);
            configuracionFijarVentanaItem.Text = "Fijar ventana";
            configuracionFijarVentanaItem.Click += fijarConfiguracionItem_Click;
            // 
            // configuracionRutaCompletaItem
            // 
            configuracionRutaCompletaItem.Checked = true;
            configuracionRutaCompletaItem.CheckOnClick = true;
            configuracionRutaCompletaItem.CheckState = CheckState.Checked;
            configuracionRutaCompletaItem.Name = "configuracionRutaCompletaItem";
            configuracionRutaCompletaItem.Size = new Size(213, 22);
            configuracionRutaCompletaItem.Text = "Ruta archivo completa";
            configuracionRutaCompletaItem.Click += configuracionRutaCompletaItem_Click;
            // 
            // AarchivoGuardarComoItem
            // 
            AarchivoGuardarComoItem.Name = "AarchivoGuardarComoItem";
            AarchivoGuardarComoItem.Size = new Size(32, 19);
            // 
            // pnlMensajes
            // 
            pnlMensajes.BackColor = Color.FromArgb(230, 230, 230);
            pnlMensajes.Controls.Add(lbArchivo);
            pnlMensajes.Controls.Add(lbEstadoVentana);
            pnlMensajes.Dock = DockStyle.Bottom;
            pnlMensajes.Location = new Point(4, 576);
            pnlMensajes.Name = "pnlMensajes";
            pnlMensajes.Size = new Size(492, 20);
            pnlMensajes.TabIndex = 3;
            // 
            // lbArchivo
            // 
            lbArchivo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbArchivo.AutoEllipsis = true;
            lbArchivo.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbArchivo.Location = new Point(0, 0);
            lbArchivo.Margin = new Padding(0);
            lbArchivo.Name = "lbArchivo";
            lbArchivo.Padding = new Padding(10, 3, 0, 3);
            lbArchivo.Size = new Size(380, 20);
            lbArchivo.TabIndex = 26;
            lbArchivo.Text = " ";
            lbArchivo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbEstadoVentana
            // 
            lbEstadoVentana.Dock = DockStyle.Right;
            lbEstadoVentana.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEstadoVentana.Location = new Point(381, 0);
            lbEstadoVentana.Name = "lbEstadoVentana";
            lbEstadoVentana.Padding = new Padding(0, 0, 10, 0);
            lbEstadoVentana.Size = new Size(111, 20);
            lbEstadoVentana.TabIndex = 25;
            lbEstadoVentana.Text = "Ventana fijada";
            lbEstadoVentana.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmVisorPDF
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 600);
            Controls.Add(pnlVisor);
            Controls.Add(pnlHerramientas);
            Controls.Add(menuStrip);
            Controls.Add(pnlTitulo);
            Controls.Add(pnlSuperior);
            Controls.Add(pnlMensajes);
            Controls.Add(pnlInferior);
            Controls.Add(pnlIzquierdo);
            Controls.Add(pnlDerecho);
            DoubleBuffered = true;
            Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(400, 600);
            Name = "frmVisorPDF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += frmVisorPDF_FormClosing;
            Load += frmVisorPDF_Load;
            ResizeEnd += frmVisorPDF_ResizeEnd;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlHerramientas.ResumeLayout(false);
            pnlHerramientas.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            pnlMensajes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTitulo;
        private Panel pnlHerramientas;
        private Button btnCerrar;
        private Panel pnlVisor;
        private Button btnMaximizar;
        private Button btnMinimizar;
        private Label label1;
        private Button button3;
        private ImageList imageList1;
        private Button btnPrimero;
        private Button btnAvance;
        private Button btnUltimo;
        private Button btnRetroceso;
        private ImageList ctrlVentana;
        private Panel panel3;
        private Panel pnlSuperior;
        private Panel pnlDerecho;
        private Panel pnlInferior;
        private ImageList ctrlPDF;
        private Panel pnlIzquierdo;
        private Button btnAumentar;
        private Button btnDisminuir;
        private MenuStrip menuStrip;
        private ToolStripMenuItem archivoItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem archivoGuardarComoItem;
        private ToolStripMenuItem archivoAbrirItem;
        private ToolStripMenuItem archivoCerrarItem;
        private ToolStripMenuItem AarchivoGuardarComoItem;
        private ToolStripMenuItem configuracionItem;
        private ToolStripMenuItem configuracionFijarVentanaItem;
        private Panel pnlMensajes;
        private Label lbEstadoVentana;
        private Label lbArchivo;
        private ToolStripMenuItem configuracionRutaCompletaItem;
        private ToolStripMenuItem envioItem;
        private ToolStripMenuItem enviarImprimirItem;
        private ToolStripMenuItem enviarEmailItem;
        private TextBox txtNumeroPagina;
        private TextBox txtTotalPaginas;
        private Button btnAjusteAncho;
        private Button btnAjustePagina;
        private Button btnAjusteAlto;
        private ComboBox cbxZoom;
    }
}

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
            chkFijar = new CheckBox();
            label1 = new Label();
            btnMaximizar = new Button();
            ctrlVentana = new ImageList(components);
            btnMinimizar = new Button();
            btnCerrar = new Button();
            pnlSuperior = new Panel();
            pnlHerramientas = new Panel();
            txtZoom = new TextBox();
            btnDisminuir = new Button();
            ctrlPDF = new ImageList(components);
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
            AarchivoGuardarComoItem = new ToolStripMenuItem();
            pnlTitulo.SuspendLayout();
            pnlHerramientas.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.Silver;
            pnlTitulo.Controls.Add(chkFijar);
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
            // 
            // chkFijar
            // 
            chkFijar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkFijar.AutoSize = true;
            chkFijar.Checked = true;
            chkFijar.CheckState = CheckState.Checked;
            chkFijar.Location = new Point(260, 12);
            chkFijar.Name = "chkFijar";
            chkFijar.Size = new Size(99, 19);
            chkFijar.TabIndex = 20;
            chkFijar.Text = "Fijar ventana";
            chkFijar.TextAlign = ContentAlignment.MiddleCenter;
            chkFijar.UseVisualStyleBackColor = true;
            chkFijar.CheckedChanged += chkFijar_CheckedChanged;
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
            btnMaximizar.TabIndex = 22;
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
            btnMinimizar.TabIndex = 21;
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
            btnCerrar.TabIndex = 23;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = SystemColors.ScrollBar;
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
            pnlHerramientas.Controls.Add(txtZoom);
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
            pnlHerramientas.Size = new Size(492, 40);
            pnlHerramientas.TabIndex = 1;
            // 
            // txtZoom
            // 
            txtZoom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtZoom.BackColor = Color.White;
            txtZoom.BorderStyle = BorderStyle.None;
            txtZoom.Font = new Font("Calibri", 12F);
            txtZoom.ForeColor = Color.Black;
            txtZoom.Location = new Point(390, 10);
            txtZoom.Name = "txtZoom";
            txtZoom.Size = new Size(50, 20);
            txtZoom.TabIndex = 7;
            txtZoom.TextAlign = HorizontalAlignment.Center;
            txtZoom.Validated += txtZoom_Validated;
            // 
            // btnDisminuir
            // 
            btnDisminuir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDisminuir.BackColor = Color.Transparent;
            btnDisminuir.FlatAppearance.BorderSize = 0;
            btnDisminuir.FlatStyle = FlatStyle.Flat;
            btnDisminuir.ImageIndex = 5;
            btnDisminuir.ImageList = ctrlPDF;
            btnDisminuir.Location = new Point(450, 4);
            btnDisminuir.Name = "btnDisminuir";
            btnDisminuir.Size = new Size(30, 30);
            btnDisminuir.TabIndex = 8;
            btnDisminuir.UseVisualStyleBackColor = false;
            btnDisminuir.Click += btnDisminuir_Click;
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
            // 
            // btnAumentar
            // 
            btnAumentar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAumentar.BackColor = Color.Transparent;
            btnAumentar.FlatAppearance.BorderSize = 0;
            btnAumentar.FlatStyle = FlatStyle.Flat;
            btnAumentar.ImageIndex = 4;
            btnAumentar.ImageList = ctrlPDF;
            btnAumentar.Location = new Point(350, 4);
            btnAumentar.Name = "btnAumentar";
            btnAumentar.Size = new Size(30, 30);
            btnAumentar.TabIndex = 6;
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
            btnPrimero.Location = new Point(10, 4);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(30, 30);
            btnPrimero.TabIndex = 2;
            btnPrimero.UseVisualStyleBackColor = false;
            // 
            // btnRetroceso
            // 
            btnRetroceso.BackColor = Color.Transparent;
            btnRetroceso.FlatAppearance.BorderSize = 0;
            btnRetroceso.FlatStyle = FlatStyle.Flat;
            btnRetroceso.ImageIndex = 2;
            btnRetroceso.ImageList = ctrlPDF;
            btnRetroceso.Location = new Point(50, 4);
            btnRetroceso.Name = "btnRetroceso";
            btnRetroceso.Size = new Size(30, 30);
            btnRetroceso.TabIndex = 3;
            btnRetroceso.UseVisualStyleBackColor = false;
            // 
            // btnAvance
            // 
            btnAvance.BackColor = Color.Transparent;
            btnAvance.FlatAppearance.BorderSize = 0;
            btnAvance.FlatStyle = FlatStyle.Flat;
            btnAvance.ImageIndex = 0;
            btnAvance.ImageList = ctrlPDF;
            btnAvance.Location = new Point(90, 4);
            btnAvance.Name = "btnAvance";
            btnAvance.Size = new Size(30, 30);
            btnAvance.TabIndex = 4;
            btnAvance.UseVisualStyleBackColor = false;
            // 
            // btnUltimo
            // 
            btnUltimo.BackColor = Color.Transparent;
            btnUltimo.FlatAppearance.BorderSize = 0;
            btnUltimo.FlatStyle = FlatStyle.Flat;
            btnUltimo.ImageIndex = 3;
            btnUltimo.ImageList = ctrlPDF;
            btnUltimo.Location = new Point(130, 4);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(30, 30);
            btnUltimo.TabIndex = 5;
            btnUltimo.UseVisualStyleBackColor = false;
            // 
            // pnlVisor
            // 
            pnlVisor.BackColor = Color.WhiteSmoke;
            pnlVisor.Dock = DockStyle.Top;
            pnlVisor.Location = new Point(4, 110);
            pnlVisor.Name = "pnlVisor";
            pnlVisor.Size = new Size(492, 412);
            pnlVisor.TabIndex = 1;
            // 
            // pnlIzquierdo
            // 
            pnlIzquierdo.BackColor = SystemColors.ScrollBar;
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
            pnlDerecho.BackColor = SystemColors.ScrollBar;
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
            pnlInferior.BackColor = SystemColors.ScrollBar;
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
            menuStrip.BackColor = Color.Gainsboro;
            menuStrip.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip.Items.AddRange(new ToolStripItem[] { archivoItem });
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
            archivoAbrirItem.Size = new Size(180, 22);
            archivoAbrirItem.Text = "Abrir...";
            archivoAbrirItem.Click += archivoAbrirItem_Click;
            // 
            // archivoCerrarItem
            // 
            archivoCerrarItem.Name = "archivoCerrarItem";
            archivoCerrarItem.Size = new Size(180, 22);
            archivoCerrarItem.Text = "Cerrar";
            archivoCerrarItem.Click += archivoCerrarItem_Click;
            // 
            // archivoGuardarComoItem
            // 
            archivoGuardarComoItem.Name = "archivoGuardarComoItem";
            archivoGuardarComoItem.Size = new Size(180, 22);
            archivoGuardarComoItem.Text = "Guardar como...";
            archivoGuardarComoItem.Click += archivoGuardarComoItem_Click;
            // 
            // AarchivoGuardarComoItem
            // 
            AarchivoGuardarComoItem.Name = "AarchivoGuardarComoItem";
            AarchivoGuardarComoItem.Size = new Size(32, 19);
            // 
            // frmVisorPDF
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 600);
            Controls.Add(pnlInferior);
            Controls.Add(pnlVisor);
            Controls.Add(pnlHerramientas);
            Controls.Add(menuStrip);
            Controls.Add(pnlTitulo);
            Controls.Add(pnlSuperior);
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
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlHerramientas.ResumeLayout(false);
            pnlHerramientas.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
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
        private TextBox txtZoom;
        private CheckBox chkFijar;
        private MenuStrip menuStrip;
        private ToolStripMenuItem archivoItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem archivoGuardarComoItem;
        private ToolStripMenuItem archivoAbrirItem;
        private ToolStripMenuItem archivoCerrarItem;
        private ToolStripMenuItem AarchivoGuardarComoItem;
    }
}

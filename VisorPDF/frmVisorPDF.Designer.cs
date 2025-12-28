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
            btnFijar = new Button();
            label1 = new Label();
            btnMaximizar = new Button();
            ctrlVentana = new ImageList(components);
            btnMinimizar = new Button();
            btnCerrar = new Button();
            pnlSuperior = new Panel();
            pnlHerramientas = new Panel();
            btnPrimero = new Button();
            ctrlPDF = new ImageList(components);
            btnRetroceso = new Button();
            btnAvance = new Button();
            btnUltimo = new Button();
            pnlVisor = new Panel();
            pnlIzquierdo = new Panel();
            pnlDerecho = new Panel();
            pnlInferior = new Panel();
            pnlTitulo.SuspendLayout();
            pnlHerramientas.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.Gainsboro;
            pnlTitulo.Controls.Add(btnFijar);
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
            // btnFijar
            // 
            btnFijar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFijar.BackColor = Color.Transparent;
            btnFijar.FlatAppearance.BorderSize = 0;
            btnFijar.FlatStyle = FlatStyle.Flat;
            btnFijar.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFijar.Image = Properties.Resources.Activo;
            btnFijar.ImageAlign = ContentAlignment.MiddleRight;
            btnFijar.Location = new Point(246, 1);
            btnFijar.Name = "btnFijar";
            btnFijar.Size = new Size(92, 38);
            btnFijar.TabIndex = 4;
            btnFijar.Text = "Fijar \r\nventana";
            btnFijar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnFijar.UseVisualStyleBackColor = false;
            btnFijar.Click += btnFijar_Click;
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
            btnMaximizar.Location = new Point(401, 2);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(36, 36);
            btnMaximizar.TabIndex = 2;
            btnMaximizar.UseVisualStyleBackColor = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // ctrlVentana
            // 
            ctrlVentana.ColorDepth = ColorDepth.Depth32Bit;
            ctrlVentana.ImageStream = (ImageListStreamer)resources.GetObject("ctrlVentana.ImageStream");
            ctrlVentana.TransparentColor = Color.Transparent;
            ctrlVentana.Images.SetKeyName(0, "Cerrar.png");
            ctrlVentana.Images.SetKeyName(1, "Maximizar.png");
            ctrlVentana.Images.SetKeyName(2, "Minimizar.png");
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.Transparent;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.ImageIndex = 2;
            btnMinimizar.ImageList = ctrlVentana;
            btnMinimizar.Location = new Point(346, 2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(36, 36);
            btnMinimizar.TabIndex = 1;
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
            btnCerrar.Location = new Point(453, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(36, 36);
            btnCerrar.TabIndex = 0;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.LightGray;
            pnlSuperior.Cursor = Cursors.SizeNS;
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(500, 4);
            pnlSuperior.TabIndex = 1;
            pnlSuperior.MouseDown += pnlSuperior_MouseDown;
            pnlSuperior.MouseLeave += pnlSuperior_MouseLeave;
            pnlSuperior.MouseMove += pnlSuperior_MouseMove;
            pnlSuperior.MouseUp += pnlSuperior_MouseUp;
            // 
            // pnlHerramientas
            // 
            pnlHerramientas.BackColor = Color.FromArgb(237, 237, 237);
            pnlHerramientas.Controls.Add(btnPrimero);
            pnlHerramientas.Controls.Add(btnRetroceso);
            pnlHerramientas.Controls.Add(btnAvance);
            pnlHerramientas.Controls.Add(btnUltimo);
            pnlHerramientas.Dock = DockStyle.Top;
            pnlHerramientas.ForeColor = Color.Black;
            pnlHerramientas.Location = new Point(4, 44);
            pnlHerramientas.Name = "pnlHerramientas";
            pnlHerramientas.Size = new Size(492, 40);
            pnlHerramientas.TabIndex = 1;
            // 
            // btnPrimero
            // 
            btnPrimero.BackColor = Color.Transparent;
            btnPrimero.FlatAppearance.BorderSize = 0;
            btnPrimero.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            btnPrimero.FlatStyle = FlatStyle.Flat;
            btnPrimero.ImageIndex = 1;
            btnPrimero.ImageList = ctrlPDF;
            btnPrimero.Location = new Point(5, 1);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(36, 36);
            btnPrimero.TabIndex = 8;
            btnPrimero.UseVisualStyleBackColor = false;
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
            // 
            // btnRetroceso
            // 
            btnRetroceso.BackColor = Color.Transparent;
            btnRetroceso.FlatAppearance.BorderSize = 0;
            btnRetroceso.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            btnRetroceso.FlatStyle = FlatStyle.Flat;
            btnRetroceso.ImageIndex = 2;
            btnRetroceso.ImageList = ctrlPDF;
            btnRetroceso.Location = new Point(56, 1);
            btnRetroceso.Name = "btnRetroceso";
            btnRetroceso.Size = new Size(36, 36);
            btnRetroceso.TabIndex = 7;
            btnRetroceso.UseVisualStyleBackColor = false;
            // 
            // btnAvance
            // 
            btnAvance.BackColor = Color.Transparent;
            btnAvance.FlatAppearance.BorderSize = 0;
            btnAvance.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            btnAvance.FlatStyle = FlatStyle.Flat;
            btnAvance.ImageIndex = 0;
            btnAvance.ImageList = ctrlPDF;
            btnAvance.Location = new Point(107, 1);
            btnAvance.Name = "btnAvance";
            btnAvance.Size = new Size(36, 36);
            btnAvance.TabIndex = 6;
            btnAvance.UseVisualStyleBackColor = false;
            // 
            // btnUltimo
            // 
            btnUltimo.BackColor = Color.Transparent;
            btnUltimo.FlatAppearance.BorderSize = 0;
            btnUltimo.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            btnUltimo.FlatStyle = FlatStyle.Flat;
            btnUltimo.ImageIndex = 3;
            btnUltimo.ImageList = ctrlPDF;
            btnUltimo.Location = new Point(158, 1);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(36, 36);
            btnUltimo.TabIndex = 5;
            btnUltimo.UseVisualStyleBackColor = false;
            // 
            // pnlVisor
            // 
            pnlVisor.BackColor = Color.WhiteSmoke;
            pnlVisor.Dock = DockStyle.Fill;
            pnlVisor.Location = new Point(0, 0);
            pnlVisor.Name = "pnlVisor";
            pnlVisor.Size = new Size(500, 600);
            pnlVisor.TabIndex = 2;
            // 
            // pnlIzquierdo
            // 
            pnlIzquierdo.BackColor = Color.LightGray;
            pnlIzquierdo.Cursor = Cursors.SizeWE;
            pnlIzquierdo.Dock = DockStyle.Left;
            pnlIzquierdo.Location = new Point(0, 4);
            pnlIzquierdo.Name = "pnlIzquierdo";
            pnlIzquierdo.Size = new Size(4, 592);
            pnlIzquierdo.TabIndex = 2;
            pnlIzquierdo.MouseDown += pnlIzquierdo_MouseDown;
            pnlIzquierdo.MouseLeave += pnlIzquierdo_MouseLeave;
            pnlIzquierdo.MouseMove += pnlIzquierdo_MouseMove;
            pnlIzquierdo.MouseUp += pnlIzquierdo_MouseUp;
            // 
            // pnlDerecho
            // 
            pnlDerecho.BackColor = Color.FromArgb(208, 208, 208);
            pnlDerecho.Cursor = Cursors.SizeWE;
            pnlDerecho.Dock = DockStyle.Right;
            pnlDerecho.Location = new Point(496, 4);
            pnlDerecho.Name = "pnlDerecho";
            pnlDerecho.Size = new Size(4, 592);
            pnlDerecho.TabIndex = 1;
            pnlDerecho.MouseDown += pnlDerecho_MouseDown;
            pnlDerecho.MouseLeave += pnlDerecho_MouseLeave;
            pnlDerecho.MouseMove += pnlDerecho_MouseMove;
            pnlDerecho.MouseUp += pnlDerecho_MouseUp;
            // 
            // pnlInferior
            // 
            pnlInferior.BackColor = Color.LightGray;
            pnlInferior.Cursor = Cursors.SizeNS;
            pnlInferior.Dock = DockStyle.Bottom;
            pnlInferior.Location = new Point(0, 596);
            pnlInferior.Name = "pnlInferior";
            pnlInferior.Size = new Size(500, 4);
            pnlInferior.TabIndex = 0;
            pnlInferior.MouseDown += pnlInferior_MouseDown;
            pnlInferior.MouseLeave += pnlInferior_MouseLeave;
            pnlInferior.MouseMove += pnlInferior_MouseMove;
            pnlInferior.MouseUp += pnlInferior_MouseUp;
            // 
            // frmVisorPDF
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 600);
            Controls.Add(pnlHerramientas);
            Controls.Add(pnlTitulo);
            Controls.Add(pnlIzquierdo);
            Controls.Add(pnlDerecho);
            Controls.Add(pnlInferior);
            Controls.Add(pnlSuperior);
            Controls.Add(pnlVisor);
            DoubleBuffered = true;
            Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(400, 600);
            Name = "frmVisorPDF";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlHerramientas.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Panel pnlHerramientas;
        private Button btnCerrar;
        private Panel pnlVisor;
        private Button btnMaximizar;
        private Button btnMinimizar;
        private Label label1;
        private Button btnFijar;
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
    }
}

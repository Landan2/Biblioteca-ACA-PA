namespace Biblioteca_ACA_PA
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            pnlMenu = new Panel();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnReportes = new FontAwesome.Sharp.IconButton();
            btnPrestamos = new FontAwesome.Sharp.IconButton();
            btnEditoriales = new FontAwesome.Sharp.IconButton();
            btnAutores = new FontAwesome.Sharp.IconButton();
            btnUsuarios = new FontAwesome.Sharp.IconButton();
            btnLibros = new FontAwesome.Sharp.IconButton();
            btnInicio = new FontAwesome.Sharp.IconButton();
            pnlLogo = new Panel();
            picLogo = new PictureBox();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            pnlSuperior = new Panel();
            pnlEstado = new Panel();
            pnlContenido = new Panel();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.DarkGray;
            pnlMenu.Controls.Add(btnSalir);
            pnlMenu.Controls.Add(btnReportes);
            pnlMenu.Controls.Add(btnPrestamos);
            pnlMenu.Controls.Add(btnEditoriales);
            pnlMenu.Controls.Add(btnAutores);
            pnlMenu.Controls.Add(btnUsuarios);
            pnlMenu.Controls.Add(btnLibros);
            pnlMenu.Controls.Add(btnInicio);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);

            pnlMenu.Margin = new Padding(3, 4, 3, 4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(343, 600);

            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(300, 450);

            pnlMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.AutoSize = true;
            btnSalir.BackColor = Color.WhiteSmoke;
            btnSalir.Dock = DockStyle.Top;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.Font = new Font("Sitka Subheading Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 30;

            btnSalir.Location = new Point(0, 484);
            btnSalir.Margin = new Padding(0, 13, 0, 13);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(343, 52);

            btnSalir.Location = new Point(0, 349);
            btnSalir.Margin = new Padding(0, 10, 0, 10);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(300, 37);
            
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnReportes
            // 
            btnReportes.AutoSize = true;
            btnReportes.BackColor = Color.WhiteSmoke;
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.Font = new Font("Sitka Subheading Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.IconChar = FontAwesome.Sharp.IconChar.Readme;
            btnReportes.IconColor = Color.Black;
            btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportes.IconSize = 30;

            btnReportes.Location = new Point(0, 432);
            btnReportes.Margin = new Padding(0, 13, 0, 13);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(343, 52);

            btnReportes.Location = new Point(0, 312);
            btnReportes.Margin = new Padding(0, 10, 0, 10);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(300, 37);

            btnReportes.TabIndex = 7;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.AutoSize = true;
            btnPrestamos.BackColor = Color.WhiteSmoke;
            btnPrestamos.Dock = DockStyle.Top;
            btnPrestamos.FlatAppearance.BorderSize = 0;
            btnPrestamos.Font = new Font("Sitka Subheading Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrestamos.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            btnPrestamos.IconColor = Color.Black;
            btnPrestamos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrestamos.IconSize = 30;

            btnPrestamos.Location = new Point(0, 380);
            btnPrestamos.Margin = new Padding(0, 13, 0, 13);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(343, 52);

            btnPrestamos.Location = new Point(0, 275);
            btnPrestamos.Margin = new Padding(0, 10, 0, 10);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(300, 37);

            btnPrestamos.TabIndex = 6;
            btnPrestamos.Text = "Prestamos";
            btnPrestamos.TextAlign = ContentAlignment.MiddleLeft;
            btnPrestamos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrestamos.UseVisualStyleBackColor = false;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // btnEditoriales
            // 
            btnEditoriales.AutoSize = true;
            btnEditoriales.BackColor = Color.WhiteSmoke;
            btnEditoriales.Dock = DockStyle.Top;
            btnEditoriales.FlatAppearance.BorderSize = 0;
            btnEditoriales.Font = new Font("Sitka Subheading Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditoriales.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            btnEditoriales.IconColor = Color.Black;
            btnEditoriales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditoriales.IconSize = 30;

            btnEditoriales.Location = new Point(0, 328);
            btnEditoriales.Margin = new Padding(0, 13, 0, 13);
            btnEditoriales.Name = "btnEditoriales";
            btnEditoriales.Size = new Size(343, 52);

            btnEditoriales.Location = new Point(0, 238);
            btnEditoriales.Margin = new Padding(0, 10, 0, 10);
            btnEditoriales.Name = "btnEditoriales";
            btnEditoriales.Size = new Size(300, 37);

            btnEditoriales.TabIndex = 5;
            btnEditoriales.Text = "Editoriales";
            btnEditoriales.TextAlign = ContentAlignment.MiddleLeft;
            btnEditoriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditoriales.UseVisualStyleBackColor = false;
            btnEditoriales.Click += btnEditoriales_Click;
            // 
            // btnAutores
            // 
            btnAutores.AutoSize = true;
            btnAutores.BackColor = Color.WhiteSmoke;
            btnAutores.Dock = DockStyle.Top;
            btnAutores.FlatAppearance.BorderSize = 0;
            btnAutores.Font = new Font("Sitka Subheading Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutores.IconChar = FontAwesome.Sharp.IconChar.UserPen;
            btnAutores.IconColor = Color.Black;
            btnAutores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAutores.IconSize = 30;

            btnAutores.Location = new Point(0, 276);
            btnAutores.Margin = new Padding(0, 13, 0, 13);
            btnAutores.Name = "btnAutores";
            btnAutores.Size = new Size(343, 52);

            btnAutores.Location = new Point(0, 201);
            btnAutores.Margin = new Padding(0, 10, 0, 10);
            btnAutores.Name = "btnAutores";
            btnAutores.Size = new Size(300, 37);

            btnAutores.TabIndex = 4;
            btnAutores.Text = "Autores";
            btnAutores.TextAlign = ContentAlignment.MiddleLeft;
            btnAutores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAutores.UseVisualStyleBackColor = false;
            btnAutores.Click += btnAutores_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.AutoSize = true;
            btnUsuarios.BackColor = Color.WhiteSmoke;
            btnUsuarios.Dock = DockStyle.Top;
            btnUsuarios.FlatAppearance.BorderSize = 0;
            btnUsuarios.Font = new Font("Sitka Subheading Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            btnUsuarios.IconColor = Color.Black;
            btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUsuarios.IconSize = 30;

            btnUsuarios.Location = new Point(0, 224);
            btnUsuarios.Margin = new Padding(0, 13, 0, 13);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(343, 52);

            btnUsuarios.Location = new Point(0, 164);
            btnUsuarios.Margin = new Padding(0, 10, 0, 10);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(300, 37);

            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnLibros
            // 
            btnLibros.AutoSize = true;
            btnLibros.BackColor = Color.WhiteSmoke;
            btnLibros.Dock = DockStyle.Top;
            btnLibros.FlatAppearance.BorderSize = 0;
            btnLibros.Font = new Font("Sitka Subheading Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLibros.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnLibros.IconColor = Color.Black;
            btnLibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLibros.IconSize = 30;

            btnLibros.Location = new Point(0, 172);
            btnLibros.Margin = new Padding(0, 13, 0, 13);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(343, 52);

            btnLibros.Location = new Point(0, 127);
            btnLibros.Margin = new Padding(0, 10, 0, 10);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(300, 37);

            btnLibros.TabIndex = 2;
            btnLibros.Text = "Libros";
            btnLibros.TextAlign = ContentAlignment.MiddleLeft;
            btnLibros.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLibros.UseVisualStyleBackColor = false;
            btnLibros.Click += btnLibros_Click;
            // 
            // btnInicio
            // 
            btnInicio.AutoSize = true;
            btnInicio.BackColor = Color.WhiteSmoke;
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.Font = new Font("Sitka Subheading Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            btnInicio.IconColor = Color.Black;
            btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInicio.IconSize = 30;

            btnInicio.Location = new Point(0, 120);
            btnInicio.Margin = new Padding(0, 13, 0, 13);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(343, 52);

            btnInicio.Location = new Point(0, 90);
            btnInicio.Margin = new Padding(0, 10, 0, 10);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(300, 37);

            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.Black;
            pnlLogo.Controls.Add(picLogo);
            pnlLogo.Controls.Add(lblSubtitulo);
            pnlLogo.Controls.Add(lblTitulo);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);

            pnlLogo.Margin = new Padding(3, 4, 3, 4);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(343, 120);

            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(300, 90);

            pnlLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.DarkGray;
            picLogo.BackgroundImageLayout = ImageLayout.Zoom;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");

            picLogo.Location = new Point(3, 4);
            picLogo.Margin = new Padding(3, 4, 3, 4);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(127, 112);

            picLogo.Location = new Point(3, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(111, 84);

            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Maroon;
            lblSubtitulo.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = SystemColors.ButtonShadow;

            lblSubtitulo.Location = new Point(137, 60);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(172, 28);

            lblSubtitulo.Location = new Point(120, 45);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(137, 21);

            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Sistema de Gestión";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Maroon;
            lblTitulo.Font = new Font("Sitka Heading", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;

            lblTitulo.Location = new Point(137, 4);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(230, 53);

            lblTitulo.Location = new Point(120, 3);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(180, 42);

            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "BIBLIOTECA";
            // 
            // pnlSuperior
            // 

            pnlSuperior.BackColor = Color.LightGray;
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(343, 0);
            pnlSuperior.Margin = new Padding(3, 4, 3, 4);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(462, 120);

            pnlSuperior.BackColor = SystemColors.ActiveBorder;
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(300, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(404, 90);

            pnlSuperior.TabIndex = 1;
            // 
            // pnlEstado
            // 
            pnlEstado.BackColor = SystemColors.ScrollBar;
            pnlEstado.Dock = DockStyle.Bottom;

            pnlEstado.Location = new Point(343, 545);
            pnlEstado.Margin = new Padding(3, 4, 3, 4);
            pnlEstado.Name = "pnlEstado";
            pnlEstado.Size = new Size(462, 55);
            pnlEstado.Location = new Point(300, 409);
            pnlEstado.Name = "pnlEstado";
            pnlEstado.Size = new Size(404, 41);

            pnlEstado.TabIndex = 2;
            // 
            // pnlContenido
            // 

            pnlContenido.BackColor = SystemColors.GradientActiveCaption;
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(343, 120);
            pnlContenido.Margin = new Padding(3, 4, 3, 4);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(462, 425);

            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(300, 90);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(404, 319);

            pnlContenido.TabIndex = 3;
            // 
            // FrmPrincipal
            // 

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 600);

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 450);

            Controls.Add(pnlContenido);
            Controls.Add(pnlEstado);
            Controls.Add(pnlSuperior);
            Controls.Add(pnlMenu);

            Margin = new Padding(3, 4, 3, 4);

            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlLogo;
        private Label lblTitulo;
        private Panel pnlSuperior;
        private Panel pnlEstado;
        private Panel pnlContenido;
        private Label lblSubtitulo;
        private PictureBox picLogo;
        private FontAwesome.Sharp.IconButton btnInicio;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnLibros;
        private FontAwesome.Sharp.IconButton btnEditoriales;
        private FontAwesome.Sharp.IconButton btnAutores;
        private FontAwesome.Sharp.IconButton btnPrestamos;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}

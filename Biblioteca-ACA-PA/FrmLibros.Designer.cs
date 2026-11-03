namespace Biblioteca_ACA_PA
{
    partial class FrmLibros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTitulos = new Panel();
            lblTitulo = new Label();
            pnlBusqueda = new Panel();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            pnlDatos = new Panel();
            cmbEditorial = new ComboBox();
            cmbAutor = new ComboBox();
            txtExsistencias = new TextBox();
            txtAño = new TextBox();
            txtCategoria = new TextBox();
            txtTitulo = new TextBox();
            txtISBN = new TextBox();
            lblExistencias = new Label();
            lblAño = new Label();
            lblCategoria = new Label();
            lblEditorial = new Label();
            lblAutor = new Label();
            lblTituloLibro = new Label();
            lblISBN = new Label();
            pnlTitulos.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlDatos.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulos
            // 
            pnlTitulos.BackColor = Color.LightGray;
            pnlTitulos.Controls.Add(lblTitulo);
            pnlTitulos.Dock = DockStyle.Top;
            pnlTitulos.Location = new Point(0, 0);
            pnlTitulos.Name = "pnlTitulos";
            pnlTitulos.Size = new Size(800, 60);
            pnlTitulos.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Sitka Banner", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ActiveCaptionText;
            lblTitulo.Location = new Point(272, 4);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(285, 53);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Libros";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.WhiteSmoke;
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscar);
            pnlBusqueda.Controls.Add(lblBuscar);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 60);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(800, 55);
            pnlBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(447, 23);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(241, 23);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(181, 23);
            txtBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(144, 23);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(91, 19);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "ISBN-Codigo";
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(cmbEditorial);
            pnlDatos.Controls.Add(cmbAutor);
            pnlDatos.Controls.Add(txtExsistencias);
            pnlDatos.Controls.Add(txtAño);
            pnlDatos.Controls.Add(txtCategoria);
            pnlDatos.Controls.Add(txtTitulo);
            pnlDatos.Controls.Add(txtISBN);
            pnlDatos.Controls.Add(lblExistencias);
            pnlDatos.Controls.Add(lblAño);
            pnlDatos.Controls.Add(lblCategoria);
            pnlDatos.Controls.Add(lblEditorial);
            pnlDatos.Controls.Add(lblAutor);
            pnlDatos.Controls.Add(lblTituloLibro);
            pnlDatos.Controls.Add(lblISBN);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Location = new Point(0, 115);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(800, 336);
            pnlDatos.TabIndex = 2;
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(275, 156);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(180, 23);
            cmbEditorial.TabIndex = 15;
            // 
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(275, 117);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(180, 23);
            cmbAutor.TabIndex = 14;
            // 
            // txtExsistencias
            // 
            txtExsistencias.Location = new Point(269, 284);
            txtExsistencias.Name = "txtExsistencias";
            txtExsistencias.Size = new Size(186, 23);
            txtExsistencias.TabIndex = 13;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(269, 239);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(186, 23);
            txtAño.TabIndex = 12;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(272, 196);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(186, 23);
            txtCategoria.TabIndex = 11;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(272, 71);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(186, 23);
            txtTitulo.TabIndex = 8;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(272, 34);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(186, 23);
            txtISBN.TabIndex = 3;
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExistencias.Location = new Point(167, 284);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(88, 19);
            lblExistencias.TabIndex = 7;
            lblExistencias.Text = "Existencias:";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAño.Location = new Point(167, 243);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(39, 19);
            lblAño.TabIndex = 6;
            lblAño.Text = "Año:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(167, 200);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(75, 19);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoria:";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditorial.Location = new Point(167, 156);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(72, 19);
            lblEditorial.TabIndex = 4;
            lblEditorial.Text = "Editorial:";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutor.Location = new Point(170, 115);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(50, 19);
            lblAutor.TabIndex = 3;
            lblAutor.Text = "Autor:";
            // 
            // lblTituloLibro
            // 
            lblTituloLibro.AutoSize = true;
            lblTituloLibro.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLibro.Location = new Point(170, 71);
            lblTituloLibro.Name = "lblTituloLibro";
            lblTituloLibro.Size = new Size(54, 19);
            lblTituloLibro.TabIndex = 2;
            lblTituloLibro.Text = "Titulo:";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Sitka Text", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.Location = new Point(170, 34);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(96, 19);
            lblISBN.TabIndex = 1;
            lblISBN.Text = "ISBN-Codigo:";
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlTitulos);
            Name = "FrmLibros";
            Text = "FrmLibros";
            pnlTitulos.ResumeLayout(false);
            pnlTitulos.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulos;
        private Label lblTitulo;
        private Panel pnlBusqueda;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private Panel pnlDatos;
        private Label lblISBN;
        private Label lblTituloLibro;
        private Label lblAutor;
        private Label lblAño;
        private Label lblCategoria;
        private Label lblEditorial;
        private TextBox txtAño;
        private TextBox txtCategoria;
        private TextBox txtTitulo;
        private TextBox txtISBN;
        private Label lblExistencias;
        private TextBox txtExsistencias;
        private ComboBox cmbEditorial;
        private ComboBox cmbAutor;
    }
}
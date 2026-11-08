namespace Biblioteca_ACA_PA
{
    partial class FrmPrestamos
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
            pnlPrestamos = new Panel();
            lblPrestamos = new Label();
            pnlDatosPrestamos = new Panel();
            btnCancelarP = new FontAwesome.Sharp.IconButton();
            dtpFechaDevolucion = new DateTimePicker();
            btnEliminarPrestamo = new FontAwesome.Sharp.IconButton();
            dtpFechaPrestamo = new DateTimePicker();
            btnEditarPrestamo = new FontAwesome.Sharp.IconButton();
            btnGuardarPrestamo = new FontAwesome.Sharp.IconButton();
            cmbLibro = new ComboBox();
            btnNuevoPrestamo = new FontAwesome.Sharp.IconButton();
            cmbUsuario = new ComboBox();
            lblFechaDevolucion = new Label();
            lblFechaPrestamos = new Label();
            lblLibroPrestado = new Label();
            lblUsuarioPrestamos = new Label();
            pnlListaPrestamos = new Panel();
            dgvPrestamos = new DataGridView();
            pnlPrestamos.SuspendLayout();
            pnlDatosPrestamos.SuspendLayout();
            pnlListaPrestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // pnlPrestamos
            // 
            pnlPrestamos.BackColor = Color.Gainsboro;
            pnlPrestamos.Controls.Add(lblPrestamos);
            pnlPrestamos.Dock = DockStyle.Top;
            pnlPrestamos.Location = new Point(0, 0);
            pnlPrestamos.Margin = new Padding(4, 2, 4, 2);
            pnlPrestamos.Name = "pnlPrestamos";
            pnlPrestamos.Size = new Size(1065, 75);
            pnlPrestamos.TabIndex = 0;
            // 
            // lblPrestamos
            // 
            lblPrestamos.AutoSize = true;
            lblPrestamos.Font = new Font("Sitka Display", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrestamos.ForeColor = Color.Maroon;
            lblPrestamos.Location = new Point(359, 9);
            lblPrestamos.Margin = new Padding(4, 0, 4, 0);
            lblPrestamos.Name = "lblPrestamos";
            lblPrestamos.Size = new Size(343, 50);
            lblPrestamos.TabIndex = 0;
            lblPrestamos.Text = "Gestión de Prestamos";
            // 
            // pnlDatosPrestamos
            // 
            pnlDatosPrestamos.Controls.Add(btnCancelarP);
            pnlDatosPrestamos.Controls.Add(dtpFechaDevolucion);
            pnlDatosPrestamos.Controls.Add(btnEliminarPrestamo);
            pnlDatosPrestamos.Controls.Add(dtpFechaPrestamo);
            pnlDatosPrestamos.Controls.Add(btnEditarPrestamo);
            pnlDatosPrestamos.Controls.Add(btnGuardarPrestamo);
            pnlDatosPrestamos.Controls.Add(cmbLibro);
            pnlDatosPrestamos.Controls.Add(btnNuevoPrestamo);
            pnlDatosPrestamos.Controls.Add(cmbUsuario);
            pnlDatosPrestamos.Controls.Add(lblFechaDevolucion);
            pnlDatosPrestamos.Controls.Add(lblFechaPrestamos);
            pnlDatosPrestamos.Controls.Add(lblLibroPrestado);
            pnlDatosPrestamos.Controls.Add(lblUsuarioPrestamos);
            pnlDatosPrestamos.Dock = DockStyle.Top;
            pnlDatosPrestamos.Location = new Point(0, 75);
            pnlDatosPrestamos.Margin = new Padding(4, 2, 4, 2);
            pnlDatosPrestamos.Name = "pnlDatosPrestamos";
            pnlDatosPrestamos.Size = new Size(1065, 322);
            pnlDatosPrestamos.TabIndex = 1;
            // 
            // btnCancelarP
            // 
            btnCancelarP.Font = new Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarP.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelarP.IconColor = Color.Black;
            btnCancelarP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelarP.Location = new Point(839, 278);
            btnCancelarP.Margin = new Padding(4, 2, 4, 2);
            btnCancelarP.Name = "btnCancelarP";
            btnCancelarP.Size = new Size(122, 38);
            btnCancelarP.TabIndex = 9;
            btnCancelarP.Text = "Cancelar";
            btnCancelarP.UseVisualStyleBackColor = true;
            btnCancelarP.Click += btnCancelarP_Click;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.CalendarFont = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaDevolucion.Checked = false;
            dtpFechaDevolucion.Font = new Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaDevolucion.Format = DateTimePickerFormat.Short;
            dtpFechaDevolucion.Location = new Point(531, 195);
            dtpFechaDevolucion.Margin = new Padding(4, 2, 4, 2);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.ShowCheckBox = true;
            dtpFechaDevolucion.Size = new Size(288, 26);
            dtpFechaDevolucion.TabIndex = 7;
            // 
            // btnEliminarPrestamo
            // 
            btnEliminarPrestamo.Font = new Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarPrestamo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminarPrestamo.IconColor = Color.Black;
            btnEliminarPrestamo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarPrestamo.Location = new Point(656, 278);
            btnEliminarPrestamo.Margin = new Padding(4, 2, 4, 2);
            btnEliminarPrestamo.Name = "btnEliminarPrestamo";
            btnEliminarPrestamo.Size = new Size(122, 38);
            btnEliminarPrestamo.TabIndex = 8;
            btnEliminarPrestamo.Text = "Eliminar";
            btnEliminarPrestamo.UseVisualStyleBackColor = true;
            btnEliminarPrestamo.Click += btnEliminarPrestamo_Click;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.CalendarFont = new Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaPrestamo.Font = new Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaPrestamo.Format = DateTimePickerFormat.Short;
            dtpFechaPrestamo.Location = new Point(531, 139);
            dtpFechaPrestamo.Margin = new Padding(4, 2, 4, 2);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.RightToLeft = RightToLeft.No;
            dtpFechaPrestamo.Size = new Size(288, 26);
            dtpFechaPrestamo.TabIndex = 6;
            dtpFechaPrestamo.Value = new DateTime(2026, 11, 8, 11, 9, 0, 0);
            // 
            // btnEditarPrestamo
            // 
            btnEditarPrestamo.Font = new Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarPrestamo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEditarPrestamo.IconColor = Color.Black;
            btnEditarPrestamo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarPrestamo.Location = new Point(490, 278);
            btnEditarPrestamo.Margin = new Padding(4, 2, 4, 2);
            btnEditarPrestamo.Name = "btnEditarPrestamo";
            btnEditarPrestamo.Size = new Size(122, 38);
            btnEditarPrestamo.TabIndex = 7;
            btnEditarPrestamo.Text = "Editar ";
            btnEditarPrestamo.UseVisualStyleBackColor = true;
            btnEditarPrestamo.Click += btnEditarPrestamo_Click;
            // 
            // btnGuardarPrestamo
            // 
            btnGuardarPrestamo.Font = new Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarPrestamo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardarPrestamo.IconColor = Color.Black;
            btnGuardarPrestamo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarPrestamo.Location = new Point(317, 278);
            btnGuardarPrestamo.Margin = new Padding(4, 2, 4, 2);
            btnGuardarPrestamo.Name = "btnGuardarPrestamo";
            btnGuardarPrestamo.Size = new Size(122, 38);
            btnGuardarPrestamo.TabIndex = 6;
            btnGuardarPrestamo.Text = "Guardar ";
            btnGuardarPrestamo.UseVisualStyleBackColor = true;
            btnGuardarPrestamo.Click += btnGuardarPrestamo_Click;
            // 
            // cmbLibro
            // 
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(531, 81);
            cmbLibro.Margin = new Padding(4, 2, 4, 2);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(288, 31);
            cmbLibro.TabIndex = 5;
            // 
            // btnNuevoPrestamo
            // 
            btnNuevoPrestamo.Font = new Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoPrestamo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevoPrestamo.IconColor = Color.Black;
            btnNuevoPrestamo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevoPrestamo.Location = new Point(89, 278);
            btnNuevoPrestamo.Margin = new Padding(4, 2, 4, 2);
            btnNuevoPrestamo.Name = "btnNuevoPrestamo";
            btnNuevoPrestamo.Size = new Size(176, 38);
            btnNuevoPrestamo.TabIndex = 5;
            btnNuevoPrestamo.Text = "Nuevo Prestamo";
            btnNuevoPrestamo.UseVisualStyleBackColor = true;
            btnNuevoPrestamo.Click += btnNuevoPrestamo_Click;
            // 
            // cmbUsuario
            // 
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(531, 24);
            cmbUsuario.Margin = new Padding(4, 2, 4, 2);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(288, 31);
            cmbUsuario.TabIndex = 4;
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaDevolucion.Location = new Point(262, 200);
            lblFechaDevolucion.Margin = new Padding(4, 0, 4, 0);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(134, 23);
            lblFechaDevolucion.TabIndex = 3;
            lblFechaDevolucion.Text = "Fecha Devolución:";
            // 
            // lblFechaPrestamos
            // 
            lblFechaPrestamos.AutoSize = true;
            lblFechaPrestamos.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaPrestamos.Location = new Point(262, 144);
            lblFechaPrestamos.Margin = new Padding(4, 0, 4, 0);
            lblFechaPrestamos.Name = "lblFechaPrestamos";
            lblFechaPrestamos.Size = new Size(123, 23);
            lblFechaPrestamos.TabIndex = 2;
            lblFechaPrestamos.Text = "Fecha Prestamo:";
            // 
            // lblLibroPrestado
            // 
            lblLibroPrestado.AutoSize = true;
            lblLibroPrestado.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLibroPrestado.Location = new Point(262, 85);
            lblLibroPrestado.Margin = new Padding(4, 0, 4, 0);
            lblLibroPrestado.Name = "lblLibroPrestado";
            lblLibroPrestado.Size = new Size(52, 23);
            lblLibroPrestado.TabIndex = 1;
            lblLibroPrestado.Text = "Libro:";
            // 
            // lblUsuarioPrestamos
            // 
            lblUsuarioPrestamos.AutoSize = true;
            lblUsuarioPrestamos.Font = new Font("Sitka Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioPrestamos.Location = new Point(262, 26);
            lblUsuarioPrestamos.Margin = new Padding(4, 0, 4, 0);
            lblUsuarioPrestamos.Name = "lblUsuarioPrestamos";
            lblUsuarioPrestamos.Size = new Size(70, 23);
            lblUsuarioPrestamos.TabIndex = 0;
            lblUsuarioPrestamos.Text = "Usuario:";
            // 
            // pnlListaPrestamos
            // 
            pnlListaPrestamos.Controls.Add(dgvPrestamos);
            pnlListaPrestamos.Dock = DockStyle.Fill;
            pnlListaPrestamos.Location = new Point(0, 397);
            pnlListaPrestamos.Margin = new Padding(4, 2, 4, 2);
            pnlListaPrestamos.Name = "pnlListaPrestamos";
            pnlListaPrestamos.Size = new Size(1065, 352);
            pnlListaPrestamos.TabIndex = 2;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(-4, 4);
            dgvPrestamos.Margin = new Padding(4, 2, 4, 2);
            dgvPrestamos.MultiSelect = false;
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrestamos.Size = new Size(1065, 234);
            dgvPrestamos.TabIndex = 0;
            dgvPrestamos.CellDoubleClick += dgvPrestamos_CellDoubleClick;
            // 
            // FrmPrestamos
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1065, 749);
            Controls.Add(pnlListaPrestamos);
            Controls.Add(pnlDatosPrestamos);
            Controls.Add(pnlPrestamos);
            Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmPrestamos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrestamos";
            WindowState = FormWindowState.Maximized;
            pnlPrestamos.ResumeLayout(false);
            pnlPrestamos.PerformLayout();
            pnlDatosPrestamos.ResumeLayout(false);
            pnlDatosPrestamos.PerformLayout();
            pnlListaPrestamos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrestamos;
        private Panel pnlDatosPrestamos;
        private Panel pnlListaPrestamos;
        private Label lblPrestamos;
        private Label lblUsuarioPrestamos;
        private ComboBox cmbUsuario;
        private Label lblFechaDevolucion;
        private Label lblFechaPrestamos;
        private Label lblLibroPrestado;
        private DateTimePicker dtpFechaDevolucion;
        private DateTimePicker dtpFechaPrestamo;
        private ComboBox cmbLibro;
        private FontAwesome.Sharp.IconButton btnCancelarP;
        private FontAwesome.Sharp.IconButton btnEliminarPrestamo;
        private FontAwesome.Sharp.IconButton btnEditarPrestamo;
        private FontAwesome.Sharp.IconButton btnGuardarPrestamo;
        private FontAwesome.Sharp.IconButton btnNuevoPrestamo;
        private DataGridView dgvPrestamos;
    }
}
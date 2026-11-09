namespace Biblioteca_ACA_PA
{
    partial class FrmUsuarios
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
            pnlUsuarios = new Panel();
            lblUsuarios = new Label();
            pnlCargarUsuarios = new Panel();
            pnlBuscarU = new Panel();
            txtBuscarU = new TextBox();
            btnBuscarU = new Button();
            lblBuscarU = new Label();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtDocumento = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblCorreo = new Label();
            lblTelefono = new Label();
            lblDocumento = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            pnlBotonesU = new Panel();
            btnCancelarU = new FontAwesome.Sharp.IconButton();
            btnEliminarU = new FontAwesome.Sharp.IconButton();
            btnEditarU = new FontAwesome.Sharp.IconButton();
            btnGuardarU = new FontAwesome.Sharp.IconButton();
            btnNuevoU = new FontAwesome.Sharp.IconButton();
            dgvUsuarios = new DataGridView();
            pnlUsuarios.SuspendLayout();
            pnlCargarUsuarios.SuspendLayout();
            pnlBuscarU.SuspendLayout();
            pnlBotonesU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // pnlUsuarios
            // 
            pnlUsuarios.BackColor = Color.Gainsboro;
            pnlUsuarios.Controls.Add(lblUsuarios);
            pnlUsuarios.Dock = DockStyle.Top;
            pnlUsuarios.Location = new Point(0, 0);
            pnlUsuarios.Margin = new Padding(3, 5, 3, 5);
            pnlUsuarios.Name = "pnlUsuarios";
            pnlUsuarios.Size = new Size(1082, 75);
            pnlUsuarios.TabIndex = 0;
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.Font = new Font("Sitka Display", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarios.ForeColor = Color.Maroon;
            lblUsuarios.Location = new Point(419, 9);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new Size(322, 50);
            lblUsuarios.TabIndex = 0;
            lblUsuarios.Text = "Gestión De Usuarios";
            // 
            // pnlCargarUsuarios
            // 
            pnlCargarUsuarios.BackColor = Color.WhiteSmoke;
            pnlCargarUsuarios.Controls.Add(pnlBuscarU);
            pnlCargarUsuarios.Controls.Add(txtCorreo);
            pnlCargarUsuarios.Controls.Add(txtTelefono);
            pnlCargarUsuarios.Controls.Add(txtDocumento);
            pnlCargarUsuarios.Controls.Add(txtApellido);
            pnlCargarUsuarios.Controls.Add(txtNombre);
            pnlCargarUsuarios.Controls.Add(lblCorreo);
            pnlCargarUsuarios.Controls.Add(lblTelefono);
            pnlCargarUsuarios.Controls.Add(lblDocumento);
            pnlCargarUsuarios.Controls.Add(lblApellido);
            pnlCargarUsuarios.Controls.Add(lblNombre);
            pnlCargarUsuarios.Dock = DockStyle.Top;
            pnlCargarUsuarios.Location = new Point(0, 75);
            pnlCargarUsuarios.Margin = new Padding(3, 5, 3, 5);
            pnlCargarUsuarios.Name = "pnlCargarUsuarios";
            pnlCargarUsuarios.Size = new Size(1082, 322);
            pnlCargarUsuarios.TabIndex = 1;
            // 
            // pnlBuscarU
            // 
            pnlBuscarU.BackColor = Color.WhiteSmoke;
            pnlBuscarU.Controls.Add(txtBuscarU);
            pnlBuscarU.Controls.Add(btnBuscarU);
            pnlBuscarU.Controls.Add(lblBuscarU);
            pnlBuscarU.Dock = DockStyle.Top;
            pnlBuscarU.Location = new Point(0, 0);
            pnlBuscarU.Margin = new Padding(3, 5, 3, 5);
            pnlBuscarU.Name = "pnlBuscarU";
            pnlBuscarU.Size = new Size(1082, 60);
            pnlBuscarU.TabIndex = 10;
            // 
            // txtBuscarU
            // 
            txtBuscarU.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarU.Location = new Point(473, 18);
            txtBuscarU.Margin = new Padding(3, 5, 3, 5);
            txtBuscarU.Name = "txtBuscarU";
            txtBuscarU.Size = new Size(238, 27);
            txtBuscarU.TabIndex = 11;
            // 
            // btnBuscarU
            // 
            btnBuscarU.Font = new Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarU.ForeColor = Color.DarkRed;
            btnBuscarU.Location = new Point(741, 20);
            btnBuscarU.Margin = new Padding(3, 5, 3, 5);
            btnBuscarU.Name = "btnBuscarU";
            btnBuscarU.Size = new Size(93, 25);
            btnBuscarU.TabIndex = 12;
            btnBuscarU.Text = "Buscar";
            btnBuscarU.UseVisualStyleBackColor = true;
            btnBuscarU.Click += btnBuscarU_Click;
            // 
            // lblBuscarU
            // 
            lblBuscarU.AutoSize = true;
            lblBuscarU.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscarU.ForeColor = Color.Black;
            lblBuscarU.Location = new Point(327, 19);
            lblBuscarU.Name = "lblBuscarU";
            lblBuscarU.Size = new Size(85, 23);
            lblBuscarU.TabIndex = 11;
            lblBuscarU.Text = "Usuario ID:";
            lblBuscarU.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(473, 285);
            txtCorreo.Margin = new Padding(3, 5, 3, 5);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(238, 27);
            txtCorreo.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(473, 230);
            txtTelefono.Margin = new Padding(3, 5, 3, 5);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(238, 27);
            txtTelefono.TabIndex = 8;
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocumento.Location = new Point(473, 176);
            txtDocumento.Margin = new Padding(3, 5, 3, 5);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(238, 27);
            txtDocumento.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(473, 126);
            txtApellido.Margin = new Padding(3, 5, 3, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(238, 27);
            txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(473, 77);
            txtNombre.Margin = new Padding(3, 5, 3, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(238, 27);
            txtNombre.TabIndex = 5;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(326, 285);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(61, 23);
            lblCorreo.TabIndex = 4;
            lblCorreo.Text = "Correo:";
            lblCorreo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(323, 230);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(71, 23);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Teléfono:";
            lblTelefono.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocumento.Location = new Point(323, 180);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(89, 23);
            lblDocumento.TabIndex = 2;
            lblDocumento.Text = "Documento:";
            lblDocumento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(326, 126);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 23);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            lblApellido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(328, 77);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(69, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlBotonesU
            // 
            pnlBotonesU.Controls.Add(btnCancelarU);
            pnlBotonesU.Controls.Add(btnEliminarU);
            pnlBotonesU.Controls.Add(btnEditarU);
            pnlBotonesU.Controls.Add(btnGuardarU);
            pnlBotonesU.Controls.Add(btnNuevoU);
            pnlBotonesU.Location = new Point(104, 407);
            pnlBotonesU.Margin = new Padding(3, 5, 3, 5);
            pnlBotonesU.Name = "pnlBotonesU";
            pnlBotonesU.Size = new Size(907, 45);
            pnlBotonesU.TabIndex = 2;
            // 
            // btnCancelarU
            // 
            btnCancelarU.BackColor = Color.WhiteSmoke;
            btnCancelarU.Cursor = Cursors.Hand;
            btnCancelarU.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarU.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelarU.IconColor = Color.Maroon;
            btnCancelarU.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelarU.IconSize = 25;
            btnCancelarU.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarU.Location = new Point(772, 5);
            btnCancelarU.Margin = new Padding(3, 5, 3, 5);
            btnCancelarU.Name = "btnCancelarU";
            btnCancelarU.Size = new Size(96, 33);
            btnCancelarU.TabIndex = 4;
            btnCancelarU.Text = "Cancelar";
            btnCancelarU.TextAlign = ContentAlignment.MiddleRight;
            btnCancelarU.UseVisualStyleBackColor = false;
            btnCancelarU.Click += btnCancelarU_Click;
            // 
            // btnEliminarU
            // 
            btnEliminarU.BackColor = Color.WhiteSmoke;
            btnEliminarU.Cursor = Cursors.Hand;
            btnEliminarU.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminarU.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnEliminarU.IconColor = Color.Maroon;
            btnEliminarU.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarU.IconSize = 25;
            btnEliminarU.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarU.Location = new Point(585, 5);
            btnEliminarU.Margin = new Padding(3, 5, 3, 5);
            btnEliminarU.Name = "btnEliminarU";
            btnEliminarU.Size = new Size(148, 33);
            btnEliminarU.TabIndex = 3;
            btnEliminarU.Text = "Eliminar Usuario";
            btnEliminarU.TextAlign = ContentAlignment.MiddleRight;
            btnEliminarU.UseVisualStyleBackColor = false;
            btnEliminarU.Click += btnEliminarU_Click;
            // 
            // btnEditarU
            // 
            btnEditarU.BackColor = Color.WhiteSmoke;
            btnEditarU.Cursor = Cursors.Hand;
            btnEditarU.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarU.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditarU.IconColor = Color.Maroon;
            btnEditarU.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarU.IconSize = 25;
            btnEditarU.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarU.Location = new Point(411, 5);
            btnEditarU.Margin = new Padding(3, 5, 3, 5);
            btnEditarU.Name = "btnEditarU";
            btnEditarU.Size = new Size(129, 33);
            btnEditarU.TabIndex = 2;
            btnEditarU.Text = "Editar Usuario";
            btnEditarU.TextAlign = ContentAlignment.MiddleRight;
            btnEditarU.UseVisualStyleBackColor = false;
            btnEditarU.Click += btnEditarU_Click;
            // 
            // btnGuardarU
            // 
            btnGuardarU.BackColor = Color.WhiteSmoke;
            btnGuardarU.Cursor = Cursors.Hand;
            btnGuardarU.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarU.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardarU.IconColor = Color.Maroon;
            btnGuardarU.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarU.IconSize = 25;
            btnGuardarU.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarU.Location = new Point(241, 5);
            btnGuardarU.Margin = new Padding(3, 5, 3, 5);
            btnGuardarU.Name = "btnGuardarU";
            btnGuardarU.Size = new Size(124, 33);
            btnGuardarU.TabIndex = 1;
            btnGuardarU.Text = "Guardar ";
            btnGuardarU.UseVisualStyleBackColor = false;
            btnGuardarU.Click += btnGuardarU_Click;
            // 
            // btnNuevoU
            // 
            btnNuevoU.BackColor = Color.WhiteSmoke;
            btnNuevoU.Cursor = Cursors.Hand;
            btnNuevoU.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevoU.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnNuevoU.IconColor = Color.DarkRed;
            btnNuevoU.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevoU.IconSize = 25;
            btnNuevoU.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoU.Location = new Point(60, 5);
            btnNuevoU.Margin = new Padding(3, 5, 3, 5);
            btnNuevoU.Name = "btnNuevoU";
            btnNuevoU.Size = new Size(146, 33);
            btnNuevoU.TabIndex = 0;
            btnNuevoU.Text = "Nuevo Usuario";
            btnNuevoU.TextAlign = ContentAlignment.MiddleRight;
            btnNuevoU.UseVisualStyleBackColor = false;
            btnNuevoU.Click += btnNuevoU_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.Silver;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Cursor = Cursors.Hand;
            dgvUsuarios.Location = new Point(37, 462);
            dgvUsuarios.Margin = new Padding(3, 5, 3, 5);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(1007, 177);
            dgvUsuarios.TabIndex = 3;
            dgvUsuarios.CellDoubleClick += dgvUsuarios_CellDoubleClick;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 749);
            Controls.Add(dgvUsuarios);
            Controls.Add(pnlBotonesU);
            Controls.Add(pnlCargarUsuarios);
            Controls.Add(pnlUsuarios);
            Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 5, 3, 5);
            Name = "FrmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuarios";
            WindowState = FormWindowState.Maximized;
            pnlUsuarios.ResumeLayout(false);
            pnlUsuarios.PerformLayout();
            pnlCargarUsuarios.ResumeLayout(false);
            pnlCargarUsuarios.PerformLayout();
            pnlBuscarU.ResumeLayout(false);
            pnlBuscarU.PerformLayout();
            pnlBotonesU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlUsuarios;
        private Label lblUsuarios;
        private Panel pnlCargarUsuarios;
        private Label lblNombre;
        private Label lblTelefono;
        private Label lblDocumento;
        private Label lblApellido;
        private Label lblCorreo;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtDocumento;
        private Panel pnlBotonesU;
        private FontAwesome.Sharp.IconButton btnNuevoU;
        private FontAwesome.Sharp.IconButton btnGuardarU;
        private FontAwesome.Sharp.IconButton btnEditarU;
        private FontAwesome.Sharp.IconButton btnEliminarU;
        private FontAwesome.Sharp.IconButton btnCancelarU;
        private DataGridView dgvUsuarios;
        private Panel pnlBuscarU;
        private Label lblBuscarU;
        private Button btnBuscarU;
        private TextBox txtBuscarU;
    }
}
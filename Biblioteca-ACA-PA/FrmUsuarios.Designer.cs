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
            pnlUsuarios.BackColor = Color.LightGray;
            pnlUsuarios.Controls.Add(lblUsuarios);
            pnlUsuarios.Dock = DockStyle.Top;
            pnlUsuarios.Location = new Point(0, 0);
            pnlUsuarios.Name = "pnlUsuarios";
            pnlUsuarios.Size = new Size(1083, 48);
            pnlUsuarios.TabIndex = 0;
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.Font = new Font("Sitka Text Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarios.Location = new Point(398, 9);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new Size(251, 35);
            lblUsuarios.TabIndex = 0;
            lblUsuarios.Text = "Gestión De Usuarios";
            // 
            // pnlCargarUsuarios
            // 
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
            pnlCargarUsuarios.Location = new Point(0, 48);
            pnlCargarUsuarios.Name = "pnlCargarUsuarios";
            pnlCargarUsuarios.Size = new Size(1083, 317);
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
            pnlBuscarU.Name = "pnlBuscarU";
            pnlBuscarU.Size = new Size(1083, 50);
            pnlBuscarU.TabIndex = 10;
            // 
            // txtBuscarU
            // 
            txtBuscarU.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarU.Location = new Point(440, 13);
            txtBuscarU.Name = "txtBuscarU";
            txtBuscarU.Size = new Size(209, 27);
            txtBuscarU.TabIndex = 11;
            // 
            // btnBuscarU
            // 
            btnBuscarU.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscarU.Location = new Point(667, 15);
            btnBuscarU.Name = "btnBuscarU";
            btnBuscarU.Size = new Size(79, 26);
            btnBuscarU.TabIndex = 12;
            btnBuscarU.Text = "Buscar";
            btnBuscarU.UseVisualStyleBackColor = true;
            btnBuscarU.Click += btnBuscarU_Click;
            // 
            // lblBuscarU
            // 
            lblBuscarU.AutoSize = true;
            lblBuscarU.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscarU.Location = new Point(297, 13);
            lblBuscarU.Name = "lblBuscarU";
            lblBuscarU.Size = new Size(80, 21);
            lblBuscarU.TabIndex = 11;
            lblBuscarU.Text = "Usuario ID:";
            lblBuscarU.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(442, 276);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(209, 27);
            txtCorreo.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(442, 222);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(209, 27);
            txtTelefono.TabIndex = 8;
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocumento.Location = new Point(442, 173);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(209, 27);
            txtDocumento.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.Location = new Point(442, 125);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(209, 27);
            txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(442, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(209, 27);
            txtNombre.TabIndex = 5;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(297, 276);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(55, 21);
            lblCorreo.TabIndex = 4;
            lblCorreo.Text = "Correo:";
            lblCorreo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(295, 225);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 21);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Teléfono:";
            lblTelefono.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocumento.Location = new Point(295, 178);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(84, 21);
            lblDocumento.TabIndex = 2;
            lblDocumento.Text = "Documento:";
            lblDocumento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(297, 125);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(65, 21);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            lblApellido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(299, 79);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 21);
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
            pnlBotonesU.Location = new Point(118, 371);
            pnlBotonesU.Name = "pnlBotonesU";
            pnlBotonesU.Size = new Size(874, 58);
            pnlBotonesU.TabIndex = 2;
            // 
            // btnCancelarU
            // 
            btnCancelarU.BackColor = Color.WhiteSmoke;
            btnCancelarU.Cursor = Cursors.Hand;
            btnCancelarU.Font = new Font("Sitka Text", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarU.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnCancelarU.IconColor = Color.Black;
            btnCancelarU.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelarU.IconSize = 25;
            btnCancelarU.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarU.Location = new Point(712, 12);
            btnCancelarU.Name = "btnCancelarU";
            btnCancelarU.Size = new Size(89, 32);
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
            btnEliminarU.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnEliminarU.IconColor = Color.Black;
            btnEliminarU.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarU.IconSize = 25;
            btnEliminarU.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarU.Location = new Point(525, 12);
            btnEliminarU.Name = "btnEliminarU";
            btnEliminarU.Size = new Size(143, 32);
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
            btnEditarU.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnEditarU.IconColor = Color.Black;
            btnEditarU.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarU.IconSize = 25;
            btnEditarU.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarU.Location = new Point(366, 12);
            btnEditarU.Name = "btnEditarU";
            btnEditarU.Size = new Size(133, 32);
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
            btnGuardarU.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnGuardarU.IconColor = Color.Black;
            btnGuardarU.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarU.IconSize = 25;
            btnGuardarU.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarU.Location = new Point(203, 12);
            btnGuardarU.Name = "btnGuardarU";
            btnGuardarU.Size = new Size(123, 32);
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
            btnNuevoU.IconColor = Color.Black;
            btnNuevoU.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevoU.IconSize = 25;
            btnNuevoU.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoU.Location = new Point(43, 12);
            btnNuevoU.Name = "btnNuevoU";
            btnNuevoU.Size = new Size(134, 32);
            btnNuevoU.TabIndex = 0;
            btnNuevoU.Text = "Nuevo Usuario";
            btnNuevoU.TextAlign = ContentAlignment.MiddleRight;
            btnNuevoU.UseVisualStyleBackColor = false;
            btnNuevoU.Click += btnNuevoU_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Cursor = Cursors.Hand;
            dgvUsuarios.Location = new Point(161, 435);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(778, 184);
            dgvUsuarios.TabIndex = 3;
            dgvUsuarios.CellDoubleClick += dgvUsuarios_CellDoubleClick;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 749);
            Controls.Add(dgvUsuarios);
            Controls.Add(pnlBotonesU);
            Controls.Add(pnlCargarUsuarios);
            Controls.Add(pnlUsuarios);
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
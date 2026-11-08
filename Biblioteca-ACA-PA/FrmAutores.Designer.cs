namespace Biblioteca_ACA_PA
{
    partial class FrmAutores
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
            pnlAutores = new Panel();
            lblAutores = new Label();
            pnlBuscarA = new Panel();
            btnBuscarA = new Button();
            txtBuscarA = new TextBox();
            lblBuscaarA = new Label();
            pnlCargarA = new Panel();
            txtApellidoA = new TextBox();
            txtNombreA = new TextBox();
            lblApellidoA = new Label();
            lblNombreA = new Label();
            pnlBotonesA = new Panel();
            btnCancelarA = new FontAwesome.Sharp.IconButton();
            btnEliminarA = new FontAwesome.Sharp.IconButton();
            btnEditarA = new FontAwesome.Sharp.IconButton();
            btnGuardarA = new FontAwesome.Sharp.IconButton();
            btnNuevoA = new FontAwesome.Sharp.IconButton();
            dgvAutores = new DataGridView();
            pnlAutores.SuspendLayout();
            pnlBuscarA.SuspendLayout();
            pnlCargarA.SuspendLayout();
            pnlBotonesA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAutores).BeginInit();
            SuspendLayout();
            // 
            // pnlAutores
            // 
            pnlAutores.BackColor = Color.LightGray;
            pnlAutores.Controls.Add(lblAutores);
            pnlAutores.Dock = DockStyle.Top;
            pnlAutores.Location = new Point(0, 0);
            pnlAutores.Name = "pnlAutores";
            pnlAutores.Size = new Size(1059, 48);
            pnlAutores.TabIndex = 0;
            // 
            // lblAutores
            // 
            lblAutores.AutoSize = true;
            lblAutores.BackColor = Color.LightGray;
            lblAutores.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutores.Location = new Point(434, 9);
            lblAutores.Name = "lblAutores";
            lblAutores.Size = new Size(219, 35);
            lblAutores.TabIndex = 0;
            lblAutores.Text = "Gestión de Autores";
            lblAutores.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBuscarA
            // 
            pnlBuscarA.BackColor = Color.WhiteSmoke;
            pnlBuscarA.Controls.Add(btnBuscarA);
            pnlBuscarA.Controls.Add(txtBuscarA);
            pnlBuscarA.Controls.Add(lblBuscaarA);
            pnlBuscarA.Dock = DockStyle.Top;
            pnlBuscarA.Location = new Point(0, 48);
            pnlBuscarA.Name = "pnlBuscarA";
            pnlBuscarA.Size = new Size(1059, 58);
            pnlBuscarA.TabIndex = 1;
            // 
            // btnBuscarA
            // 
            btnBuscarA.AutoSize = true;
            btnBuscarA.Location = new Point(675, 15);
            btnBuscarA.Name = "btnBuscarA";
            btnBuscarA.Size = new Size(81, 31);
            btnBuscarA.TabIndex = 2;
            btnBuscarA.Text = "Buscar";
            btnBuscarA.UseVisualStyleBackColor = true;
            btnBuscarA.Click += btnBuscarA_Click;
            // 
            // txtBuscarA
            // 
            txtBuscarA.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarA.Location = new Point(464, 15);
            txtBuscarA.Name = "txtBuscarA";
            txtBuscarA.Size = new Size(175, 27);
            txtBuscarA.TabIndex = 1;
            // 
            // lblBuscaarA
            // 
            lblBuscaarA.AutoSize = true;
            lblBuscaarA.Location = new Point(364, 21);
            lblBuscaarA.Name = "lblBuscaarA";
            lblBuscaarA.Size = new Size(59, 21);
            lblBuscaarA.TabIndex = 0;
            lblBuscaarA.Text = "Id Autor";
            lblBuscaarA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlCargarA
            // 
            pnlCargarA.BackColor = Color.WhiteSmoke;
            pnlCargarA.Controls.Add(txtApellidoA);
            pnlCargarA.Controls.Add(txtNombreA);
            pnlCargarA.Controls.Add(lblApellidoA);
            pnlCargarA.Controls.Add(lblNombreA);
            pnlCargarA.Dock = DockStyle.Top;
            pnlCargarA.Location = new Point(0, 106);
            pnlCargarA.Name = "pnlCargarA";
            pnlCargarA.Size = new Size(1059, 208);
            pnlCargarA.TabIndex = 2;
            // 
            // txtApellidoA
            // 
            txtApellidoA.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidoA.Location = new Point(464, 101);
            txtApellidoA.Name = "txtApellidoA";
            txtApellidoA.Size = new Size(175, 26);
            txtApellidoA.TabIndex = 3;
            // 
            // txtNombreA
            // 
            txtNombreA.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreA.Location = new Point(464, 48);
            txtNombreA.Name = "txtNombreA";
            txtNombreA.Size = new Size(175, 26);
            txtNombreA.TabIndex = 2;
            // 
            // lblApellidoA
            // 
            lblApellidoA.AutoSize = true;
            lblApellidoA.Location = new Point(360, 106);
            lblApellidoA.Name = "lblApellidoA";
            lblApellidoA.Size = new Size(63, 21);
            lblApellidoA.TabIndex = 2;
            lblApellidoA.Text = "Apellido:";
            lblApellidoA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombreA
            // 
            lblNombreA.AutoSize = true;
            lblNombreA.Location = new Point(360, 53);
            lblNombreA.Name = "lblNombreA";
            lblNombreA.Size = new Size(62, 21);
            lblNombreA.TabIndex = 1;
            lblNombreA.Text = "Nombre:";
            lblNombreA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBotonesA
            // 
            pnlBotonesA.Controls.Add(btnCancelarA);
            pnlBotonesA.Controls.Add(btnEliminarA);
            pnlBotonesA.Controls.Add(btnEditarA);
            pnlBotonesA.Controls.Add(btnGuardarA);
            pnlBotonesA.Controls.Add(btnNuevoA);
            pnlBotonesA.Location = new Point(104, 320);
            pnlBotonesA.Name = "pnlBotonesA";
            pnlBotonesA.Size = new Size(893, 66);
            pnlBotonesA.TabIndex = 3;
            // 
            // btnCancelarA
            // 
            btnCancelarA.BackColor = Color.WhiteSmoke;
            btnCancelarA.FlatStyle = FlatStyle.Flat;
            btnCancelarA.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnCancelarA.IconColor = Color.Black;
            btnCancelarA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelarA.IconSize = 25;
            btnCancelarA.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarA.Location = new Point(706, 17);
            btnCancelarA.Name = "btnCancelarA";
            btnCancelarA.Size = new Size(121, 33);
            btnCancelarA.TabIndex = 4;
            btnCancelarA.Text = "Cancelar";
            btnCancelarA.TextAlign = ContentAlignment.TopCenter;
            btnCancelarA.UseVisualStyleBackColor = false;
            btnCancelarA.Click += btnCancelarA_Click;
            // 
            // btnEliminarA
            // 
            btnEliminarA.BackColor = Color.WhiteSmoke;
            btnEliminarA.FlatStyle = FlatStyle.Flat;
            btnEliminarA.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnEliminarA.IconColor = Color.Black;
            btnEliminarA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarA.IconSize = 25;
            btnEliminarA.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarA.Location = new Point(515, 17);
            btnEliminarA.Name = "btnEliminarA";
            btnEliminarA.Size = new Size(153, 33);
            btnEliminarA.TabIndex = 3;
            btnEliminarA.Text = "Eliminar Autor";
            btnEliminarA.TextAlign = ContentAlignment.TopCenter;
            btnEliminarA.UseVisualStyleBackColor = false;
            btnEliminarA.Click += btnEliminarA_Click;
            // 
            // btnEditarA
            // 
            btnEditarA.BackColor = Color.WhiteSmoke;
            btnEditarA.FlatStyle = FlatStyle.Flat;
            btnEditarA.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnEditarA.IconColor = Color.Black;
            btnEditarA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarA.IconSize = 25;
            btnEditarA.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarA.Location = new Point(346, 17);
            btnEditarA.Name = "btnEditarA";
            btnEditarA.Size = new Size(141, 33);
            btnEditarA.TabIndex = 2;
            btnEditarA.Text = "Editar Autor";
            btnEditarA.TextAlign = ContentAlignment.TopCenter;
            btnEditarA.UseVisualStyleBackColor = false;
            btnEditarA.Click += btnEditarA_Click;
            // 
            // btnGuardarA
            // 
            btnGuardarA.BackColor = Color.WhiteSmoke;
            btnGuardarA.FlatStyle = FlatStyle.Flat;
            btnGuardarA.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnGuardarA.IconColor = Color.Black;
            btnGuardarA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarA.IconSize = 25;
            btnGuardarA.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarA.Location = new Point(200, 17);
            btnGuardarA.Name = "btnGuardarA";
            btnGuardarA.Size = new Size(123, 33);
            btnGuardarA.TabIndex = 1;
            btnGuardarA.Text = "Guardar ";
            btnGuardarA.TextAlign = ContentAlignment.TopCenter;
            btnGuardarA.UseVisualStyleBackColor = false;
            btnGuardarA.Click += btnGuardarA_Click;
            // 
            // btnNuevoA
            // 
            btnNuevoA.BackColor = Color.WhiteSmoke;
            btnNuevoA.FlatStyle = FlatStyle.Flat;
            btnNuevoA.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnNuevoA.IconColor = Color.Black;
            btnNuevoA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevoA.IconSize = 25;
            btnNuevoA.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoA.Location = new Point(32, 17);
            btnNuevoA.Name = "btnNuevoA";
            btnNuevoA.Size = new Size(148, 33);
            btnNuevoA.TabIndex = 0;
            btnNuevoA.Text = "Nuevo Autor";
            btnNuevoA.TextAlign = ContentAlignment.TopCenter;
            btnNuevoA.UseVisualStyleBackColor = false;
            btnNuevoA.Click += btnNuevoA_Click;
            // 
            // dgvAutores
            // 
            dgvAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutores.Location = new Point(202, 392);
            dgvAutores.Name = "dgvAutores";
            dgvAutores.Size = new Size(649, 275);
            dgvAutores.TabIndex = 4;
            dgvAutores.CellDoubleClick += dgvAutores_CellDoubleClick;
            // 
            // FrmAutores
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 749);
            Controls.Add(dgvAutores);
            Controls.Add(pnlBotonesA);
            Controls.Add(pnlCargarA);
            Controls.Add(pnlBuscarA);
            Controls.Add(pnlAutores);
            Font = new Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmAutores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAutores";
            WindowState = FormWindowState.Maximized;
            pnlAutores.ResumeLayout(false);
            pnlAutores.PerformLayout();
            pnlBuscarA.ResumeLayout(false);
            pnlBuscarA.PerformLayout();
            pnlCargarA.ResumeLayout(false);
            pnlCargarA.PerformLayout();
            pnlBotonesA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAutores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAutores;
        private Panel pnlBuscarA;
        private Panel pnlCargarA;
        private Panel pnlBotonesA;
        private Label lblAutores;
        private Label lblBuscaarA;
        private Label lblNombreA;
        private Button btnBuscarA;
        private TextBox txtBuscarA;
        private TextBox txtApellidoA;
        private TextBox txtNombreA;
        private Label lblApellidoA;
        private FontAwesome.Sharp.IconButton btnNuevoA;
        private FontAwesome.Sharp.IconButton btnGuardarA;
        private FontAwesome.Sharp.IconButton btnEditarA;
        private FontAwesome.Sharp.IconButton btnCancelarA;
        private FontAwesome.Sharp.IconButton btnEliminarA;
        private DataGridView dgvAutores;
    }
}
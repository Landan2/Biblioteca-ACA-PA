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
            lblNombre = new Label();
            lblApellidos = new Label();
            lblDocumento = new Label();
            lblTelefono = new Label();
            lblCorreo = new Label();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            txtDocumento = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            pnlUsuarios.SuspendLayout();
            pnlCargarUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // pnlUsuarios
            // 
            pnlUsuarios.BackColor = Color.LightGray;
            pnlUsuarios.Controls.Add(lblUsuarios);
            pnlUsuarios.Dock = DockStyle.Top;
            pnlUsuarios.Location = new Point(0, 0);
            pnlUsuarios.Name = "pnlUsuarios";
            pnlUsuarios.Size = new Size(1059, 48);
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
            pnlCargarUsuarios.Controls.Add(txtCorreo);
            pnlCargarUsuarios.Controls.Add(txtTelefono);
            pnlCargarUsuarios.Controls.Add(txtDocumento);
            pnlCargarUsuarios.Controls.Add(txtApellidos);
            pnlCargarUsuarios.Controls.Add(txtNombre);
            pnlCargarUsuarios.Controls.Add(lblCorreo);
            pnlCargarUsuarios.Controls.Add(lblTelefono);
            pnlCargarUsuarios.Controls.Add(lblDocumento);
            pnlCargarUsuarios.Controls.Add(lblApellidos);
            pnlCargarUsuarios.Controls.Add(lblNombre);
            pnlCargarUsuarios.Dock = DockStyle.Top;
            pnlCargarUsuarios.Location = new Point(0, 48);
            pnlCargarUsuarios.Name = "pnlCargarUsuarios";
            pnlCargarUsuarios.Size = new Size(1059, 273);
            pnlCargarUsuarios.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Sitka Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(297, 23);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(78, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Font = new Font("Sitka Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellidos.Location = new Point(295, 69);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(89, 23);
            lblApellidos.TabIndex = 1;
            lblApellidos.Text = "Apellidos:";
            lblApellidos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Sitka Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocumento.Location = new Point(293, 122);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(104, 23);
            lblDocumento.TabIndex = 2;
            lblDocumento.Text = "Documento:";
            lblDocumento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Sitka Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(293, 169);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(82, 23);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Teléfono:";
            lblTelefono.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Sitka Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(295, 220);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(69, 23);
            lblCorreo.TabIndex = 4;
            lblCorreo.Text = "Correo:";
            lblCorreo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(440, 23);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(209, 28);
            txtNombre.TabIndex = 5;
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellidos.Location = new Point(440, 69);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(209, 28);
            txtApellidos.TabIndex = 6;
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDocumento.Location = new Point(440, 117);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(209, 28);
            txtDocumento.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(440, 166);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(209, 28);
            txtTelefono.TabIndex = 8;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(440, 220);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(209, 28);
            txtCorreo.TabIndex = 9;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 749);
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
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlUsuarios;
        private Label lblUsuarios;
        private Panel pnlCargarUsuarios;
        private Label lblNombre;
        private Label lblTelefono;
        private Label lblDocumento;
        private Label lblApellidos;
        private Label lblCorreo;
        private TextBox txtApellidos;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtDocumento;
    }
}
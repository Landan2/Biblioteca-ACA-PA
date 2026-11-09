namespace Biblioteca_ACA_PA
{
    partial class FrmEditoriales
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
            pnlEditorial = new Panel();
            lblEditoriales = new Label();
            pnlDatosE = new Panel();
            btnBuscarE = new FontAwesome.Sharp.IconButton();
            txtBuscarE = new TextBox();
            lblBuscarE = new Label();
            txtNombreE = new TextBox();
            lblNombreE = new Label();
            pnlBotonesE = new Panel();
            btnCancelarE = new FontAwesome.Sharp.IconButton();
            btnEliminarE = new FontAwesome.Sharp.IconButton();
            btnEditarE = new FontAwesome.Sharp.IconButton();
            btnGuardarE = new FontAwesome.Sharp.IconButton();
            btnNuevoE = new FontAwesome.Sharp.IconButton();
            dgvEditoriales = new DataGridView();
            pnlEditorial.SuspendLayout();
            pnlDatosE.SuspendLayout();
            pnlBotonesE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).BeginInit();
            SuspendLayout();
            // 
            // pnlEditorial
            // 
            pnlEditorial.BackColor = Color.Gainsboro;
            pnlEditorial.Controls.Add(lblEditoriales);
            pnlEditorial.Dock = DockStyle.Top;
            pnlEditorial.Location = new Point(0, 0);
            pnlEditorial.Margin = new Padding(5, 4, 5, 4);
            pnlEditorial.Name = "pnlEditorial";
            pnlEditorial.Size = new Size(1059, 75);
            pnlEditorial.TabIndex = 0;
            // 
            // lblEditoriales
            // 
            lblEditoriales.AutoSize = true;
            lblEditoriales.Font = new Font("Sitka Display", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditoriales.ForeColor = Color.Maroon;
            lblEditoriales.Location = new Point(369, 9);
            lblEditoriales.Name = "lblEditoriales";
            lblEditoriales.Size = new Size(349, 50);
            lblEditoriales.TabIndex = 0;
            lblEditoriales.Text = "Gestión de Editoriales";
            // 
            // pnlDatosE
            // 
            pnlDatosE.BackColor = Color.WhiteSmoke;
            pnlDatosE.Controls.Add(btnBuscarE);
            pnlDatosE.Controls.Add(txtBuscarE);
            pnlDatosE.Controls.Add(lblBuscarE);
            pnlDatosE.Controls.Add(txtNombreE);
            pnlDatosE.Controls.Add(lblNombreE);
            pnlDatosE.Dock = DockStyle.Top;
            pnlDatosE.Location = new Point(0, 75);
            pnlDatosE.Margin = new Padding(5, 4, 5, 4);
            pnlDatosE.Name = "pnlDatosE";
            pnlDatosE.Size = new Size(1059, 170);
            pnlDatosE.TabIndex = 1;
            // 
            // btnBuscarE
            // 
            btnBuscarE.Font = new Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarE.ForeColor = Color.Maroon;
            btnBuscarE.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuscarE.IconColor = Color.Black;
            btnBuscarE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarE.Location = new Point(689, 29);
            btnBuscarE.Name = "btnBuscarE";
            btnBuscarE.Size = new Size(87, 36);
            btnBuscarE.TabIndex = 5;
            btnBuscarE.Text = "Buscar";
            btnBuscarE.UseVisualStyleBackColor = true;
            btnBuscarE.Click += btnBuscarE_Click;
            // 
            // txtBuscarE
            // 
            txtBuscarE.BackColor = SystemColors.Window;
            txtBuscarE.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarE.Location = new Point(453, 29);
            txtBuscarE.Name = "txtBuscarE";
            txtBuscarE.Size = new Size(210, 28);
            txtBuscarE.TabIndex = 3;
            // 
            // lblBuscarE
            // 
            lblBuscarE.AutoSize = true;
            lblBuscarE.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscarE.Location = new Point(317, 28);
            lblBuscarE.Name = "lblBuscarE";
            lblBuscarE.Size = new Size(103, 23);
            lblBuscarE.TabIndex = 2;
            lblBuscarE.Text = "Buscar por Id:";
            // 
            // txtNombreE
            // 
            txtNombreE.BackColor = SystemColors.Window;
            txtNombreE.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreE.Location = new Point(453, 103);
            txtNombreE.Name = "txtNombreE";
            txtNombreE.Size = new Size(210, 28);
            txtNombreE.TabIndex = 1;
            // 
            // lblNombreE
            // 
            lblNombreE.AutoSize = true;
            lblNombreE.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreE.Location = new Point(317, 103);
            lblNombreE.Name = "lblNombreE";
            lblNombreE.Size = new Size(69, 23);
            lblNombreE.TabIndex = 0;
            lblNombreE.Text = "Nombre:";
            // 
            // pnlBotonesE
            // 
            pnlBotonesE.Controls.Add(btnCancelarE);
            pnlBotonesE.Controls.Add(btnEliminarE);
            pnlBotonesE.Controls.Add(btnEditarE);
            pnlBotonesE.Controls.Add(btnGuardarE);
            pnlBotonesE.Controls.Add(btnNuevoE);
            pnlBotonesE.Location = new Point(143, 253);
            pnlBotonesE.Margin = new Padding(5, 4, 5, 4);
            pnlBotonesE.Name = "pnlBotonesE";
            pnlBotonesE.Size = new Size(797, 56);
            pnlBotonesE.TabIndex = 2;
            // 
            // btnCancelarE
            // 
            btnCancelarE.Font = new Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarE.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelarE.IconColor = Color.Maroon;
            btnCancelarE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelarE.IconSize = 25;
            btnCancelarE.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarE.Location = new Point(589, 13);
            btnCancelarE.Name = "btnCancelarE";
            btnCancelarE.Size = new Size(121, 32);
            btnCancelarE.TabIndex = 4;
            btnCancelarE.Text = "Cancelar";
            btnCancelarE.UseVisualStyleBackColor = true;
            btnCancelarE.Click += btnCancelarE_Click;
            // 
            // btnEliminarE
            // 
            btnEliminarE.Font = new Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarE.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnEliminarE.IconColor = Color.Maroon;
            btnEliminarE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarE.IconSize = 25;
            btnEliminarE.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarE.Location = new Point(459, 13);
            btnEliminarE.Name = "btnEliminarE";
            btnEliminarE.Size = new Size(116, 32);
            btnEliminarE.TabIndex = 3;
            btnEliminarE.Text = "Eliminar";
            btnEliminarE.UseVisualStyleBackColor = true;
            btnEliminarE.Click += btnEliminarE_Click;
            // 
            // btnEditarE
            // 
            btnEditarE.Font = new Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarE.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditarE.IconColor = Color.Maroon;
            btnEditarE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarE.IconSize = 25;
            btnEditarE.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarE.Location = new Point(341, 13);
            btnEditarE.Name = "btnEditarE";
            btnEditarE.Size = new Size(112, 32);
            btnEditarE.TabIndex = 2;
            btnEditarE.Text = "Editar ";
            btnEditarE.UseVisualStyleBackColor = true;
            btnEditarE.Click += btnEditarE_Click;
            // 
            // btnGuardarE
            // 
            btnGuardarE.Font = new Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarE.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardarE.IconColor = Color.Maroon;
            btnGuardarE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarE.IconSize = 25;
            btnGuardarE.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarE.Location = new Point(213, 13);
            btnGuardarE.Name = "btnGuardarE";
            btnGuardarE.Size = new Size(109, 32);
            btnGuardarE.TabIndex = 1;
            btnGuardarE.Text = "Guardar ";
            btnGuardarE.UseVisualStyleBackColor = true;
            btnGuardarE.Click += btnGuardarE_Click;
            // 
            // btnNuevoE
            // 
            btnNuevoE.Font = new Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoE.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnNuevoE.IconColor = Color.Maroon;
            btnNuevoE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevoE.IconSize = 25;
            btnNuevoE.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoE.Location = new Point(46, 13);
            btnNuevoE.Name = "btnNuevoE";
            btnNuevoE.Size = new Size(146, 32);
            btnNuevoE.TabIndex = 0;
            btnNuevoE.Text = "Nueva Editorial";
            btnNuevoE.UseVisualStyleBackColor = true;
            btnNuevoE.Click += btnNuevoE_Click;
            // 
            // dgvEditoriales
            // 
            dgvEditoriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEditoriales.BackgroundColor = Color.Silver;
            dgvEditoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditoriales.Location = new Point(57, 316);
            dgvEditoriales.Name = "dgvEditoriales";
            dgvEditoriales.Size = new Size(931, 300);
            dgvEditoriales.TabIndex = 3;
            dgvEditoriales.CellDoubleClick += dgvEditoriales_CellDoubleClick;
            // 
            // FrmEditoriales
            // 
            AutoScaleDimensions = new SizeF(8F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1059, 749);
            Controls.Add(dgvEditoriales);
            Controls.Add(pnlBotonesE);
            Controls.Add(pnlDatosE);
            Controls.Add(pnlEditorial);
            Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmEditoriales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEditoriales";
            WindowState = FormWindowState.Maximized;
            pnlEditorial.ResumeLayout(false);
            pnlEditorial.PerformLayout();
            pnlDatosE.ResumeLayout(false);
            pnlDatosE.PerformLayout();
            pnlBotonesE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEditorial;
        private Panel pnlDatosE;
        private Panel pnlBotonesE;
        private DataGridView dgvEditoriales;
        private Label lblEditoriales;
        private Label lblNombreE;
        private TextBox txtNombreE;
        private FontAwesome.Sharp.IconButton btnNuevoE;
        private FontAwesome.Sharp.IconButton btnGuardarE;
        private FontAwesome.Sharp.IconButton btnCancelarE;
        private FontAwesome.Sharp.IconButton btnEliminarE;
        private FontAwesome.Sharp.IconButton btnEditarE;
        private FontAwesome.Sharp.IconButton btnBuscarE;
        private TextBox txtBuscarE;
        private Label lblBuscarE;
    }
}
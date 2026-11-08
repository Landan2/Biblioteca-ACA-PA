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
            pnlCargarE = new Panel();
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
            pnlCargarE.SuspendLayout();
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
            pnlEditorial.Margin = new Padding(4);
            pnlEditorial.Name = "pnlEditorial";
            pnlEditorial.Size = new Size(1041, 75);
            pnlEditorial.TabIndex = 0;
            // 
            // lblEditoriales
            // 
            lblEditoriales.AutoSize = true;
            lblEditoriales.Font = new Font("Sitka Display", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditoriales.ForeColor = Color.Maroon;
            lblEditoriales.Location = new Point(351, 9);
            lblEditoriales.Name = "lblEditoriales";
            lblEditoriales.Size = new Size(349, 50);
            lblEditoriales.TabIndex = 0;
            lblEditoriales.Text = "Gestión de Editoriales";
            // 
            // pnlCargarE
            // 
            pnlCargarE.BackColor = Color.WhiteSmoke;
            pnlCargarE.Controls.Add(btnBuscarE);
            pnlCargarE.Controls.Add(txtBuscarE);
            pnlCargarE.Controls.Add(lblBuscarE);
            pnlCargarE.Controls.Add(txtNombreE);
            pnlCargarE.Controls.Add(lblNombreE);
            pnlCargarE.Dock = DockStyle.Top;
            pnlCargarE.Location = new Point(0, 75);
            pnlCargarE.Margin = new Padding(4);
            pnlCargarE.Name = "pnlCargarE";
            pnlCargarE.Size = new Size(1041, 183);
            pnlCargarE.TabIndex = 1;
            // 
            // btnBuscarE
            // 
            btnBuscarE.Font = new Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarE.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuscarE.IconColor = Color.Black;
            btnBuscarE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarE.Location = new Point(675, 26);
            btnBuscarE.Name = "btnBuscarE";
            btnBuscarE.Size = new Size(98, 33);
            btnBuscarE.TabIndex = 5;
            btnBuscarE.Text = "Buscar";
            btnBuscarE.UseVisualStyleBackColor = true;
            btnBuscarE.Click += btnBuscarE_Click;
            // 
            // txtBuscarE
            // 
            txtBuscarE.BackColor = SystemColors.Window;
            txtBuscarE.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarE.Location = new Point(410, 26);
            txtBuscarE.Name = "txtBuscarE";
            txtBuscarE.Size = new Size(236, 28);
            txtBuscarE.TabIndex = 3;
            // 
            // lblBuscarE
            // 
            lblBuscarE.AutoSize = true;
            lblBuscarE.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscarE.Location = new Point(256, 25);
            lblBuscarE.Name = "lblBuscarE";
            lblBuscarE.Size = new Size(123, 28);
            lblBuscarE.TabIndex = 2;
            lblBuscarE.Text = "Buscar por Id:";
            // 
            // txtNombreE
            // 
            txtNombreE.BackColor = SystemColors.Window;
            txtNombreE.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreE.Location = new Point(410, 111);
            txtNombreE.Name = "txtNombreE";
            txtNombreE.Size = new Size(236, 28);
            txtNombreE.TabIndex = 1;
            // 
            // lblNombreE
            // 
            lblNombreE.AutoSize = true;
            lblNombreE.Font = new Font("Sitka Banner", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreE.Location = new Point(256, 111);
            lblNombreE.Name = "lblNombreE";
            lblNombreE.Size = new Size(81, 28);
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
            pnlBotonesE.Location = new Point(101, 280);
            pnlBotonesE.Margin = new Padding(4);
            pnlBotonesE.Name = "pnlBotonesE";
            pnlBotonesE.Size = new Size(897, 63);
            pnlBotonesE.TabIndex = 2;
            // 
            // btnCancelarE
            // 
            btnCancelarE.Font = new Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarE.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelarE.IconColor = Color.Black;
            btnCancelarE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelarE.Location = new Point(663, 12);
            btnCancelarE.Name = "btnCancelarE";
            btnCancelarE.Size = new Size(98, 37);
            btnCancelarE.TabIndex = 4;
            btnCancelarE.Text = "Cancelar";
            btnCancelarE.UseVisualStyleBackColor = true;
            btnCancelarE.Click += btnCancelarE_Click;
            // 
            // btnEliminarE
            // 
            btnEliminarE.Font = new Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarE.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminarE.IconColor = Color.Black;
            btnEliminarE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminarE.Location = new Point(517, 12);
            btnEliminarE.Name = "btnEliminarE";
            btnEliminarE.Size = new Size(98, 37);
            btnEliminarE.TabIndex = 3;
            btnEliminarE.Text = "Eliminar";
            btnEliminarE.UseVisualStyleBackColor = true;
            btnEliminarE.Click += btnEliminarE_Click;
            // 
            // btnEditarE
            // 
            btnEditarE.Font = new Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarE.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEditarE.IconColor = Color.Black;
            btnEditarE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditarE.Location = new Point(384, 12);
            btnEditarE.Name = "btnEditarE";
            btnEditarE.Size = new Size(98, 37);
            btnEditarE.TabIndex = 2;
            btnEditarE.Text = "Editar ";
            btnEditarE.UseVisualStyleBackColor = true;
            btnEditarE.Click += btnEditarE_Click;
            // 
            // btnGuardarE
            // 
            btnGuardarE.Font = new Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarE.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardarE.IconColor = Color.Black;
            btnGuardarE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardarE.Location = new Point(246, 12);
            btnGuardarE.Name = "btnGuardarE";
            btnGuardarE.Size = new Size(98, 37);
            btnGuardarE.TabIndex = 1;
            btnGuardarE.Text = "Guardar ";
            btnGuardarE.UseVisualStyleBackColor = true;
            btnGuardarE.Click += btnGuardarE_Click;
            // 
            // btnNuevoE
            // 
            btnNuevoE.Font = new Font("Sitka Banner Semibold", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoE.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevoE.IconColor = Color.Black;
            btnNuevoE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevoE.Location = new Point(63, 12);
            btnNuevoE.Name = "btnNuevoE";
            btnNuevoE.Size = new Size(141, 37);
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
            dgvEditoriales.Location = new Point(147, 367);
            dgvEditoriales.Name = "dgvEditoriales";
            dgvEditoriales.Size = new Size(744, 221);
            dgvEditoriales.TabIndex = 3;
            dgvEditoriales.CellDoubleClick += dgvEditoriales_CellDoubleClick;
            // 
            // FrmEditoriales
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1041, 749);
            Controls.Add(dgvEditoriales);
            Controls.Add(pnlBotonesE);
            Controls.Add(pnlCargarE);
            Controls.Add(pnlEditorial);
            Font = new Font("Sitka Text", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmEditoriales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmEditoriales";
            WindowState = FormWindowState.Maximized;
            pnlEditorial.ResumeLayout(false);
            pnlEditorial.PerformLayout();
            pnlCargarE.ResumeLayout(false);
            pnlCargarE.PerformLayout();
            pnlBotonesE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEditorial;
        private Panel pnlCargarE;
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
namespace Biblioteca_ACA_PA
{
    partial class FrmReportes
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
            pnlReportes = new Panel();
            lblReportes = new Label();
            pnlOpciones = new Panel();
            btnLimpiarReporte = new FontAwesome.Sharp.IconButton();
            btnGenerarReporte = new FontAwesome.Sharp.IconButton();
            cmbTipoReporte = new ComboBox();
            lblTipoReporte = new Label();
            pnlListaReportes = new Panel();
            dgvReportes = new DataGridView();
            pnlReportes.SuspendLayout();
            pnlOpciones.SuspendLayout();
            pnlListaReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // pnlReportes
            // 
            pnlReportes.BackColor = Color.Gainsboro;
            pnlReportes.Controls.Add(lblReportes);
            pnlReportes.Dock = DockStyle.Top;
            pnlReportes.Location = new Point(0, 0);
            pnlReportes.Margin = new Padding(3, 4, 3, 4);
            pnlReportes.Name = "pnlReportes";
            pnlReportes.Size = new Size(1050, 75);
            pnlReportes.TabIndex = 0;
            // 
            // lblReportes
            // 
            lblReportes.AutoSize = true;
            lblReportes.Font = new Font("Sitka Display Semibold", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReportes.ForeColor = Color.Maroon;
            lblReportes.Location = new Point(379, 9);
            lblReportes.Name = "lblReportes";
            lblReportes.Size = new Size(313, 50);
            lblReportes.TabIndex = 0;
            lblReportes.Text = "Gestión De Reportes";
            // 
            // pnlOpciones
            // 
            pnlOpciones.BackColor = Color.WhiteSmoke;
            pnlOpciones.Controls.Add(btnLimpiarReporte);
            pnlOpciones.Controls.Add(btnGenerarReporte);
            pnlOpciones.Controls.Add(cmbTipoReporte);
            pnlOpciones.Controls.Add(lblTipoReporte);
            pnlOpciones.Dock = DockStyle.Top;
            pnlOpciones.Location = new Point(0, 75);
            pnlOpciones.Margin = new Padding(3, 4, 3, 4);
            pnlOpciones.Name = "pnlOpciones";
            pnlOpciones.Size = new Size(1050, 274);
            pnlOpciones.TabIndex = 1;
            // 
            // btnLimpiarReporte
            // 
            btnLimpiarReporte.Font = new Font("Sitka Display Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiarReporte.IconChar = FontAwesome.Sharp.IconChar.None;
            btnLimpiarReporte.IconColor = Color.Black;
            btnLimpiarReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiarReporte.Location = new Point(622, 166);
            btnLimpiarReporte.Margin = new Padding(3, 4, 3, 4);
            btnLimpiarReporte.Name = "btnLimpiarReporte";
            btnLimpiarReporte.Size = new Size(159, 48);
            btnLimpiarReporte.TabIndex = 3;
            btnLimpiarReporte.Text = "Limpiar";
            btnLimpiarReporte.UseVisualStyleBackColor = true;
            btnLimpiarReporte.Click += btnLimpiarReporte_Click;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.Font = new Font("Sitka Display Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarReporte.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGenerarReporte.IconColor = Color.Black;
            btnGenerarReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGenerarReporte.Location = new Point(343, 166);
            btnGenerarReporte.Margin = new Padding(3, 4, 3, 4);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(177, 48);
            btnGenerarReporte.TabIndex = 2;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.Font = new Font("Sitka Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Location = new Point(410, 40);
            cmbTipoReporte.Margin = new Padding(3, 4, 3, 4);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(299, 31);
            cmbTipoReporte.TabIndex = 1;
            // 
            // lblTipoReporte
            // 
            lblTipoReporte.AutoSize = true;
            lblTipoReporte.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoReporte.Location = new Point(211, 40);
            lblTipoReporte.Name = "lblTipoReporte";
            lblTipoReporte.Size = new Size(121, 23);
            lblTipoReporte.TabIndex = 0;
            lblTipoReporte.Text = "Tipo De Reporte:";
            // 
            // pnlListaReportes
            // 
            pnlListaReportes.Controls.Add(dgvReportes);
            pnlListaReportes.Dock = DockStyle.Fill;
            pnlListaReportes.Location = new Point(0, 349);
            pnlListaReportes.Margin = new Padding(3, 4, 3, 4);
            pnlListaReportes.Name = "pnlListaReportes";
            pnlListaReportes.Size = new Size(1050, 400);
            pnlListaReportes.TabIndex = 2;
            // 
            // dgvReportes
            // 
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.BackgroundColor = Color.Silver;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.GridColor = Color.Silver;
            dgvReportes.Location = new Point(3, 0);
            dgvReportes.Margin = new Padding(3, 4, 3, 4);
            dgvReportes.MultiSelect = false;
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.Size = new Size(1044, 282);
            dgvReportes.TabIndex = 0;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1050, 749);
            Controls.Add(pnlListaReportes);
            Controls.Add(pnlOpciones);
            Controls.Add(pnlReportes);
            Font = new Font("Sitka Display", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmReportes";
            Text = "FrmReportes";
            pnlReportes.ResumeLayout(false);
            pnlReportes.PerformLayout();
            pnlOpciones.ResumeLayout(false);
            pnlOpciones.PerformLayout();
            pnlListaReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlReportes;
        private Panel pnlOpciones;
        private Label lblReportes;
        private Label lblTipoReporte;
        private Panel pnlListaReportes;
        private ComboBox cmbTipoReporte;
        private FontAwesome.Sharp.IconButton btnLimpiarReporte;
        private FontAwesome.Sharp.IconButton btnGenerarReporte;
        private DataGridView dgvReportes;
    }
}
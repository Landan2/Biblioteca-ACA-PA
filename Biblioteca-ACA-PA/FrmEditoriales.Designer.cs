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
            pnlCargarE = new Panel();
            pnlBotonesE = new Panel();
            dgvEditoriales = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).BeginInit();
            SuspendLayout();
            // 
            // pnlEditorial
            // 
            pnlEditorial.BackColor = Color.Gainsboro;
            pnlEditorial.Dock = DockStyle.Top;
            pnlEditorial.Location = new Point(0, 0);
            pnlEditorial.Margin = new Padding(4);
            pnlEditorial.Name = "pnlEditorial";
            pnlEditorial.Size = new Size(1041, 83);
            pnlEditorial.TabIndex = 0;
            // 
            // pnlCargarE
            // 
            pnlCargarE.BackColor = Color.WhiteSmoke;
            pnlCargarE.Dock = DockStyle.Top;
            pnlCargarE.Location = new Point(0, 83);
            pnlCargarE.Margin = new Padding(4);
            pnlCargarE.Name = "pnlCargarE";
            pnlCargarE.Size = new Size(1041, 183);
            pnlCargarE.TabIndex = 1;
            // 
            // pnlBotonesE
            // 
            pnlBotonesE.Location = new Point(85, 296);
            pnlBotonesE.Margin = new Padding(4);
            pnlBotonesE.Name = "pnlBotonesE";
            pnlBotonesE.Size = new Size(897, 63);
            pnlBotonesE.TabIndex = 2;
            // 
            // dgvEditoriales
            // 
            dgvEditoriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEditoriales.BackgroundColor = Color.Silver;
            dgvEditoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditoriales.Location = new Point(148, 394);
            dgvEditoriales.Name = "dgvEditoriales";
            dgvEditoriales.Size = new Size(744, 181);
            dgvEditoriales.TabIndex = 3;
            // 
            // FrmEditoriales
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
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
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEditorial;
        private Panel pnlCargarE;
        private Panel pnlBotonesE;
        private DataGridView dgvEditoriales;
    }
}
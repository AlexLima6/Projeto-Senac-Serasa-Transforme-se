namespace ProjetoIntegrador.Controles
{
    partial class ControleTurmas
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            dgvListaTurmas = new DataGridView();
            btnPesquisarTurmas = new Button();
            lblTurmas = new Label();
            cbxPesquisar = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvListaTurmas).BeginInit();
            SuspendLayout();
            // 
            // dgvListaTurmas
            // 
            dgvListaTurmas.AllowUserToAddRows = false;
            dgvListaTurmas.AllowUserToDeleteRows = false;
            dgvListaTurmas.AllowUserToOrderColumns = true;
            dgvListaTurmas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvListaTurmas.BackgroundColor = Color.Red;
            dgvListaTurmas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaTurmas.Location = new Point(12, 42);
            dgvListaTurmas.Name = "dgvListaTurmas";
            dgvListaTurmas.ReadOnly = true;
            dgvListaTurmas.Size = new Size(520, 387);
            dgvListaTurmas.TabIndex = 7;
            // 
            // btnPesquisarTurmas
            // 
            btnPesquisarTurmas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisarTurmas.Location = new Point(461, 13);
            btnPesquisarTurmas.Name = "btnPesquisarTurmas";
            btnPesquisarTurmas.Size = new Size(71, 23);
            btnPesquisarTurmas.TabIndex = 5;
            btnPesquisarTurmas.Text = "button1";
            btnPesquisarTurmas.UseVisualStyleBackColor = true;
            // 
            // lblTurmas
            // 
            lblTurmas.AutoSize = true;
            lblTurmas.Location = new Point(12, 16);
            lblTurmas.Name = "lblTurmas";
            lblTurmas.Size = new Size(72, 15);
            lblTurmas.TabIndex = 4;
            lblTurmas.Text = "listar turmas";
            // 
            // cbxPesquisar
            // 
            cbxPesquisar.FormattingEnabled = true;
            cbxPesquisar.Location = new Point(128, 12);
            cbxPesquisar.Name = "cbxPesquisar";
            cbxPesquisar.Size = new Size(298, 23);
            cbxPesquisar.TabIndex = 8;
            // 
            // ControleTurmas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbxPesquisar);
            Controls.Add(dgvListaTurmas);
            Controls.Add(btnPesquisarTurmas);
            Controls.Add(lblTurmas);
            Name = "ControleTurmas";
            Size = new Size(551, 442);
            ((System.ComponentModel.ISupportInitialize)dgvListaTurmas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListaTurmas;
        private Button btnPesquisarTurmas;
        private Label lblTurmas;
        private ComboBox cbxPesquisar;
    }
}

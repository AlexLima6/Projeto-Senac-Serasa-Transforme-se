namespace ProjetoIntegrador.Controles
{
    partial class controlebtn3
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
            label1 = new Label();
            btnPesquisar = new Button();
            txtPesquisar = new TextBox();
            dgvLista = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "listar professores";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.Location = new Point(380, 16);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(71, 23);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "button1";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Anchor = AnchorStyles.Top;
            txtPesquisar.Location = new Point(122, 16);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(248, 23);
            txtPesquisar.TabIndex = 2;
            // 
            // dgvLista
            // 
            dgvLista.AllowUserToAddRows = false;
            dgvLista.AllowUserToDeleteRows = false;
            dgvLista.AllowUserToOrderColumns = true;
            dgvLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(12, 45);
            dgvLista.Name = "dgvLista";
            dgvLista.ReadOnly = true;
            dgvLista.Size = new Size(464, 301);
            dgvLista.TabIndex = 3;
            // 
            // controlebtn3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvLista);
            Controls.Add(txtPesquisar);
            Controls.Add(btnPesquisar);
            Controls.Add(label1);
            Name = "controlebtn3";
            Size = new Size(488, 357);
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPesquisar;
        private TextBox txtPesquisar;
        private DataGridView dgvLista;
    }
}

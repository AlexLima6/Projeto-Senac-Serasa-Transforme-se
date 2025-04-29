namespace ProjetoIntegrador.Controles
{
    partial class Estoque
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
            pnlCabecalho = new Panel();
            btnEditarProduto = new Button();
            btnRmvProduto = new Button();
            btnAdcProduto = new Button();
            dgvLista = new DataGridView();
            pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = SystemColors.ActiveCaption;
            pnlCabecalho.Controls.Add(btnEditarProduto);
            pnlCabecalho.Controls.Add(btnRmvProduto);
            pnlCabecalho.Controls.Add(btnAdcProduto);
            pnlCabecalho.Dock = DockStyle.Top;
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(800, 63);
            pnlCabecalho.TabIndex = 0;
            // 
            // btnEditarProduto
            // 
            btnEditarProduto.Cursor = Cursors.Hand;
            btnEditarProduto.Font = new Font("Poor Richard", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnEditarProduto.Location = new Point(658, 12);
            btnEditarProduto.Name = "btnEditarProduto";
            btnEditarProduto.Size = new Size(130, 38);
            btnEditarProduto.TabIndex = 2;
            btnEditarProduto.Text = "Editar Produto";
            btnEditarProduto.UseVisualStyleBackColor = true;
            // 
            // btnRmvProduto
            // 
            btnRmvProduto.Cursor = Cursors.Hand;
            btnRmvProduto.Font = new Font("Poor Richard", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnRmvProduto.Location = new Point(510, 12);
            btnRmvProduto.Name = "btnRmvProduto";
            btnRmvProduto.Size = new Size(130, 38);
            btnRmvProduto.TabIndex = 1;
            btnRmvProduto.Text = "Remover Produto";
            btnRmvProduto.UseVisualStyleBackColor = true;
            btnRmvProduto.Click += btnRmvProduto_Click;
            // 
            // btnAdcProduto
            // 
            btnAdcProduto.Cursor = Cursors.Hand;
            btnAdcProduto.Font = new Font("Poor Richard", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            btnAdcProduto.Location = new Point(364, 12);
            btnAdcProduto.Name = "btnAdcProduto";
            btnAdcProduto.Size = new Size(130, 38);
            btnAdcProduto.TabIndex = 0;
            btnAdcProduto.Text = "Adicionar Produto";
            btnAdcProduto.UseVisualStyleBackColor = true;
            btnAdcProduto.Click += btnAdcProduto_Click;
            // 
            // dgvLista
            // 
            dgvLista.AllowUserToAddRows = false;
            dgvLista.AllowUserToDeleteRows = false;
            dgvLista.AllowUserToOrderColumns = true;
            dgvLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(12, 69);
            dgvLista.Name = "dgvLista";
            dgvLista.ReadOnly = true;
            dgvLista.Size = new Size(776, 369);
            dgvLista.TabIndex = 1;
            // 
            // Estoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvLista);
            Controls.Add(pnlCabecalho);
            Name = "Estoque";
            Size = new Size(800, 450);
            pnlCabecalho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecalho;
        private Button btnAdcProduto;
        private DataGridView dgvLista;
        private Button btnEditarProduto;
        private Button btnRmvProduto;
    }
}
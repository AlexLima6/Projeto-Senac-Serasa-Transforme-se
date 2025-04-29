namespace ProjetoIntegrador.Controles
{
    partial class CardProduto
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
            pnlConteudo = new Panel();
            lblValor = new Label();
            lblDesc = new Label();
            lblNomeProduto = new Label();
            ptbProdutoImage = new PictureBox();
            pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbProdutoImage).BeginInit();
            SuspendLayout();
            // 
            // pnlConteudo
            // 
            pnlConteudo.Controls.Add(lblValor);
            pnlConteudo.Controls.Add(lblDesc);
            pnlConteudo.Controls.Add(lblNomeProduto);
            pnlConteudo.Controls.Add(ptbProdutoImage);
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(0, 0);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(258, 258);
            pnlConteudo.TabIndex = 0;
            // 
            // lblValor
            // 
            lblValor.Dock = DockStyle.Bottom;
            lblValor.Location = new Point(0, 235);
            lblValor.Margin = new Padding(0);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(258, 23);
            lblValor.TabIndex = 3;
            lblValor.Text = "R$ 000,00";
            // 
            // lblDesc
            // 
            lblDesc.BackColor = Color.LightCoral;
            lblDesc.Location = new Point(0, 193);
            lblDesc.Margin = new Padding(0);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(258, 39);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Desc";
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.Location = new Point(3, 170);
            lblNomeProduto.Margin = new Padding(0);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(255, 23);
            lblNomeProduto.TabIndex = 1;
            lblNomeProduto.Text = "Nome";
            // 
            // ptbProdutoImage
            // 
            ptbProdutoImage.Location = new Point(0, 3);
            ptbProdutoImage.Margin = new Padding(0);
            ptbProdutoImage.Name = "ptbProdutoImage";
            ptbProdutoImage.Size = new Size(258, 164);
            ptbProdutoImage.SizeMode = PictureBoxSizeMode.Zoom;
            ptbProdutoImage.TabIndex = 0;
            ptbProdutoImage.TabStop = false;
            // 
            // CardProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlConteudo);
            Name = "CardProduto";
            Size = new Size(258, 258);
            pnlConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbProdutoImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlConteudo;
        private Label lblNomeProduto;
        private PictureBox ptbProdutoImage;
        private Label lblValor;
        private Label lblDesc;
    }
}

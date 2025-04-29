namespace ProjetoIntegrador
{
    partial class menuCardPersonalizado
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
            pnlCardconteudo = new Panel();
            lblnomeCategoria = new Label();
            ptbCardimage = new PictureBox();
            pnlCardconteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbCardimage).BeginInit();
            SuspendLayout();
            // 
            // pnlCardconteudo
            // 
            pnlCardconteudo.Controls.Add(lblnomeCategoria);
            pnlCardconteudo.Controls.Add(ptbCardimage);
            pnlCardconteudo.Dock = DockStyle.Fill;
            pnlCardconteudo.Location = new Point(0, 0);
            pnlCardconteudo.Name = "pnlCardconteudo";
            pnlCardconteudo.Size = new Size(145, 46);
            pnlCardconteudo.TabIndex = 0;
            // 
            // lblnomeCategoria
            // 
            lblnomeCategoria.BackColor = Color.Red;
            lblnomeCategoria.Cursor = Cursors.Hand;
            lblnomeCategoria.Font = new Font("Poor Richard", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblnomeCategoria.ForeColor = Color.White;
            lblnomeCategoria.Location = new Point(52, 0);
            lblnomeCategoria.Margin = new Padding(0);
            lblnomeCategoria.Name = "lblnomeCategoria";
            lblnomeCategoria.Size = new Size(93, 46);
            lblnomeCategoria.TabIndex = 1;
            lblnomeCategoria.Text = "Pães";
            lblnomeCategoria.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ptbCardimage
            // 
            ptbCardimage.Cursor = Cursors.Hand;
            ptbCardimage.Image = Properties.Resources.ciabatta;
            ptbCardimage.Location = new Point(0, 0);
            ptbCardimage.Margin = new Padding(0);
            ptbCardimage.Name = "ptbCardimage";
            ptbCardimage.Size = new Size(52, 46);
            ptbCardimage.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbCardimage.TabIndex = 0;
            ptbCardimage.TabStop = false;
            // 
            // menuCardPersonalizado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlCardconteudo);
            Name = "menuCardPersonalizado";
            Size = new Size(145, 46);
            pnlCardconteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbCardimage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCardconteudo;
        private PictureBox ptbCardimage;
        private Label lblnomeCategoria;
    }
}

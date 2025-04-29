namespace ProjetoIntegrador
{
    partial class Form_Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            panel1 = new Panel();
            menuCardPersonalizado7 = new menuCardPersonalizado();
            menuCardPersonalizado1 = new menuCardPersonalizado();
            menuCardPersonalizado6 = new menuCardPersonalizado();
            menuCardPersonalizado5 = new menuCardPersonalizado();
            menuCardPersonalizado4 = new menuCardPersonalizado();
            menuCardPersonalizado3 = new menuCardPersonalizado();
            menuCardPersonalizado2 = new menuCardPersonalizado();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pnlConteudo = new Panel();
            btnEstoque = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(191, 19, 4);
            panel1.Controls.Add(btnEstoque);
            panel1.Controls.Add(menuCardPersonalizado7);
            panel1.Controls.Add(menuCardPersonalizado1);
            panel1.Controls.Add(menuCardPersonalizado6);
            panel1.Controls.Add(menuCardPersonalizado5);
            panel1.Controls.Add(menuCardPersonalizado4);
            panel1.Controls.Add(menuCardPersonalizado3);
            panel1.Controls.Add(menuCardPersonalizado2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 681);
            panel1.TabIndex = 0;
            // 
            // menuCardPersonalizado7
            // 
            menuCardPersonalizado7.cardImage = (Image)resources.GetObject("menuCardPersonalizado7.cardImage");
            menuCardPersonalizado7.Location = new Point(12, 405);
            menuCardPersonalizado7.Name = "menuCardPersonalizado7";
            menuCardPersonalizado7.nomeCard = "Bebidas";
            menuCardPersonalizado7.Size = new Size(145, 46);
            menuCardPersonalizado7.TabIndex = 8;
            menuCardPersonalizado7.Click += menuCardPersonalizado7_Click;
            // 
            // menuCardPersonalizado1
            // 
            menuCardPersonalizado1.cardImage = (Image)resources.GetObject("menuCardPersonalizado1.cardImage");
            menuCardPersonalizado1.Location = new Point(12, 353);
            menuCardPersonalizado1.Name = "menuCardPersonalizado1";
            menuCardPersonalizado1.nomeCard = "Batatas";
            menuCardPersonalizado1.Size = new Size(145, 46);
            menuCardPersonalizado1.TabIndex = 7;
            menuCardPersonalizado1.Click += menuCardPersonalizado1_Click_2;
            // 
            // menuCardPersonalizado6
            // 
            menuCardPersonalizado6.cardImage = (Image)resources.GetObject("menuCardPersonalizado6.cardImage");
            menuCardPersonalizado6.Location = new Point(12, 93);
            menuCardPersonalizado6.Name = "menuCardPersonalizado6";
            menuCardPersonalizado6.nomeCard = "Pães";
            menuCardPersonalizado6.Size = new Size(145, 46);
            menuCardPersonalizado6.TabIndex = 6;
            menuCardPersonalizado6.Click += menuCardPersonalizado6_Click;
            // 
            // menuCardPersonalizado5
            // 
            menuCardPersonalizado5.cardImage = (Image)resources.GetObject("menuCardPersonalizado5.cardImage");
            menuCardPersonalizado5.Location = new Point(12, 301);
            menuCardPersonalizado5.Name = "menuCardPersonalizado5";
            menuCardPersonalizado5.nomeCard = "Molhos";
            menuCardPersonalizado5.Size = new Size(145, 46);
            menuCardPersonalizado5.TabIndex = 5;
            menuCardPersonalizado5.Click += menuCardPersonalizado5_Click;
            // 
            // menuCardPersonalizado4
            // 
            menuCardPersonalizado4.cardImage = (Image)resources.GetObject("menuCardPersonalizado4.cardImage");
            menuCardPersonalizado4.Location = new Point(12, 249);
            menuCardPersonalizado4.Name = "menuCardPersonalizado4";
            menuCardPersonalizado4.nomeCard = "Saladas";
            menuCardPersonalizado4.Size = new Size(145, 46);
            menuCardPersonalizado4.TabIndex = 4;
            menuCardPersonalizado4.Click += menuCardPersonalizado4_Click;
            // 
            // menuCardPersonalizado3
            // 
            menuCardPersonalizado3.cardImage = (Image)resources.GetObject("menuCardPersonalizado3.cardImage");
            menuCardPersonalizado3.Location = new Point(12, 197);
            menuCardPersonalizado3.Name = "menuCardPersonalizado3";
            menuCardPersonalizado3.nomeCard = "Queijos";
            menuCardPersonalizado3.Size = new Size(145, 46);
            menuCardPersonalizado3.TabIndex = 3;
            menuCardPersonalizado3.Click += menuCardPersonalizado3_Click;
            // 
            // menuCardPersonalizado2
            // 
            menuCardPersonalizado2.cardImage = (Image)resources.GetObject("menuCardPersonalizado2.cardImage");
            menuCardPersonalizado2.Location = new Point(12, 145);
            menuCardPersonalizado2.Name = "menuCardPersonalizado2";
            menuCardPersonalizado2.nomeCard = "Proteína";
            menuCardPersonalizado2.Size = new Size(145, 46);
            menuCardPersonalizado2.TabIndex = 2;
            menuCardPersonalizado2.Click += menuCardPersonalizado2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.BEM_VINDO__3__removebg_preview;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(165, 581);
            panel2.Name = "panel2";
            panel2.Size = new Size(1059, 100);
            panel2.TabIndex = 1;
            // 
            // pnlConteudo
            // 
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(165, 0);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(1059, 581);
            pnlConteudo.TabIndex = 2;
            // 
            // btnEstoque
            // 
            btnEstoque.Location = new Point(12, 611);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(134, 40);
            btnEstoque.TabIndex = 9;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = true;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // Form_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 681);
            Controls.Add(pnlConteudo);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Poor Richard", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            Margin = new Padding(4);
            MaximumSize = new Size(1240, 720);
            MinimumSize = new Size(620, 480);
            Name = "Form_Menu";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private menuCardPersonalizado menuCardPersonalizado5;
        private menuCardPersonalizado menuCardPersonalizado4;
        private menuCardPersonalizado menuCardPersonalizado3;
        private menuCardPersonalizado menuCardPersonalizado2;
        private menuCardPersonalizado menuCardPersonalizado6;
        private menuCardPersonalizado menuCardPersonalizado7;
        private menuCardPersonalizado menuCardPersonalizado1;
        private Panel pnlConteudo;
        private Button btnEstoque;
    }
}

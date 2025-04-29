namespace ProjetoIntegrador
{
    partial class controleClientes
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
            dgb_tabela = new DataGridView();
            btnTurmas = new Button();
            panel1 = new Panel();
            button3 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgb_tabela).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgb_tabela
            // 
            dgb_tabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgb_tabela.Location = new Point(128, 38);
            dgb_tabela.Name = "dgb_tabela";
            dgb_tabela.Size = new Size(564, 365);
            dgb_tabela.TabIndex = 0;
            dgb_tabela.CellContentClick += dgb_tabela_CellContentClick;
            // 
            // btnTurmas
            // 
            btnTurmas.Location = new Point(3, 73);
            btnTurmas.Name = "btnTurmas";
            btnTurmas.Size = new Size(101, 38);
            btnTurmas.TabIndex = 2;
            btnTurmas.Text = "Turmas";
            btnTurmas.UseVisualStyleBackColor = true;
            btnTurmas.Click += btnTurmas_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnTurmas);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(122, 415);
            panel1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Location = new Point(3, 126);
            button3.Name = "button3";
            button3.Size = new Size(101, 38);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 24);
            button1.Name = "button1";
            button1.Size = new Size(101, 33);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // controleClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(695, 415);
            Controls.Add(panel1);
            Controls.Add(dgb_tabela);
            Name = "controleClientes";
            Load += controleClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgb_tabela).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgb_tabela;
        private Button btnTurmas;
        private Panel panel1;
        private Button button3;
        private Button button1;
    }
}

namespace ProjetoIntegrador
{
    partial class controleProduto
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
            pnlCabelho = new Panel();
            flpListaProdutos = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // pnlCabelho
            // 
            pnlCabelho.BackColor = SystemColors.GradientActiveCaption;
            pnlCabelho.Dock = DockStyle.Top;
            pnlCabelho.Location = new Point(0, 0);
            pnlCabelho.Name = "pnlCabelho";
            pnlCabelho.Size = new Size(800, 46);
            pnlCabelho.TabIndex = 0;
            // 
            // flpListaProdutos
            // 
            flpListaProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpListaProdutos.AutoScroll = true;
            flpListaProdutos.BackColor = SystemColors.Control;
            flpListaProdutos.BorderStyle = BorderStyle.FixedSingle;
            flpListaProdutos.Location = new Point(10, 54);
            flpListaProdutos.Margin = new Padding(16);
            flpListaProdutos.Name = "flpListaProdutos";
            flpListaProdutos.Size = new Size(776, 390);
            flpListaProdutos.TabIndex = 1;
            // 
            // controleProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpListaProdutos);
            Controls.Add(pnlCabelho);
            Name = "controleProduto";
            Text = "controleProduto";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabelho;
        private FlowLayoutPanel flpListaProdutos;
    }
}
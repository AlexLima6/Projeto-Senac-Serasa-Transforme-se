using ProjetoIntegrador.Controles;
using ProjetoIntegrador.Uteis;

namespace ProjetoIntegrador
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }



        private void menuCardPersonalizado1_Click(object sender, EventArgs e)
        {
            CardProduto paes = new CardProduto();
            paes.Show();
        }

        private void menuCardPersonalizado1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Teste" +
                "");
        }

        private void menuCardPersonalizado6_Click(object sender, EventArgs e)
        {
            pnlConteudo.Controls.Clear();

            controleProduto meuControleProdutos = new controleProduto(1);
            pnlConteudo.Controls.Add(meuControleProdutos);
            meuControleProdutos.Dock = DockStyle.Fill;

        }

        private void cardProduto1_Click(object sender, EventArgs e)
        {

        }

        private void menuCardPersonalizado2_Click(object sender, EventArgs e)
        {
            pnlConteudo.Controls.Clear();

            controleProduto meuControleProdutos = new controleProduto(2);
            pnlConteudo.Controls.Add(meuControleProdutos);
            meuControleProdutos.Dock = DockStyle.Fill;
        }

        private void menuCardPersonalizado3_Click(object sender, EventArgs e)
        {
            pnlConteudo.Controls.Clear();

            controleProduto meuControleProdutos = new controleProduto(3);
            pnlConteudo.Controls.Add(meuControleProdutos);
            meuControleProdutos.Dock = DockStyle.Fill;
        }

        private void menuCardPersonalizado4_Click(object sender, EventArgs e)
        {
            pnlConteudo.Controls.Clear();

            controleProduto meuControleProdutos = new controleProduto(4);
            pnlConteudo.Controls.Add(meuControleProdutos);
            meuControleProdutos.Dock = DockStyle.Fill;
        }

        private void menuCardPersonalizado5_Click(object sender, EventArgs e)
        {
            pnlConteudo.Controls.Clear();

            controleProduto meuControleProdutos = new controleProduto(5);
            pnlConteudo.Controls.Add(meuControleProdutos);
            meuControleProdutos.Dock = DockStyle.Fill;
        }

        private void menuCardPersonalizado7_Click(object sender, EventArgs e)
        {
            pnlConteudo.Controls.Clear();

            controleProduto meuControleProdutos = new controleProduto(6);
            pnlConteudo.Controls.Add(meuControleProdutos);
            meuControleProdutos.Dock = DockStyle.Fill;
        }

        private void menuCardPersonalizado1_Click_2(object sender, EventArgs e)
        {
            pnlConteudo.Controls.Clear();

            controleProduto meuControleProdutos = new controleProduto(7);
            pnlConteudo.Controls.Add(meuControleProdutos);
            meuControleProdutos.Dock = DockStyle.Fill;
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            Estoque controleEtoque = new Estoque ();
            pnlConteudo.Controls.Add(controleEtoque);
            controleEtoque.Dock = DockStyle.Fill;
        }
    }
}

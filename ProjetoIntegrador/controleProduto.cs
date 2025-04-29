using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegrador.Controles;
using ProjetoIntegrador.DAL;

namespace ProjetoIntegrador
{
    public partial class controleProduto : UserControl
    {
        public controleProduto()
        {
            InitializeComponent();

            flpListaProdutos.AutoScroll = true;
            flpListaProdutos.Controls.Clear();

            foreach (var item in ConsultaProdutos.ListarTodosOsProdutosDTO())
            {
                CardProduto meuCard = new CardProduto(item);
                flpListaProdutos.Controls.Add(meuCard);
            }
        }

        public controleProduto(int id_selecionado)
        {
            InitializeComponent();

            flpListaProdutos.AutoScroll = true;
            flpListaProdutos.Controls.Clear();

            foreach (var item in ConsultaProdutos.ListarTodosOsProdutosDTO().Where(item => item.idCategoria == id_selecionado))
            {
                CardProduto meuCard = new CardProduto(item);
                flpListaProdutos.Controls.Add(meuCard);
            }
        }
    }
}

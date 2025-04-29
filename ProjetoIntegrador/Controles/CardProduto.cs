using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegrador.DTO;

namespace ProjetoIntegrador.Controles
{
    [DefaultEvent("Click")]
    
    public partial class CardProduto : UserControl
    {
        [Category("# MenuCard - Configuração")]
        public string descricaoCard
        {
            get { return lblDesc.Text; }
            set { lblDesc.Text = value; }
        }

        [Category("# MenuCard - Configuração")]
        public string nomeProduto

        {
            get { return lblNomeProduto.Text; }
            set { lblNomeProduto.Text = value; }
        }


        [Category("# MenuCard - Configuração")]
        public string linkImagem

        {
            get { return ptbProdutoImage.ImageLocation; }
            set { ptbProdutoImage.ImageLocation = value; }
        }

        [Category("# MenuCard - Configuração")]
        public string valorProduto

        {
            get { return lblValor.Text; }
            set { lblValor.Text = value; }
        }

        public CardProduto()
        {
            InitializeComponent();
            
        }
        public CardProduto(ProdutoDTO Produto)
        {
            InitializeComponent();
            lblNomeProduto.Text = Produto.Nome;
            lblDesc.Text = Produto.Descricao;
            lblValor.Text = $"R$ {Produto.Valor.ToString()}";
            //ptbProdutoImage.ImageLocation = Link da imagem
            
        }


        public event EventHandler Click
        {
            add
            {
                lblNomeProduto.Click += value;
                ptbProdutoImage.Click += value;
                lblValor.Click += value;
                lblDesc.Click += value;


            }

            remove
            {
                lblNomeProduto.Click -= value;
                ptbProdutoImage.Click -= value;
                lblValor.Click -= value;
                lblDesc.Click -= value;
           
            }
        }
    }
}

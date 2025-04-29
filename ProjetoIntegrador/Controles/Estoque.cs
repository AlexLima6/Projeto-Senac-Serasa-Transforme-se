using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegrador.DAL;

namespace ProjetoIntegrador.Controles
{
    public partial class Estoque : UserControl
    {
        public Estoque()
        {
            InitializeComponent();

            dgvLista.DataSource = ConsultaProdutos.ListarTodosOsProdutosDataTable();

        }

        private void btnRmvProduto_Click(object sender, EventArgs e)
        {

        }

        private void btnAdcProduto_Click(object sender, EventArgs e)
        {
            
        }
    }
}

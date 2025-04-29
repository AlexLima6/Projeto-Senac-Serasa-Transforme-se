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
    public partial class controlebtn3 : UserControl
    {
        public controlebtn3()
        {
            InitializeComponent();

            dgvLista.DataSource = ConsultaProfessores.listarProdutos();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvLista.DataSource = ConsultaProfessores.buscarProdutos(txtPesquisar.Text);
        }
    }
}

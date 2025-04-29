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
    public partial class ControleTurmas : UserControl
    {
        public ControleTurmas()
        {
            InitializeComponent();
            dgvListaTurmas.DataSource = ConsultarTurmas.buscarProdutos(cbxPesquisar.SelectedValue.ToString());

            cbxPesquisar.DataSource =  
                cbxPesquisar.DisplayMember = "";
                cbxPesquisar.ValueMember = "";
        }

       
    }
}

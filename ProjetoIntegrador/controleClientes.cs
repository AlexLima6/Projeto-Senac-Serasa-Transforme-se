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

namespace ProjetoIntegrador
{
    public partial class controleClientes : Form
    {
        public controleClientes()
        {
            InitializeComponent();

        }

        private void controleClientes_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            controlebtn3 controleprofessores = new controlebtn3();
            dgb_tabela.Controls.Add(controleprofessores);
            controleprofessores.Dock = DockStyle.Fill;

        }

        private void dgb_tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTurmas_Click(object sender, EventArgs e)
        {
            ControleTurmas exemploturmas = new ControleTurmas();
            dgb_tabela.Controls.Add(exemploturmas);
            exemploturmas.Dock = DockStyle.Fill;
        }
    }
}

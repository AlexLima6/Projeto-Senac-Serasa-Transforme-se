using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegrador.Uteis;

namespace ProjetoIntegrador
{
    [DefaultEvent("Click")]
    public partial class menuCardPersonalizado : UserControl
    {



        [Category("# Opções de Card")]
        public Image cardImage { get { return ptbCardimage.Image; } set { ptbCardimage.Image = value; } }

        [Category("# Opções de Card")]
        public string nomeCard { get { return lblnomeCategoria.Text; } set { lblnomeCategoria.Text = value; } }

        public menuCardPersonalizado()
        {
            InitializeComponent();
            Uteis.Rounded.setRoundedController(this, 16);


        }       

        public event EventHandler Click
        {
            add
            {
                lblnomeCategoria.Click += value;
                ptbCardimage.Click += value;


            }

            remove
            {
                lblnomeCategoria.Click -= value;
                ptbCardimage.Click -= value;


            }
        }

    }
}




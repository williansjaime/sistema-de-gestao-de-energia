using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGerenciamentoEnergia.Vews
{
    public partial class ContatosAdm : Form
    {
        public ContatosAdm()
        {
            InitializeComponent();
        }

        private void BotaoSairContatos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using SistemaGerenciamentoEnergia.Vews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGerenciamentoEnergia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
           
        }

        private void BootaoIrLogin_Click(object sender, EventArgs e)
        {
            var IniciarLogin = new Form2();
            IniciarLogin.ShowDialog();
            
            
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Contatos = new ContatosAdm();
            Contatos.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Servico = new ServiçosAdm();
            Servico.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var Institucional = new IntitucionalAdm();
            Institucional.ShowDialog();
        }
    }
}

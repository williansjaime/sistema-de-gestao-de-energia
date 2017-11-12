using SistemaGerenciamentoEnergia.Vews;
using SistemaGerenciamentoEnergia.Modelo.Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGerenciamentoEnergia.Controller;

namespace SistemaGerenciamentoEnergia
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var login = new cadastro_usuario();
            login.Show();
                        
            var form = new Form2();
            form.Close();
            
            //this.Close();
            var form1 = new Form1();
            form1.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ControleDeUsuario controle = new ControleDeUsuario();
            Controller_Equipamento controleEquipamento = new Controller_Equipamento();
            CadastroEquipamentos cadastro_Equipamento = new CadastroEquipamentos();
            bool verificaUsuario, verificaEquipamento; //receber o valor
            double senha;

            senha = double.Parse(textSenha.Text);
            verificaUsuario = controle.Verificar_Usuario(textNomelogin.ToString(), senha);
            verificaEquipamento = controleEquipamento.PesquisarEquipamento(double.Parse(textSenha.Text));

            if(verificaEquipamento == true)
            {
                var monitorar = new Monitoramento();
                monitorar.Show();
                this.Close();               
            }
             else if (verificaUsuario == true)
            {
                cadastro_Equipamento.Show();
                this.Close();
                var form1 = new Form1();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nome de usuario ou senha incorretos");
            }


        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

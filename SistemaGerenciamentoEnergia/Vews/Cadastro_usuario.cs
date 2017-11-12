using System;
using SistemaGerenciamentoEnergia.Modelo.Entidade;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGerenciamentoEnergia.Controller;

namespace SistemaGerenciamentoEnergia.Vews
{
    public partial class cadastro_usuario : Form
    {
        public cadastro_usuario()
        {
            InitializeComponent();

        }

        //Criar uma variavel do tipo modelo de cadastro
        Modelo_Cadastro modelCasdastro = new Modelo_Cadastro();

        //Criar uma variavel para controle
        ControleDeUsuario controleUsuario = new ControleDeUsuario();

        //controlar o id
        Modelo_Equipamento modelequipamento = new Modelo_Equipamento();
        Controller_Equipamento controlequipamento = new Controller_Equipamento();

        
        private void button1_Click(object sender, EventArgs e)
        {
            var login = new Form2();

            modelCasdastro.Nome = Nome.ToString();
            controleUsuario.AddUsuario(modelCasdastro);
            
            modelCasdastro.CEP = double.Parse(textCep.Text);
            controleUsuario.AddUsuario(modelCasdastro);

            modelCasdastro.Rua = textEndereco.Text;
            controleUsuario.AddUsuario(modelCasdastro);

            modelCasdastro.NUmero = double.Parse(textNumero.Text);
            controleUsuario.AddUsuario(modelCasdastro);

            modelCasdastro.Senha = double.Parse(textSenha.Text);
            controleUsuario.AddUsuario(modelCasdastro);

            var senhadois = double.Parse(textCofSenha.Text);
            controleUsuario.AddUsuario(modelCasdastro);

            //verifica se a senha batem  
            if (modelCasdastro.Senha == senhadois )
            {
                //vai usar a senha como id
                modelequipamento.Id = double.Parse(textSenha.Text);
                controlequipamento.Add_Equipamento(modelequipamento); 
                                
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Suas senhas não batem ");
            }
        }

        private void cadastro_usuario_Load(object sender, EventArgs e)
        {

        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void BootaoSairLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

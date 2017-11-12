using SistemaGerenciamentoEnergia.Controller;
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

namespace SistemaGerenciamentoEnergia.Vews
{
    public partial class CadastroEquipamentos : Form
    {
        public CadastroEquipamentos()
        {
            InitializeComponent();
            var login = new Form2();
            login.Close();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Criar um modelo de cadastro para adicionar ao controller 
            Modelo_Equipamento modeEquipamento = new Modelo_Equipamento();
            Controller_Equipamento controleEquipamento = new Controller_Equipamento();

            //Criar as variavei para receber os valores de cadastro 
            double TV = 0, Computador = 0, fogao = 0, lampada = 0, chuveiro = 0, microndas = 0,
                lavadoura = 0, som = 0, ferro_de_passar = 0, geladeira = 0;


            TV = double.Parse(textTV.Text); // referente a TV
            modeEquipamento.PotenciaTV = double.Parse(tvUpDown1.Text);
            modeEquipamento.PotenciaTV *= TV;
            controleEquipamento.Add_Equipamento(modeEquipamento);

            lavadoura = double.Parse(textMaqL.Text); // referente a Lavadoura
            modeEquipamento.PotenciaMaquinaLavar = double.Parse(maquLavaUpDown2.Text);
            modeEquipamento.PotenciaMaquinaLavar *= lavadoura;
            controleEquipamento.Add_Equipamento(modeEquipamento);

            microndas = double.Parse(textMicro.Text); // referente a Microondas
            modeEquipamento.PotenciaMicroondas = double.Parse(microodUpDown3.Text);
            modeEquipamento.PotenciaMicroondas *= microndas;
            controleEquipamento.Add_Equipamento(modeEquipamento);

            chuveiro = double.Parse(textChuveiro.Text); // referente a Chuveiro
            modeEquipamento.PotenciaChuveiro = double.Parse(chuveiroUpDown4.Text);
            modeEquipamento.PotenciaChuveiro *= chuveiro;
            controleEquipamento.Add_Equipamento(modeEquipamento);

            Computador = double.Parse(textComputado.Text); // referente ao Computador
            modeEquipamento.PotenciaComputador = double.Parse(computaUpDown7.Text);
            modeEquipamento.PotenciaComputador *= Computador;
            controleEquipamento.Add_Equipamento(modeEquipamento);

            ferro_de_passar = double.Parse(FerroUpDown5.Text);
            modeEquipamento.PotenciaFerroPassar = double.Parse(textFerro.Text); 
            modeEquipamento.PotenciaFerroPassar *= ferro_de_passar;
            controleEquipamento.Add_Equipamento(modeEquipamento);

            geladeira = double.Parse(geladeiraUpDown9.Text);
            modeEquipamento.PotenciaGeladeira = double.Parse(geladeiraUpDown9.Text);
            modeEquipamento.PotenciaGeladeira *= geladeira;
            controleEquipamento.Add_Equipamento(modeEquipamento);

            fogao = double.Parse(textFoEl.Text); // referente a Fogão
            modeEquipamento.PotenciaFogãoEletetrico = double.Parse(fogaEleUpDown6.Text);
            modeEquipamento.PotenciaFogãoEletetrico *= fogao;
            controleEquipamento.Add_Equipamento(modeEquipamento);

            lampada = double.Parse(textLampa.Text); // referente a Lampada
            modeEquipamento.PotenciaLampada = double.Parse(lampadaUpDown8.Text);
            modeEquipamento.PotenciaLampada *= lampada;
            controleEquipamento.Add_Equipamento(modeEquipamento);
                                
            som = double.Parse(textMicro.Text); // referente ao Som
            modeEquipamento.PotenciaSom = double.Parse(somedvdUpDown11.Text);
            modeEquipamento.PotenciaSom *= som;
            controleEquipamento.Add_Equipamento(modeEquipamento);

            
            var monitorar = new Monitoramento();
            monitorar.Show();
        }

        private void sairEquipamento_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastroEquipamentos_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void voltar_Click(object sender, EventArgs e)
        {
            var login = new Form1();
            login.Show();
            this.Close();           
        }
    }
}
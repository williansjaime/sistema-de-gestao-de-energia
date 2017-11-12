using SistemaGerenciamentoEnergia.Controller;
using SistemaGerenciamentoEnergia.Modelo.Entidade;
using SistemaGerenciamentoEnergia.Modelo.Repositorio;
using SistemaGerenciamentoEnergia.Modelo.Serviços;
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
    public partial class Monitoramento : Form
    {
        public Monitoramento()
        {
            InitializeComponent();
            
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void Monitoramento_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var VoltarCadEquipamento = new CadastroEquipamentos();
            VoltarCadEquipamento.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ///

        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            Controller_Equipamento controleEquipamento = new Controller_Equipamento();
            Calculo_Custo_Equipamento custoequipamento = new Calculo_Custo_Equipamento();
            Media_Horas_Equipamento mediaequpamento = new Media_Horas_Equipamento();
            Media_Horas_Equipamento mediahoraEquipamento = new Media_Horas_Equipamento();
            Modelo_Equipamento modeloequipamento = new Modelo_Equipamento();
            Calculos_Estatistico estatistica = new Calculos_Estatistico();

            double totalTV, totalchuveiro, totalLampada, totalmicro, totalMaqui, totalSom, totalferro, totalFogao, totalcomputado, totalgeladeira, totalVentilador;

            totalTV = custoequipamento.calculo_Potencia_Mensal(mediahoraEquipamento.MediahorasDiaTV, modeloequipamento.PotenciaTV, mediaequpamento.MediahorasDiaTV);

            totalchuveiro = custoequipamento.calculo_Potencia_Mensal(mediahoraEquipamento.MediahorasDiaChuveiro, modeloequipamento.PotenciaChuveiro, mediaequpamento.MediahorasDiaChuveiro);

            totalLampada = custoequipamento.calculo_Potencia_Mensal(mediahoraEquipamento.MediahorasDiaLampada, modeloequipamento.PotenciaLampada, mediaequpamento.MediahorasDiaLampada);

            totalmicro = custoequipamento.calculo_Potencia_Mensal(mediahoraEquipamento.MediahorasDiaMicroondas, modeloequipamento.PotenciaMicroondas, mediaequpamento.MediahorasDiaMicroondas);

            totalMaqui = custoequipamento.calculo_Potencia_Mensal(mediahoraEquipamento.MediahorasDiaMaquinaLavar, modeloequipamento.PotenciaMaquinaLavar, mediaequpamento.MediahorasDiaMaquinaLavar);

            totalferro = custoequipamento.calculo_Potencia_Mensal(mediahoraEquipamento.MediahorasDiaFerroPassar, modeloequipamento.PotenciaFerroPassar, mediaequpamento.MediahorasDiaFerroPassar);

            totalFogao = custoequipamento.calculo_Potencia_Mensal(mediahoraEquipamento.MediahorasDiaFogãoEletetrico, modeloequipamento.PotenciaFogãoEletetrico, mediaequpamento.MediahorasDiaFogãoEletetrico);

            totalcomputado = custoequipamento.calculo_Potencia_Mensal(mediahoraEquipamento.MediahorasDiaComputador, modeloequipamento.PotenciaComputador, mediaequpamento.MediahorasDiaComputador);

            totalgeladeira = custoequipamento.calculo_Potencia_Mensal(mediahoraEquipamento.MediahorasDiaGeladeira, modeloequipamento.PotenciaGeladeira, mediaequpamento.MediahorasDiaGeladeira);

            totalVentilador = custoequipamento.calculo_Potencia_Mensal(mediahoraEquipamento.MediahorasDiaVentilador, modeloequipamento.PotenciaVentilador, mediaequpamento.MediahorasDiaVentilador);

            totalSom = custoequipamento.calculo_Potencia_Mensal(mediahoraEquipamento.MediahorasDiaSom, modeloequipamento.PotenciaSom, mediaequpamento.MediahorasDiaSom);


            double total = totalTV + totalchuveiro + totalLampada + totalmicro + totalMaqui + totalSom + totalferro + totalFogao + totalcomputado + totalgeladeira + totalVentilador;

            //Mostrar o calculo total no gauge
            string receber = total.ToString();
            double totall = total / 1000;
            aGauge2.Text = totall.ToString();
            aGauge1.Text = receber.ToString();
        }
    }
} 
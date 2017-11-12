
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoEnergia.Modelo.Serviços
{
    public class Calculos
    {
        //Metodo para converte o valor em porcentagem
        public double Porcentage(double valor)
        {
            return valor = valor / 100;
        }


        //Metodo para calcular a media 
        public double Media(double valorTotal, int Quantidade)
        {
            double media;
            return media = valorTotal / Quantidade;
        }


        //Calcular a probabilidade do usuario atigir a meta
        public double Possibilidade_Meta(double mediaReais, double mediaWattEquipamento)
        {
            double total;
            return  total = mediaReais / mediaWattEquipamento;
        }
    }
}

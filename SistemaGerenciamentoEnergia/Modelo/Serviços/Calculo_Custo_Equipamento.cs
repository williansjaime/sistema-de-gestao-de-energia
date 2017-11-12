using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaGerenciamentoEnergia.Modelo.Serviços
{
    public class Calculo_Custo_Equipamento
    {
        public double calculo_Potencia_Mensal(double horas, double equipamento, double dias)
        {
            double  Resultado;
            //Dias = 30;
            Resultado = (dias * equipamento * horas) / 1000;
            return Resultado;

         }


         public double calculo_resultado_total(double potencia_mensal, double taxa_companhia_energia)
          {

            double Resultado;
            Resultado = potencia_mensal * taxa_companhia_energia;
            return Resultado;           
           
           }


    }
}

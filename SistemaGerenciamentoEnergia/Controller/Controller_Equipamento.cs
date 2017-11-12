using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGerenciamentoEnergia.Modelo.Entidade;

namespace SistemaGerenciamentoEnergia.Controller
{
    public class Controller_Equipamento
    {
        List<Modelo_Equipamento> _dbEquipamento = new List<Modelo_Equipamento>();
        
        public void Add_Equipamento(Modelo_Equipamento equipamento)
        {
            _dbEquipamento.Add(equipamento);
        }
          
        //metodo para fazer uma pesquisa de equipamento
        public double PesquisarEquipamento(Modelo_Equipamento model)
        {
            _dbEquipamento.ToList();
                
            return ; 
         }

        
        //Metodo para remover filme
        public List<Modelo_Equipamento> RemoverFilme(Modelo_Equipamento modeloequi)
        {
            foreach (Modelo_Equipamento equipamento in _dbEquipamento)
            {
                _dbEquipamento.Remove(modeloequi);
            }
            return _dbEquipamento.ToList();
        }

        public List<Modelo_Equipamento> ListarTodos()
        {
            return _dbEquipamento.ToList();
        }

        /*public Modelo_Equipamento PotenciaTotal(Modelo_Equipamento  model)
        {

            double potencia;
            foreach(Modelo_Equipamento pesquisa in _dbEquipamento)
            {
                _dbEquipamento.All(model);
            }
            
                 
            

            /*Modelo_Equipamento calculo = new Modelo_Equipamento();
            potencia = calculo.PotenciaChuveiro + calculo.PotenciaComputador + calculo.PotenciaFerroPassar
                + calculo.PotenciaFogãoEletetrico + calculo.PotenciaGeladeira + calculo.PotenciaLampada + calculo.PotenciaMaquinaLavar
                + calculo.PotenciaSom + calculo.PotenciaTV + calculo.PotenciaVentilador;
                
            return potencia = 0;

        }*/
    }
}

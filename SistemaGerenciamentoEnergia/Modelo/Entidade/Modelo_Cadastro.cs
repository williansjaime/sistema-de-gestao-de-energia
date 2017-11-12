using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoEnergia.Modelo.Entidade
{
    //Metodo para definir o modelo de negocio 
    public class Modelo_Cadastro
    {
        public double Id { get; set; }
        public string Nome{get; set; }
        public string Email { get; set; }
        public string Rua { get; set; }
        public double NUmero { get; set; }
        public double Senha { get; set; }
        public double CEP { get; set; }
    }
}

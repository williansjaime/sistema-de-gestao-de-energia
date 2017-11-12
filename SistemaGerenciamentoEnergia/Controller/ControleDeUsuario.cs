using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGerenciamentoEnergia.Modelo.Entidade;

namespace SistemaGerenciamentoEnergia.Controller
{
   public  class ControleDeUsuario
    {
        private static List<Modelo_Cadastro> _db = new List<Modelo_Cadastro>();
        Modelo_Cadastro model = new Modelo_Cadastro();

        public void AddUsuario(Modelo_Cadastro usuario)
        {
            _db.Add(usuario);
                           
        }
        
                
        ///Verificar senha e usuario cadastrado
        public  bool Verificar_Usuario( string usuario, double  senha)
        {
            foreach(var verifica in _db)
            {
                if (verifica.Nome == usuario && verifica.Senha == senha)
                {
                    return true;
                }
            }
            return false;

         }

      }
}

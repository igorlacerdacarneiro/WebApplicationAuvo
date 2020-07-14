using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAuvo.Dados;

namespace WebApplicationAuvo.Models
{
    public class TarefaDAL : TarefaInterface
    {
        private List<TarefaModel> tarefas = new TarefasDados().getTarefas();


        public void DeleteTarefa(int id)
        {
            var item = this.tarefas.Where(t => t.Id == id).First();
            this.tarefas.Remove(item);
        }

        public List<TarefaModel> GetAllTarefas()
        {
            return this.tarefas;
        }
    }
}

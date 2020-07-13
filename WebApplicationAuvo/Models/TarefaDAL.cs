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


        public void DeleteTarefa(TarefaModel tarefa)
        {
            this.tarefas.Remove(tarefa);
        }

        public List<TarefaModel> GetAllTarefas()
        {
            return this.tarefas;
        }
    }
}

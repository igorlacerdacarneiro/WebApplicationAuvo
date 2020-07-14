using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAuvo.Models
{
    public interface TarefaInterface
    {
        List<TarefaModel> GetAllTarefas();
        void DeleteTarefa(int id);
    }
}

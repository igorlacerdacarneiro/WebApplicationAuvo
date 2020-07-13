using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAuvo.Models
{
    public class HomeModel
    {
        public List<TarefaModel> Tarefas { get; set; }
        public UsuarioModel Usuario { get; set; }
        public List<ContatoModel> Contatos { get; set; }
    }
}

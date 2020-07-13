using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAuvo.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string TipoTarefa { get; set; }
        public string DataExecucao { get; set; }
        public string Colaborador { get; set; }
        public bool Finalizada { get; set; }
        public int Tipo { get; set; }
    }
}


using System.Collections.Generic;
using WebApplicationAuvo.Models;
using System.Linq;

namespace WebApplicationAuvo.Dados
{
    public class TarefasDados
    {
        public List<TarefaModel> getTarefas()
        {
            return new List<TarefaModel> {
                new TarefaModel { Id = 1, Codigo = "12345", TipoTarefa = "Manutenção Preventiva",  DataExecucao = "Hoje às 08:00h",  Colaborador = "Eduardo", Finalizada = false, Tipo = 2 },
                new TarefaModel { Id = 2, Codigo = "23456", TipoTarefa = "Manutenção Corretiva",  DataExecucao = "18/07/2020 às 10:20h",  Colaborador = "", Finalizada = false, Tipo = 3 },
                new TarefaModel { Id = 3, Codigo = "34567", TipoTarefa = "Manutenção Corretiva",  DataExecucao = "",  Colaborador = "Felipe Silva",  Finalizada = false, Tipo = 3 },
                new TarefaModel { Id = 4, Codigo = "45678", TipoTarefa = "Manutenção Corretiva",  DataExecucao = "16/07/2020 às 10:20h",  Colaborador = "Felipe Silva",  Finalizada = false, Tipo = 1 },
                new TarefaModel { Id = 5, Codigo = "67891", TipoTarefa = "Manutenção Preventiva",  DataExecucao = "Hoje às 08:00h",  Colaborador = "Eduardo",  Finalizada = true, Tipo = 2 },
                new TarefaModel { Id = 6, Codigo = "78912", TipoTarefa = "Manutenção Corretiva",  DataExecucao = "16/06/2020 às 10:20h",  Colaborador = "Felipe Silva", Finalizada = true, Tipo = 3 },
                new TarefaModel { Id = 7, Codigo = "89123", TipoTarefa = "Manutenção Corretiva",  DataExecucao = "16/06/2020 às 10:20h",  Colaborador = "Felipe Silva", Finalizada = true, Tipo = 3 },
                new TarefaModel { Id = 8, Codigo = "91234", TipoTarefa = "Manutenção Corretiva",  DataExecucao = "16/06/2020 às 10:20h",  Colaborador = "Felipe Silva", Finalizada = true, Tipo = 1 },
                new TarefaModel { Id = 9, Codigo = "98765", TipoTarefa = "Manutenção Corretiva",  DataExecucao = "16/06/2020 às 10:20h",  Colaborador = "Felipe Silva", Finalizada = true, Tipo = 3 },
                new TarefaModel { Id = 10, Codigo = "87654", TipoTarefa = "Manutenção Corretiva",  DataExecucao = "16/06/2020 às 10:20h",  Colaborador = "Felipe Silva", Finalizada = true, Tipo = 3 },
                new TarefaModel { Id = 11, Codigo = "76543", TipoTarefa = "Manutenção Corretiva",  DataExecucao = "16/06/2020 às 10:20h",  Colaborador = "Felipe Silva", Finalizada = true, Tipo = 3 },
             };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAuvo.Models;

namespace WebApplicationAuvo.Dados
{
    public class ContatosDados
    {
        public List<ContatoModel> getContatos()
        {
            return new List<ContatoModel> {
                new ContatoModel { Id = 1, Nome = "Eduardo Garcia", Cargo = "Cargo 1", Email = "email1@gmail.com", Telefone = "(62) 9999-9999" },
                new ContatoModel { Id = 2, Nome = "Fernando Correa", Cargo = "Cargo 2", Email = "email1@gmail.com", Telefone = "(62) 9999-9999" },
                new ContatoModel { Id = 3, Nome = "Eduardo Porto", Cargo = "Cargo 2", Email = "email1@gmail.com", Telefone = "(62) 9999-9999" },
                new ContatoModel { Id = 4, Nome = "Elisa Monteiro", Cargo = "Cargo 3", Email = "email1@gmail.com", Telefone = "(62) 9999-9999" },
                new ContatoModel { Id = 5, Nome = "Kaique Marquês", Cargo = "Cargo 1", Email = "email1@gmail.com", Telefone = "(62) 9999-9999" },
                new ContatoModel { Id = 6, Nome = "Beatriz Silveira", Cargo = "Cargo 1", Email = "email1@gmail.com", Telefone = "(62) 9999-9999" },
                new ContatoModel { Id = 7, Nome = "Isabela Conrradine", Cargo = "Cargo 2", Email = "email1@gmail.com", Telefone = "(62) 9999-9999" },
                new ContatoModel { Id = 8, Nome = "Fernanda Dias", Cargo = "Cargo 3", Email = "email1@gmail.com", Telefone = "(62) 9999-9999" },
                new ContatoModel { Id = 9, Nome = "Marta Lucia do Carmo", Cargo = "Cargo 3", Email = "email1@gmail.com", Telefone = "(62) 9999-9999" },
                new ContatoModel { Id = 9, Nome = "Vagner Xavier", Cargo = "Cargo 1", Email = "email1@gmail.com", Telefone = "(62) 9999-9999" },
             };
        }
    }
}

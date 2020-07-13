using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAuvo.Dados;

namespace WebApplicationAuvo.Models
{
    public class ContatoDAL : ContatoInterface
    {
        private List<ContatoModel> contatos = new ContatosDados().getContatos();

        public List<ContatoModel> GetAllContatos()
        {
            return this.contatos;
        }

        public ContatoModel GetContato(string id)
        {
            throw new NotImplementedException();
        }

        public void UpdateContato(ContatoModel contato)
        {
            var index = this.contatos.FindIndex(c => c.Id == contato.Id);
            this.contatos[index] = contato;
        }
    }
}
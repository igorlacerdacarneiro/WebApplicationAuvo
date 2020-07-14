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
        private List<ContatoModel> contatosAux = new ContatosDados().getContatos();

        public void RebaseContatos()
        {
            this.contatos = this.contatosAux;
        }

        public List<ContatoModel> GetAllContatos()
        {
            return this.contatos;
        }

        public void GetContato(string id)
        {
            this.contatos = this.contatos.Where(c => c.Nome.Contains(id)).ToList();
        }

        public void UpdateContato(ContatoModel contato)
        {
            var index = this.contatos.FindIndex(c => c.Id == contato.Id);
            this.contatos[index] = contato;
            this.contatosAux[index] = contato;
        }
    }
}
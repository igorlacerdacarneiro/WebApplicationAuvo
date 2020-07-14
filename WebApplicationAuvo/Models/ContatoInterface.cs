using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAuvo.Models
{
    public interface ContatoInterface
    {
        List<ContatoModel> GetAllContatos();
        void RebaseContatos();
        void UpdateContato(ContatoModel contato);
        void GetContato(string id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAuvo.Models
{
    public interface ContatoInterface
    {
        List<ContatoModel> GetAllContatos();
        void UpdateContato(ContatoModel contato);
        ContatoModel GetContato(string id);
    }
}

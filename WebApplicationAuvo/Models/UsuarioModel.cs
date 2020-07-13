using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAuvo.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Imagem { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Localizacao { get; set; }
        public string Segmento { get; set; }
        public string CnpjCpf { get; set; }
        public string CodigoSistema { get; set; }
        public string CodigoExterno { get; set; }
    }
}

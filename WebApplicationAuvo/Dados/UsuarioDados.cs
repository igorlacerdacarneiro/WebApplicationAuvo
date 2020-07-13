using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAuvo.Models;

namespace WebApplicationAuvo.Dados
{
    public class UsuarioDados
    {
        private UsuarioModel usuario;

        public UsuarioDados()
        {
            this.usuario = new UsuarioModel {
                Id = 1,
                Imagem = "https://static.wixstatic.com/media/690286_f7f6329c4eef4150889cbeff4f1c881a~mv2.png/v1/fill/w_115,h_115,al_c,q_95/Prancheta%204.webp",
                Nome = "Sigma Sistemas",
                Telefone = "(62) 3254-4752",
                Email = "sigmasistemas@gmail.com",
                Endereco = "Rua Teste, 123, Cidade Jardim, CEP: 74747-747, Goiânia, Goiás",
                Localizacao = "https://maps.google.com/?q=40.5509,-105.0668&output=svembed",
                Segmento = "Informatica",
                CnpjCpf = "123.123.123-12",
                CodigoSistema = "192738",
                CodigoExterno = "Nao informado"
            };
        }

        public UsuarioModel getUsuario()
        {
            return this.usuario;

        }
    }
}

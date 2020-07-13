using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationAuvo.Dados;
using WebApplicationAuvo.Models;

namespace WebApplicationAuvo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ContatoInterface contatoInterface;
        private readonly TarefaInterface tarefaInterface;
        public HomeController(ContatoInterface contato, TarefaInterface tarefa)
        {
            contatoInterface = contato;
            tarefaInterface = tarefa;
        }

        public IActionResult Index()
        {
            return View(new HomeModel
            {
                Tarefas = tarefaInterface.GetAllTarefas(),
                Usuario = new UsuarioDados().getUsuario(),
                Contatos = contatoInterface.GetAllContatos()
            });
        }

        [HttpGet]
        public IActionResult BuscarContato(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ContatoModel contato = contatoInterface.GetContato(id);

            if (contato == null)
            {
                return NotFound();
            }
            return View(contato);
        }


        [HttpPost]
        public IActionResult EditarContato(ContatoModel contato)
        {
            contatoInterface.UpdateContato(contato);
            return RedirectToAction("Index");
        }

        public IActionResult RemoverTarefa(TarefaModel tarefa)
        {
            tarefaInterface.DeleteTarefa(tarefa);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

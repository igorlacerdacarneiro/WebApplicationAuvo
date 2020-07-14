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

        [HttpPost]
        public IActionResult Index(string searchString, bool notUsed)
        {
            contatoInterface.GetContato(searchString);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult RebaseContatos()
        {
            contatoInterface.RebaseContatos();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditarContato(ContatoModel contato)
        {
            contatoInterface.UpdateContato(contato);
            return RedirectToAction("Index");
        }

        public IActionResult RemoverTarefa(int id)
        {
            tarefaInterface.DeleteTarefa(id);
            return RedirectToAction("Index");
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

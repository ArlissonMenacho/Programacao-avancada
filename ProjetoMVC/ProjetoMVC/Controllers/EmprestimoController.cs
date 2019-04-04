using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Models;

namespace ProjetoMVC.Controllers
{
    public class EmprestimoController : Controller
    {
        public IActionResult ListagemEmprestimo()
        {
            IList<Emprestimo> lista = new Emprestimo().BuscarTodos();
            return View(lista);
        }
        [HttpGet]
        public IActionResult Novo()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Novo(Emprestimo E)

        {
            if (ModelState.IsValid)
            {
                E.Inserir();
                TempData["Mensagem"] = "Gravado com Sucesso";
                return RedirectToAction("ListagemEmprestimo");
            }
            ViewBag.MensagemErro = "Preencha os campos obrigatórios";
            return View(E);

        }
        public IActionResult Excluir(int id)
        {
            Emprestimo E = new Emprestimo().BuscarEmprestimoPorID(id);
            return View(E);
        }
    }
}
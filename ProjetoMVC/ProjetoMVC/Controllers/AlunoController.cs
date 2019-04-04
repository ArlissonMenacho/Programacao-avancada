using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Models;


namespace ProjetoMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult ListagemAluno()
        {
            IList<Aluno> lista = new Aluno().BuscarTodos();
            return View(lista);
        }
        [HttpGet]
        public IActionResult Novo()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Novo(Aluno A)

        {
            if (ModelState.IsValid)
            {
                A.Inserir();
                TempData["Mensagem"] = "Gravado com Sucesso";
                return RedirectToAction("ListagemAluno");
            }
            ViewBag.MensagemErro = "Preencha os campos obrigatórios";
            return View(A);

        }
        public IActionResult Excluir(int id)
        {
            Aluno A = new Aluno().BuscarAlunoPorID(id);
            return View(A);
        }
    }
}
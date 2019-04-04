using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Models;


namespace ProjetoMVC.Controllers
{
    public class FuncionarioController : Controller
    {
        public IActionResult ListagemFuncionario()
        {
            IList<Funcionario> lista = new Funcionario().BuscarTodos();
            return View(lista);
        }
        [HttpGet]
        public IActionResult Novo()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Novo(Funcionario F)

        {
            if (ModelState.IsValid)
            {
                F.Inserir();
                TempData["Mensagem"] = "Gravado com Sucesso";
                return RedirectToAction("Listagem");
            }
            ViewBag.MensagemErro = "Preencha os campos obrigatórios";
            return View(F);

        }
        public IActionResult Excluir(int id)
        {
            Funcionario F = new Funcionario().BuscarFuncionarioPorID(id);
            return View(F);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Models;

namespace ProjetoMVC.Controllers
{
    public class LivroController : Controller
    {
        public IActionResult Listagem()
        {
            IList<Livro> lista = new Livro().BuscarTodos();
            return View(lista);
        }
        [HttpGet]
        public IActionResult Novo()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Novo(Livro L)

        {
            if (ModelState.IsValid)
            {
                L.Inserir();
                TempData["Mensagem"] = "Gravado com Sucesso";
                return RedirectToAction("Listagem");
            }
            ViewBag.MensagemErro = "Preencha os campos obrigatórios";
            return View(L);
            
        }
        public IActionResult Excluir(int id)
        {
            Livro l = new Livro().BuscarLivroPorID(id);
            return View(l);
        }
    }
}
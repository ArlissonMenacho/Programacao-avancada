using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoMVC.Models;

namespace ProjetoMVC.Repositorio
{
    public class Banco
    {
        public static IList<Livro> Livros = new List<Livro>();
        public static IList<Emprestimo> Emprestimos = new List<Emprestimo>();
        public static IList<Aluno> Alunos = new List<Aluno>();
        public static IList<Funcionario> Funcionarios = new List<Funcionario>();

    }
}

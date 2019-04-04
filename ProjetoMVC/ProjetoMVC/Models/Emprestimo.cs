using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ProjetoMVC.Repositorio;

namespace ProjetoMVC.Models
{
    public class Emprestimo
    {
        private DateTime dtEmprestimo;
        private int id;
        private double valorTotal;

        [Display(Name = "Data do Emprestimo: ")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public DateTime DtEmprestimo { get => dtEmprestimo; set => dtEmprestimo = value; }
        [ScaffoldColumn(false)]
        public int Id { get => id; set => id = value; }
        [Display(Name = "Valor Total: ")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }

        public Aluno ObjAluno
        {
            get; set;
        }
        public Funcionario ObjFuncionario
        {
            get; set;
        }
        public IList<ItensEmprestimo> ObjItensEmprestimo
        {
            get; set;
        }
        public Emprestimo BuscarEmprestimoPorID(int id)
        {
            return Banco.Emprestimos.First(x => x.id == id);
        }

        public void Delete(Emprestimo id)
        {
            return;
        }

        public Emprestimo Update(Emprestimo emprestimo)
        {
            return new Emprestimo();
        }

        public void Inserir()
        {
            if (this.Id == 0)
            {
                Random r = new Random();
                this.id = r.Next(1, 9999);
                Banco.Emprestimos.Add(this);
            }
        }
        public IList<Emprestimo> BuscarTodos()
        {
            return Banco.Emprestimos;
        }
    }
}

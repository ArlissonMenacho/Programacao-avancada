using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

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
    }
}

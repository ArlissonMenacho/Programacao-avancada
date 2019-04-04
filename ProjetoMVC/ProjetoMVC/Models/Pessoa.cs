using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjetoMVC.Models
{
    public class Pessoa
    {
        string cpf, nome;
        int id;

        public string Cpf { get => cpf; set => cpf = value; }
        [Display(Name = "CPF: ")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(11, MinimumLength = 11)]
        public string Nome { get => nome; set => nome = value; }
        [Display(Name = "Nome: ")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(15, MinimumLength = 5)]

        public Aluno ObjAluno
        {
            get; set;
        }
        public Funcionario ObjFuncionario
        {
            get; set;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ProjetoMVC.Repositorio;

namespace ProjetoMVC.Models
{
    public class Funcionario : Pessoa
    {
        private string cargo, matricula, pis;
        private DateTime dataAdmissao;
        private double salario;

        [Display(Name = "Cargo: ")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Cargo { get => cargo; set => cargo = value; }
        [Display(Name = "Matricula: ")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Matricula { get => matricula; set => matricula = value; }
        [Display(Name = "Pis: ")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Pis { get => pis; set => pis = value; }
        [Display(Name = "Data de Admissão: ")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public DateTime DataAdmissao { get => dataAdmissao; set => dataAdmissao = value; }
        [Display(Name = "Salário: ")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public double Salario { get => salario; set => salario = value; }

        public Funcionario BuscarFuncionarioPorID(int id)
        {
            return Banco.Funcionarios.First(x => x.Id == id);
        }

        public void Delete(Funcionario id)
        {
            return;
        }

        public Funcionario Update(Funcionario funcionario)
        {
            return new Funcionario();
        }

        public void Inserir()
        {
            if (this.Id == 0)
            {
                Random r = new Random();
                this.Id = r.Next(1, 9999);
                Banco.Funcionarios.Add(this);
            }
        }
        public IList<Funcionario> BuscarTodos()
        {
            return Banco.Funcionarios;
        }
    }
}

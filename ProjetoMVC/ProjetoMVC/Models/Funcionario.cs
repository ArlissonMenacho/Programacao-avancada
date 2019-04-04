using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjetoMVC.Models
{
    public class Funcionario
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
    }
}

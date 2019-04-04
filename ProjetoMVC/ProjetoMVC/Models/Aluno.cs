using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace ProjetoMVC.Models
{
    public class Aluno
    {
        private string cidade, numero, orgaoExpedidor, rg, rua, sexo, uf;
        private DateTime dataNascimento;
        //[Display(Name ="Codigo",Description ="Informe um número inteiro de 1 a 99999")]
        //public int id { get; set; }

        [Display(Name = "Informe o Nome da Sua cidade :")]
        [Required(ErrorMessage = "O nome da sua cidade é obrigatório")]
        public string Cidade { get => cidade; set => cidade = value; }

        [Range(1, 99999)]
        [Required(ErrorMessage = "O número deve ser entre 1 a 99999")]

        public string Numero { get => numero; set => numero = value; }
        [Display(Name = "Orgão Expedidor do Documento: ")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string OrgaoExpedidor { get => orgaoExpedidor; set => orgaoExpedidor = value; }
        [Display(Name = "RG:")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Rg { get => rg; set => rg = value; }
        [Display(Name = "Rua:")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Rua { get => rua; set => rua = value; }
        [Display(Name = "Sexo: ")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Sexo { get => sexo; set => sexo = value; }
        [Display(Name = "Unidade da Federação :")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Uf { get => uf; set => uf = value; }
        [Display(Name = "Data de Nascimento:")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }

    }
}

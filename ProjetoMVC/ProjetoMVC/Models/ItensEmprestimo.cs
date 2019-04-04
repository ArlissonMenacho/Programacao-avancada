using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjetoMVC.Models
{
    public class ItensEmprestimo
    {
        private DateTime dtDevolucao;
        private int id;

        [Display(Name = "Data de Devolução: ")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public DateTime DtDevolucao { get => dtDevolucao; set => dtDevolucao = value; }
        [ScaffoldColumn(false)]
        public int Id { get => id; set => id = value; }
    }
}

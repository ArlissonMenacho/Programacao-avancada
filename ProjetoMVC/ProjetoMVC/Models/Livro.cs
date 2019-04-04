using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ProjetoMVC.Repositorio;

namespace ProjetoMVC.Models
{
    public class Livro
    {
        private string autor, editora, titulo;
        private int id;
        private DateTime dtPublicacao;

        [Display(Name = "Autor: ")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Autor { get => autor; set => autor = value; }
        [Display(Name = "Editora: ")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Editora { get => editora; set => editora = value; }
        [Display(Name = "Título: ")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Titulo { get => titulo; set => titulo = value; }
        [ScaffoldColumn(false)]
        public int Id { get => id; set => id = value; }
        [Display(Name = "Data de Publicação: ")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public DateTime DtPulicacao { get => dtPublicacao; set => dtPublicacao = value; }

        public Emprestimo ObjEmprestimo
        {
            get; set;
        }
        public Livro Objlivro
        {
            get; set;
        }

        public Livro BuscarLivroPorID(int id)
        {
            return Banco.Livros.First(x => x.id == id);
        }

        public void Delete(Livro id)
        {
            return;
        }

        public Livro Update(Livro livro)
        {
            return livro;
        }

        public void Inserir()
        {
            if (this.Id == 0)
            {
                Random r = new Random();
                this.id = r.Next(1, 9999);
                 Banco.Livros.Add(this);
            }            
        }
        public IList<Livro> BuscarTodos()
        {
            return Banco.Livros;
        }
    }
}

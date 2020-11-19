using System.Collections.Generic;
using ProjBiblioteca.Domain.Entities;

namespace ProjBiblioteca.Application.ViewModels
{
    public class LivroListViewModel
    {
        public IEnumerable<Livro> Livros { get; set; }
    }
}
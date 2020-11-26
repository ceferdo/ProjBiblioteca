using System.Collections.Generic;
using ProjBiblioteca.Domain.Entities;

namespace ProjBiblioteca.Application.ViewModels
{
    public class LivroListViewModel
    {
        public IEnumerable<LivroViewModel> Livros { get; set; }
    }
}
using System.Collections.Generic;
using ProjBiblioteca.Domain.Entities;

namespace ProjBiblioteca.Application.ViewModels
{
    public class AutorListViewModel
    {
        public IEnumerable<AutorViewModel> Autores { get; set; }
    }
}
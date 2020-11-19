using System.Collections.Generic;
using ProjBiblioteca.Domain.Entities;

namespace ProjBiblioteca.Application.ViewModels
{
    public class AutorListViewModel
    {
        public IEnumerable<Autor> Autores { get; set; }
    }
}
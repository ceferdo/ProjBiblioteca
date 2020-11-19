using System.Collections.Generic;
using ProjBiblioteca.Domain.Entities;

namespace ProjBiblioteca.Application.ViewModels
{
    public class UsuarioListViewModel
    {
        public IEnumerable<Usuario> Usuarios { get; set; }
    }
}
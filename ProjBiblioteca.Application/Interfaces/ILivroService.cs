using ProjBiblioteca.Application.ViewModels;

namespace ProjBiblioteca.Application.Interfaces
{
    public interface ILivroService
    {
         LivroListViewModel Get();
    }
}
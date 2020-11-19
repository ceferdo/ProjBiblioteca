using ProjBiblioteca.Application.InputModels;
using ProjBiblioteca.Application.ViewModels;

namespace ProjBiblioteca.Application.Interfaces
{
    public interface IAutorService
    {
        AutorListViewModel Get();
        AutorViewModel Get(int Id);
        AutorViewModel Post(AutorInputModel autor);
        AutorViewModel Put(int id, AutorInputModel autor);
        AutorViewModel Delete(int id);
    }
}
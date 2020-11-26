using ProjBiblioteca.Application.InputModels;
using ProjBiblioteca.Application.ViewModels;

namespace ProjBiblioteca.Application.Interfaces
{
    public interface ILivroService
    {
        LivroListViewModel Get();

        LivroViewModel Get(int id);

        LivroViewModel Post(LivroInputModel livro);

        LivroViewModel Put(int id, LivroInputModel livro);

        LivroViewModel Delete(int id);
    }
}
using ProjBiblioteca.Application.Interfaces;
using ProjBiblioteca.Application.ViewModels;
using ProjBiblioteca.Domain.Interfaces;

namespace ProjBiblioteca.Application.Services
{
    public class LivroService : ILivroService
    {
        private ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository)
        {
            this._livroRepository = livroRepository;
        }

        public LivroListViewModel Get()
        {
            return new LivroListViewModel()
            {
                Livros = this._livroRepository.Get()
            };
        }
    }
}
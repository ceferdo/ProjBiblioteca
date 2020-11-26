using System.Collections.Generic;
using AutoMapper;
using ProjBiblioteca.Application.InputModels;
using ProjBiblioteca.Application.Interfaces;
using ProjBiblioteca.Application.ViewModels;
using ProjBiblioteca.Domain.Entities;
using ProjBiblioteca.Domain.Interfaces;

namespace ProjBiblioteca.Application.Services
{
    public class LivroService : ILivroService
    {
        public IUnitOfWork _uow;
        public IMapper _mapper;

        public LivroService(IUnitOfWork uow, IMapper mapper)
        {
            this._uow = uow;
            this._mapper = mapper;
        }

        public LivroListViewModel Get()
        {
            var livros = this._uow.LivroRepository.Get();

            return new LivroListViewModel()
            {
                Livros = _mapper.Map<IEnumerable<LivroViewModel>>(livros)
            };
        }

        public LivroViewModel Get(int id)
        {
            var livro = this._uow.LivroRepository.GetById(a => a.LivroID == id);
            return _mapper.Map<LivroViewModel>(livro);
        }

        public LivroViewModel Post(LivroInputModel livroInputModel)
        {
            var livro = _mapper.Map<Livro>(livroInputModel);

            _uow.LivroRepository.Add(livro);
            _uow.Commit();

            return _mapper.Map<LivroViewModel>(livro);
        }

        public LivroViewModel Put(int id, LivroInputModel livroInputModel)
        {
            var livro = _mapper.Map<Livro>(livroInputModel);

            _uow.LivroRepository.Update(livro);
            _uow.Commit();

            return _mapper.Map<LivroViewModel>(livro);
        }

        public LivroViewModel Delete(int id)
        {
            var livro = this._uow.LivroRepository.GetById(a => a.LivroID == id);

            if (livro == null)
            {
                return null;
            }

            _uow.LivroRepository.Delete(livro);
            _uow.Commit();

            return _mapper.Map<LivroViewModel>(livro);
        }
    }
}
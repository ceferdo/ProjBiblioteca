using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProjBiblioteca.Domain.Entities;
using ProjBiblioteca.Domain.Interfaces;
using ProjBiblioteca.Infrastructure.Data.Context;

namespace ProjBiblioteca.Infrastructure.Data.Repositories
{
    public class LivroRepository : Repository<Livro>, ILivroRepository
    {
        public LivroRepository(BibliotecaDBContext context) : base(context)
        {
        }

        public IEnumerable<Livro> GetLivrosPorAutor(int autorID)
        {
            return _context.Livro
                .Include(l => l.LivAutor)
                .Where(l => l.LivAutor.Any(la => la.AutorID == autorID));
        }

        public IEnumerable<Livro> GetLivrosContemTitulo(string titulo)
        {
            return _context.Livro.Where(l => l.Titulo.Contains(titulo));
        }

        public IEnumerable<Livro> GetLivrosSemEstoque()
        {
            return _context.Livro.Where(l => l.Quantidade == 0);
        }
    }
}
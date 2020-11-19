using ProjBiblioteca.Domain.Interfaces;
using ProjBiblioteca.Infrastructure.Data.Context;

namespace ProjBiblioteca.Infrastructure.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private AutorRepository _autorRepo;
        private BibliotecaDBContext _context;
        public IAutorRepository AutorRepository
        {
            get{
                return _autorRepo = _autorRepo ?? 
                    new AutorRepository(_context);
            }
        }
        
        public UnitOfWork(BibliotecaDBContext contexto)
        {
            _context = contexto;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
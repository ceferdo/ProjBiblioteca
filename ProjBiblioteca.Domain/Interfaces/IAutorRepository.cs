using System.Collections.Generic;
using ProjBiblioteca.Domain.Entities;

namespace ProjBiblioteca.Domain.Interfaces
{
    public interface IAutorRepository : IRepository<Autor>
    {
        IEnumerable<Autor> GetAutoresContemNome(string nome);
    }
}
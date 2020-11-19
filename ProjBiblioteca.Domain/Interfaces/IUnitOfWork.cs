namespace ProjBiblioteca.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IAutorRepository AutorRepository{ get; }
        void Commit();
    }
}
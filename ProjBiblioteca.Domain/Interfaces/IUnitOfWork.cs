namespace ProjBiblioteca.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IAutorRepository AutorRepository{ get; }
        ILivroRepository LivroRepository { get; }

        void Commit();
    }
}
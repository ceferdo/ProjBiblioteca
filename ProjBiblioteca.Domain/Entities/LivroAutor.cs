namespace ProjBiblioteca.Domain.Entities
{
    public class LivroAutor
    {
        public int AutorID { get; set; }
        public Autor Autores { get; set; }

        public int LivroID { get; set; }
        public Livro Livros { get; set; }
    }
}
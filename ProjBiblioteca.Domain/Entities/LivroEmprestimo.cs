namespace ProjBiblioteca.Domain.Entities
{
    public class LivroEmprestimo
    {
        public int LivroID { get; set; }
        public Livro Livros { get; set; }

        public int EmprestimoID { get; set; }
        public Emprestimo Emprestimos { get; set; }
    }
}
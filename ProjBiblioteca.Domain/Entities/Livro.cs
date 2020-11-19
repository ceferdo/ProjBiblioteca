using System.Collections.Generic;

namespace ProjBiblioteca.Domain.Entities
{
    public class Livro
    {
        public int LivroID { get; set; }
        public string Titulo { get; set; }
        public int? Quantidade { get; set; }
        public int? Nota {get; set; }
        public string Foto { get; set; }
        public ICollection<LivroAutor> LivAutor { get; set; }
        public ICollection<LivroEmprestimo> LivEmprestimo {get; set; }
    }
}
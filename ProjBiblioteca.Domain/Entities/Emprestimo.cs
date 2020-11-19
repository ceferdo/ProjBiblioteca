using System;
using System.Collections.Generic;

namespace ProjBiblioteca.Domain.Entities
{
    public class Emprestimo
    {
        public int EmprestimoID { get; set; }
        public int? UsuarioID { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public DateTime? DataDevolucao { get; set; }
        
        public ICollection<LivroEmprestimo> LivEmprestimo {get; set; }

    }
}
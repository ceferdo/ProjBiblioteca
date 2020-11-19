using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjBiblioteca.Domain.Entities;

namespace ProjBiblioteca.Infrastructure.Data.Context.Config
{
    public class LivroEmprestimoConfiguration : IEntityTypeConfiguration<LivroEmprestimo>
    {
        public void Configure(EntityTypeBuilder<LivroEmprestimo> builder)
        {
            builder.HasKey(bc => new { bc.LivroID, bc.EmprestimoID });

            builder.HasOne(bc => bc.Livros)
                .WithMany(b => b.LivEmprestimo)
                .HasForeignKey(bc => bc.LivroID);

            builder.HasOne(bc => bc.Emprestimos)
                .WithMany(c => c.LivEmprestimo)
                .HasForeignKey(bc => bc.EmprestimoID);
        }
    }
}
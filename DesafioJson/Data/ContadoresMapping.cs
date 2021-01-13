using DesafioJson.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioJson.Data
{
    class ContadoresMapping : IEntityTypeConfiguration<Contadores>
    {
        public void Configure(EntityTypeBuilder<Contadores> builder)
        {
            builder.ToTable("Contadores", "Desafio");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Nome).HasMaxLength(100).IsRequired();
            builder.Property(b => b.DataNascimento).HasColumnType("DateTime");
            builder.Property(b => b.Endereco).HasMaxLength(500).IsRequired();
            builder.Property(b => b.Numero).HasColumnType("Int");
            builder.Property(b => b.Bairro).HasMaxLength(500).IsRequired();
            builder.Property(b => b.Ativo).HasColumnType("BIT").IsRequired();
        }
    }
}

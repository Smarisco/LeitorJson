using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DesafioJson.Model;

namespace DesafioJson.Data
{
    public class UnidadeGestoraMapping : IEntityTypeConfiguration<UnidadeGestora>
    {
        public void Configure(EntityTypeBuilder<UnidadeGestora> builder)
        {
            builder.ToTable("UnidadeGestora", "Desafio");

            //tamanho para as propriedades e declaração de tipo

            builder.Property(b => b.Codigo).ValueGeneratedNever().IsRequired();
            builder.Property(b => b.Nome).HasMaxLength(500).IsRequired();
            builder.Property(b => b.NomeReduzido).HasMaxLength(100).IsRequired();
            builder.Property(b => b.DataCriacao).HasColumnType("DateTime");
            builder.Property(b => b.Cnpj).HasMaxLength(14).IsRequired();
            builder.Property(b => b.IntegracaoCompras).HasColumnType("BIT").IsRequired();
            builder.Property(b => b.EmitePreEmpenhoIntegrado).HasColumnType("BIT").IsRequired();
           
            builder.HasMany(p => p.Contadores)
                 .WithOne(b => b.UnidadeGestora);
        }
    }
}


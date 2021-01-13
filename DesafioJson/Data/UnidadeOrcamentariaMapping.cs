using DesafioJson.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioJson.Data
{
    public class UnidadeOrcamentariaMapping : IEntityTypeConfiguration<UnidadeOrcamentaria>
    {
        public void Configure(EntityTypeBuilder<UnidadeOrcamentaria> builder)
        {
            builder.ToTable("Orcamentaria", "Desafio");
            builder.Property(b => b.Codigo).ValueGeneratedNever().IsRequired();
            builder.Property(b => b.Nome).HasMaxLength(100).IsRequired();
            builder.Property(b => b.UsuarioInclusaoRegistro).HasMaxLength(100).IsRequired();
            builder.Property(b => b.DataInclusaoRegistro).HasColumnType("DateTime");
            builder.Property(b => b.UnidadeGestoraCodigo).HasColumnType("int").IsRequired();


            //chave estrangeira para a tabela Unidade Gestora da relação um para um

            builder.HasOne(u => u.UnidadeGestora)
              .WithOne(uo => uo.UnidadeOrcamentaria);

            //chave estrangeira para a relação muitos para um
            //modelBuilder.Entity<Pedido>().HasRequired(c => c.Cliente)
            // .WithMany(p => p.Pedidos).HasForeignKey(p => p.ClienteId);

        }
    }
}



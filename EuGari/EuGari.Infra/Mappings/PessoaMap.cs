using EuGari.Domain;
using System.Data.Entity.ModelConfiguration;

namespace EuGari.Infra.Mappings
{
    public class PessoaMap : EntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeConfiguration<Pessoa> builder)
        {
            builder.ToTable("Pessoa");
            builder.HasKey(x => x.PessoaId);
            builder.Property(x => x.Nome).HasMaxLength(50).IsRequired();
            builder.Property(x => x.CPF).HasMaxLength(18).IsRequired();
        }
    }
}

using Cleiteam.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cleiteam.Data.Mapping
{
    internal class UsuarioConfiguracaoMapping : IEntityTypeConfiguration<UsuarioConfiguracao>
    {
        public void Configure(EntityTypeBuilder<UsuarioConfiguracao> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("UsuarioConfiguracoes");

            builder.Property(x => x.Alcance)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(x => x.Nome) 
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(x => x.ReceberNotificacao)
                .HasColumnType("bit")
                .IsRequired();
        }
    }
}

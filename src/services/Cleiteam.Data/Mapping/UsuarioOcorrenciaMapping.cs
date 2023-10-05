using Cleiteam.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cleiteam.Data.Mapping
{
    internal class UsuarioOcorrenciaMapping : IEntityTypeConfiguration<UsuarioOcorrencia>
    {
        public void Configure(EntityTypeBuilder<UsuarioOcorrencia> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("UsuarioOcorrencias");

            builder.Property(x => x.IdUsuario)
                .IsRequired();

            builder.Property(x => x.IdOcorrencia)
                .IsRequired();

            builder.Property(x => x.Responsavel)
                .IsRequired()
                .HasColumnType("bit");

            builder.HasOne(x => x.Usuario)
                .WithMany(x => x.Ocorrencias)
                .HasForeignKey(x => x.IdUsuario);

            builder.HasOne(x => x.Ocorrencia)
                .WithMany(x => x.Usuarios)
                .HasForeignKey(x => x.IdOcorrencia);
        }
    }
}
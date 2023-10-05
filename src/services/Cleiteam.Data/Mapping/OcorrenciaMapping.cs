using Cleiteam.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cleiteam.Data.Mapping
{
    internal class OcorrenciaMapping : IEntityTypeConfiguration<Ocorrencia>
    {
        public void Configure(EntityTypeBuilder<Ocorrencia> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("Ocorrencias");

            builder.Property(x => x.Descricao)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(x => x.IdTipoOcorrencia)
                .IsRequired();

            builder.Property(x => x.Latitude)
                .IsRequired()
                .HasColumnType("Decimal(8,6)");

            builder.Property(x => x.Longitude)  
                .IsRequired()
                .HasColumnType("Decimal(9,6)");

            builder.HasOne(x => x.TipoOcorrencia)
                .WithMany(x => x.Ocorrencias)
                .HasForeignKey(x => x.IdTipoOcorrencia);
        }
    }
}
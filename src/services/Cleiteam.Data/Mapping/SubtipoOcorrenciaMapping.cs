using Cleiteam.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cleiteam.Data.Mapping
{
    public class SubTipoOcorrenciaMapping : IEntityTypeConfiguration<SubtipoOcorrencia>
    {
        public void Configure(EntityTypeBuilder<SubtipoOcorrencia> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("SubtiposOcorrencia");

            builder.Property(x => x.Descricao)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.HasOne(x => x.TipoOcorrencia)
                .WithMany(x => x.SubtiposOcorrencia)
                .HasForeignKey(x => x.IdTipoOcorrencia);
        }
    }
}
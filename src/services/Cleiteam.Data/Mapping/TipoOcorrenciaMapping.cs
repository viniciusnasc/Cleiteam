using Cleiteam.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cleiteam.Data.Mapping
{
    public class TipoOcorrenciaMapping : IEntityTypeConfiguration<TipoOcorrencia>
    {
        public void Configure(EntityTypeBuilder<TipoOcorrencia> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Descricao)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.ToTable("TiposOcorrencia");
        }
    }
}
using Cleiteam.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cleiteam.Data.Mapping
{
    internal class ImagemOcorrenciaMapping : IEntityTypeConfiguration<ImagemOcorrencia>
    {
        public void Configure(EntityTypeBuilder<ImagemOcorrencia> builder)
        {
            builder.HasKey(x => x.Id);

            builder.ToTable("ImagensOcorrencia");

            builder.Property(x => x.NomeArquivo)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(x => x.IdOcorrencia)
                .IsRequired();

            builder.Property(x => x.IdUsuario) 
                .IsRequired();

            builder.Property(x => x.Likes)
                .HasColumnType("int")
                .IsRequired();

            builder.HasOne(x => x.Ocorrencia)
                .WithMany(x => x.Imagens)
                .HasForeignKey(x => x.IdOcorrencia);

            builder.HasOne(x => x.Usuario)
                .WithMany(x => x.Imagens).OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(x => x.IdUsuario);
        }
    }
}
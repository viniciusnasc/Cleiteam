using Cleiteam.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Cleiteam.Data.Mapping
{
    internal class ComentarioImagemMapping : IEntityTypeConfiguration<ComentarioImagem>
    {
        public void Configure(EntityTypeBuilder<ComentarioImagem> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Comentario)
                .HasColumnType("varchar(300)")
                .IsRequired();

            builder.Property(x => x.IdUsuario)
                .IsRequired();

            builder.Property(x => x.IdImagem)
                .IsRequired();

            builder.HasOne(x => x.Imagem)
                .WithMany(x => x.Comentarios)
                .HasForeignKey(x => x.IdImagem)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.Usuario)
                .WithMany(x => x.Comentarios)
                .HasForeignKey(x => x.IdUsuario);
        }
    }
}
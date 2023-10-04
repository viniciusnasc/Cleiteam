using Cleiteam.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Cleiteam.Data.Context
{
    public class CleiteamContext : DbContext
    {
        public CleiteamContext(DbContextOptions<CleiteamContext> options) : base(options) 
        { }

        public DbSet<TipoOcorrencia> TiposOcorrencia { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
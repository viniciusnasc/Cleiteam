using Cleiteam.Data.Context;
using Cleiteam.Domain.Entities;
using Cleiteam.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace Cleiteam.Data.Repositorys
{
    public class ComentarioImagemRepository : BaseRepository<ComentarioImagem>, IComentarioImagemRepository
    {
        public ComentarioImagemRepository(CleiteamContext context) : base(context)
        {}

        public override async Task<List<ComentarioImagem>> BuscarVarios(Expression<Func<ComentarioImagem, bool>> predicate)
        {
            return await _context.Set<ComentarioImagem>()
                .Where(predicate).Include(x => x.Usuario).ToListAsync();
        }
    }
}
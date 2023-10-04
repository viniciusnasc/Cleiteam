using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cleiteam.Identidade.API.Context
{
    public class AutenticacaoContext : IdentityDbContext
    {
        public AutenticacaoContext(DbContextOptions<AutenticacaoContext> options) : base(options) { }
    }
}
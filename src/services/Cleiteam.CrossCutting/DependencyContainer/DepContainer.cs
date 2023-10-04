using Cleiteam.Data.Context;
using Cleiteam.Data.Repositorys;
using Cleiteam.Domain.Interfaces.Repository;
using Cleiteam.Domain.Interfaces.Service;
using Cleiteam.Domain.NotificadorErros;
using Cleiteam.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cleiteam.CrossCutting.DependencyContainer
{
    public static class DepContainer
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<CleiteamContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"),
                                     p => p.EnableRetryOnFailure()
                                           .MigrationsHistoryTable("Migracoes_Cleiteam"));
            });

            // Services
            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<ITipoOcorrenciaService, TipoOcorrenciaService>();
            services.AddScoped<IOcorrenciaService, OcorrenciaService>();

            // Repositorys
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            // UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
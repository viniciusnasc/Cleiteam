using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace Cleiteam.CrossCutting.AutoMapper
{
    public static class AutoMapperConfiguration
    {
        public static IServiceCollection AddAutoMapperConfiguration(this IServiceCollection services)
        {
            MapperConfiguration config = new(config =>
            {
                config.AddProfile(new EntityToDtoProfile());
            });
            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            return services;
        }
    }
}

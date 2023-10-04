using AutoMapper;
using Cleiteam.Domain.Entities;
using Cleiteam.Domain.Models;

namespace Cleiteam.CrossCutting.AutoMapper
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<TipoOcorrencia, TipoOcorrenciaView>();
            CreateMap<Ocorrencia, OcorrenciaInputModel>().ReverseMap();
        }
    }
}
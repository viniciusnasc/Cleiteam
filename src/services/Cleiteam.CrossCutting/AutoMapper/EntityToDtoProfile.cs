using AutoMapper;
using Cleiteam.Domain.Entities;
using Cleiteam.Domain.Models;

namespace Cleiteam.CrossCutting.AutoMapper
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            // TipoOcorrencia
            CreateMap<TipoOcorrencia, TipoOcorrenciaView>();

            // Ocorrencia
            CreateMap<Ocorrencia, OcorrenciaViewModel>();
            CreateMap<Ocorrencia, OcorrenciaInputModel>().ReverseMap();
            
            // Comentarios
            CreateMap<ComentarioImagem, ComentarioView>()
                .ForMember(x => x.NomeUsuario, map => map.MapFrom(src => src.Usuario.Nome));
            CreateMap<ComentarioInputModel, ComentarioImagem>();

            // Usuario
            CreateMap<UsuarioConfiguracao, UsuarioView>().ReverseMap();

            // Imagem
            CreateMap<ImagemOcorrencia, ImagemView>();
        }
    }
}
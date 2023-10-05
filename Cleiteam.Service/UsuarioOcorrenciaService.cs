using AutoMapper;
using Cleiteam.Domain.Entities;
using Cleiteam.Domain.Interfaces.Repository;
using Cleiteam.Domain.Interfaces.Service;
using Cleiteam.Domain.Models;

namespace Cleiteam.Service
{
    public class UsuarioOcorrenciaService : BaseService, Domain.Interfaces.Service.IUsuarioOcorrenciaService
    {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IUser _user;
            private readonly IMapper _mapper;

            public UsuarioOcorrenciaService(INotificador notificador, IUnitOfWork unitOfWork, IUser user, IMapper mapper) : base(notificador)
            {
                _unitOfWork = unitOfWork;
                _user = user;
                _mapper = mapper;
            }

        public async Task<IEnumerable<UsuarioOcorrencia>> BuscarTodos()
        {
            var entities = await _unitOfWork.UsuarioOcorrenciaRepository.SelecionarTudo();
            return _mapper.Map<IEnumerable<UsuarioOcorrencia>>(entities);
        }

        public async Task Cadastrar(Guid idOcorrencia)
        {
            await _unitOfWork.UsuarioOcorrenciaRepository.Incluir(new Domain.Entities.UsuarioOcorrencia { 
                                                                  IdOcorrencia = idOcorrencia, IdUsuario = _user.GetUserId(), Responsavel = false });
        }
    }
}

using AutoMapper;
using Cleiteam.Domain.Interfaces.Repository;
using Cleiteam.Domain.Interfaces.Service;
using Cleiteam.Domain.Models;

namespace Cleiteam.Service
{
    public class UsuarioConfiguracaoService : BaseService, IUsuarioConfiguracaoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUser _user;
        private readonly IMapper _mapper;

        public UsuarioConfiguracaoService(INotificador notificador, IUnitOfWork unitOfWork, IUser user, IMapper mapper) : base(notificador)
        {
            _unitOfWork = unitOfWork;
            _user = user;
            _mapper = mapper;
        }

        public async Task<UsuarioView> ObterDadosUsuario()
        {
            var entity = await _unitOfWork.UsuarioConfiguracaoRepository.SelecionarPorId(_user.GetUserId());

            if (entity == null)
            {
                entity = new()
                {
                    Nome = _user.GetUserEmail(),
                    Alcance = 0,
                    ReceberNotificacao = false,
                    Id = _user.GetUserId()
                };

                await _unitOfWork.UsuarioConfiguracaoRepository.Incluir(entity);
            }

            return _mapper.Map<UsuarioView>(entity);
        }

        public async Task Editar(UsuarioView model)
        {
            if(_user.GetUserId() != model.Id)
            {
                Notificar("Não é possível alterar dados de outro usuario!");
                return;
            }

            var entity = await _unitOfWork.UsuarioConfiguracaoRepository.SelecionarPorId(model.Id);
            
            if(entity is null)
            {
                Notificar("Id nao encontrado");
                return;
            }

            entity.ReceberNotificacao = model.ReceberNotificacao;
            entity.Alcance = model.Alcance;
            entity.Nome = model.Nome;
            entity.DataEdicao = DateTime.Now;

            await _unitOfWork.UsuarioConfiguracaoRepository.Alterar(entity);
        }
    }
}
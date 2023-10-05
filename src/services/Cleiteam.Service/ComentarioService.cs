using AutoMapper;
using Cleiteam.Domain.Entities;
using Cleiteam.Domain.Interfaces.Repository;
using Cleiteam.Domain.Interfaces.Service;
using Cleiteam.Domain.Models;

namespace Cleiteam.Service
{
    public class ComentarioService : BaseService, IComentarioService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUser _user;
        private readonly IMapper _mapper;

        public ComentarioService(INotificador notificador, IUnitOfWork unitOfWork, IUser user, IMapper mapper) : base(notificador)
        {
            _unitOfWork = unitOfWork;
            _user = user;
            _mapper = mapper;
        }

        public async Task Comentar(ComentarioInputModel model)
        {
            var entity = _mapper.Map<ComentarioImagem>(model);
            entity.IdUsuario = _user.GetUserId();
            await _unitOfWork.ComentarioImagemRepository.Incluir(entity);
        }

        public async Task<List<ComentarioView>> BuscarTodos(Guid idImagem)
        {
            var entities = await _unitOfWork.ComentarioImagemRepository
                                        .BuscarVarios(x => x.IdImagem == idImagem);

            return _mapper.Map<List<ComentarioView>>(entities);
        }

        public async Task Editar(ComentarioEditModel model)
        {
            var entity = await _unitOfWork.ComentarioImagemRepository.SelecionarPorId(model.Id);

            if(entity is null)
            {
                Notificar("Não foi encontrado o comentario");
            }

            if (entity.IdUsuario != _user.GetUserId())
            {
                Notificar("Não é possível excluir este comentario!");
            }

            entity.Comentario = model.Comentario;

            await _unitOfWork.ComentarioImagemRepository.Alterar(entity);
        }

        public async Task Deletar(Guid idComentario)
        {
            var entity = await _unitOfWork.ComentarioImagemRepository.SelecionarPorId(idComentario);

            if(entity is null)
            {
                Notificar("Não foi encontrado o comentario informado");
                return;
            }

            if(entity.IdUsuario != _user.GetUserId())
            {
                Notificar("Não é possível excluir este comentario!");
            }

            await _unitOfWork.ComentarioImagemRepository.Remover(entity);
        }
    }
}
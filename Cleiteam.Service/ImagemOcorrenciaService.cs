using Cleiteam.Domain.Entities;
using Cleiteam.Domain.Interfaces.Repository;
using Cleiteam.Domain.Interfaces.Service;
using Microsoft.AspNetCore.Http;

namespace Cleiteam.Service
{
    public class ImagemOcorrenciaService : BaseService, IImagemOcorrenciaService
    {
        private readonly IUser _user;
        private readonly IUnitOfWork _unitOfWork;

        public ImagemOcorrenciaService(INotificador notificador, IUser user, IUnitOfWork unitOfWork) : base(notificador)
        {
            _user = user;
            _unitOfWork = unitOfWork;
        }

        public async Task BuscarTodos(Guid idOcorrencia)
        {
            var entities = await _unitOfWork.ImagemOcorrenciaRepository.BuscarVarios(x => x.IdOcorrencia == idOcorrencia);
        }

        public async Task Adicionar(Guid idOcorrencia, IFormFile file)
        {
            string fileName = file.FileName + Guid.NewGuid();

            if(!await RealizarUpload(file, fileName))
            {
                Notificar("Não foi possível realizar upload da imagem");
                return;
            }

            var entity = new ImagemOcorrencia(fileName);
            entity.IdUsuario = _user.GetUserId();
            entity.IdOcorrencia = idOcorrencia;
            
            await _unitOfWork.ImagemOcorrenciaRepository.Incluir(entity);
        }

        public async Task Deletar(Guid idImagem)
        {
            var entity = await _unitOfWork.ImagemOcorrenciaRepository.SelecionarPorId(idImagem);

            if (entity is null)
            {
                Notificar("Não foi encontrado o comentario informado");
                return;
            }

            if (entity.IdUsuario != _user.GetUserId())
            {
                Notificar("Não é possível excluir este comentario!");
            }

            await _unitOfWork.ImagemOcorrenciaRepository.Remover(entity);
        }
    }
}
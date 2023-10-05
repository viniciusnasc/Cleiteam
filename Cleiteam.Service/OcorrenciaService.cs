using AutoMapper;
using Cleiteam.Domain.Entities;
using Cleiteam.Domain.Interfaces.Repository;
using Cleiteam.Domain.Interfaces.Service;
using Cleiteam.Domain.Models;
using Microsoft.AspNetCore.Http;

namespace Cleiteam.Service
{
    public class OcorrenciaService : BaseService, IOcorrenciaService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUser _user;

        public OcorrenciaService(INotificador notificador, IMapper mapper, IUnitOfWork unitOfWork, IUser user) : base(notificador)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _user = user;
        }

        public async Task<List<OcorrenciaViewModel>> Buscar(long latitude, long longitude, int rangeDistancia)
        {
            var entities = await _unitOfWork.OcorrenciaRepository.BuscarVarios(latitude, longitude, rangeDistancia);
            return _mapper.Map<List<OcorrenciaViewModel>>(entities);
        }

        public async Task Cadastrar(OcorrenciaInputModel model)
        {
            string fileName = model.Imagem.FileName + Guid.NewGuid();

            if(!await RealizarUpload(model.Imagem, fileName))
            {
                Notificar("Não foi possível realizar upload da imagem");
                return;
            }

            var entityOcorrencia = _mapper.Map<Ocorrencia>(model);
            entityOcorrencia.Imagens = new();
            entityOcorrencia.Usuarios = new();

            var imagem = new ImagemOcorrencia(fileName);
            imagem.IdOcorrencia = entityOcorrencia.Id;
            imagem.IdUsuario = _user.GetUserId();
            entityOcorrencia.Imagens.Add(imagem);


            entityOcorrencia.Usuarios.Add(new UsuarioOcorrencia()
            {
                IdOcorrencia = entityOcorrencia.Id,
                IdUsuario = _user.GetUserId(),
                Responsavel = true
            });

            await _unitOfWork.OcorrenciaRepository.Incluir(entityOcorrencia);
        }

        public async Task<bool> RealizarUpload(IFormFile file, string fileName)
        {
            if(file.Length <= 0)
            {
                Notificar("Arquivo inválido!");
                return false;
            }

            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", fileName);

            if(File.Exists(filePath))
            {
                Notificar("Já existe um arquivo com este nome!");
                return false;
            }

            await using FileStream fileStream = new(filePath, FileMode.Create);
            await file.CopyToAsync(fileStream);

            return true;
        }
    }
}

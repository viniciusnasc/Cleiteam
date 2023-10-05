using AutoMapper;
using Cleiteam.Domain.Entities;
using Cleiteam.Domain.Interfaces.Repository;
using Cleiteam.Domain.Interfaces.Service;
using Cleiteam.Domain.Models;
using Microsoft.AspNetCore.Http;
using System.IO.Enumeration;

namespace Cleiteam.Service
{
    public class OcorrenciaService : BaseService, IOcorrenciaService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public OcorrenciaService(INotificador notificador, IMapper mapper, IUnitOfWork unitOfWork) : base(notificador)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task Buscar(long latitude, long longitude)
        {
            //await _unitOfWork.
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

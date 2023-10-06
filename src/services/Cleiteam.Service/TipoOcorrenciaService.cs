using AutoMapper;
using Cleiteam.Domain.Entities;
using Cleiteam.Domain.Interfaces.Repository;
using Cleiteam.Domain.Interfaces.Service;
using Cleiteam.Domain.Models;
using Cleiteam.Domain.Validations;

namespace Cleiteam.Service
{
    public class TipoOcorrenciaService : BaseService, ITipoOcorrenciaService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TipoOcorrenciaService(INotificador notificador, IUnitOfWork unitOfWork, IMapper mapper) : base(notificador)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _mapper = mapper;
        }

        public async Task<IEnumerable<TipoOcorrenciaView>> BuscarTodos()
        {
            var entities = await _unitOfWork.TipoOcorrenciaRepository.SelecionarTudo();
            return _mapper.Map<IEnumerable<TipoOcorrenciaView>>(entities);
        }

        public async Task<IEnumerable<SubtipoOcorrenciaView>> BuscarSubtiposOcorrencia(Guid idTipoOcorrencia)
        {
            var entities = await _unitOfWork.SubtipoOcorrenciaRepository.BuscarVarios(x => x.IdTipoOcorrencia == idTipoOcorrencia);
            return _mapper.Map<IEnumerable<SubtipoOcorrenciaView>>(entities);
        }

        public async Task Adicionar(string descricao)
        {
            var entity = new TipoOcorrencia(descricao);

            if (!ExecutarValidacao(new TipoOcorrenciaValidation(), entity))
                return;

            await _unitOfWork.TipoOcorrenciaRepository.Incluir(entity);
        }
    }
}
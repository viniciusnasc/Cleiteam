using Cleiteam.API.Extensions;
using Cleiteam.Domain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;

namespace Cleiteam.API.Controllers
{
    public class TipoOcorrenciaController : BaseController
    {
        private readonly ITipoOcorrenciaService _tipoOcorrenciaService;

        public TipoOcorrenciaController(ITipoOcorrenciaService tipoOcorrenciaService)
        {
            _tipoOcorrenciaService = tipoOcorrenciaService ?? throw new ArgumentNullException(nameof(tipoOcorrenciaService));
        }

        [HttpGet]
        public async Task<ActionResult> BuscarTodos()
        {
            var entities = await _tipoOcorrenciaService.BuscarTodos();
            return CustomResponse(entities);
        }

        [HttpGet("SubtipoOcorrencia")]
        public async Task<ActionResult> BuscarTodosSubtipos(Guid idTipoOcorrencia)
        {
            var entities = await _tipoOcorrenciaService.BuscarSubtiposOcorrencia(idTipoOcorrencia);
            return CustomResponse(entities);
        }

        /*
        [HttpPost]
        public async Task<ActionResult> Cadastrar(string descricaoTipoOcorrencia)
        {
            await _tipoOcorrenciaService.Adicionar(descricaoTipoOcorrencia);
            return CustomResponse();
        }*/
    }
}
using Cleiteam.API.Extensions;
using Cleiteam.Domain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;

namespace Cleiteam.API.Controllers
{
    [Route("api/[controller]")]
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

        [HttpPost]
        //[ClaimsAuthorize("", "")]
        public async Task<ActionResult> Cadastrar(string descricaoTipoOcorrencia)
        {
            await _tipoOcorrenciaService.Adicionar(descricaoTipoOcorrencia);
            return CustomResponse();
        }
    }
}
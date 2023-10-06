using Cleiteam.Domain.Interfaces.Service;
using Cleiteam.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cleiteam.API.Controllers
{
    public class OcorrenciaController : BaseController
    {
        private readonly IOcorrenciaService _ocorrenciaService;

        public OcorrenciaController(IOcorrenciaService ocorrenciaService)
        {
            _ocorrenciaService = ocorrenciaService ?? throw new ArgumentNullException(nameof(ocorrenciaService));
        }

        [HttpGet]
        public async Task<ActionResult> BuscarOcorrencias(long latitude, long longitude, int rangeDistancia = 10)
        {
            var result = await _ocorrenciaService.Buscar(latitude, longitude, rangeDistancia);
            return CustomResponse(result);
        }

        [HttpPost]
        public async Task<ActionResult> Cadastrar(OcorrenciaInputModel model)
        {
            if(!ModelState.IsValid) return CustomResponse(ModelState);

            await _ocorrenciaService.Cadastrar(model);

            return CustomResponse();
        }
    }
}
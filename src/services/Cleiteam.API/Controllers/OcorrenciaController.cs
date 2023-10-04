using Cleiteam.Domain.Interfaces.Service;
using Cleiteam.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cleiteam.API.Controllers
{
    [Route("[controller]")]
    public class OcorrenciaController : BaseController
    {
        private readonly IOcorrenciaService _ocorrenciaService;

        public OcorrenciaController(IOcorrenciaService ocorrenciaService)
        {
            _ocorrenciaService = ocorrenciaService ?? throw new ArgumentNullException(nameof(ocorrenciaService));
        }

        [HttpGet]
        public async Task<ActionResult> BuscarOcorrencias()
        {
            return CustomResponse();
        }

        [HttpPost]
        public async Task<ActionResult> Cadastrar(OcorrenciaInputModel model)
        {
            if(ModelState.IsValid) return CustomResponse(ModelState);



            return CustomResponse();
        }
    }
}
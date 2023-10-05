using Cleiteam.Domain.Interfaces.Service;
using Cleiteam.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cleiteam.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagemController : BaseController
    {
        private readonly IImagemOcorrenciaService _imagemOcorrenciaService;

        public ImagemController(IImagemOcorrenciaService imagemOcorrenciaService)
        {
            _imagemOcorrenciaService = imagemOcorrenciaService;
        }

        [HttpGet]
        public async Task<ActionResult> BuscarTodos(Guid idOcorrencia)
        {
            var model = await _imagemOcorrenciaService.BuscarTodos(idOcorrencia);
            return CustomResponse(model);
        }

        [HttpPost]
        public async Task<ActionResult> Adicionar(Guid idOcorrencia, IFormFile file)
        {
            await _imagemOcorrenciaService.Adicionar(idOcorrencia, file);
            return CustomResponse();
        }

        [HttpDelete]
        public async Task<ActionResult> Deletar(Guid id)
        {
            await _imagemOcorrenciaService.Deletar(id);
            return CustomResponse();
        }
    }
}
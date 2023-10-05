using Cleiteam.Domain.Interfaces.Service;
using Cleiteam.Service;
using Microsoft.AspNetCore.Mvc;

namespace Cleiteam.API.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioOcorrenciaController : BaseController
    {
        private readonly IUsuarioOcorrenciaService _usuarioOcorrenciaService;

        public UsuarioOcorrenciaController(IUsuarioOcorrenciaService usuarioOcorrenciaService)
        {
            _usuarioOcorrenciaService = usuarioOcorrenciaService ?? throw new ArgumentNullException(nameof(usuarioOcorrenciaService));
        }

        [HttpGet]
        public async Task<ActionResult> BuscarTodos()
        {
            var entities = await _usuarioOcorrenciaService.BuscarTodos();
            return CustomResponse(entities);
        }

        [HttpPost]
        public async Task<ActionResult> Cadastrar(Guid idOcorrencia)
        {
            await _usuarioOcorrenciaService.Cadastrar(idOcorrencia);
            return CustomResponse();
        }
    }
}

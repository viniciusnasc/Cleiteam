using Cleiteam.Domain.Interfaces.Service;
using Cleiteam.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cleiteam.API.Controllers
{
    public class ComentarioController : BaseController
    {
        private readonly IComentarioService _comentarioService;

        public ComentarioController(IComentarioService comentarioService)
        {
            _comentarioService = comentarioService ?? throw new ArgumentNullException(nameof(comentarioService));
        }

        [HttpGet]
        public async Task<ActionResult> BuscarTodos(Guid idImagem)
        {
            var result = await _comentarioService.BuscarTodos(idImagem);
            return CustomResponse(result);
        }

        [HttpPost]
        public async Task<ActionResult> ComentarImagem(ComentarioInputModel model)
        {
            await _comentarioService.Comentar(model);
            return CustomResponse();
        }

        [HttpPut]
        public async Task<ActionResult> Editar(ComentarioEditModel model)
        {
            await _comentarioService.Editar(model);
            return CustomResponse();
        }

        [HttpDelete]
        public async Task<ActionResult> Deletar(Guid id)
        {
            await _comentarioService.Deletar(id);
            return CustomResponse();
        }
    }
}
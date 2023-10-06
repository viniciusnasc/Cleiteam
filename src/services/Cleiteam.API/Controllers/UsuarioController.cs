using Cleiteam.Domain.Interfaces.Service;
using Cleiteam.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cleiteam.API.Controllers
{
    public class UsuarioController : BaseController
    {
        private readonly IUsuarioConfiguracaoService _usuarioConfiguracaoService;

        public UsuarioController(IUsuarioConfiguracaoService usuarioConfiguracaoService)
        {
            _usuarioConfiguracaoService = usuarioConfiguracaoService ?? throw new ArgumentNullException(nameof(usuarioConfiguracaoService));
        }

        [HttpGet]
        public async Task<ActionResult> BuscarDados()
        {
            var result = await _usuarioConfiguracaoService.ObterDadosUsuario();
            return CustomResponse(result);
        }

        [HttpPut]
        public async Task<ActionResult> AlterarDados(UsuarioView model)
        {
            await _usuarioConfiguracaoService.Editar(model);
            return CustomResponse();
        }
    }
}
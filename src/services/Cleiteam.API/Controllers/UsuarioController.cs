using Cleiteam.Domain.Interfaces.Service;
using Cleiteam.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cleiteam.API.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : BaseController
    {
        private readonly IUsuarioConfiguracaoService _usuarioConfiguracaoService;

        public UsuarioController(IUsuarioConfiguracaoService usuarioConfiguracaoService)
        {
            _usuarioConfiguracaoService = usuarioConfiguracaoService;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult> BuscarDados()
        {
            var result = await _usuarioConfiguracaoService.ObterDadosUsuario();
            return CustomResponse(result);
        }

        [HttpPut]
        [Authorize]
        public async Task<ActionResult> AlterarDados(UsuarioView model)
        {
            await _usuarioConfiguracaoService.Editar(model);
            return CustomResponse();
        }
    }
}
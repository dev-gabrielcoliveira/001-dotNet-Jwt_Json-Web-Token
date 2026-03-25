using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtApi.Controller.Secure
{
    [ApiController]
    [Route("[controller]")]
    public class SecureController : ControllerBase
    {
        
        [HttpGet("perfil/administrador")]
        [Authorize(Policy = "Administrador")]
        public IActionResult Administrador()
        {
            return Ok("Você está acessando esse método que é exclusivo para administrador.");
        }

        [HttpGet("perfil/usuario")]
        [Authorize(Policy = "UsuarioComum")]
        public IActionResult Usuario()
        {
            return Ok("Você está acessando esse método que é exclusivo para usuário comum.");
        }

        [HttpGet("home")]
        public IActionResult Home()
        {
            return Ok("Permitido A Todos os Usuários");
        }
    }
}

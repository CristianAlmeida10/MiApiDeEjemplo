using Microsoft.AspNetCore.Mvc;
using MiPrimeraAPI.Model;

namespace MiPrimeraAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name = "GetUsuarios")]
        public List<Usuario> GetUsuario()
        {
            return new List<Usuario>();
        }
    }
}

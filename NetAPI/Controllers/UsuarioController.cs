using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace WebApplication.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        // GET: /Usuario
        [HttpGet]
        public IActionResult ObtenerUsuarios()
        {
            // Lógica para obtener usuarios
            return Ok(new List<string> { "Usuario1", "Usuario2" });
        }

        // GET: /Usuario/5
        [HttpGet("{id}")]
        public IActionResult ObtenerUsuarioPorId(int id)
        {
            // Lógica para obtener un usuario por id
            return Ok($"Usuario con id: {id}");
        }

        // POST: /Usuario
        [HttpPost]
        public IActionResult CrearUsuario([FromBody] string nombre)
        {
            // Lógica para crear usuario
            return Created($"Usuario/123", new { id = 123, nombre });
        }

        // PUT: /Usuario/5
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(void), 204)]
        public IActionResult ActualizarUsuario(int id, [FromBody] string nuevoNombre)
        {
            // Lógica para actualizar usuario
            return NoContent(); // 204 No Content
        }

        // Permite acceso anónimo
        [AllowAnonymous]
        [HttpGet("publico")]
        public IActionResult AccesoPublico()
        {
            return Ok("Este endpoint no requiere autenticación");
        }
    }
}

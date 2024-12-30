using Projetoloja.backend.models;
using Projetoloja.backend.respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Projetoloja.backend.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioController(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsuarios() => Ok(await _repository.GetUsuariosAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUsuario(int id) => Ok(await _repository.GetUsuarioByIdAsync(id));

        [HttpPost]
        public async Task<IActionResult> AddUsuario([FromBody] Usuario usuario)
        {
            await _repository.AddUsuarioAsync(usuario);
            return CreatedAtAction(nameof(GetUsuario), new { id = usuario.Id }, usuario);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUsuario(int id, [FromBody] Usuario usuario)
        {
            if (id != usuario.Id) return BadRequest();
            await _repository.UpdateUsuarioAsync(usuario);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            await _repository.DeleteUsuarioAsync(id);
            return NoContent();
        }
    }
}

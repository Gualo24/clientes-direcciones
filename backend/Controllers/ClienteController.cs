using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;
        private readonly Context.ApplicationContext _context;
        public ClienteController(ILogger<ClienteController> logger,
            Context.ApplicationContext context)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var clientes = await _context.Clientes.Where(x => !x.Eliminado).ToListAsync();

                return Ok(clientes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get([FromQuery] int id)
        {
            try
            {
                var cliente = await _context.Clientes.FirstOrDefaultAsync(x => !x.Eliminado && x.IdCliente == id);

                if (cliente == null || cliente.IdCliente == 0)
                    return BadRequest("No fue posible encontrar este cliente");

                return Ok(cliente);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Post")]
        public async Task<IActionResult> Post([FromBody] DTOs.Cliente.ClienteCreate model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(model);

                Models.Cliente cliente = new()
                {
                    Nombres = model.Nombres,
                    Apellidos = model.Apellidos,
                    Telefono = model.Telefono,
                    CorreoElectronico = model.CorreoElectronico,
                };

                await _context.Clientes.AddAsync(cliente);
                await _context.SaveChangesAsync();
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Put")]
        public async Task<IActionResult> Put([FromBody] DTOs.Cliente.ClienteUpdate model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(model);

                Models.Cliente cliente = await _context.Clientes.FirstOrDefaultAsync(x => x.IdCliente == model.IdCliente);
                if (cliente == null || cliente.IdCliente == 0)
                    return BadRequest("No fue posible encontrar este cliente");

                cliente.Nombres = model.Nombres;
                cliente.Apellidos = model.Apellidos;
                cliente.Telefono = model.Telefono;
                cliente.CorreoElectronico = model.CorreoElectronico;

                await _context.SaveChangesAsync();
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            try
            {
                Models.Cliente cliente = await _context.Clientes.FirstOrDefaultAsync(x => x.IdCliente == id);
                if (cliente == null || cliente.IdCliente == 0)
                    return BadRequest("No fue posible encontrar este cliente");

                cliente.Eliminado = true;
                cliente.FechaEliminado = DateTime.Now;

                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}

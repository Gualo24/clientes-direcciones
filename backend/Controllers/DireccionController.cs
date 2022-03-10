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
    public class DireccionController : ControllerBase
    {
        private readonly ILogger<DireccionController> _logger;
        private readonly Context.ApplicationContext _context;
        public DireccionController(ILogger<DireccionController> logger,
            Context.ApplicationContext context)
        {
            _context = context;
            _logger = logger;
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] int id)
        {
            try
            {
                var direcciones = await _context.Direcciones
                            .Where(x => x.Cliente.IdCliente == id && !x.Eliminado)
                            .ToListAsync();

                return Ok(direcciones);
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
                var direccion = await _context.Direcciones.FirstOrDefaultAsync(x => !x.Eliminado && x.IdDireccion == id);

                if (direccion == null || direccion.IdCliente == 0)
                    return BadRequest("No fue posible encontrar esta direccion");

                return Ok(direccion);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Post")]
        public async Task<IActionResult> Post([FromBody] DTOs.Direccion.DireccionCreate model)
        {
            try
            {
                Models.Direccion direccion = new()
                {
                    IdCliente = model.IdCliente,
                    IdProvincia = model.IdProvincia,
                    IdMunicipio = model.IdMunicipio,
                    Referencia = model.Referencia,
                    Detalle = model.Detalle,
                    Georeferencia = "00000000-000000000",
                };

                await _context.Direcciones.AddAsync(direccion);
                await _context.SaveChangesAsync();
                return Ok(direccion);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Put")]
        public async Task<IActionResult> Put([FromQuery] DTOs.Direccion.DireccionUpdate model)
        {
            try
            {
                Models.Direccion direccion = await _context.Direcciones
                        .FirstOrDefaultAsync(x => !x.Eliminado && x.IdDireccion == model.IdDireccion);

                direccion.IdProvincia = model.IdProvincia;
                direccion.IdMunicipio = model.IdMunicipio;
                direccion.Referencia = model.Referencia;
                direccion.Detalle = model.Detalle;
                direccion.Georeferencia = model.Georeferencia;

                await _context.SaveChangesAsync();
                return Ok(direccion);

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
                Models.Direccion direccion = await _context.Direcciones.FirstOrDefaultAsync(x => x.IdDireccion == id);
                if (direccion == null || direccion.IdCliente == 0)
                    return BadRequest("No fue posible encontrar esta direccion");

                direccion.Eliminado = true;
                direccion.FechaEliminado = DateTime.Now;

                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetProvincias")]
        public async Task<IActionResult> GetProvincias()
        {
            try
            {
                var provincias = await _context.Provincias.ToListAsync();

                return Ok(provincias);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetMunicipios")]
        public async Task<IActionResult> GetMunicipios([FromQuery] int id)
        {
            try
            {
                var municipios = await _context.Municipios.Where(x=> x.IdProvincia == id).ToListAsync();

                return Ok(municipios);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}

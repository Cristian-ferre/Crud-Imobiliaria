using imobiliaria.Context;
using imobiliaria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace imobiliaria.Controllers
{
    [ApiController]
    public class PropertyController : ControllerBase

    {
        //O tipo ImobiliariaContext é provavelmente uma classe que representa o contexto de dados da aplicação. Em .NET, o contexto de dados é usado para acessar e gerenciar dados armazenados em um banco de dados
        public readonly ImobiliariaContext _context;

        public PropertyController(ImobiliariaContext context)
        {
            _context = context;
        }

        //criando propriedades 
        [HttpPost]
        [Route("api/Properties")]
        public  ActionResult CreatePropriedades(Property property)
        {
            _context.Add(property);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        [Route("api/property/{id}")]
        public IActionResult putProprietariro(int id, [FromBody] Property property)
        {
            var pPropri = _context.Properties.Update(property);

            _context.SaveChangesAsync();

            return NoContent();
        }

        //aqui eu estou buscando as propriedades por proprietario 
        [HttpGet("api/property/{OwnerId}")]
        public async Task<ActionResult<List<Property>>> GetPropriedades(int OwnerId)
        {
            var Properties = await _context.Properties.Where(x => x.OwnerId == OwnerId).ToListAsync();
            return Properties;
        }

        [HttpGet("api/properties")]
        public async Task<ActionResult<List<Property>>> GetAll()
        {
            var todos = await _context.Properties.ToListAsync();
            return Ok(todos);
        }

        [HttpDelete]
        [Route("api/property/{propertyId}")]
        public async Task<ActionResult> DeletePropriedade(int propertyId)
        {
            var dele = await _context.Properties.FindAsync(propertyId);
            _context.Remove(dele);
            _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
using imobiliaria.Context;
using imobiliaria.DTO;
using imobiliaria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace imobiliaria.Controllers
{
    [ApiController]
    [Route("Api/[Controller]")]
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
        [Route("api/Propriedades")]
        public async Task<ActionResult<List<Property>>> CreatePropriedades(CreatePropertyDTO request)
        {
            var owner = await _context.Owners.FindAsync(request.OwnerId);
            if (owner == null) return NotFound();
            var newProperty = new Property
            {
                ImgURL = request.ImgURL,
                ShortDescription = request.ShortDescription,
                PropertyValue = request.PropertyValue,
                NumberBedrooms = request.NumberBedrooms,
                NumberRestrooms = request.NumberRestrooms,
                Neighborhood = request.Neighborhood,
                Street = request.Street,
                Owner = owner
            };
            _context.Properties.Add(newProperty);
            await _context.SaveChangesAsync();
            return await GetPropriedades(newProperty.OwnerId);
        }


        [HttpPut]
        [Route("api/propriedade/{id}")]
        public IActionResult putProprietariro(int id, [FromBody] Property property)
        {
            var pPropri = _context.Properties.Update(property);

            _context.SaveChangesAsync();

            return NoContent();
        }

        //aqui eu estou buscando as propriedades por proprietario 
        [HttpGet("api/Propriedade{OwnerId}")]
        public async Task<ActionResult<List<Property>>> GetPropriedades(int OwnerId)
        {
            var Properties = await _context.Properties.Where(x => x.OwnerId == OwnerId).ToListAsync();
            return Properties;
        }

        [HttpGet("api/Propriedade")]
        public async Task<ActionResult<List<Property>>> GetAll()
        {
            var todos = await _context.Properties.ToListAsync();
            return Ok(todos);
        }

        [HttpDelete]
        [Route("delete")]
        public async Task<ActionResult> DeletePropriedade(int propertyId)
        {
            var dele = await _context.Properties.FindAsync(propertyId);
            _context.Remove(dele);
            _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
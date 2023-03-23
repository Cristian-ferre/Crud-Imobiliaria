using imobiliaria.Context;
using imobiliaria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace imobiliaria.Controllers
{
    [ApiController]
    public class OwnerController : ControllerBase
    {
        public readonly ImobiliariaContext _context;

        public OwnerController(ImobiliariaContext context)
        {
            _context = context;
        }

        //Adicionar Propritario de maneira assincrona
        [HttpPost]
        [Route("api/owners")]
        public async Task<ActionResult<Owner>> CreteProprietario(Owner prope)
        {
            _context.Owners.Add(prope);
            await _context.SaveChangesAsync();
            return Ok(prope);
        }

        
        [HttpDelete]
        [Route("api/owner/{nameOwner}")]
        public async Task<ActionResult> DeleteProprietario(string nameOwner)
        {
            var proprietario = await _context.Owners.FirstOrDefaultAsync(p => p.NameOwner == nameOwner);
            _context.Remove(proprietario);
            _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut]
        [Route("api/owners/{id}")]
        public IActionResult Edit(int Id, [FromBody] Owner Owner)
        {
            if (Id != Owner.Id)
            {
                return BadRequest(new ProblemDetails
                {
                    Status = StatusCodes.Status400BadRequest,
                    Title = "Item não Encontrado",
                    Detail = "O valor não pode ser encontardo no banco de dados."
                });
            }
            var novo = _context.Owners.Update(Owner);
            _context.SaveChanges();
            return NoContent();
        }

        // mostar todso de maneira assincrona
        [HttpGet]
        [Route("api/owners")]
        public async Task<ActionResult<List<Owner>>> GetAll()
        {
            var todes = await _context.Owners.ToListAsync();
            return Ok(todes);
        }

        //get pro nome
        [HttpGet]
        [Route("api/Owners/name/{NameOwner}")]
        public async Task<ActionResult> GetProprietario(string NameOwner)
        {
            var Proprietario = await _context.Owners.FirstOrDefaultAsync(p => p.NameOwner == NameOwner);
            return Ok(Proprietario);
        }








    }
}
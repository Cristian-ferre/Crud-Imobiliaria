using imobiliaria.Context;
using Microsoft.AspNetCore.Mvc;
using imobiliaria.Models;

namespace imobiliaria.Controllers
{
    [ApiController]
    public class PropertyTypeController : ControllerBase
    {
        public readonly ImobiliariaContext _context;
        public PropertyTypeController(ImobiliariaContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("api/PropertyTypes")]
        public ActionResult CreateTypeProperty (PropertyType PropertyType)
        {
            _context.Add(PropertyType);
            _context.SaveChanges();
            return Ok();
        }
        
    }
}
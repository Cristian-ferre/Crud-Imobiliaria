using imobiliaria.Context;
using imobiliaria.Models;
using Microsoft.AspNetCore.Mvc;

namespace imobiliaria.Controllers
{
    [ApiController]
    public class CityController : ControllerBase
    {
        public readonly ImobiliariaContext _context;

        public CityController(ImobiliariaContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("api/cities")]
        public ActionResult addCity(City city)
        {
            _context.Add(city);
            _context.SaveChanges();
            return Ok(city);
        }

    }
}
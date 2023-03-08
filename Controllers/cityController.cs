using System.Linq;
using imobiliaria.Context;
using imobiliaria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;


namespace imobiliaria.Controllers
{
    [ApiController]

    [Route("api/[Controller]")]
    public class cityController : ControllerBase
    {

        public readonly ImobiliariaContext _context;

        public cityController(ImobiliariaContext context)
        {
            _context = context;
        }
        [HttpPost]
        [Route("/api/city")]
        public ActionResult addCity(City city)
        {
            _context.Add(city);
            _context.SaveChanges();
            return Ok(city);
        }

    }
}
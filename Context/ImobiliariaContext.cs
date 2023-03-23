using imobiliaria.Models;
using Microsoft.EntityFrameworkCore;

namespace imobiliaria.Context
{
    public class ImobiliariaContext : DbContext
    {
        public ImobiliariaContext(DbContextOptions<ImobiliariaContext> options) : base(options)
        {}
        public DbSet<City> Cities { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyType> PropertyTypes { get; set; }
    }
}
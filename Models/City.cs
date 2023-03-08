using System.ComponentModel.DataAnnotations;

namespace imobiliaria.Models
{
    public class City
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "O nome da cidade deve ser Informada!")]
        public string NameCity { get; set; }

        public string CEPCyty { get; set; }

        public List<Property> Properties { get; set; }
        

    }
}
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace imobiliaria.Models
{
    public class City
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da cidade deve ser Informada!")]
        public string NameCity { get; set; }

        public string CEPCyty { get; set; }
        
        [JsonIgnore]
        public List<Property> Properties { get; set; }


    }
}
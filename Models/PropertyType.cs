using System.Text.Json.Serialization;


namespace imobiliaria.Models
{
    public class PropertyType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        [JsonIgnore]
        public List<Property> Properties { get; set; }


    }
}
namespace imobiliaria.Models
{
    public class PropertyType
    {
        public long Id { get; set; }
        public string Type { get; set; }

        public List<Property> Properties { get; set; }
        

    }
}
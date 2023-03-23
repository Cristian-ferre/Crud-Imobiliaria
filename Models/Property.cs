 using System.Text.Json.Serialization; 

namespace imobiliaria.Models
{
    public class Property
    {
        public int Id { get; set; }

        //descrição curta
        public string ShortDescription { get; set; }

        //Valor da propriedade
        public decimal PropertyValue { get; set; }

        //numero de Quartos
        public byte NumberBedrooms { get; set; }

        //numero de banheiros
        public byte NumberRestrooms { get; set; }

        //Bairo
        public string Neighborhood { get; set; }

        //rua
        public string Street { get; set; }

        [JsonIgnore]
        public PropertyType PropertyType { get; set; }
        public int PropertyTypeId { get; set; }

        [JsonIgnore]
        public City City { get; set; }
        public int CityId { get; set; }

        //Uma propriedade, poderá pertencer apenas a um proprietario
        [JsonIgnore]
        public Owner Owner { get; set; }
        public int OwnerId { get; set; }

    }
}
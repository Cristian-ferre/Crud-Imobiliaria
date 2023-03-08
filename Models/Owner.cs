using System.Text.Json.Serialization;

namespace imobiliaria.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string NameOwner { get; set; }
        public string PhoneNumber { get; set; }

        //Um proprietario poderá ter varios imoveis
        [JsonIgnore]
        public List<Property> Properties { get; set; }




    }
}
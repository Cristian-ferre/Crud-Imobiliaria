namespace imobiliaria.DTO
{
    public class CreatePropertyDTO
    {
        public string ImgURL { get; set; }

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

        // public int PropertyTypeId {get;set;}

        public int OwnerId { get; set; }
        
        // public int CityId {get;set;}

    }
}
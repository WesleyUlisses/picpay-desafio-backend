namespace CarteiraDigital.Domain.Entities
{
    public class Address
    {
        
        public Address(string street, string number, string complement, string neighborhood, string zipCode, string city, string state, string country)
        {
            Street = street;
            Number = number;
            Complement = complement;
            Neighborhood = neighborhood;
            ZipCode = zipCode;
            City = city;
            State = state;
            Country = country;
        }

        public Address()
        {
        }

        public int AddressID { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}

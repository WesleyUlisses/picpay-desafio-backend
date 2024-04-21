namespace CarteiraDigital.Domain.Entities
{
    public class Agency
    {

        public Agency(string name, string code, Bank bank, string cnpj, string email, string phoneNumber, Address address)
        {
            Name = name;
            Code = code;
            Bank = bank;
            CNPJ = cnpj;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public Agency()
        {
        }

        public int BranchID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Bank Bank { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
    }   
}

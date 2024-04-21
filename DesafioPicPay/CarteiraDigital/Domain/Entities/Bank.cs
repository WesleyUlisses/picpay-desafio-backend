namespace CarteiraDigital.Domain.Entities
{
    public class Bank
    {
        public Bank(string name, string code, string cnpj, string website, string phoneNumber)
        {
            Name = name;
            Code = code;
            CNPJ = cnpj;
            Website = website;
            PhoneNumber = phoneNumber;
        }

        public Bank()
        {
        }

        public int BankID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string CNPJ { get; set; }
        public string Website { get; set; }
        public string PhoneNumber { get; set; }
    }
}

namespace CarteiraDigital.Domain.Entities
{
    public class User
    {
        public User(string name, string email, string password, string phoneNumber, Address address)
        {
            Name = name;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public User()
        {
        }

        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }

    }
}

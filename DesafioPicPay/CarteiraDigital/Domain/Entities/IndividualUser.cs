namespace CarteiraDigital.Domain.Entities
{
    public class IndividualUser : User
    {

        public IndividualUser(string name, string email, string password, string phoneNumber, Address address, string cpf, string birthDate, string sex, string rg, double monthlySalary, string civilStatus, string profession)
        {
            Name = name;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            Address = address;
            CPF = cpf;
            BirthDate = birthDate;
            Sex = sex;
            RG = rg;
            MonthlySalary = monthlySalary;
            CivilStatus = civilStatus;
            Profession = profession;
        }

        public IndividualUser()
        {
        }

        public string CPF { get; set; }
        public string BirthDate { get; set; }
        public string Sex { get; set; }
        public string RG { get; set; }
        public double MonthlySalary { get; set; }
        public string CivilStatus { get; set; }
        public string Profession { get; set; }
    }
}

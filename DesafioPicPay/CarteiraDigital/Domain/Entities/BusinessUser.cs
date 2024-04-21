namespace CarteiraDigital.Domain.Entities;

public class BusinessUser : User
{
    public BusinessUser(string name, string email, string password, string phoneNumber, Address address, string cnpj, string socialReason, string fantasyName, string stateRegistration, string municipalRegistration, string activity, int numberOfEmployees, string legalNature, double annualBilling)
    {
        Name = name;
        Email = email;
        Password = password;
        PhoneNumber = phoneNumber;
        Address = address;
        CNPJ = cnpj;
        SocialReason = socialReason;
        FantasyName = fantasyName;
        StateRegistration = stateRegistration;
        MunicipalRegistration = municipalRegistration;
        Activity = activity;
        NumberOfEmployees = numberOfEmployees;
        LegalNature = legalNature;
        AnnualBilling = annualBilling;
    }

    public BusinessUser()
    {
    }
    
    public string CNPJ { get; set; }
    public string SocialReason { get; set; }
    public string FantasyName { get; set; }
    public string StateRegistration { get; set; }
    public string MunicipalRegistration { get; set; }
    public string Activity { get; set; }
    public int NumberOfEmployees { get; set; }
    public string LegalNature { get; set; }
    public double AnnualBilling { get; set; }


}

namespace CarteiraDigital.Domain.Entities;

public class BusinessUser : User
{
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

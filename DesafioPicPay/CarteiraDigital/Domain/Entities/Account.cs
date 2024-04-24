namespace CarteiraDigital.Domain.Entities
{
    public class Account
    {
        public Account(string accountNumber, string digit, string accountType, decimal balance, Bank bank, Agency branch, User user)
        {
            AccountNumber = accountNumber;
            Digit = digit;
            AccountType = accountType;
            Balance = balance;
            Bank = bank;
            Branch = branch;
            User = user;
        }

        public Account()
        {
        }

        public int AccountID { get; set; }
        public string AccountNumber { get; set; }
        public string Digit { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public Bank Bank { get; set; }
        public Agency Branch { get; set; }
        public User User { get; set; }
    }
}

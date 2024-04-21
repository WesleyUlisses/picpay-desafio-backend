namespace CarteiraDigital.Domain.Entities
{
    public class Transaction
    {
        public Transaction(int transactionId, string type, DateTime dateTime, decimal amount, int titularBranchNumber, int titularAccountNumber, string titularCPF_CNPJ, string titularName, string recipientCPF_CNPJ, string recipientName, int recipientBranchNumber, int recipientAccountNumber, string titularBankName, string recipientBankName)
        {
            TransactionId = transactionId;
            Type = type;
            DateTime = dateTime;
            Amount = amount;
            TitularBranchNumber = titularBranchNumber;
            TitularAccountNumber = titularAccountNumber;
            TitularCPF_CNPJ = titularCPF_CNPJ;
            TitularName = titularName;
            RecipientCPF_CNPJ = recipientCPF_CNPJ;
            RecipientName = recipientName;
            RecipientBranchNumber = recipientBranchNumber;
            RecipientAccountNumber = recipientAccountNumber;
            TitularBankName = titularBankName;
            RecipientBankName = recipientBankName;
        }

        public Transaction()
        {
        }

        public int TransactionId { get; set; }
        public string Type { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Amount { get; set; }
        public int TitularBranchNumber { get; set; }
        public int TitularAccountNumber { get; set; }
        public string TitularCPF_CNPJ { get; set; }
        public string TitularName { get; set; }
        public string RecipientCPF_CNPJ { get; set; }
        public string RecipientName { get; set; }
        public int RecipientBranchNumber { get; set; }
        public int RecipientAccountNumber { get; set; }
        public string TitularBankName { get; set; }
        public string RecipientBankName { get; set; }   
    }
}

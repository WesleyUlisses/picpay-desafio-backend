namespace CarteiraDigital.Domain.Entities
{
    public class Receipt
    {
        public Receipt(int receiptId, User user, Transaction transaction)
        {
            ReceiptId = receiptId;
            User = user;
            Transaction = transaction;
        }

        public Receipt()
        {
        }

        public int ReceiptId { get; set; }
        public User User { get; set; }
        public Transaction Transaction { get; set; }
    }
}

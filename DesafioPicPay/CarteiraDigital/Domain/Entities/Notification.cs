namespace CarteiraDigital.Domain.Entities
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsRead { get; set; }
        public Receipt Receipt { get; set; }
        public string Status { get; set; }
        public string Error { get; set; }
    }
}

namespace EBaking_API.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public decimal Amount { get; set; } 
        public DateTime Date { get; set; } 
        public string Description { get; set; }
    }
}

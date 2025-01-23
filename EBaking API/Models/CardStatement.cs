using System.Transactions;

namespace EBaking_API.Models
{
    public class CardStatement
    {
        public int CardId { get; set; } // The card ID
        public string CardHolder { get; set; } // Cardholder's name
        public DateTime StatementDate { get; set; } // The date of the statement
        public decimal Balance { get; set; } // Current balance on the card
        public List<Transaction> Transactions { get; set; } // List of transactions for this statement
    }
}

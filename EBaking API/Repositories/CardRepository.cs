using EBaking_API.Interfaces;
using EBaking_API.Models;

namespace EBaking_API.Repositories
{
    public class CardRepository : ICardRepository
    {
        public async Task<CardStatement> GetCardStatementAsync(int cardId)
        {
            // Simulating fetching data from a database or API
            return new CardStatement
            {
                CardId = cardId,
                CardHolder = "John Doe",
                StatementDate = DateTime.Now,
                Balance = 500.00m,
                Transactions = new List<Transaction>
                {
                    new Transaction { TransactionId = 1, Amount = 100.00m, Date = DateTime.Now.AddDays(-1), Description = "Purchase at Store" },
                    new Transaction { TransactionId = 2, Amount = 50.00m, Date = DateTime.Now.AddDays(-2), Description = "Grocery shopping" }
                }
            };
        }

        public async Task<IEnumerable<Transaction>> GetTransactionsAsync(int cardId)
        {
            return new List<Transaction>
            {
                new Transaction { TransactionId = 1, Amount = 100.00m, Date = DateTime.Now.AddDays(-1), Description = "Purchase at Store" },
                new Transaction { TransactionId = 2, Amount = 50.00m, Date = DateTime.Now.AddDays(-2), Description = "Grocery shopping" }
            };
        }
    }
}

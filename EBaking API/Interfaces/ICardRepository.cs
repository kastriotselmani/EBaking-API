using EBaking_API.Models;

namespace EBaking_API.Interfaces
{
    public interface ICardRepository
    {
        Task<CardStatement> GetCardStatementAsync(int cardId);
        Task<IEnumerable<Transaction>> GetTransactionsAsync(int cardId);
    }
}

using EBaking_API.Interfaces;
using EBaking_API.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace EBaking_API.Services
{
    public class CardService : ICardService
    {
        private readonly ICardRepository _cardRepository;

        public CardService(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public async Task<CardStatement> GetCardStatementAsync(int cardId)
        {
            return await _cardRepository.GetCardStatementAsync(cardId);
        }

        public async Task<IEnumerable<Transaction>> GetTransactionsAsync(int cardId)
        {
            return await _cardRepository.GetTransactionsAsync(cardId);
        }
    }
}

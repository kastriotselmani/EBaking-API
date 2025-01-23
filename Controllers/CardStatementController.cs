using EBaking_API.Interfaces;
using EBaking_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace EBaking_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardStatementController : ControllerBase
    {
        private readonly ICardService _cardService;

        public CardStatementController(ICardService cardService)
        {
            _cardService = cardService;
        }

        // Endpoint to get card statement
        [HttpGet("{id}")]
        public async Task<ActionResult<CardStatement>> GetCardStatement(int id)
        {
            var statement = await _cardService.GetCardStatementAsync(id);
            if (statement == null)
            {
                return NotFound();

            }

            return Ok(statement);
        }
      
    }
}
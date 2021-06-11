using KeyForgeDCM_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KeyForgeDCM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly KeyForgeDCMContext _context;

        public CardsController(KeyForgeDCMContext context)
        {
            _context = context;
        }

        // GET: api/Decks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Card>>> GetCards()
        {
            return await _context.Cards.ToListAsync();
        }

        // GET: api/Decks/{id}
        [HttpGet("api/Cards/{id}")]
        public async Task<ActionResult<IEnumerable<Card>>> GetCardById(int id)
        {
            return await _context.Cards.Where(c => c.CardId == id).ToListAsync();
        }
    }
}

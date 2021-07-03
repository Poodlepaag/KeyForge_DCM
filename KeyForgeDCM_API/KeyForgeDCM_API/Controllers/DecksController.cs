using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KeyForgeDCM_API.Models;

namespace KeyForgeDCM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecksController : ControllerBase
    {
        private readonly KeyForgeDCMContext _context;

        public DecksController(KeyForgeDCMContext context)
        {
            _context = context;
        }

        // GET: api/Decks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Deck>>> GetDecks()
        {
            return await _context.Decks.ToListAsync();
        }

        // GET: api/Decks/{id}
        [HttpGet("api/Decks/{id}")]
        public async Task<ActionResult<IEnumerable<Deck>>> GetDeckById(int id)
        {
            return await _context.Decks.Where(d => d.DeckId == id).ToListAsync();
        }

        // POST: api/Decks/{id}
        [HttpPost("api/Decks/Delete/{id}")]
        public void DeleteDeckById(int id)
        {
            var deckToRemove = _context.Decks.SingleOrDefault(d => d.DeckId == id);

            if (deckToRemove != null)
            {
                _context.Decks.Remove(deckToRemove);
                Console.WriteLine("Deck removed!");
            }
            else
            {
                Console.WriteLine("Deck was not found");
            }
            
            _context.SaveChanges();
        }
    }
}

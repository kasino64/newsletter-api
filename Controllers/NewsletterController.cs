using Microsoft.AspNetCore.Mvc;
using NewsletterApi.Data;
using NewsletterApi.Models;
using Microsoft.EntityFrameworkCore;

namespace NewsletterApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsletterController : ControllerBase
    {
        private readonly NewsletterDbContext _context;

        public NewsletterController(NewsletterDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<NewsletterSubscription>> PostNewsletterSubscription(NewsletterSubscription subscription)
        {
            if (_context.NewsletterSubscriptions.Any(e => e.Email == subscription.Email))
            {
                return Conflict(new { message = "Email is already subscribed." });
            }

            _context.NewsletterSubscriptions.Add(subscription);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetNewsletterSubscription), new { id = subscription.Id }, subscription);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<NewsletterSubscription>>> GetNewsletterSubscriptions()
        {
            return await _context.NewsletterSubscriptions.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NewsletterSubscription>> GetNewsletterSubscription(int id)
        {
            var subscription = await _context.NewsletterSubscriptions.FindAsync(id);

            if (subscription == null)
            {
                return NotFound();
            }

            return subscription;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNewsletterSubscription(int id)
        {
            var subscription = await _context.NewsletterSubscriptions.FindAsync(id);
            if (subscription == null)
            {
                return NotFound();
            }

            _context.NewsletterSubscriptions.Remove(subscription);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

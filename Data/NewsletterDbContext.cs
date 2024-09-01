using Microsoft.EntityFrameworkCore;
using NewsletterApi.Models;

namespace NewsletterApi.Data
{
    public class NewsletterDbContext : DbContext
    {
        public NewsletterDbContext(DbContextOptions<NewsletterDbContext> options) : base(options)
        {
        }

        public DbSet<NewsletterSubscription> NewsletterSubscriptions { get; set; }
    }
}
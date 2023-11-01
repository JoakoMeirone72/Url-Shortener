using Microsoft.EntityFrameworkCore;
using Url_Shortener.Entities;
using Url_Shortener.Models;

namespace Url_Shortener.Data
{
    public class UrlShortenerContext : DbContext
    {
        public UrlShortenerContext(DbContextOptions<UrlShortenerContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<URL> Urls { get; set; }

    }
}

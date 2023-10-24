using Microsoft.EntityFrameworkCore;
using Url_Shortener.Models;

namespace Url_Shortener.Data
{
    public class UrlShortenerContext : DbContext
    {
        public UrlShortenerContext(DbContextOptions<UrlShortenerContext> options) : base(options)
        {
        }

        public DbSet<UrlForCreationDto> UserUrl { get; set; }

    }
}

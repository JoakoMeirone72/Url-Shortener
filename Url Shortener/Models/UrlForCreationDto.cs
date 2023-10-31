using System.ComponentModel.DataAnnotations;

namespace Url_Shortener.Models
{
    public class UrlForCreationDto
    {
        public int Id { get; set; }

        [Required]
        public string? Url { get; set; }

        [Required]
        public string? ShortUrl { get; set; }

        [Required]
        public int ContadorVisitas { get; set; }

        [Required]
        public CategoriaEnum Categoria { get; set; }
    }
}

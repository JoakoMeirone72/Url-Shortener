using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Url_Shortener.Models;

namespace Url_Shortener.Entities
{
    public class URL
    {
        public string? Url { get; set; }

        public CategoriaEnum Categoria { get; set; }

    }
}

using Microsoft.AspNetCore.Mvc;
using Url_Shortener.Data;
using Url_Shortener.Entities;
using Url_Shortener.Helpers;
using Url_Shortener.Models;

namespace Url_Shortener.Controllers
{
    [ApiController]
    [Route(template: "api/[controller]")]
    public class UrlController : Controller
    {
        private readonly UrlShortenerContext _UrlContext;

        public UrlController(UrlShortenerContext UrlContext)
        {
            _UrlContext = UrlContext;
        }

        [HttpGet("get")]

        public IActionResult GetUrl(string ClientUrl)
        {
            var urlEntity = _UrlContext.UserUrl.FirstOrDefault(x => x.ShortUrl == ClientUrl);

            if (urlEntity == null)
            {
                return NotFound("La URL no existe");
            }
            urlEntity.ContadorVisitas += 1;
            _UrlContext.SaveChanges();
            return Ok(urlEntity.Url);
            //return Redirect(urlEntity.Url);
        }

        [HttpPost("post")]
        public IActionResult CreateNewURL(string newurl)
        {
            var urlHelper = new UrlHelper();
            var urlEntity = new UrlForCreationDto()
            {
                Url = newurl, 
                ShortUrl = urlHelper.GetShortURL()
            };
            _UrlContext.UserUrl.Add(urlEntity);
            _UrlContext.SaveChanges();
            return Ok(urlEntity.ShortUrl);
        }

    }
}

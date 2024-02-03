using Microsoft.AspNetCore.Mvc;
using System.Xml.Serialization;
using System;
using ClickMe.App.Models;

namespace ClickMe.App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UrlShortenerController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public UrlShortenerController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult ShortenUrl([FromBody] string originalUrl)
        {
            if (string.IsNullOrWhiteSpace(originalUrl))
                return BadRequest("Original URL cannot be empty.");

            var existingUrl = _dbContext.UrlMappings.FirstOrDefault(u => u.OriginalUrl == originalUrl);
            if (existingUrl != null)
                return Ok(existingUrl.ShortenedUrl);

            var url = new UrlEntity { OriginalUrl = originalUrl };

            _dbContext.UrlMappings.Add(url);
            _dbContext.SaveChanges();

            return Ok(url.ShortenedUrl);
        }

        [HttpGet("{shortenedUrl}")]
        public IActionResult RedirectToOriginalUrl(string shortenedUrl)
        {
            var mapping = _dbContext.UrlMappings.FirstOrDefault(u => u.ShortenedUrl == shortenedUrl);
            if (mapping == null)
                return NotFound();

            return Redirect(mapping.OriginalUrl);
        }
    }
}

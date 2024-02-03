using ClickMe.App.Models;

namespace ClickMe.App.Abstractions
{
    public interface IUrlRepository
    {
        Task<string> GetByUrl(string url);
        Task<bool> Insert(UrlEntity url);
    }
}

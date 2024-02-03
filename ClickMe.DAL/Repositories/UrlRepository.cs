using ClickMe.App.Abstractions;
using ClickMe.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickMe.DAL.Repositories
{
    internal class UrlRepository : IUrlRepository
    {
        public Task<string> GetByUrl(string url)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insert(UrlEntity url)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using Microsoft.AspNetCore.Http;

namespace Bookstore2.Infrastructure
{
    public static class UrlExtensions
    {
        //path and query for our urls
        public static string PathAndQuery(this HttpRequest request) =>
            request.QueryString.HasValue ? $"{request.Path}{request.QueryString}" : request.Path.ToString();
    }
}


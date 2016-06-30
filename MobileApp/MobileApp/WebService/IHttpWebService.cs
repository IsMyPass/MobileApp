using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.WebService
{
    interface IHttpWebService
    {
        Task<HttpResponseMessage> GetAsync(string url);

        Task<T> ReadContentAsync<T>(HttpResponseMessage response);
    }
}

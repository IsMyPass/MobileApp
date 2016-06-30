using ModernHttpClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MobileApp.WebService
{
    public class HttpWebService : IHttpWebService
    {
        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            using (var client = new HttpClient(new NativeMessageHandler()))
            {
                client.Timeout = TimeSpan.FromSeconds(10);
                try
                {
                    var address = "http://jsonplaceholder.typicode.com/todos/1";
                    var response = await client.GetAsync(address);
                    return response;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public async Task<T> ReadContentAsync<T>(HttpResponseMessage response)
        {
            var message = await response.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<T>(message);
            return content;
        }
    }
}

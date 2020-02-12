using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebProjectSample.Helper
{
    public class MyAPI
    {
        public HttpClient GetClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5066/");
            return client;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EczaneHangFire.Helper
{
    public class BaseAdress
    {
       

        public HttpClient httpClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://www.nosyapi.com/apiv2/");
            client.Timeout = TimeSpan.FromSeconds(5);
            client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
            client.DefaultRequestHeaders.Add("Authorization", "Bearer K313yic05wwpc6le0MMnm0zVRr1f2uiJORchBxIXiNOU9juRgw34yJJzxzMr");

            return client;
        }
    }
}

using ESupplierPresentation.Models;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ESupplierPresentation.Integration
{
    public class ProxyWinners
    {
        HttpClient client = new HttpClient();
        readonly string BASE_URI = "http://localhost:58251/api/winners";

        public List<Winners> GetWinners()
        {
            string serviceUri = $"{BASE_URI}";
            Task<String> response = client.GetStringAsync(serviceUri);
            return JsonConvert.DeserializeObject<List<Winners>>(response.Result);
        }
    }
}
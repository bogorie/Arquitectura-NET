using ESupplierPresentation.Models;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ESupplierPresentation.Views;

namespace ESupplierPresentation.Integration
{
    public class ProxyQueryAuction
    {
        
        HttpClient client = new HttpClient();
        readonly string BASE_URI = "http://localhost:?/api/....";

        public List<Auction> GetAuction()
        {
            string serviceUri = $"{BASE_URI}";
            Task<String> response = client.GetStringAsync(serviceUri);
            return JsonConvert.DeserializeObject<List<Auction>>(response.Result);
        }

        public Auction GetAuctionDetails(string startDate, string endDate)
        {
            string serviceUri = $"{BASE_URI}/{startDate}/{endDate}";
            Task<String> response = client.GetStringAsync(serviceUri);
            return JsonConvert.DeserializeObject<Auction>(response.Result);
        }

        public Auction query(Auction auction)
        {
            String startDate = auction.startdate;
            String endDate = auction.closedate;
            string serviceUri = $"{BASE_URI}/{startDate}/{endDate}";
            Task<String> response = client.GetStringAsync(serviceUri);
            return JsonConvert.DeserializeObject<Auction>(response.Result);
        }

        private ConsumeJaxWs.WsSoapQueryAuctionClient consumidorJaxWs = new ConsumeJaxWs.WsSoapQueryAuctionClient();
        private AuctionController controlador;
        

       
        public void ConsumeGetAuctionByDates(String fechaA, String fechaB)
        {
            ConsumeJaxWs.auction [] retorno ;
            retorno = consumidorJaxWs.getAcutionByDates(fechaA, fechaB);
            controlador.recibeJava(retorno);
        }
    }
}
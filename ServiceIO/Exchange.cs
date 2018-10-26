using EntityRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace ServiceIO
{
    public class Exchange
    {
        private const string APP_ID = "5cf47e89535d41d9a7eb81d950673c02"; //Daniel Api
        string responseStream = "";
        List <Rates> rates = new List<Rates>();
        private HttpClient client;

        public Exchange()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://openexchangerates.org/api/");
            GetDataFromApiAsync();
        }

        public Exchange(List<Rates> rates)
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://openexchangerates.org/api/");
            this.rates = rates;
            GetDataFromApiAsync();
        }

        public DollarRates GetCurrencyFromOpenExchangeRate()
        {
            while (responseStream == "")
            {
                Thread.Sleep(50);
            }

            return JsonConvert.DeserializeObject<DollarRates>(responseStream);
        }

        private async void GetDataFromApiAsync()
        {
            while (true)
            {
                try
                {
                    string query = $"latest.json?app_id={APP_ID}";
                    HttpResponseMessage responseMessageExchange = await client.GetAsync(query);

                    responseStream = await responseMessageExchange.Content.ReadAsStringAsync();

                    await Task.Delay(11000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}

using DevExpress.Map.Native;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidTracking
{
    public class DataSourceProvice
    {
         List<Root> data { get; set; } 
        DataSourceProvice()
        {
            var client = new RestClient("https://covid19.ncsc.gov.vn/api/v3/covid/provinces");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            // Console.WriteLine(response.Content);
            data = JsonConvert.DeserializeObject<List<Root>>(response.Content.ToString());
        }
      
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class Root
    {
        public int id { get; set; }
        public string name { get; set; }
        public int population { get; set; }
        public int new_case { get; set; }
        public int new_death { get; set; }
        public int new_recovered { get; set; }
        public int new_active { get; set; }
        public int total_case { get; set; }
        public int total_death { get; set; }
        public int total_active { get; set; }
        public int total_recovered { get; set; }
        public int death_yesterday { get; set; }
        public int case_yesterday { get; set; }
        public int recovered_yesterday { get; set; }
        public int death_average_7days { get; set; }
        public int case_average_7days { get; set; }
        public double percent_case_population { get; set; }
        public string last_updated { get; set; }
    }


}

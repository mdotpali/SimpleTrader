using Newtonsoft.Json;
using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.FinancialModelingPrepAPI.Services
{
    public class MajorIndexService : IMajorIndexService
    {
        public async Task<MajorIndex> GetMajorIndex(MajorIndexType indexType)
        {
            using(HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://financialmodelingprep.com/api/v3/profile/AAPL?apikey=u5iV71xU2v4uxxDyauuxEcg25I4qqq17");
                string jsonResponse = await response.Content.ReadAsStringAsync();
                
                MajorIndex majorIndex = JsonConvert.DeserializeObject<MajorIndex>(jsonResponse);
                return majorIndex;
            }
        }
    }
}

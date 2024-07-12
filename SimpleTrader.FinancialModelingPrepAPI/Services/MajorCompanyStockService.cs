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
    public class MajorCompanyStockService : IMajorCompanyService
    {
        public async Task<MajorCompanyStock> GetMajorIndex(MajorCompanyName indexType)
        {
            using(HttpClient client = new HttpClient())
            {
                
                string uri = $"https://financialmodelingprep.com/api/v3/profile/{GetUriSuffix(indexType)}?apikey=u5iV71xU2v4uxxDyauuxEcg25I4qqq17";
                
                HttpResponseMessage response = await client.GetAsync(uri);
                string jsonResponse = await response.Content.ReadAsStringAsync();
                
                var majorIndex = JsonConvert.DeserializeObject<List<MajorCompanyStock>>(jsonResponse);
                majorIndex[0].MajorCompanyName = indexType;
                return majorIndex[0];
            }
        }

        private string GetUriSuffix(MajorCompanyName companyName)
        {
            switch (companyName)
            {
                case MajorCompanyName.Apple:
                    return "AAPL";
                case MajorCompanyName.Microsoft:
                    return "MSFT";
                case MajorCompanyName.Nvidia:
                    return "NVDA";
                case MajorCompanyName.Google:
                    return "GOOGL";
                case MajorCompanyName.Tesla:
                    return "TSLA";
                default:
                    return "AAPL";
            }
        }
    }
}

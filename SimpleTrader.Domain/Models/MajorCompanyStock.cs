using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.Domain.Models
{
    public enum MajorCompanyName
    {
        Apple,
        Nvidia,
        Microsoft,
        Google,
        Tesla
    }
    public class MajorCompanyStock
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }
        
        [JsonProperty("price")]
        public double Price{ get; set; }

        [JsonProperty("changes")]
        public double Changes{ get; set; }

        public MajorCompanyName MajorCompanyName { get; set; }
    }
}

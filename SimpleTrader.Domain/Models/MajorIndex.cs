using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.Domain.Models
{
    public enum MajorIndexType
    {
        DowJones,
        Nasdaq,
        SP500,
        AAPL
    }
    public class MajorIndex
    {
        public string Symbol{ get; set; }
        public double Price{ get; set; }
        public double Beta{ get; set; }
        public MajorIndexType Type{ get; set; }
    }
}

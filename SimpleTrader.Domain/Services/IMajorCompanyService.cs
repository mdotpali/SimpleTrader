using SimpleTrader.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.Domain.Services
{
    public interface IMajorCompanyService
    {
        Task<MajorCompanyStock> GetMajorIndex(MajorCompanyName companyName);
    }
}

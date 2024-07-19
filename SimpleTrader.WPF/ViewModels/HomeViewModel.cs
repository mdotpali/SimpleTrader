using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.WPF.ViewModels
{
    public class HomeViewModel:ViewModelBase
    {

        public MajorCompanyListingViewModel MajorCompanyListingViewModel { get; set; }

        public HomeViewModel(MajorCompanyListingViewModel majorCompanyListingViewModel)
        {
            MajorCompanyListingViewModel = majorCompanyListingViewModel;
        }


    }
}

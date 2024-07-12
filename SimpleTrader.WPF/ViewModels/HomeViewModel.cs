using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.WPF.ViewModels
{
    public class HomeViewModel:ViewModelBase
    {

        public MajorCompanyViewModel MajorCompanyViewModel { get; set; }

        public HomeViewModel(MajorCompanyViewModel majorCompanyViewModel)
        {
            MajorCompanyViewModel = majorCompanyViewModel;
        }


    }
}

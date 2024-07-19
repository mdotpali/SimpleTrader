using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.WPF.ViewModels
{
    public class MajorCompanyListingViewModel : ViewModelBase
    {
        private readonly IMajorCompanyService _majorCompanyService;


        private MajorCompanyStock _apple;
        public MajorCompanyStock Apple
        {
            get
            {

                return _apple;
            }
            set
            {
                _apple = value;
                OnPropertyChanged(nameof(Apple));
            }
        }

        private MajorCompanyStock _nvidia;
        public MajorCompanyStock Nvidia
        {
            get { return _nvidia; }
            set
            {
                _nvidia = value;
                OnPropertyChanged(nameof(Nvidia));
            }
        }

        private MajorCompanyStock _microsoft;

        public MajorCompanyStock Microsoft
        {
            get { return _microsoft; }
            set
            {
                _microsoft = value;
                OnPropertyChanged(nameof(Microsoft));
            }
        }

        private MajorCompanyStock _google;

        public MajorCompanyStock Google
        {
            get { return _google; }
            set { _google = value; OnPropertyChanged(nameof(Google)); }
        }

        private MajorCompanyStock _tesla;

        public MajorCompanyStock Tesla
        {
            get { return _tesla; }
            set { _tesla = value; OnPropertyChanged(nameof(Tesla)); }
        }


        public MajorCompanyListingViewModel(IMajorCompanyService majorCompanyService)
        {
            this._majorCompanyService = majorCompanyService;
        }

        public static MajorCompanyListingViewModel LoadMajorCompanyViewModel(IMajorCompanyService minorCompanyService)
        {
            MajorCompanyListingViewModel majorCompanyViewModel = new MajorCompanyListingViewModel(minorCompanyService);
            majorCompanyViewModel.LoadMajorCompanyStock();
            return majorCompanyViewModel;
        }
        private void LoadMajorCompanyStock()
        {
            _majorCompanyService.GetMajorIndex(MajorCompanyName.Apple).ContinueWith(task =>
            {
                if (task.Exception == null)
                {
                    Apple = task.Result;
                }
            });
            _majorCompanyService.GetMajorIndex(MajorCompanyName.Nvidia).ContinueWith(task =>
            {
                if (task.Exception == null)
                {
                    Nvidia = task.Result;
                }
            });
            _majorCompanyService.GetMajorIndex(MajorCompanyName.Microsoft).ContinueWith(task =>
            {
                if (task.Exception == null)
                {
                    Microsoft = task.Result;
                }
            });
            _majorCompanyService.GetMajorIndex(MajorCompanyName.Google).ContinueWith(task =>
            {
                if (task.Exception == null)
                {
                    Google = task.Result;
                }
            });
            _majorCompanyService.GetMajorIndex(MajorCompanyName.Tesla).ContinueWith(task =>
            {
                if (task.Exception == null)
                {
                    Tesla = task.Result;
                }
            });
        }
    }
}

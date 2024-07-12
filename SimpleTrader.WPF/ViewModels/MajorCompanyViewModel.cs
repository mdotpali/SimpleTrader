using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.WPF.ViewModels
{
    public class MajorCompanyViewModel
    {
        private readonly IMajorCompanyService _majorCompanyService;



        public MajorCompanyStock Apple { get; set; }
        public MajorCompanyStock Nvidia { get; set; }
        public MajorCompanyStock Microsoft { get; set; }
        public MajorCompanyStock Google { get; set; }
        public MajorCompanyStock Tesla { get; set; }

        public MajorCompanyViewModel(IMajorCompanyService majorCompanyService)
        {
            this._majorCompanyService = majorCompanyService;
        }

        public static MajorCompanyViewModel LoadMajorCompanyViewModel(IMajorCompanyService minorCompanyService)
        {
            MajorCompanyViewModel majorCompanyViewModel = new MajorCompanyViewModel(minorCompanyService);
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
            { if (task.Exception == null) { 
                    Google = task.Result; 
                } });
            _majorCompanyService.GetMajorIndex(MajorCompanyName.Tesla).ContinueWith(task => { if (task.Exception == null) { 
                    Tesla = task.Result; 
                } });
        }
    }
}

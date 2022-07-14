using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModels
{
    public partial class HomeViewModel
    {
        INavigationService _navigationService;
        [RelayCommand]
        public async void Back()
        {
             await _navigationService.GoBackAsync();
        }

        public HomeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}

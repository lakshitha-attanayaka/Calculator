using Calculator.Services.Abstractions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        IAuthService _auth;
        INavigationService _navigationService;
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        private string _userName;
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        private string _password;

        public string FullName => $"{UserName} {Password}";

        [RelayCommand]
        void Tap()
        {
            _navigationService.CreateBuilder().AddSegment<HomeViewModel>().Navigate();
        }

        public LoginViewModel(IAuthService authService, INavigationService navigationService)
        {
            _auth = authService;
            _navigationService = navigationService;
        }
    }
}

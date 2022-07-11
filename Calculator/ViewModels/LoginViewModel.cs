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
            _auth.Login(new Models.Auth {
                UserName = UserName,
                Password = Password
            });
        }

        public LoginViewModel(IAuthService authService)
        {
            _auth = authService;
        }
    }
}

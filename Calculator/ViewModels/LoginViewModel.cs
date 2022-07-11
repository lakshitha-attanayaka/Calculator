using CommunityToolkit.Mvvm.ComponentModel;
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
        [ObservableProperty]
        private string _userName;
        [ObservableProperty]
        private string _password;

        //[ICommand]
        void Tap()
        {
            Debug.WriteLine($"{UserName} {Password}");
        }

        public LoginViewModel()
        {
        }
    }
}

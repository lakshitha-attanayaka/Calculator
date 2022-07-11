using Calculator.Models;
using Calculator.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public class AuthService : IAuthService
    {
        public AuthService()
        {

        }
        public void Login(Auth auth)
        {
            if (auth.UserName == "admin" && auth.Password == "password")
            {
                App.Current.MainPage.Navigation.PushAsync(new Home());
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Login Error", "User name or password incorrect", "OK");
            }
        }
    }
}

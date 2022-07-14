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
        public bool Login(Auth auth)
        {
            return (auth.UserName == "admin" && auth.Password == "password");
        }
    }
}

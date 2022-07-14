using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Services.Abstractions
{
    public interface IAuthService
    {
        bool Login(Auth auth);
    }
}

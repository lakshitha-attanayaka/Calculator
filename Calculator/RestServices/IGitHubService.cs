using Calculator.Models;
using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.RestServices
{
    [Header("User-Agent", "RestEase")]
    public interface IGitHubService
    {
        [Get("/users/{username}")]
        Task<GitHubUser>GetUser([Path] string username);
    }
}

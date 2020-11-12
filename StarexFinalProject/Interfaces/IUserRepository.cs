using Microsoft.AspNetCore.Identity;
using StarexFinal.ViewModels;
using StarexFinalProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarexFinalProject.Interfaces
{
    public  interface IUserRepository
    {
        Task<IdentityResult> Create(UserViewModel userViewModel);
        Task<SignInResult>  Login(LoginViewModel loginViewModel);
        Task<UserViewModel> GetById(string id);
    }
}

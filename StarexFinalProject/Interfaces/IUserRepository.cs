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
        IdentityResult Create(UserViewModel userViewModel);
        SignInResult  Login(LoginViewModel loginViewModel);
        UserViewModel GetById(string id);
    }
}

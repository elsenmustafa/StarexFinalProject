using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StarexFinal.Models;
using StarexFinal.ViewModels;
using StarexFinalProject.Interfaces;
using StarexFinalProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarexFinalProject.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<AppUsers> _userManager;
        private readonly SignInManager<AppUsers> _signInManager;
        public UserRepository(UserManager<AppUsers> userManager, SignInManager<AppUsers> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<IdentityResult> Create(UserViewModel userViewModel)
        {
            AppUsers users = new AppUsers()
            {
                AppUserId=userViewModel.AppUserId,
                Name=userViewModel.Name,
                Surname=userViewModel.Surname,
                Gender=userViewModel.Gender,
                BirthDate=userViewModel.BirthDate,
                Adress=userViewModel.Adress,
                WareHousesId=userViewModel.WareHousesId,
                GovIdPrefix=userViewModel.GovIdPrefix,
                GovId=userViewModel.GovId,
                FIN=userViewModel.FIN
            };
            return await _userManager.CreateAsync(users);
     
        }

        public async Task<UserViewModel> GetById(string id)
        {
           var AppUserResult= await _userManager.FindByIdAsync(id);
            UserViewModel userViewModel = new UserViewModel
            {
                 Adress=AppUserResult.Adress,
                 Name=AppUserResult.Name,
                 Email=AppUserResult.Email,
                 Surname=AppUserResult.Surname,
                 BirthDate=AppUserResult.BirthDate,
                 FIN=AppUserResult.FIN,
                 Gender=AppUserResult.Gender,
                 GovId=AppUserResult.GovId,
                 GovIdPrefix=AppUserResult.GovIdPrefix,
                 Password=AppUserResult.PasswordHash,
                 
                 
            };
            return await Task.FromResult(userViewModel);
        }

        public async Task<SignInResult> Login(LoginViewModel loginViewModel)
        {
            SignInResult signInResult=null;
            var resultUser = await _userManager.FindByEmailAsync(loginViewModel.Email);
            if (resultUser!=null)
            {
                signInResult= await _signInManager.PasswordSignInAsync(resultUser, loginViewModel.Password, true, true);
            }
            return signInResult;
        }

      

       

       
    }
}

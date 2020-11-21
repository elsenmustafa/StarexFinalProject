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
            AppUsers user = new AppUsers()
            {
                Name=userViewModel.Name,
                UserName = userViewModel.Email, 
                Surname = userViewModel.Surname,
                Gender = userViewModel.Gender,
                BirthDate = userViewModel.BirthDate,
                Adress = userViewModel.Adress,
                WarehouseId = userViewModel.WareHousesId,
                GovIdPrefix = userViewModel.GovIdPrefix,
                GovId = userViewModel.GovId,
                FIN = userViewModel.FIN
            };

            return await _userManager.CreateAsync(user,userViewModel.Password);
        }

        public async Task<UserViewModel> GetById(string id)
        {
            var AppUserResult = await _userManager.FindByIdAsync(id);
            UserViewModel userViewModel = new UserViewModel
            {
                Adress = AppUserResult.Adress,
                Name = AppUserResult.Name,
                Email = AppUserResult.Email,
                Surname = AppUserResult.Surname,
                BirthDate = AppUserResult.BirthDate,
                FIN = AppUserResult.FIN,
                Gender = AppUserResult.Gender,
                GovId = AppUserResult.GovId,
                GovIdPrefix = AppUserResult.GovIdPrefix,
                Password = AppUserResult.PasswordHash,
            };
            return await Task.FromResult(userViewModel);
        }

        public async Task<SignInResult> Login(LoginViewModel loginViewModel)
        {
            var signInResult = await _signInManager.PasswordSignInAsync(
                loginViewModel.Email, loginViewModel.Password, false, false);

            return signInResult;
            
        }
    }
}

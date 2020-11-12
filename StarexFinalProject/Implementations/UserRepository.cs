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
       
        public IdentityResult Create(UserViewModel userViewModel)
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
            return null;
            
        }

        public UserViewModel GetById(string id)
        {
            throw new NotImplementedException();
        }

        public SignInResult Login(LoginViewModel loginViewModel)
        {
            throw new NotImplementedException();
        }

        SignInResult IUserRepository.Login(LoginViewModel loginViewModel)
        {
            throw new NotImplementedException();
        }
    }
}

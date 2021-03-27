﻿using System.Threading.Tasks;
using Domain.Entities.User;
using Microsoft.AspNetCore.Identity;

namespace Application.Contracts
{
   public interface IAppUserManager
   {
       Task<IdentityResult> CreateUser(User user);
       Task<bool> IsExistUser(string phoneNumber);
       Task<bool> IsExistUserName(string userName);
       Task<string> GeneratePhoneNumberToken(User user, string phoneNumber);
       Task<User> GetUserByCode(string code);
       Task<IdentityResult> ChangePhoneNumber(User user, string phoneNumber, string code);
       Task<bool> VerifyUserCode(User user,string code);
       Task<string> GenerateOtpCode(User user);
       Task<User> GetUserByPhoneNumber(string phoneNumber);
    }
}

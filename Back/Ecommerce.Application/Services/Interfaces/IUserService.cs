using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Application.Dtos;
using Ecommerce.Domain.Identity;
using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<bool> UserExists(string email);
        Task<UserUpdateDto> GetUserByEmailAsync(string email);
        Task<SignInResult> CheckUserPassWordAsync(UserUpdateDto user, string passWord);
        Task<UserUpdateDto> CreateAccountAsync(UserDto user);
        Task<UserUpdateDto> UpdateAccountAsync(UserUpdateDto user);
    }
}
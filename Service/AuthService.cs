using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthAPI.Service.IService;
using AuthAPI.Models.Dto;
using AuthAPI.Data;
using AuthAPI.Models;
using Microsoft.AspNetCore.Identity;

namespace AuthAPI.Service
{
    public class AuthService(AppDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager) : IAuthService
    {
        private readonly AppDbContext _context = context;
        private readonly UserManager<ApplicationUser> _userManager = userManager;
        private readonly RoleManager<IdentityRole> _roleManager = roleManager;

        public async Task<string> Register(RegistrationRequestDto registrationRequestDto)
        {
            ApplicationUser user = new()
            {
                UserName = registrationRequestDto.Email,
                Email = registrationRequestDto.Email,
                NormalizedEmail = registrationRequestDto.Email.ToUpper(),
                Name = registrationRequestDto.Name,
                PhoneNumber = registrationRequestDto.PhoneNumber
            };

            try
            {
                var result = await _userManager.CreateAsync(user, registrationRequestDto.Password);
                if (result.Succeeded)
                {
                    var userToReturn = _context.ApplicationUsers.First(u => u.UserName == registrationRequestDto.Email);

                    UserDto userDto = new()
                    {
                        Id = userToReturn.Id,
                        Name = userToReturn.Name,
                        Email = userToReturn.Email,
                        PhoneNumber = userToReturn.PhoneNumber
                    };
                    return "";
                }
                else
                {
                    return result.Errors.First().Description;
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
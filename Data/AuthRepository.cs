using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;

namespace dotnet_rpg.Data
{
    public class AuthRepository : IAuthRepository
    {
        public Task<ServiceResponse<string>> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<int>> Register(User user, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserExist(string username)
        {
            throw new NotImplementedException();
        }
    }
}
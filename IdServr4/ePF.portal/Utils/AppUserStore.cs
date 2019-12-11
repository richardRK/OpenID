using ePF.portal.Core.Repositories;
using ePF.portal.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ePF.portal.Utils
{
    public class AppUserStore : IUserStore<Users>, IUserPasswordStore<Users>
    {


        private readonly IUsersRepository _aspNetUsersRepository;

        private readonly IUserPasswordRepository _userPasswordRepository;


        public AppUserStore(

           //Repository<AspNetUsers> aspNetUsersRepository
           IUsersRepository aspNetUsersRepository,
           IUserPasswordRepository userPasswordRepository
           )
        {
            //_userManager = userManager;
            //_signInManager = signInManager;
            //// _emailSender = emailSender;
            //_appUserStore = appUserStore;
            _userPasswordRepository = userPasswordRepository;
            _aspNetUsersRepository = aspNetUsersRepository;
        }

        public Task<IdentityResult> CreateAsync(Users user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> DeleteAsync(Users user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<Users> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Users> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            return Task.FromResult(_aspNetUsersRepository.FindUsersByAsync(normalizedUserName));
        }

        public Task<string> GetNormalizedUserNameAsync(Users user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetPasswordHashAsync(Users user, CancellationToken cancellationToken)
        {
            return Task.FromResult(_userPasswordRepository.FindPasswordHashAsync(user));
        }

        public Task<string> GetUserIdAsync(Users user, CancellationToken cancellationToken)
        {
            return Task.FromResult(_aspNetUsersRepository.FindByIdAsync(user));
        }

        public Task<string> GetUserNameAsync(Users user, CancellationToken cancellationToken)
        {
            return Task.FromResult(_aspNetUsersRepository.FindByNameAsync(user));
        }

        public Task<bool> HasPasswordAsync(Users user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetNormalizedUserNameAsync(Users user, string normalizedName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetPasswordHashAsync(Users user, string passwordHash, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetUserNameAsync(Users user, string userName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(Users user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

using ePF.portal.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePF.portal.Infra
{
    public class AppUserManager : UserManager<Users>
    {
        public AppUserManager(IUserStore<Users> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<Users> passwordHasher, IEnumerable<IUserValidator<Users>> userValidators, IEnumerable<IPasswordValidator<Users>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<Users>> logger) : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
        }
    }
}

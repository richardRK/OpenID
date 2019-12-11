using ePF.portal.Core.Repositories;
using ePF.portal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePF.portal.Persistance.Repositories
{
    public class UserPasswordRepository : Repository<UserPassword>, IUserPasswordRepository
    {
        public UserPasswordRepository(AspNetIdTstContext context) : base(context)
        {
        }

        public string FindPasswordHashAsync(Users user)
        {
            var result = AspNetIdTstContext.UserPassword.Where(x => x.UserId == user.UserId).FirstOrDefault();
            return result.UserPassword1;
        }


        public AspNetIdTstContext AspNetIdTstContext
        {
            get { return Context as AspNetIdTstContext; }
        }
    }
}

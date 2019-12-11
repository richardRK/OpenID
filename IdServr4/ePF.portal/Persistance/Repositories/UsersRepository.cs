using ePF.portal.Core.Repositories;
using ePF.portal.Entities;
using ePF.portal.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePF.portal.Persistance
{
    public class UsersRepository : Repository<Users>, IUsersRepository
    {
        public UsersRepository(AspNetIdTstContext context) : base(context)
        {
        }


        public Users FindUsersByAsync(string UserName)
        {
            var result = AspNetIdTstContext.Users.Where(x => x.UserName == UserName).FirstOrDefault();
            return result;
        }


        public string FindByIdAsync(Users user)
        {
            var result = AspNetIdTstContext.Users.Where(x => x.UserId == user.UserId).FirstOrDefault();
            return result.UserId.ToString();
        }


        public string FindByNameAsync(Users user)
        {
            var result = AspNetIdTstContext.Users.Where(x => x.UserName == user.UserName).FirstOrDefault();
            return result.UserId.ToString();
        }
        public AspNetIdTstContext AspNetIdTstContext
        {
            get { return Context as AspNetIdTstContext; }
        }
    }
}

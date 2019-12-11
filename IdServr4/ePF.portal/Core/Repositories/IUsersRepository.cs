using ePF.portal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePF.portal.Core.Repositories
{
    public interface IUsersRepository: IRepository<Users>
    {
        public Users FindUsersByAsync(string UserName);
        public string FindByIdAsync(Users Id);
        public string FindByNameAsync(Users name);
    }
}

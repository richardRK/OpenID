using ePF.portal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePF.portal.Core.Repositories
{
    public interface IUserPasswordRepository
    {
        public string FindPasswordHashAsync(Users UserName);
    }
}

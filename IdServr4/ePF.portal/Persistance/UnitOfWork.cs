using ePF.portal.Core;
using ePF.portal.Core.Repositories;
using ePF.portal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePF.portal.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly AspNetIdTstContext _context;

        public UnitOfWork(AspNetIdTstContext context)
        {
            _context = context;
            AspNetUsersRepository = new UsersRepository(_context);
            //AspNetUsersRolesRepository = new AspNetUserRolesRepository(_context);
            //AspNetUserClaimsRepositoty = new AspNetUserClaimsRepository(_context);
        }

        public IUsersRepository AspNetUsersRepository { get; private set; }
        //public IAspNetUserRolesRepository AspNetUsersRolesRepository { get; private set; }
        //public IAspNetUserClaimsRepositoty AspNetUserClaimsRepositoty { get; private set; }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

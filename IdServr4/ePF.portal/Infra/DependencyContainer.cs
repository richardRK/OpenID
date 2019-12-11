using ePF.portal.Core.Repositories;
using ePF.portal.Entities;
using ePF.portal.Persistance;
using ePF.portal.Persistance.Repositories;
using ePF.portal.Utils;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePF.portal.Infra
{
    public class DependencyContainer
    {

        public static void RegisterServices(IServiceCollection services)
        {

            //services
            services.AddScoped<AppUserManager>();
            services.AddScoped<AppSignInManager>();
            services.AddScoped<AppUserStore>();


            ////repositories
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<IUserPasswordRepository, UserPasswordRepository>();
            //services.AddScoped<IAspNetUserClaimsRepositoty, AspNetUserClaimsRepository>();





            ////Custom Store
            //services.AddIdentityCore<Users>(options => { });
            //services.AddScoped<IUserStore<Users>, AppUserStore1>();

            //services.AddIdentityCore<AppUser>(options => { });
            //services.AddScoped<IUserStore<AppUser>, AppUserStore>();

            //services.AddIdentityCore<IdentityUser>(options => { });
            //services.AddScoped<IUserStore<IdentityUser>, AppUserStore3>();



            //Custom Manager
            services.AddIdentityCore<Users>(options => { });
            services.AddScoped<UserManager<Users>, AppUserManager>();

            services.AddIdentityCore<Users>(options => { });
            services.AddScoped<SignInManager<Users>, AppSignInManager>();

            services.AddIdentityCore<Users>(options => { });
            services.AddScoped<IUserStore<Users>, AppUserStore>();
        }
    }
}

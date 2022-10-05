using BL.Bases;
using BL.ViewModel;
using DAL;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.AppServices
{
    public class AccountAppService : AppServiceBase
    {
        //Login
        public ApplicationUserIdentity Find(string name, string passworg)
        {
            return TheUnitOfWork.Account.Find(name, passworg);
        }
        public IdentityResult Register(RegisterViewodel user)
        {
            ApplicationUserIdentity identityUser = 
                Mapper.Map<RegisterViewodel, ApplicationUserIdentity>(user);
            return TheUnitOfWork.Account.Register(identityUser);

        }
        public IdentityResult AssignToRole(string userid, string rolename)
        {
            return TheUnitOfWork.Account.AssignToRole(userid, rolename);


        }
    }
}

using InventoryBussnisesLogic.SpecificRepository;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryDataAccessCore.DTO;

namespace InventoryBussnisesLogicCore.SpecificRepository
{
   public class AccountService:IAccountService
    {
        UserManager<ApplicationUser> userManager;
        SignInManager<ApplicationUser> signInManager;
        RoleManager<IdentityRole> roleManager;

        public AccountService(UserManager<ApplicationUser> _UserManager,
            SignInManager<ApplicationUser> _signInManager,
            RoleManager<IdentityRole> _roleManager
            )
        {
            userManager = _UserManager;
            signInManager = _signInManager;
            roleManager = _roleManager;
        }
        public async Task<IdentityResult> Create(SignUpModel model)
        {
            ApplicationUser user = new ApplicationUser();
            user.Email = model.Email;
            user.Name = model.Name;
            user.UserName = model.Username;

            var result = await userManager.CreateAsync(user, model.Password);


            return result;
        }

        public SignInResult SignIn(SignInModel model)
        {
            var result = signInManager.PasswordSignInAsync(model.Username, model.Password, false, false).Result;
            return result;
        }

        public async Task<IdentityResult> AddRole(RoleModel model)
        {
            IdentityRole role = new IdentityRole();
            role.Name = model.Name;

            var result = await roleManager.CreateAsync(role);
            return result;
        }

        public List<IdentityRole> GetRole()
        {
            List<IdentityRole> liRole = roleManager.Roles.ToList();
            return liRole;
        }

        public async Task Signout()
        {
            await signInManager.SignOutAsync();
        }

        public ApplicationUser GetUserByName(string Username)
        {
            var user = userManager.FindByNameAsync(Username).Result;
            return user;
        }

        public List<string> GetUserRoles(ApplicationUser obj)
        {
            var user = userManager.GetRolesAsync(obj).Result;
            return user.ToList();
        }
    }
}

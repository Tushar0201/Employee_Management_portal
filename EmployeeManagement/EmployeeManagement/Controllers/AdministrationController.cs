using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagement.ViewModels;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace EmployeeManagement.Controllers
{
    public class AdministrationController : Controller
    {
        
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;
        public AdministrationController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }
        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if(ModelState.IsValid)
            {
                IdentityRole role = new IdentityRole()
                {
                    Name = model.RoleName
                };
                IdentityResult result = await roleManager.CreateAsync(role);
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }
        public async Task<IActionResult> EditRole(string id)
        {
            var role =await  roleManager.FindByIdAsync(id);
            var newRole = new EditRoles()
            {
                RoleId = role.Id,
                RoleName = role.Name

            };
        }
    }
}

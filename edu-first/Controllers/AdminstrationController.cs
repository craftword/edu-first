using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using edu_first.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace edu_first.Controllers
{
    public class AdminstrationController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public AdminstrationController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        
        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }
        // Create rows
        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleViewModel model)
        {
           if(ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole { Name = model.RoleName };
                IdentityResult result = await _roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    
                    return RedirectToAction("index", "Account");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            
            return View();
        }

        // Edit Roles
        [HttpGet]
        public IActionResult EditRole()
        {
            return View("~/Adminstration/EditRole.cshtml");
        }


    }
}
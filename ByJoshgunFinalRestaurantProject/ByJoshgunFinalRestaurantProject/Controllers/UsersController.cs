using ByJoshgunFinalRestaurantProject.Helpers;
using ByJoshgunFinalRestaurantProject.Models;
using ByJoshgunFinalRestaurantProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ByJoshgunFinalRestaurantProject.Controllers
{
    [Authorize(Roles = "SuperAdmin")]
    public class UsersController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;

        public UsersController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        #region View Users
        public async Task<IActionResult> Index()
        {
            List<AppUser> users = await _userManager.Users.ToListAsync();
            List<UserVM> userVMs = new List<UserVM>();

            foreach (AppUser user in users)
            {
                UserVM userVM = new UserVM()
                {
                    Id = user.Id,
                    Fullname = user.Name + " " + user.Surname,
                    Username = user.UserName,
                    Email = user.Email,
                    IsDeactive = user.IsDeactive,
                    Role = (await _userManager.GetRolesAsync(user)).FirstOrDefault()
                };
                userVMs.Add(userVM);
            }
            return View(userVMs);
        }
        #endregion


        public IActionResult CreateUser()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUser(CreateUserVM createUserVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            AppUser appUserForEmail = await _userManager.FindByEmailAsync(createUserVM.Email);
            AppUser appUserForUsername = await _userManager.FindByNameAsync(createUserVM.Username);
            if (appUserForEmail != null)
            {
                ModelState.AddModelError("", "Bu emaildə artıq hesab var.");
                return View();
            }
            if (appUserForUsername != null)
            {
                ModelState.AddModelError("", "Bu istifadəçi adında artıq hesab var.");
                return View();
            }
            AppUser appuser = new AppUser
            {
                Name = createUserVM.Name,
                Surname = createUserVM.Surname,
                UserName = createUserVM.Username,
                Email = createUserVM.Email,

            };
            IdentityResult identityResult = await _userManager.CreateAsync(appuser, createUserVM.Password);
            if (!identityResult.Succeeded)
            {
                foreach (IdentityError identityError in identityResult.Errors)
                {
                    ModelState.AddModelError("", identityError.Description);
                }
                return View();
            }


            await _userManager.AddToRoleAsync(appuser, Helper.Roles.Admin.ToString());
            return RedirectToAction("Index");
        }



        #region Change Role

        public async Task<IActionResult> ChangeRole(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return BadRequest();
            }

            List<IdentityRole> roles = await _roleManager.Roles.ToListAsync();
            ViewBag.Roles = roles;
            ChangeRoleVM changeRoleVM = new ChangeRoleVM
            {
                OldRole = (await _userManager.GetRolesAsync(user)).FirstOrDefault()
            };
            if (changeRoleVM.OldRole == null)
            {
                return BadRequest();
            }

            return View(changeRoleVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeRole(string id, string newRole)
        {

            if (id == null)
            {
                return NotFound();
            }
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return BadRequest();
            }
            List<IdentityRole> roles = await _roleManager.Roles.ToListAsync();
            ViewBag.Roles = roles;  // ModelStateIsvalid viewbag-in altinda yazmaliyiq.
            ChangeRoleVM changeRoleVM = new ChangeRoleVM
            {
                OldRole = (await _userManager.GetRolesAsync(user)).FirstOrDefault()
            };
            if (changeRoleVM.OldRole == null)
            {
                return BadRequest();
            }
            if (newRole != changeRoleVM.OldRole)
            {
                IdentityResult addIdentityResult = await _userManager.AddToRoleAsync(user, newRole);
                if (!addIdentityResult.Succeeded)
                {
                    foreach (IdentityError error in addIdentityResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(changeRoleVM);
                }
                IdentityResult removeIdentityResult = await _userManager.RemoveFromRoleAsync(user, changeRoleVM.OldRole);
                if (!removeIdentityResult.Succeeded)
                {
                    foreach (IdentityError error in removeIdentityResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(changeRoleVM);
                }
                await _userManager.UpdateAsync(user);
            }
            return RedirectToAction("Index");
        }

        #endregion


        //#region ResetPassword
        //public IActionResult ResetPassword(string token, string email)
        //{
        //    if (token == null && email == null)
        //    {
        //        ModelState.AddModelError("", "Şifrə boş ola bilməz!");
        //    }
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> ResetPassword(ResetPasswordVM resetPasswordVM)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = await _userManager.FindByEmailAsync(resetPasswordVM.Email);
        //        if (user != null)
        //        {
        //            var result = await _userManager.ResetPasswordAsync(user, resetPasswordVM.Token, resetPasswordVM.Password);
        //            if (result.Succeeded)
        //            {
        //                return View("ResetPasswordConfirmation");
        //            }
        //            foreach (var error in result.Errors)
        //            {
        //                ModelState.AddModelError("", error.Description);
        //            }
        //            return View(resetPasswordVM);
        //        }
        //        return View("ForgotPasswordConfirmation");
        //    }
        //    return View(resetPasswordVM);
        //}
        //#endregion







        #region ResetPassword 2
        public async Task<IActionResult> ResetPassword(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View();


        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM resetPasswordVM, string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            string token = await _userManager.GeneratePasswordResetTokenAsync(user);
            IdentityResult identityResult = await _userManager.ResetPasswordAsync(user, token, resetPasswordVM.Password);
            if (!identityResult.Succeeded)
            {
                ModelState.AddModelError("", "Şifrə minimum 6 simvoldan ibarət olmalıdır");
                ModelState.AddModelError("", "Şifrədə ən az 1 ədəd kiçik hərf olmalıdır");
                ModelState.AddModelError("", "Şifrədə ən az 1 ədəd böyük hərf olmalıdır");
                ModelState.AddModelError("", "Şifrədə ən az 1 ədəd rəqəm olmalıdır");
                return View();
            }
            return RedirectToAction("Index");




        }
        #endregion




        #region ActivityAdmin

        public async Task<IActionResult> Activity(string id)
        {
            if (id == null)
                return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null)
                return BadRequest();
            if (user.IsDeactive)
            {
                user.IsDeactive = false;
            }
            else
            {
                user.IsDeactive = true;
            }


            await _userManager.UpdateAsync(user);
            return RedirectToAction("Index");
        }


        #endregion


        public async Task<IActionResult> UpdateUsernameAndEmail(string id)
        {
            if (id == null) 
            { 
                return NotFound(); 
            }
               
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return BadRequest();
            }
            UpdateUserVM updateUserVM = new UpdateUserVM
            {
                Name = user.Name,
                Surname = user.Surname,
                Username = user.UserName,
                Email = user.Email,
            };

            return View(updateUserVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateUsernameAndEmail(string id, UpdateUserVM updateUserVM)
        {
            
            if (id == null)
            {
                return NotFound();
            }

            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return BadRequest();
            }
            UpdateUserVM updateUserVMdb = new UpdateUserVM
            {
                Name = user.Name,
                Surname = user.Surname,
                Username = user.UserName,
                Email = user.Email,
            };
            if (!ModelState.IsValid)
            {
                return View(updateUserVMdb);
            }
            user.Email = updateUserVM.Email;
            user.UserName = updateUserVM.Username;
            user.Name = updateUserVM.Name;
            user.Surname = updateUserVM.Surname;
            await _userManager.UpdateAsync(user); // bunu yalniz userler ucun yaziriq. 
            return RedirectToAction("Index");
        }



    }
}

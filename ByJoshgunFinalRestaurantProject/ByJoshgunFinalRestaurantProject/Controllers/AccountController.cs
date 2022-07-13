using ByJoshgunFinalRestaurantProject.Models;
using ByJoshgunFinalRestaurantProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ByJoshgunFinalRestaurantProject.Controllers
{
    
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AccountController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }


        #region CreateAdmin Admin Yarat

        public async Task<IActionResult> CreateAdmin()
        {
            AppUser user = await _userManager.FindByEmailAsync("SuperAdmin1234@gmail.com");
            if (user == null)
            {
                await CreateRoles();

                AppUser appUser = new AppUser
                {
                    Name = "SuperAdmin",
                    Surname = "SuperAdmin",
                    UserName = "SuperAdmin",
                    Email = "SuperAdmin1234@gmail.com"
                };
                await _userManager.CreateAsync(appUser, "SuperAdmin1234");

                await _userManager.AddToRoleAsync(appUser, "SuperAdmin");
            }
            else
            {
                return NotFound();
            }

            return RedirectToAction("Login");

        }

        #endregion


        #region Logout Çıxış

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return NotFound();
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            AppUser appUser = await _userManager.FindByEmailAsync(login.Email);
            if (appUser == null)
            {
                ModelState.AddModelError("Email", "Hal-hazırda bu emaillə istifadəçi adı yoxdur.");
                return View();
            }
            if (appUser.IsDeactive)
            {
                ModelState.AddModelError("", "Siz bloklanmısınız");
                return View();
            }
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(appUser, login.Password, true, true);
            if (result.IsLockedOut)
            {
                ModelState.AddModelError("", "Sizin hesab 1 dəqiqəlik blok olunub");
                return View();
            }
            if (!result.Succeeded)
            {
                ModelState.AddModelError("Password", "Sizin şifrəniz yanlışdır");
                return View();
            }
            return RedirectToAction("Index", "Dashboard");


        }

        #endregion


        #region CreateRoles Role Yarat

        public async Task CreateRoles()
        {
            if (!await _roleManager.RoleExistsAsync("SuperAdmin"))
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = "SuperAdmin" });
            }
            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
            }
        }

        #endregion


        #region ForgotPassword Comment Sətri Sonra lazım ola bilər


        //public IActionResult ForgotPassword()
        //{

        //    return View();
        //}
        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> ForgotPassword(ForgotPasswordVM forgotPasswordVM)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = await _userManager.FindByEmailAsync(forgotPasswordVM.Email);
        //        if (user != null)
        //        {
        //            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
        //            var passwordResetLink = Url.Action("ResetPassword", "Account", new { email = forgotPasswordVM.Email, token = token }, Request.Scheme);
        //            await _userManager.SendEmailAsync(token, "Reset Password", "Please reset your password by click <a href=\"" + passwordResetlink + "\">here</a>");
        //            MimeMessage message = new MimeMessage();
        //            message.From.Add(new MailboxAddress("Nabatov", "coshqun.n@itbrains.az")); // bura bax

        //            message.To.Add(MailboxAddress.Parse(user.Email));
        //            message.Body = new TextPart("plain")
        //            {
        //                Text = passwordResetLink
        //            };
        //            message.Subject = "Reset your password please";
        //            string email = "coshqun.n@itbrains.az";
        //            string password = "nabatov"; // bura bax
        //            SmtpClient client = new SmtpClient();
        //            client.Connect("smtp.gmail.com", 465, true);
        //            client.Authenticate(email, password);
        //            client.Send(message);
        //            return View("ForgotPasswordConfirmation");
        //        }
        //    }
        //    return View(forgotPasswordVM);
        //}


        #endregion

    }
}

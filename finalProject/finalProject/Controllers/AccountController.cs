using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using finalProject.Infrastructure;
using finalProject.Models;
using finalProject.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace finalProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ProviderDbContext _providerDbContext;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ProviderDbContext providerDbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _providerDbContext = providerDbContext;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = await _userManager.FindByEmailAsync(registerModel.Email);
                if (appUser != null)
                {
                    ModelState.AddModelError("", "This user already exists");
                }
                else
                {
                    appUser = registerModel;

                    #region User and it's role creation witrh transaction

                    if (await this.RegisterUserAsync(registerModel, appUser))
                        return Ok();

                    #endregion
                }
                return View();
            }
            else
                return View();
        }

        private async Task<bool> RegisterUserAsync(RegisterModel registerModel, AppUser appUser)
        {
            bool isRegistered = false;

            using (IDbContextTransaction dbContextTransaction = _providerDbContext.Database.BeginTransaction())
            {
                try
                {

                    IdentityResult identityResult = await _userManager.CreateAsync(appUser, registerModel.Password);

                    if (identityResult.Succeeded)
                    {
                        IdentityResult identityRoleResult = await _userManager.AddToRoleAsync(appUser, RoleType.User.ToString());

                        if (identityRoleResult.Succeeded)
                        {
                            dbContextTransaction.Commit();
                            isRegistered = true;
                        }
                        else
                        {
                            dbContextTransaction.Rollback();
                            this.AddToModelErrors(identityResult.Errors);
                        }

                    }
                    else
                    {
                        dbContextTransaction.Rollback();
                        this.AddToModelErrors(identityResult.Errors);

                    }
                }
                catch (Exception exp)
                {
                    dbContextTransaction.Rollback();
                    ModelState.AddModelError("", exp.Message);
                }
            }

            return isRegistered;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                //get current user by email
                AppUser currentUser = await _userManager.FindByEmailAsync(loginModel.Email);

                Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.PasswordSignInAsync(currentUser, loginModel.Password, loginModel.RememberMe, true);
                if (signInResult.Succeeded)
                {
                    var user = this.User;
                    return RedirectToAction("Index", "CoreProviders", new { area = "Admin" });
                }
                else
                    if (signInResult.IsLockedOut)
                {
                    ModelState.AddModelError("", "This use is already locked out!!");
                }
                else
                    if (signInResult.IsNotAllowed)
                {
                    ModelState.AddModelError("", "Your have no access");
                }

            }
            return RedirectToAction(nameof(Login));
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using DrinkFest.ViewModel;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace DrinkFest.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        [Route("Register")]
        public IActionResult Register()
        {
            RegisterViewModel registerViewModel = new RegisterViewModel();
            return View(registerViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Register")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.Email, Email = model.Email };
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                
                AddErrors(result);
            }
            return View(model);
        }

        [HttpGet]
        
        public IActionResult Login(string? returnurl=null)
        {
            ViewData["ReturnUrl"] = returnurl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string? returnurl = null)
        {
            ViewData["ReturnUrl"] = returnurl;
            returnurl = returnurl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {
               

                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: true);

                if (result.Succeeded)
                {

                    return LocalRedirect(returnurl);
                }
                if (result.IsLockedOut)
                {
                    return View("LockOut");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View(model);
                }


            }
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ExternalLogin(string provider, string? returnurl = null)
        {
            var redirecturl = Url.Action("ExternalLoginCallback", "Account", new { ReturnUrl = returnurl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirecturl);

            return Challenge(properties, provider);
        }

        [HttpGet]
        public async Task<IActionResult> ExternalLoginCallback(string? returnurl = null, string? remoteError = null)
        {
            returnurl = returnurl ?? Url.Content("~/");
            if (remoteError != null)
            {
                ModelState.AddModelError(string.Empty, $"Error from external provider: {remoteError}");
                return View(nameof(Login));
            }

            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                return RedirectToAction(nameof(Login));
            }

            var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false);
            if (result.Succeeded)
            {
                await _signInManager.UpdateExternalAuthenticationTokensAsync(info);
                return LocalRedirect(returnurl);
            }
            else
            {
                ViewData["ReturnUrl"] = returnurl;
                ViewData["ProviderDisplayName"] = info.ProviderDisplayName;

                var email = info.Principal.FindFirstValue(ClaimTypes.Email);

                return View("ExternalLoginConfirmation", new ExternalLoginConfirmationViewModel { Email = email });
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ExternalLoginConfirmation(ExternalLoginConfirmationViewModel model, string? returnurl = null)
        {
            returnurl = returnurl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {
                var info = await _signInManager.GetExternalLoginInfoAsync();

                if (info == null)
                {
                    return View("Error");
                }

                var user = new IdentityUser { Email = model.Email, UserName = model.Email };
                var result = await _userManager.CreateAsync(user);

                if (result.Succeeded)
                {
                    result = await _userManager.AddLoginAsync(user, info);
                    
                    if (result.Succeeded)
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        await _signInManager.UpdateExternalAuthenticationTokensAsync(info);

                        return LocalRedirect(returnurl);
                    }
                }
                AddErrors(result);

            }
            ViewData["ReturnUrl"] = returnurl;
            return View(model);
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }
    }
}

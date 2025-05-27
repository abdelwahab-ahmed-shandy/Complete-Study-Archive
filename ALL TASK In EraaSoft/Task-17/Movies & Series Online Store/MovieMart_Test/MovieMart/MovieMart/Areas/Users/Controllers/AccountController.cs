using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using MovieMart.Models.ViewModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MovieMart.Areas.Users.Controllers
{
    [Area("Users")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._roleManager = roleManager;
        }
        #region Register
        [HttpGet]
        public async Task<IActionResult> Register()
        {
            if (_roleManager.Roles.IsNullOrEmpty())
            {
                await _roleManager.CreateAsync(role: new IdentityRole("SuberAdmin"));
                await _roleManager.CreateAsync(role: new IdentityRole("Admin"));
                await _roleManager.CreateAsync(role: new IdentityRole("User"));
                await _roleManager.CreateAsync(role: new IdentityRole("Customer"));
            }

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser applicationUser = new()
                {
                    FirstName = registerVM.FirstName,
                    LastName = registerVM.LastName,
                    Email = registerVM.Email,
                    Address = registerVM.Address,
                    UserName = registerVM.UserName,

                };

                var result = await _userManager.CreateAsync(applicationUser, registerVM.Password);

                if (result.Succeeded)
                {
                    // Success
                    await _signInManager.SignInAsync(applicationUser, isPersistent: false);

                    await _userManager.AddToRoleAsync(applicationUser, "Customer");

                    return RedirectToAction("Index", "Home", new { area = "Customer" });
                }
                else
                {
                    // Show validation errors
                    // This code ensures that the user sees the reason for the registration failure instead of being redirected to a generic error page.
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }

            }
            return View(registerVM);
        }

        #endregion

        #region Login
        // Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                var User = await _userManager.FindByEmailAsync(loginVM.Email);

                if (User != null)
                {
                    var result = await _userManager.CheckPasswordAsync(User, loginVM.Password);

                    if (result)
                    {
                        // Success

                        await _signInManager.SignInAsync(User, loginVM.RememberMe);

                        return RedirectToAction("Index", "Home", new { area = "Customer" });
                    }
                    else
                    {
                        ModelState.AddModelError("Password", "Invalid password");
                        ModelState.AddModelError("Email", "Email not found");
                    }

                }
                else
                {
                    ModelState.AddModelError("Email", "Email not found");
                    ModelState.AddModelError("Password", "Invalid password");
                }
            }
            return View(loginVM);
        }
        #endregion

        #region Logout 
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account", new { area = "Identity" });
        }
        #endregion

        #region Profile Pages
        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            var _user = await _userManager.GetUserAsync(User);

            if (_user != null)
            {

                var profile = new ProfileVM
                {
                    FirstName = _user.FirstName,
                    LastName = _user.LastName,
                    Email = _user.Email,
                    Address = _user.Address,
                    UserName = _user.UserName
                };

                return View(profile);

            }
            else
            {
                return RedirectToAction("Login", "Account", new { area = "Identity" });
            }

        }

        // Display the edit profile page
        [HttpGet]
        public async Task<IActionResult> EditProfile()
        {
            // Get the current user's data
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                // Redirect to the "Not Found" page if the user is not found
                return RedirectToAction("NotFound", "Home", new { area = "Customer" });
            }

            // Fill the edit profile form with the current user's data
            var profile = new EditProfileVM
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.UserName,
                Email = user.Email,
                Address = user.Address,
                // TODO: Add a profile image in the future
                // ProfileImagePath = user.ProfileImagePath
            };

            return View(profile);
        }

        // Processing profile edits after submission
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProfile(EditProfileVM editProfileVM)
        {
            if (!ModelState.IsValid)
            {
                return View(editProfileVM);
            }

            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("NotFound", "Home", new { area = "Customer" });
            }

            // Check the current password
            if (string.IsNullOrEmpty(editProfileVM.CurrentPassword))
            {
                ModelState.AddModelError("", "You must enter the current password to update the profile.");
                return View(editProfileVM);
            }

            var isPasswordValid = await _userManager.CheckPasswordAsync(user, editProfileVM.CurrentPassword);
            if (!isPasswordValid)
            {
                ModelState.AddModelError("", "The current password is incorrect.");
                return View(editProfileVM);
            }

            // Update basic data
            user.FirstName = editProfileVM.FirstName;
            user.LastName = editProfileVM.LastName;
            user.Address = editProfileVM.Address;
            user.UserName = editProfileVM.UserName;
            user.Email = editProfileVM.Email;

            var updateResult = await _userManager.UpdateAsync(user);
            if (!updateResult.Succeeded)
            {
                ModelState.AddModelError("", "Profile update failed.");
                return View(editProfileVM);
            }

            // If a new password is entered, change it
            if (!string.IsNullOrEmpty(editProfileVM.NewPassword) && !string.IsNullOrEmpty(editProfileVM.ConfirmNewPassword))
            {
                if (editProfileVM.NewPassword != editProfileVM.ConfirmNewPassword)
                {
                    ModelState.AddModelError("", "The new password and confirmation do not match.");
                    return View(editProfileVM);
                }

                var passwordChangeResult = await _userManager.ChangePasswordAsync(user, editProfileVM.CurrentPassword, editProfileVM.NewPassword);
                if (!passwordChangeResult.Succeeded)
                {
                    foreach (var error in passwordChangeResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(editProfileVM);
                }
            }

            return RedirectToAction("Profile", "Account", new { area = "Identity" });
        }

        #endregion

        #region AccDenied And NotFound And IntSerErr
        public IActionResult AccessDenied() => View();
        public IActionResult NotFound() => View();
        public IActionResult InternalServerError() => View();

        #endregion
    }
}

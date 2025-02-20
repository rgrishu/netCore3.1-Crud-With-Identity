﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Whatsapp.AppCode.HelperClass;
using Whatsapp.Models;
using Whatsapp.Models.Data;
using Whatsapp.Models.UtilityModel;

namespace Whatsapp.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<WhatsappUser> _signInManager;
        private readonly UserManager<WhatsappUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private ApplicationContext _appcontext;
        private ApplicationContext __appcontext;
        // private readonly IEmailSender _emailSender;
        private IHttpContextAccessor Accessor;

        public RegisterModel(
            UserManager<WhatsappUser> userManager,
            SignInManager<WhatsappUser> signInManager,
            ILogger<RegisterModel> logger, IHttpContextAccessor _accessor, ApplicationContext appcontext, ApplicationContext aappcontext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            this.Accessor = _accessor;
            _appcontext = appcontext;
            __appcontext = aappcontext;
            //_emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {


            [Required]

            [Display(Name = "Name")]
            public string Name { get; set; }

            [Required]
            [Phone]
            [Display(Name = "Phone")]
            public string Phone { get; set; }
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            string wid = this.Accessor.HttpContext.Request.Cookies["WID"];
            wid = HashEncryption.O.Decrypt(wid);
            if (ModelState.IsValid && !string.IsNullOrEmpty(wid))
            {
                var user = new WhatsappUser { UserName = Input.Email, Email = Input.Email, PhoneNumber = Input.Phone, Name = Input.Name, EmailConfirmed = true,WID=Convert.ToInt32(wid)};
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    var res = await _userManager.AddToRoleAsync(user, "Admin");
                    InsertInUserBalance(user.Id);
                    _logger.LogInformation("User created a new account with password.");

                    //Send Email And Whatsappp For Users As Confirmation
                    //Send Email And Whatsappp For Users As Confirmation Ends Here

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return Page();
        }
        public Response InsertInUserBalance(int Id)
        {
            var res = new Response()
            {
                StatusCode = (int)ResponseStatus.Success,
                ResponseText = "Successfull"
            };
            try
            {
                UserBalance userBalance = new UserBalance()
                {
                    UserId = Id,
                    Balance = 0,
                    CreatedDate = DateTime.Now,
                    ModifyBy = User.Identity.Name
                };
                var rest = __appcontext.Add(userBalance);
                __appcontext.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
            return res;
        }
    }
}

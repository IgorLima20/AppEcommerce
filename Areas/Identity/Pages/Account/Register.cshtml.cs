using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using AppEcommerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using AppEcommerce.Data;

namespace AppEcommerce.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly Contexto _contexto;

        public RegisterModel(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender, Contexto contexto)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _contexto = contexto;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Informe seu nome!!")]
            [Display(Name = "Username", Prompt = "Username")]
            public string Nome { get; set; }


            [Required(ErrorMessage = "Informe um Username!!")]
            [StringLength(8)]
            [Display(Name = "Username", Prompt = "Username")]
            public string UserName { get; set; }


            [Required(ErrorMessage = "Informe um endereço de E-mail")]
            [EmailAddress(ErrorMessage = "Informe um endereço de E-mail Válido!!")]
            [Display(Name = "E-mail", Prompt = "E-mail")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Digite sua Senha de Acesso")]
            [DataType(DataType.Password)]
            [Display(Name = "Senha", Prompt = "Senha")]            
            [StringLength(100, ErrorMessage = "Sua {0} deve possuir no mínimo {2} e no máximo {1} caracteres.", MinimumLength = 6)]
            public string Password { get; set; }

            [Display(Name = "Confirmação de Senha", Prompt = "Confirmação de Senha")]
            [DataType(DataType.Password)]
            [Compare("Password", ErrorMessage = "Senha e Confirmação de Senha não conferem!")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ViewData["Categorias"] = _contexto.Categorias.ToList();
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new User { UserName = Input.UserName, Email = Input.Email, NomeCompleto =  Input.Nome};
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    // await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                    //     $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");
                    
                    await _userManager.AddToRoleAsync(user, "Usuario");

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
                    if (error.Code == "PasswordRequiresUpper")
                        ModelState.AddModelError(string.Empty, "A senha precisa ter no mínimo um caracter maiúsculo.");
                    else
                    if (error.Code == "PasswordRequiresDigit")
                        ModelState.AddModelError(string.Empty, "A senha precisa ter no minimo um número.");
                    else
                    if (error.Code == "PasswordRequiresLower")
                        ModelState.AddModelError(string.Empty, "A senha precisa ter no minimo um caracter minúsculo.");
                    else
                    if (error.Code == "DuplicateUserName")
                        ModelState.AddModelError(string.Empty, "Esse Nome de Usuário já existe. Informe outro nome!");
                    else
                        ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using AppEcommerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using AppEcommerce.Data;
using System.Linq;

namespace AppEcommerce.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ResendEmailConfirmationModel : PageModel
    {
        private readonly UserManager<User> _userManager;
        private readonly IEmailSender _emailSender;

        private readonly Contexto _contexto;

        public ResendEmailConfirmationModel(UserManager<User> userManager, IEmailSender emailSender, Contexto contexto)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            _contexto = contexto;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Informe um endereço de E-mail")]
            [EmailAddress(ErrorMessage = "Informe um endereço de E-mail Válido!!")]
            [Display(Name = "E-mail", Prompt = "E-mail")]
            public string Email { get; set; }
        }

        public void OnGet()
        {
            ViewData["Categorias"] = _contexto.Categorias.ToList();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var user = await _userManager.FindByEmailAsync(Input.Email);
            if (user == null)
            {
            ModelState.AddModelError(string.Empty, "NotFound");
                return Page();
            }

            var userId = await _userManager.GetUserIdAsync(user);
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            var callbackUrl = Url.Page(
                "/Account/ConfirmEmail",
                pageHandler: null,
                values: new { userId = userId, code = code },
                protocol: Request.Scheme);
            await _emailSender.SendEmailAsync(
                Input.Email,
                "Confirm your email",
                $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

            ViewData["Categorias"] = _contexto.Categorias.ToList();
            ModelState.AddModelError(string.Empty, "OK");
            return Page();
        }
    }
}

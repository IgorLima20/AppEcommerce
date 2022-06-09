using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AppEcommerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace AppEcommerce.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMapper mapper;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IEmailSender emailSender;
        
        public AccountController(UserManager<User> user, SignInManager<User> sign, IMapper map,
            RoleManager<IdentityRole> role, IEmailSender email)
        {
            userManager = user;
            signInManager = sign;
            mapper = map;
            roleManager = role;
            emailSender = email;
        }

        // public IActionResult Login()
        // {
        //     return View();
        // }

        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Login(UserLoginModel user)
        // {
        //     if (!ModelState.IsValid)
        //     {
        //         return View(user);
        //     }

        //     var result = await signInManager.PasswordSignInAsync(user.Email, user.Password, true, lockoutOnFailure: true);
        //     if (result.Succeeded)
        //     {
        //         var u = await userManager.FindByEmailAsync(user.Email);
        //         var r = await userManager.GetRolesAsync(u);
        //         if (r[0] == "Administrador")
        //             return RedirectToAction("Index", "Admin");
        //         else
        //             return RedirectToAction("Index", "Home");
        //     }

        //     if (result.IsLockedOut)
        //     {
        //         ModelState.AddModelError("", "Usuário Bloqueado, aguarde alguns minutos e tente novamente");
        //         return View();
        //     }
        //     else
        //     {
        //         ModelState.AddModelError("", "E-mail de Acesso e/ou Senhas Inválidos!!!");
        //         return View();
        //     }
        // }


        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Logout()
        // {
        //     await signInManager.SignOutAsync();
        //     return RedirectToAction("Index", "Home");
        // }

        
        // [Authorize(Roles = "Administrador")]
        // [HttpGet]
        // public IActionResult Register()
        // {
        //     var perfis = roleManager.Roles;
        //     ViewData["Perfis"] = new SelectList(perfis, "NormalizedName", "Name");
        //     return View();
        // }


        // [HttpPost]
        // public async Task<IActionResult> Register(UserRegistrationModel userModel)
        // {
        //     var perfis = roleManager.Roles;
        //     ViewData["Perfis"] = new SelectList(perfis, "NormalizedName", "Name");

        //     if (!ModelState.IsValid)
        //     {
        //         return View(userModel);
        //     }

        //     var user = mapper.Map<Usuario>(userModel);

        //     var result = await userManager.CreateAsync(user, userModel.Password);

        //     if (!result.Succeeded)
        //     {
        //         foreach (var error in result.Errors)
        //         {
        //             ModelState.TryAddModelError(error.Code, error.Description);
        //         }
        //         return View(userModel);
        //     }

        //     await userManager.AddToRoleAsync(user, userModel.Perfis);

        //     return RedirectToAction("Index");
        // }

        // [AllowAnonymous]
        // public IActionResult AccessDenied()
        // {
        //     return View();
        // }


        public async Task<IActionResult> Index()
        {
            var users = await userManager.Users.ToListAsync();
            foreach (var user in users)
            {
                var roles = await userManager.GetRolesAsync(user);
                user.Perfis = string.Join(", ", roles);
            }
            return View(users);
        }

        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = userManager.Users.Where(u => u.Id == id).SingleOrDefault();

            if (user == null)
            {
                return NotFound();
            }

            var perfil = await userManager.GetRolesAsync(user);
            var perfis = roleManager.Roles;
            ViewData["Perfis"] = new SelectList(perfis, "NormalizedName", "Name");

            UserViewModel usuario = new UserViewModel();
            usuario.Id = user.Id;
            usuario.Nome = user.NomeCompleto;
            usuario.use = user.UserName;
            usuario.Email = user.Email;
            usuario.Perfil = perfil[0];

            return View(usuario);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = userManager.Users.Where(u => u.Id == id).SingleOrDefault();

            if (user == null)
            {
                return NotFound();
            }

            var perfil = await userManager.GetRolesAsync(user);
            var perfis = roleManager.Roles;
            ViewData["Perfis"] = new SelectList(perfis, "NormalizedName", "Name");

            UserViewModel usuario = new UserViewModel();
            usuario.Id = user.Id;
            usuario.Nome = user.NomeCompleto;
            usuario.use = user.UserName;
            usuario.Email = user.Email;
            usuario.Perfil = perfil[0];

            return View(usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, UserViewModel userModel)
        {
            if (id != userModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var user = userManager.Users.Where(u => u.Id == id).SingleOrDefault();
                    user.NomeCompleto = userModel.Nome;
                    user.UserName = userModel.use;
                    user.Email = userModel.Email;
                    await userManager.UpdateAsync(user); // Salva os dados do usuário
                    ViewBag.Concluido = "OK"; 

                    var perfil = await userManager.GetRolesAsync(user);
                    if (perfil[0] != userModel.Perfil)
                    {
                        await userManager.RemoveFromRoleAsync(user, perfil[0]);
                        await userManager.AddToRoleAsync(user, userModel.Perfil);
                    }
                }
                catch
                {
                    throw;
                }
                return View(userModel);
            }
            var perfis = roleManager.Roles;
            ViewData["Perfis"] = new SelectList(perfis, "NormalizedName", "Name");
            return View(userModel);
        }

        [Authorize(Roles = "Administrador")]
        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
         
            if (id == null)
            {
                return NotFound();
            }

            var user = userManager.Users.Where(u => u.Id == id).SingleOrDefault();

            if (user == null)
            {
                return NotFound();
            }

            var perfil = await userManager.GetRolesAsync(user);
            UserViewModel usuario = new UserViewModel();
            usuario.Id = user.Id;
            usuario.Nome = user.NomeCompleto;
            usuario.use = user.UserName;
            usuario.Email = user.Email;
            usuario.Perfil = perfil[0];

            return View(usuario);
        }
        
        [Authorize(Roles = "Administrador")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var user = userManager.Users.Where(u => u.Id == id).SingleOrDefault();
            try
            {
                await userManager.DeleteAsync(user);
                ViewBag.Concluido = "OK"; 
            }
            catch
            {
                throw;
            }
            return View(user);
        }


        // [HttpGet]
        // [AllowAnonymous]
        // public IActionResult ForgotPassword()
        // {
        //     return View();
        // }

        // [HttpPost]
        // [AllowAnonymous]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> ForgotPassword(ForgotPasswordModel forgotPassword)
        // {
        //     if (!ModelState.IsValid)
        //         return View(forgotPassword);

        //     var user = await userManager.FindByEmailAsync(forgotPassword.Email);
        //     if (user == null)
        //         return RedirectToAction("ForgotPasswordConfirmation");

        //     var token = await userManager.GeneratePasswordResetTokenAsync(user);
        //     var callback = Url.Action("ResetPassword", "Account", new { token, email = user.Email }, Request.Scheme);

        //     var message = new Message(new string[] { forgotPassword.Email }, "Recuperar Senha", callback, null);
        //     await emailSender.SendEmailAsync(message);

        //     return RedirectToAction("ForgotPasswordConfirmation");
            
        // }

        // [HttpGet]
        // [AllowAnonymous]
        // public IActionResult ForgotPasswordConfirmation()
        // {
        //     return View();
        // }

        // [HttpGet]
        // [AllowAnonymous]
        // public IActionResult ResetPassword(string token, string email)
        // {
        //     var model = new ResetPasswordModel { Token = token, Email = email };
        //     return View(model);
        // }


        // [HttpPost]
        // [AllowAnonymous]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> ResetPassword(ResetPasswordModel resetPassword)
        // {
        //     if (!ModelState.IsValid)
        //         return View(resetPassword);

        //     var user = await userManager.FindByEmailAsync(resetPassword.Email);
        //     if (user == null)
        //         RedirectToAction("ResetPasswordConfirmation");  // Criar uma view de email não encontrado

        //     var reset = await userManager.ResetPasswordAsync(user, resetPassword.Token, resetPassword.Password);
        //     if (!reset.Succeeded)
        //     {
        //         foreach (var error in reset.Errors)
        //         {
        //             ModelState.TryAddModelError(error.Code, error.Description);
        //         }

        //         return View();
        //     }

        //     return RedirectToAction("ResetPasswordConfirmation");
        // }


        // [HttpGet]
        // [AllowAnonymous]
        // public IActionResult ResetPasswordConfirmation()
        // {
        //     return View();
        // }

    }
}
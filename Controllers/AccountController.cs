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

        [Authorize(Roles = "Administrador, Moderador")]
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

        [Authorize(Roles = "Administrador, Moderador")]
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

        [Authorize(Roles = "Administrador")]
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

        [Authorize(Roles = "Administrador")]
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
        public async Task<IActionResult> DeleteConfirmed(string id, UserViewModel userModel)
        {
            if (id != userModel.Id)
            {
                return NotFound();
            }
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
            return View(userModel);
        }
    }
}
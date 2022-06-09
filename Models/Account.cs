using AppEcommerce.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Threading.Tasks;

namespace AppEcommerce.Models
{
    // ViewModel

    public class UserViewModel
    {
        [HiddenInput]
        public string Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome do Usuário")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o Usuário")]
        public string use { get; set; }

        [Display(Name = "E-mail de Acesso")]
        [Required(ErrorMessage = "Informe o E-mail de Acesso")]
        [EmailAddress(ErrorMessage = "Informe um E-mail válido")]
        public string Email { get; set; }

        [Display(Name = "Perfil de Acesso")]
        [Required(ErrorMessage = "Informe o Perfil de Acesso")]
        public string Perfil { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AppEcommerce.Models
{
    [Table("User")]
    public class User : IdentityUser
    {   
        [StringLength(100)]
        public string NomeCompleto { get; set; }

        [NotMapped]
        [Display(Name = "Perfil")]
        public string Perfis { get; set; }

        public DateTime DataCadastro { get; } = DateTime.Now;
    }
}
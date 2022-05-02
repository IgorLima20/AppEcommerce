using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppEcommerce.ViewModels
{
    public class MarcaViewModel
    {
        public bool Selecionado { get;set; }
        public int IdMarca { get; set; }

        [Required]
        [ForeignKey("IdMarca")]
        public string Marca { get; set; }
    }
}
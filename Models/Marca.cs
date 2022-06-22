using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace AppEcommerce.Models
{
    [Table("Marca")]
    public class Marca
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Nome da Marca")]
        [StringLength(100, ErrorMessage = "O Nome da Marca deve possuir no máximo 100 caracteres")]
        public string Nome { get; set; }
        
        public string Imagem { get; set; }

    }
}